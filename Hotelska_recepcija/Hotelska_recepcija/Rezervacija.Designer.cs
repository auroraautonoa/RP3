namespace Hotelska_recepcija
{
    partial class Rezervacija
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
            this.Rez_naslov = new System.Windows.Forms.Label();
            this.btn_rezerviraj = new System.Windows.Forms.Button();
            this.odabir_sobe = new System.Windows.Forms.Label();
            this.SobaBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Rez_naslov
            // 
            this.Rez_naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rez_naslov.Location = new System.Drawing.Point(35, 35);
            this.Rez_naslov.Name = "Rez_naslov";
            this.Rez_naslov.Size = new System.Drawing.Size(194, 23);
            this.Rez_naslov.TabIndex = 0;
            this.Rez_naslov.Text = "Rezervacija";
            // 
            // btn_rezerviraj
            // 
            this.btn_rezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rezerviraj.Location = new System.Drawing.Point(616, 385);
            this.btn_rezerviraj.Name = "btn_rezerviraj";
            this.btn_rezerviraj.Size = new System.Drawing.Size(150, 39);
            this.btn_rezerviraj.TabIndex = 1;
            this.btn_rezerviraj.Text = "Rezerviraj";
            this.btn_rezerviraj.UseVisualStyleBackColor = true;
            this.btn_rezerviraj.Click += new System.EventHandler(this.button1_Click);
            // 
            // odabir_sobe
            // 
            this.odabir_sobe.AutoSize = true;
            this.odabir_sobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odabir_sobe.Location = new System.Drawing.Point(36, 347);
            this.odabir_sobe.Name = "odabir_sobe";
            this.odabir_sobe.Size = new System.Drawing.Size(93, 16);
            this.odabir_sobe.TabIndex = 2;
            this.odabir_sobe.Text = "Odaberi sobu:";
            // 
            // SobaBox
            // 
            this.SobaBox.FormattingEnabled = true;
            this.SobaBox.Location = new System.Drawing.Point(39, 376);
            this.SobaBox.Name = "SobaBox";
            this.SobaBox.Size = new System.Drawing.Size(137, 56);
            this.SobaBox.TabIndex = 3;
            // 
            // Rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SobaBox);
            this.Controls.Add(this.odabir_sobe);
            this.Controls.Add(this.btn_rezerviraj);
            this.Controls.Add(this.Rez_naslov);
            this.Name = "Rezervacija";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Rezervacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rez_naslov;
        private System.Windows.Forms.Button btn_rezerviraj;
        private System.Windows.Forms.Label odabir_sobe;
        private System.Windows.Forms.ListBox SobaBox;
    }
}