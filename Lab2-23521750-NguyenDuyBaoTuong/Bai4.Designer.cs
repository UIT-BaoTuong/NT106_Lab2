namespace Lab2_23521750_NguyenDuyBaoTuong
{
    partial class Bai4
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
            button_NhapDuLieu = new Button();
            button_Luu = new Button();
            button_HienThi = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button_NhapDuLieu
            // 
            button_NhapDuLieu.Location = new Point(36, 50);
            button_NhapDuLieu.Name = "button_NhapDuLieu";
            button_NhapDuLieu.Size = new Size(166, 68);
            button_NhapDuLieu.TabIndex = 0;
            button_NhapDuLieu.Text = "Nhập Dữ Liệu";
            button_NhapDuLieu.UseVisualStyleBackColor = true;
            // 
            // button_Luu
            // 
            button_Luu.Location = new Point(36, 148);
            button_Luu.Name = "button_Luu";
            button_Luu.Size = new Size(166, 68);
            button_Luu.TabIndex = 0;
            button_Luu.Text = "Lưu";
            button_Luu.UseVisualStyleBackColor = true;
            // 
            // button_HienThi
            // 
            button_HienThi.Location = new Point(36, 250);
            button_HienThi.Name = "button_HienThi";
            button_HienThi.Size = new Size(166, 68);
            button_HienThi.TabIndex = 0;
            button_HienThi.Text = "Hiển Thị Thông Tin";
            button_HienThi.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(217, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(560, 370);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button_HienThi);
            Controls.Add(button_Luu);
            Controls.Add(button_NhapDuLieu);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
        }

        #endregion

        private Button button_NhapDuLieu;
        private Button button_Luu;
        private Button button_HienThi;
        private RichTextBox richTextBox1;
    }
}