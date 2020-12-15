namespace Java_Proje
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_calkala = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_yapistir = new System.Windows.Forms.Button();
            this.btn_kir = new System.Windows.Forms.Button();
            this.lbl_miktar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calkala
            // 
            this.btn_calkala.Location = new System.Drawing.Point(68, 296);
            this.btn_calkala.Name = "btn_calkala";
            this.btn_calkala.Size = new System.Drawing.Size(154, 43);
            this.btn_calkala.TabIndex = 17;
            this.btn_calkala.Text = "Kumbarayı Çalkala";
            this.btn_calkala.UseVisualStyleBackColor = true;
            this.btn_calkala.Click += new System.EventHandler(this.btn_calkala_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(434, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btn_yapistir
            // 
            this.btn_yapistir.Location = new System.Drawing.Point(366, 382);
            this.btn_yapistir.Name = "btn_yapistir";
            this.btn_yapistir.Size = new System.Drawing.Size(154, 40);
            this.btn_yapistir.TabIndex = 15;
            this.btn_yapistir.Text = "Kumbarayı Yapıştır";
            this.btn_yapistir.UseVisualStyleBackColor = true;
            this.btn_yapistir.Click += new System.EventHandler(this.Btn_yapistir_Click);
            // 
            // btn_kir
            // 
            this.btn_kir.Location = new System.Drawing.Point(68, 382);
            this.btn_kir.Name = "btn_kir";
            this.btn_kir.Size = new System.Drawing.Size(154, 40);
            this.btn_kir.TabIndex = 14;
            this.btn_kir.Text = "Kumbarayı Kır";
            this.btn_kir.UseVisualStyleBackColor = true;
            this.btn_kir.Click += new System.EventHandler(this.Btn_kir_Click);
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.AutoSize = true;
            this.lbl_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_miktar.Location = new System.Drawing.Point(431, 349);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(0, 13);
            this.lbl_miktar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "TOPLAM MİKTAR";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(68, 196);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(154, 63);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "Para Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.01",
            "0.05",
            "0.1",
            "0.25",
            "0.50",
            "1",
            "5",
            "10",
            "20",
            "50",
            "100",
            "200"});
            this.comboBox1.Location = new System.Drawing.Point(68, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(366, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_calkala);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_yapistir);
            this.Controls.Add(this.btn_kir);
            this.Controls.Add(this.lbl_miktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calkala;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_yapistir;
        private System.Windows.Forms.Button btn_kir;
        private System.Windows.Forms.Label lbl_miktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

