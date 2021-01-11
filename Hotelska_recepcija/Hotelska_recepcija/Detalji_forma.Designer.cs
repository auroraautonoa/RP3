
namespace Hotelska_recepcija
{
    partial class Detalji_forma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalji_forma));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date_prijava = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datum_odjava = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_brojOsoba = new System.Windows.Forms.TextBox();
            this.btn_Rezerviraj = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labela_cijena = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 953);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(550, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 953);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 470);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Sitka Text", 8.5F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "OPIS SMJEŠTAJA",
            "",
            "Raspolažemo sa 2 vrste jednokrevetnih soba.",
            "Jednokrevetne standardne i jednokrevetne comforne sobe . ",
            "Sve su sobe vrhunski opremljene za Vaš ugodan boravak, ",
            "bilo da se radi o poslovnom putu, romatičnom vikendu, obiteljskom izletu",
            " ili samo o dnevnom odmoru. Svaka soba",
            "ima vrhunsku, modernu kupaonicu, klimu, mini bar, TV uređaj sa satelitiskim",
            "prijamom, telefonski i internetski priključak.",
            "",
            "Pojedinosti:",
            "",
            "Krevet za jednu osobu",
            "Besplatan Internet i parking",
            "Doručak uključen",
            "17 kvadratnih metara",
            "Kupona sa tuš kabinom",
            "Radni stol",
            "Room service",
            "Flat Screen TV",
            "Minibar"});
            this.listBox1.Location = new System.Drawing.Point(3, 479);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(544, 440);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_Rezerviraj);
            this.panel2.Controls.Add(this.txt_brojOsoba);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.datum_odjava);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.date_prijava);
            this.panel2.Location = new System.Drawing.Point(22, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 745);
            this.panel2.TabIndex = 0;
            // 
            // date_prijava
            // 
            this.date_prijava.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.date_prijava.Checked = false;
            this.date_prijava.CustomFormat = "";
            this.date_prijava.Font = new System.Drawing.Font("Sitka Text", 10F);
            this.date_prijava.Location = new System.Drawing.Point(65, 396);
            this.date_prijava.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.date_prijava.Name = "date_prijava";
            this.date_prijava.Size = new System.Drawing.Size(358, 28);
            this.date_prijava.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prijava";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(62, 439);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odjava";
            // 
            // datum_odjava
            // 
            this.datum_odjava.CalendarFont = new System.Drawing.Font("Sitka Text", 12F);
            this.datum_odjava.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.datum_odjava.Checked = false;
            this.datum_odjava.CustomFormat = "";
            this.datum_odjava.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datum_odjava.Location = new System.Drawing.Point(65, 476);
            this.datum_odjava.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.datum_odjava.Name = "datum_odjava";
            this.datum_odjava.Size = new System.Drawing.Size(358, 29);
            this.datum_odjava.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(62, 524);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj osoba";
            // 
            // txt_brojOsoba
            // 
            this.txt_brojOsoba.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_brojOsoba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_brojOsoba.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brojOsoba.Location = new System.Drawing.Point(68, 560);
            this.txt_brojOsoba.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.txt_brojOsoba.Multiline = true;
            this.txt_brojOsoba.Name = "txt_brojOsoba";
            this.txt_brojOsoba.Size = new System.Drawing.Size(358, 43);
            this.txt_brojOsoba.TabIndex = 5;
            // 
            // btn_Rezerviraj
            // 
            this.btn_Rezerviraj.AutoSize = true;
            this.btn_Rezerviraj.Font = new System.Drawing.Font("Sitka Text", 12F);
            this.btn_Rezerviraj.Location = new System.Drawing.Point(102, 632);
            this.btn_Rezerviraj.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.btn_Rezerviraj.Name = "btn_Rezerviraj";
            this.btn_Rezerviraj.Size = new System.Drawing.Size(269, 50);
            this.btn_Rezerviraj.TabIndex = 6;
            this.btn_Rezerviraj.Text = "Rezerviraj!";
            this.btn_Rezerviraj.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.labela_cijena);
            this.panel3.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(79, 90);
            this.panel3.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(312, 192);
            this.panel3.TabIndex = 7;
            // 
            // labela_cijena
            // 
            this.labela_cijena.AutoSize = true;
            this.labela_cijena.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela_cijena.Location = new System.Drawing.Point(29, 67);
            this.labela_cijena.Name = "labela_cijena";
            this.labela_cijena.Size = new System.Drawing.Size(244, 43);
            this.labela_cijena.TabIndex = 0;
            this.labela_cijena.Text = "Cijena, npr 450kn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Smještaj od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "po noćenju";
            // 
            // Detalji_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1082, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Detalji_forma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.Detalji_forma_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date_prijava;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labela_cijena;
        private System.Windows.Forms.Button btn_Rezerviraj;
        private System.Windows.Forms.TextBox txt_brojOsoba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datum_odjava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}