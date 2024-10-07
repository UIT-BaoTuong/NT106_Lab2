namespace Lab2_23521750_NguyenDuyBaoTuong
{
    partial class Bai4_NhapDuLieu
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
            label1 = new Label();
            label2 = new Label();
            textBox_HoTen = new TextBox();
            label3 = new Label();
            textBox_MSSV = new TextBox();
            label4 = new Label();
            textBox_DienThoai = new TextBox();
            label5 = new Label();
            textBox_DiemIT005 = new TextBox();
            label6 = new Label();
            textBox_DiemNT106 = new TextBox();
            button_Nhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 32);
            label1.Name = "label1";
            label1.Size = new Size(283, 38);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 114);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // textBox_HoTen
            // 
            textBox_HoTen.Location = new Point(274, 107);
            textBox_HoTen.Name = "textBox_HoTen";
            textBox_HoTen.Size = new Size(450, 27);
            textBox_HoTen.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 166);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 1;
            label3.Text = "MSSV";
            // 
            // textBox_MSSV
            // 
            textBox_MSSV.Location = new Point(274, 159);
            textBox_MSSV.Name = "textBox_MSSV";
            textBox_MSSV.Size = new Size(450, 27);
            textBox_MSSV.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 220);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 1;
            label4.Text = "Điện Thoại";
            // 
            // textBox_DienThoai
            // 
            textBox_DienThoai.Location = new Point(274, 213);
            textBox_DienThoai.Name = "textBox_DienThoai";
            textBox_DienThoai.Size = new Size(450, 27);
            textBox_DienThoai.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 271);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 1;
            label5.Text = "Điểm môn IT005";
            // 
            // textBox_DiemIT005
            // 
            textBox_DiemIT005.Location = new Point(274, 264);
            textBox_DiemIT005.Name = "textBox_DiemIT005";
            textBox_DiemIT005.Size = new Size(450, 27);
            textBox_DiemIT005.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 330);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 1;
            label6.Text = "Điểm môn NT106";
            // 
            // textBox_DiemNT106
            // 
            textBox_DiemNT106.Location = new Point(274, 323);
            textBox_DiemNT106.Name = "textBox_DiemNT106";
            textBox_DiemNT106.Size = new Size(450, 27);
            textBox_DiemNT106.TabIndex = 2;
            // 
            // button_Nhap
            // 
            button_Nhap.Location = new Point(325, 374);
            button_Nhap.Name = "button_Nhap";
            button_Nhap.Size = new Size(220, 64);
            button_Nhap.TabIndex = 3;
            button_Nhap.Text = "Nhập";
            button_Nhap.UseVisualStyleBackColor = true;
            // 
            // Bai4_NhapDuLieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Nhap);
            Controls.Add(textBox_DiemNT106);
            Controls.Add(label6);
            Controls.Add(textBox_DiemIT005);
            Controls.Add(label5);
            Controls.Add(textBox_DienThoai);
            Controls.Add(label4);
            Controls.Add(textBox_MSSV);
            Controls.Add(label3);
            Controls.Add(textBox_HoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai4_NhapDuLieu";
            Text = "Bai4_NhapDuLieu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_HoTen;
        private Label label3;
        private TextBox textBox_MSSV;
        private Label label4;
        private TextBox textBox_DienThoai;
        private Label label5;
        private TextBox textBox_DiemIT005;
        private Label label6;
        private TextBox textBox_DiemNT106;
        private Button button_Nhap;
    }
}