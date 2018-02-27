// MP3 Skull Downloader 0.5
// © Ismael Heredia , Argentina , 2014
// Credits :
// Based on http://www.fluxbytes.com/csharp/how-to-download-a-file-in-c-progressbar-and-download-speed/
// Thanks to CooLMinE 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Media;

namespace MP3_Skull_Downloader
{
    public partial class FormHome : Form
    {

        WebClient downloader;              
        Stopwatch chaunow = new Stopwatch();    

        public FormHome()
        {
            InitializeComponent();
        }
       
        private void ahivoy(object sender, DownloadProgressChangedEventArgs e)
        {
            string velocidad = string.Format("{0} kb/s", (e.BytesReceived / 1024d / chaunow.Elapsed.TotalSeconds).ToString("0.00"));
            string porcentaje = e.ProgressPercentage.ToString() + "%";
            string cantidad = string.Format("{0} MB's / {1} MB's",(e.BytesReceived / 1024d / 1024d).ToString("0.00"),(e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

            toolStripStatusLabel1.Text = " [+] Speed :  " + velocidad + "  [+] Percentage : " + porcentaje + "  [+] Size : " + cantidad;
            this.Refresh();

            pbProgress.Value = e.ProgressPercentage;

        }

        private void termine(object sender, AsyncCompletedEventArgs e)
        {
            chaunow.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Canceled");
            }
            else
            {
                MessageBox.Show("Downloaded");
                SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.scanfin);
                sound.Play();
            }

            pbProgress.Value = 0;
            txtLinkToDownload.Text = "";

            toolStripStatusLabel1.Text = "[+] Finished";
            this.Refresh();

            get_files();

        }

        //

        public void get_files()
        {

            lvSongsFoundDownloaded.Items.Clear();
            lbSongsFoundDownloaded.Items.Clear();

            string[] archivos = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string archivo in archivos)
            {
                if (Path.GetExtension(archivo) == ".mp3")
                {
                    lbSongsFoundDownloaded.Items.Add(archivo);
                    FileInfo basename = new FileInfo(archivo);
                    string nombre = basename.Name;

                    ListViewItem agregar = new ListViewItem();
                    agregar.Text = nombre;
                    FileInfo info = new FileInfo(nombre);
                    DateTime cuando = info.CreationTime;
                    agregar.SubItems.Add(Convert.ToString(cuando));

                    lvSongsFoundDownloaded.Items.Add(agregar);
                }
            }

            gbSongsFoundDownloaded.Text = "Songs found [" + lbSongsFoundDownloaded.Items.Count + "]";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.click);
            sound.Play();

            string cancion = txtEnterSongName.Text;
            cancion = cancion.Replace(" ", "_");

            toolStripStatusLabel1.Text = "[+] Searching - Please Wait -";
            this.Refresh();

            WebClient web = new WebClient();
            web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            string codigofuente = web.DownloadString("http://mp3skull.com/mp3/" + cancion + ".html");

            Match testar = Regex.Match(codigofuente, "Sorry, no results found for", RegexOptions.IgnoreCase);

            if (testar.Success)
            {
                MessageBox.Show("Not Found");
            }

            List<string> lista_nombres = new List<string> { };
            List<string> lista_info = new List<string> { };
            List<string> lista_links = new List<string> { };

            Match search1 = Regex.Match(codigofuente, "<div style=\"font-size:15px;\"><b>(.*)</b></div>", RegexOptions.IgnoreCase);

            while (search1.Success)
            {
                string nombre = search1.Groups[1].Value;
                lista_nombres.Add(nombre);
                search1 = search1.NextMatch();
            }

            Match search2 = Regex.Match(codigofuente, "<!-- info mp3 here -->\\s*(.*?)</div>", RegexOptions.IgnoreCase);

            while (search2.Success)
            {
                string info = search2.Groups[1].Value;
                if (info == "")
                {
                    info = "Not Available";
                }
                info = info.Replace("<br />", " ");
                info = info.Replace("\t", "");
                lista_info.Add(info);
                search2 = search2.NextMatch();
            }

            Match search3 = Regex.Match(codigofuente, "<a href=\"(.*)\" rel=\"nofollow\" target=\"_blank\" style=\"color:green;\">Download", RegexOptions.IgnoreCase);

            while (search3.Success)
            {
                string link = search3.Groups[1].Value;
                link = link.Replace("\\", "");
                lista_links.Add(link);
                search3 = search3.NextMatch();
            }

            lvSongsFound.Items.Clear();
            lbSongsFound.Items.Clear();

            for (int i = 0; i <= lista_nombres.Count - 1; i++)
            {
                ListViewItem agregar = new ListViewItem();
                agregar.Text = lista_nombres[i];
                agregar.SubItems.Add(lista_info[i]);
                lbSongsFound.Items.Add(lista_links[i]);
                lvSongsFound.Items.Add(agregar);

            }

            toolStripStatusLabel1.Text = "[+] Finished";
            this.Refresh();

            gbSongsFound.Text = "Songs found [" + lbSongsFound.Items.Count + "]";

            SoundPlayer sound1 = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.scanfin);
            sound1.Play();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.click);
            sound.Play();

            if (lbSongsFound.Items.Count == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {

                SoundPlayer sound1 = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.click);
                sound1.Play();

                string bajar = lbSongsFound.Items[lvSongsFound.FocusedItem.Index].ToString();

                var url = new Uri(bajar);
                downloader = new WebClient();
                downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(termine);
                downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ahivoy);
                chaunow.Start();

                txtLinkToDownload.Text = url.ToString();

                Uri urisplit = new Uri(bajar);
                string archivo = urisplit.AbsolutePath;
                FileInfo parte = new FileInfo(archivo);
                archivo = parte.Name;

                try
                {
                    downloader.DownloadFileAsync(url, archivo);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.click);
            sound.Play();
            lvSongsFound.Items.Clear();
            lbSongsFound.Items.Clear();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.click);
            sound.Play();

            if (lbSongsFoundDownloaded.Items.Count == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {

                string cargarCancion = lbSongsFoundDownloaded.Items[lvSongsFoundDownloaded.FocusedItem.Index].ToString();
                System.Diagnostics.Process.Start(cargarCancion);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.click);
            sound.Play();
            get_files();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("mp3_downloads"))
            {
                System.IO.Directory.CreateDirectory("mp3_downloads");
                Directory.SetCurrentDirectory("mp3_downloads");
            }
            else
            {
                Directory.SetCurrentDirectory("mp3_downloads");
            }

            get_files();

            SoundPlayer sound = new SoundPlayer(MP3_Skull_Downloader.Properties.Resources.formcreate);
            sound.Play();
        }

    }
}
