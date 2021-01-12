
namespace Hotelska_recepcija
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_onama = new System.Windows.Forms.ToolStripButton();
            this.btn_smjestaj = new System.Windows.Forms.ToolStripButton();
            this.btn_restoran = new System.Windows.Forms.ToolStripButton();
            this.btn_posebnaponuda = new System.Windows.Forms.ToolStripButton();
            this.btn_kontakt = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_PosebnaPonuda1 = new Hotelska_recepcija.UC_PosebnaPonuda();
            this.uC_Restorancs1 = new Hotelska_recepcija.UC_Restorancs();
            this.uC_Naslovna1 = new Hotelska_recepcija.UC_Naslovna();
            this.uC_Smjestaj1 = new Hotelska_recepcija.UC_Smjestaj();
            this.uC_Onama1 = new Hotelska_recepcija.UC_Onama();
            this.uC_Kontakt1 = new Hotelska_recepcija.UC_Kontakt();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 100);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btn_onama,
            this.btn_smjestaj,
            this.btn_restoran,
            this.btn_posebnaponuda,
            this.btn_kontakt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1582, 100);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 97);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_onama
            // 
            this.btn_onama.AutoSize = false;
            this.btn_onama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_onama.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_onama.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_onama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_onama.Image = ((System.Drawing.Image)(resources.GetObject("btn_onama.Image")));
            this.btn_onama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_onama.Name = "btn_onama";
            this.btn_onama.Size = new System.Drawing.Size(220, 97);
            this.btn_onama.Text = "O NAMA";
            this.btn_onama.Click += new System.EventHandler(this.btn_onama_Click);
            // 
            // btn_smjestaj
            // 
            this.btn_smjestaj.AutoSize = false;
            this.btn_smjestaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_smjestaj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_smjestaj.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_smjestaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_smjestaj.Image = ((System.Drawing.Image)(resources.GetObject("btn_smjestaj.Image")));
            this.btn_smjestaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_smjestaj.Name = "btn_smjestaj";
            this.btn_smjestaj.Size = new System.Drawing.Size(220, 97);
            this.btn_smjestaj.Text = "SMJEŠTAJ";
            this.btn_smjestaj.Click += new System.EventHandler(this.btn_smjestaj_Click);
            // 
            // btn_restoran
            // 
            this.btn_restoran.AutoSize = false;
            this.btn_restoran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_restoran.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_restoran.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restoran.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_restoran.Image = ((System.Drawing.Image)(resources.GetObject("btn_restoran.Image")));
            this.btn_restoran.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_restoran.Name = "btn_restoran";
            this.btn_restoran.Size = new System.Drawing.Size(220, 97);
            this.btn_restoran.Text = "RESTORAN";
            this.btn_restoran.Click += new System.EventHandler(this.btn_restoran_Click);
            // 
            // btn_posebnaponuda
            // 
            this.btn_posebnaponuda.AutoSize = false;
            this.btn_posebnaponuda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_posebnaponuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_posebnaponuda.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_posebnaponuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_posebnaponuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_posebnaponuda.Image")));
            this.btn_posebnaponuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_posebnaponuda.Name = "btn_posebnaponuda";
            this.btn_posebnaponuda.Size = new System.Drawing.Size(220, 97);
            this.btn_posebnaponuda.Text = "POSEBNA PONUDA";
            this.btn_posebnaponuda.Click += new System.EventHandler(this.btn_posebnaponuda_Click);
            // 
            // btn_kontakt
            // 
            this.btn_kontakt.AutoSize = false;
            this.btn_kontakt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kontakt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_kontakt.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kontakt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_kontakt.Image = ((System.Drawing.Image)(resources.GetObject("btn_kontakt.Image")));
            this.btn_kontakt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_kontakt.Name = "btn_kontakt";
            this.btn_kontakt.Size = new System.Drawing.Size(220, 97);
            this.btn_kontakt.Text = "KONTAKT";
            this.btn_kontakt.Click += new System.EventHandler(this.btn_kontakt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Kontakt1);
            this.panel2.Controls.Add(this.uC_PosebnaPonuda1);
            this.panel2.Controls.Add(this.uC_Restorancs1);
            this.panel2.Controls.Add(this.uC_Naslovna1);
            this.panel2.Controls.Add(this.uC_Smjestaj1);
            this.panel2.Controls.Add(this.uC_Onama1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1582, 753);
            this.panel2.TabIndex = 1;
            // 
            // uC_PosebnaPonuda1
            // 
            this.uC_PosebnaPonuda1.Location = new System.Drawing.Point(302, 37);
            this.uC_PosebnaPonuda1.Margin = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.uC_PosebnaPonuda1.Name = "uC_PosebnaPonuda1";
            this.uC_PosebnaPonuda1.Size = new System.Drawing.Size(1074, 764);
            this.uC_PosebnaPonuda1.TabIndex = 4;
            // 
            // uC_Restorancs1
            // 
            this.uC_Restorancs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Restorancs1.Location = new System.Drawing.Point(0, 0);
            this.uC_Restorancs1.Name = "uC_Restorancs1";
            this.uC_Restorancs1.Size = new System.Drawing.Size(1582, 753);
            this.uC_Restorancs1.TabIndex = 3;
            // 
            // uC_Naslovna1
            // 
            this.uC_Naslovna1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Naslovna1.Location = new System.Drawing.Point(0, 0);
            this.uC_Naslovna1.Name = "uC_Naslovna1";
            this.uC_Naslovna1.Size = new System.Drawing.Size(1582, 753);
            this.uC_Naslovna1.TabIndex = 2;
            // 
            // uC_Smjestaj1
            // 
            this.uC_Smjestaj1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Smjestaj1.Location = new System.Drawing.Point(0, 0);
            this.uC_Smjestaj1.Name = "uC_Smjestaj1";
            this.uC_Smjestaj1.Size = new System.Drawing.Size(1582, 753);
            this.uC_Smjestaj1.TabIndex = 1;
            // 
            // uC_Onama1
            // 
            this.uC_Onama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Onama1.Location = new System.Drawing.Point(0, 0);
            this.uC_Onama1.Name = "uC_Onama1";
            this.uC_Onama1.Size = new System.Drawing.Size(1582, 753);
            this.uC_Onama1.TabIndex = 0;
            // 
            // uC_Kontakt1
            // 
            this.uC_Kontakt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Kontakt1.Location = new System.Drawing.Point(0, 0);
            this.uC_Kontakt1.Name = "uC_Kontakt1";
            this.uC_Kontakt1.Size = new System.Drawing.Size(1582, 753);
            this.uC_Kontakt1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotelska_recepcija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Onama uC_Onama1 = new UC_Onama()
        {
            Visible = false
        };

        private UC_Smjestaj uC_Smjestaj1 = new UC_Smjestaj()
        {
            Visible = false
        };

        private UC_Naslovna uC_Naslovna1 = new UC_Naslovna()
        {
            Visible = false
        };

        private UC_Restorancs uC_Restorancs1 = new UC_Restorancs()
        {
            Visible = false
        };

        private UC_Kontakt uC_Kontakt1 = new UC_Kontakt()
        {
            Visible = false
        };

        private UC_PosebnaPonuda uC_PosebnaPonuda1 = new UC_PosebnaPonuda()
        {
            Visible = false
        };


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_onama;
        private System.Windows.Forms.ToolStripButton btn_smjestaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btn_restoran;
        private System.Windows.Forms.ToolStripButton btn_posebnaponuda;
        private System.Windows.Forms.ToolStripButton btn_kontakt;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

