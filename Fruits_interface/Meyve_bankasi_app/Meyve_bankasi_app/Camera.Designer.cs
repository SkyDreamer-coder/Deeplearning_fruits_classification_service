namespace Meyve_bankasi_app
{
    partial class Camera
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_yakala = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_picture_select = new System.Windows.Forms.Button();
            this.btn_detect = new System.Windows.Forms.Button();
            this.dgv_fruits_info = new System.Windows.Forms.DataGridView();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fruits_info)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kameralar :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(136, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_yakala
            // 
            this.btn_yakala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_yakala.Location = new System.Drawing.Point(312, 457);
            this.btn_yakala.Name = "btn_yakala";
            this.btn_yakala.Size = new System.Drawing.Size(161, 40);
            this.btn_yakala.TabIndex = 4;
            this.btn_yakala.Text = "Yakala";
            this.btn_yakala.UseVisualStyleBackColor = false;
            this.btn_yakala.Click += new System.EventHandler(this.btn_yakala_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Yellow;
            this.btn_back.Location = new System.Drawing.Point(42, 101);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(88, 44);
            this.btn_back.TabIndex = 31;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_picture_select
            // 
            this.btn_picture_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_picture_select.Location = new System.Drawing.Point(136, 402);
            this.btn_picture_select.Name = "btn_picture_select";
            this.btn_picture_select.Size = new System.Drawing.Size(161, 40);
            this.btn_picture_select.TabIndex = 32;
            this.btn_picture_select.Text = "Fotoğraf Seç";
            this.btn_picture_select.UseVisualStyleBackColor = false;
            this.btn_picture_select.Click += new System.EventHandler(this.btn_picture_select_Click);
            // 
            // btn_detect
            // 
            this.btn_detect.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_detect.Location = new System.Drawing.Point(312, 402);
            this.btn_detect.Name = "btn_detect";
            this.btn_detect.Size = new System.Drawing.Size(161, 40);
            this.btn_detect.TabIndex = 33;
            this.btn_detect.Text = "Çözümle";
            this.btn_detect.UseVisualStyleBackColor = false;
            this.btn_detect.Click += new System.EventHandler(this.btn_detect_Click);
            // 
            // dgv_fruits_info
            // 
            this.dgv_fruits_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fruits_info.Location = new System.Drawing.Point(596, 101);
            this.dgv_fruits_info.Name = "dgv_fruits_info";
            this.dgv_fruits_info.RowHeadersWidth = 51;
            this.dgv_fruits_info.RowTemplate.Height = 24;
            this.dgv_fruits_info.Size = new System.Drawing.Size(524, 280);
            this.dgv_fruits_info.TabIndex = 34;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Lime;
            this.btn_start.Location = new System.Drawing.Point(136, 457);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(161, 40);
            this.btn_start.TabIndex = 35;
            this.btn_start.Text = "Başlat";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 527);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.dgv_fruits_info);
            this.Controls.Add(this.btn_detect);
            this.Controls.Add(this.btn_picture_select);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_yakala);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Camera";
            this.Text = "Camera";
            this.Load += new System.EventHandler(this.Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fruits_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_yakala;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_picture_select;
        private System.Windows.Forms.Button btn_detect;
        private System.Windows.Forms.DataGridView dgv_fruits_info;
        private System.Windows.Forms.Button btn_start;
    }
}