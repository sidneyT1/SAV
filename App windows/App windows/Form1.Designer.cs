namespace App_windows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox nomSaisie;
        private System.Windows.Forms.Label nomMachine;
        private System.Windows.Forms.Label adresseIP;
        private System.Windows.Forms.TextBox ipSaisie;
        private System.Windows.Forms.Button btnLancerOutlook;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nomSaisie = new System.Windows.Forms.TextBox();
            this.nomMachine = new System.Windows.Forms.Label();
            this.adresseIP = new System.Windows.Forms.Label();
            this.ipSaisie = new System.Windows.Forms.TextBox();
            this.btnLancerOutlook = new System.Windows.Forms.Button();
            this.utilSaisie = new System.Windows.Forms.TextBox();
            this.utilConnecte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // nomSaisie
            // 
            this.nomSaisie.Location = new System.Drawing.Point(320, 101);
            this.nomSaisie.Name = "nomSaisie";
            this.nomSaisie.Size = new System.Drawing.Size(139, 20);
            this.nomSaisie.TabIndex = 0;
            this.nomSaisie.TextChanged += new System.EventHandler(this.nomSaisie_TextChanged);
            // 
            // nomMachine
            // 
            this.nomMachine.AutoSize = true;
            this.nomMachine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMachine.Location = new System.Drawing.Point(188, 105);
            this.nomMachine.Name = "nomMachine";
            this.nomMachine.Size = new System.Drawing.Size(117, 12);
            this.nomMachine.TabIndex = 1;
            this.nomMachine.Text = "Nom de la machine :";
            this.nomMachine.Click += new System.EventHandler(this.nomMachine_Click);
            // 
            // adresseIP
            // 
            this.adresseIP.AutoSize = true;
            this.adresseIP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseIP.Location = new System.Drawing.Point(235, 145);
            this.adresseIP.Name = "adresseIP";
            this.adresseIP.Size = new System.Drawing.Size(70, 12);
            this.adresseIP.TabIndex = 2;
            this.adresseIP.Text = "Adresse IP :";
            this.adresseIP.Click += new System.EventHandler(this.adresseIP_Click);
            // 
            // ipSaisie
            // 
            this.ipSaisie.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ipSaisie.Location = new System.Drawing.Point(320, 141);
            this.ipSaisie.Name = "ipSaisie";
            this.ipSaisie.Size = new System.Drawing.Size(139, 20);
            this.ipSaisie.TabIndex = 3;
            this.ipSaisie.TextChanged += new System.EventHandler(this.ipSaisie_TextChanged_1);
            // 
            // btnLancerOutlook
            // 
            this.btnLancerOutlook.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLancerOutlook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancerOutlook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLancerOutlook.Location = new System.Drawing.Point(213, 260);
            this.btnLancerOutlook.Name = "btnLancerOutlook";
            this.btnLancerOutlook.Size = new System.Drawing.Size(180, 63);
            this.btnLancerOutlook.TabIndex = 4;
            this.btnLancerOutlook.Text = "CONTACTER LE SUPPORT";
            this.btnLancerOutlook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLancerOutlook.UseVisualStyleBackColor = false;
            this.btnLancerOutlook.Click += new System.EventHandler(this.btnLancerOutlook_Click);
            // 
            // utilSaisie
            // 
            this.utilSaisie.ForeColor = System.Drawing.SystemColors.MenuText;
            this.utilSaisie.Location = new System.Drawing.Point(320, 181);
            this.utilSaisie.Name = "utilSaisie";
            this.utilSaisie.Size = new System.Drawing.Size(139, 20);
            this.utilSaisie.TabIndex = 6;
            this.utilSaisie.TextChanged += new System.EventHandler(this.utilSaisie_TextChanged);
            // 
            // utilConnecte
            // 
            this.utilConnecte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilConnecte.Location = new System.Drawing.Point(181, 185);
            this.utilConnecte.Name = "utilConnecte";
            this.utilConnecte.Size = new System.Drawing.Size(126, 16);
            this.utilConnecte.TabIndex = 5;
            this.utilConnecte.Text = "Utilisateur connecté :";
            this.utilConnecte.UseMnemonic = false;
            this.utilConnecte.Click += new System.EventHandler(this.utilConnecte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(131, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(131, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 36);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(591, 369);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.utilSaisie);
            this.Controls.Add(this.utilConnecte);
            this.Controls.Add(this.btnLancerOutlook);
            this.Controls.Add(this.ipSaisie);
            this.Controls.Add(this.adresseIP);
            this.Controls.Add(this.nomMachine);
            this.Controls.Add(this.nomSaisie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SAV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox utilSaisie;
        private System.Windows.Forms.Label utilConnecte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}