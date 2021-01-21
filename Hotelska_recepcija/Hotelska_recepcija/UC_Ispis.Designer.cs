
namespace Hotelska_recepcija
{
    partial class UC_Ispis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Izbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AccessibleName = "";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(215, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(397, 277);
            this.listBox1.TabIndex = 0;
            // 
            // Izbrisi
            // 
            this.Izbrisi.Location = new System.Drawing.Point(464, 371);
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.Size = new System.Drawing.Size(124, 43);
            this.Izbrisi.TabIndex = 2;
            this.Izbrisi.Text = "izbrisiButton";
            this.Izbrisi.UseVisualStyleBackColor = true;
            this.Izbrisi.Click += new System.EventHandler(this.izbrisiButton_Click);
            // 
            // UC_Ispis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Izbrisi);
            this.Controls.Add(this.listBox1);
            this.Name = "UC_Ispis";
            this.Size = new System.Drawing.Size(874, 495);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Izbrisi;
    }
}
