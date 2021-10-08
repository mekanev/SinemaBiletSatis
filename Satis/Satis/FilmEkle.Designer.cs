
namespace Satis
{
    partial class FilmEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.btnFilmKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı :";
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(166, 59);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(117, 26);
            this.txtFilm.TabIndex = 1;
            // 
            // btnFilmKaydet
            // 
            this.btnFilmKaydet.Location = new System.Drawing.Point(166, 102);
            this.btnFilmKaydet.Name = "btnFilmKaydet";
            this.btnFilmKaydet.Size = new System.Drawing.Size(117, 43);
            this.btnFilmKaydet.TabIndex = 2;
            this.btnFilmKaydet.Text = "Filmi Kaydet";
            this.btnFilmKaydet.UseVisualStyleBackColor = true;
            this.btnFilmKaydet.Click += new System.EventHandler(this.btnFilmKaydet_Click);
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(389, 229);
            this.Controls.Add(this.btnFilmKaydet);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FilmEkle";
            this.Text = "FilmEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilmEkle_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Button btnFilmKaydet;
    }
}