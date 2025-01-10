using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace App_windows
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;

        public Form1()
        {
            InitializeComponent();
            AjouterAuDemarrage();
            RécupérerInformations();
            InitialiserNotifyIcon();
        }



        private void InitialiserNotifyIcon()
        {
            string iconPath = @"C:\Users\stagiairedev\Projets\SAV\App windows\App windows\icon_sav.ico";


            if (!File.Exists(iconPath))
            {
                MessageBox.Show($"Le fichier d'icône '{iconPath}' est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            notifyIcon = new NotifyIcon
            {
                Icon = new Icon(iconPath),
                Visible = true,
                Text = "SAV",
            };

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Ouvrir", null, (s, e) => this.Show());
            contextMenu.Items.Add("Quitter", null, (s, e) => Application.Exit());
            notifyIcon.ContextMenuStrip = contextMenu;


            notifyIcon.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                }
            };
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();

            }
        }

        private void btnLancerOutlook_Click(object sender, EventArgs e)
        {
            try
            {

                string chemin = @"C:\Program Files (x86)\Microsoft Office\root\Office16\OUTLOOK.EXE";


                string nomMachine = Environment.MachineName;
                string adresseIP = ObtenirAdresseIP();
                string utilisateurConnecte = Environment.UserName;


                string corpsMail = $"Nom de la machine : {nomMachine}\n" +
                                   $"Adresse IP : {adresseIP}\n" +
                                   $"Utilisateur connecté : {utilisateurConnecte}";


                string destinataire = "vsa@vsa.fr";


                string arguments = $"/c ipm.note /m \"{destinataire}?body={Uri.EscapeDataString(corpsMail)}\"";


                Process.Start(chemin, arguments);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture d'Outlook : " + ex.Message);
            }
        }




        private void AjouterAuDemarrage()
        {
            string exePath = Application.ExecutablePath;
            string arguments = "--silent";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            key.SetValue("MonApplication", $"\"{exePath}\" {arguments}");
        }


        private void RécupérerInformations()
        {
            string nomMachine = Environment.MachineName;
            nomSaisie.Text = nomMachine;

            string adresseIP = ObtenirAdresseIP();
            ipSaisie.Text = adresseIP;

            string utilisateurConnecté = Environment.UserName;
            utilSaisie.Text = utilisateurConnecté;
        }

        private string ObtenirAdresseIP()
        {
            string adresseIP = string.Empty;

            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        adresseIP = ip.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération de l'adresse IP : {ex.Message}");
            }

            return adresseIP;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);


            string[] args = Environment.GetCommandLineArgs();
            if (args.Contains("--silent"))
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void ipSaisie_TextChanged(object sender, EventArgs e) { }

        private void boutton_Click(object sender, EventArgs e) { }

        private void ipSaisie_TextChanged_1(object sender, EventArgs e) { }

        private void utilConnecte_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void adresseIP_Click(object sender, EventArgs e)
        {

        }

        private void nomSaisie_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomMachine_Click(object sender, EventArgs e)
        {

        }

        private void utilSaisie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}