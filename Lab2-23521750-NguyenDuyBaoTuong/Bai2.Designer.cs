namespace Lab2_23521750_NguyenDuyBaoTuong
{
    partial class Bai2
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
            richTextBox1 = new RichTextBox();
            button_DocFile = new Button();
            textBox_TenFile = new TextBox();
            textBox_URL = new TextBox();
            textBox_SoDong = new TextBox();
            textBox_SoTu = new TextBox();
            textBox_SoKyTu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(376, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(412, 426);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button_DocFile
            // 
            button_DocFile.Location = new Point(61, 12);
            button_DocFile.Name = "button_DocFile";
            button_DocFile.Size = new Size(229, 80);
            button_DocFile.TabIndex = 1;
            button_DocFile.Text = "Đọc File";
            button_DocFile.UseVisualStyleBackColor = true;
            // 
            // textBox_TenFile
            // 
            textBox_TenFile.Location = new Point(125, 136);
            textBox_TenFile.Name = "textBox_TenFile";
            textBox_TenFile.ReadOnly = true;
            textBox_TenFile.Size = new Size(165, 27);
            textBox_TenFile.TabIndex = 2;
            // 
            // textBox_URL
            // 
            textBox_URL.Location = new Point(125, 190);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.ReadOnly = true;
            textBox_URL.Size = new Size(165, 27);
            textBox_URL.TabIndex = 2;
            // 
            // textBox_SoDong
            // 
            textBox_SoDong.Location = new Point(125, 243);
            textBox_SoDong.Name = "textBox_SoDong";
            textBox_SoDong.ReadOnly = true;
            textBox_SoDong.Size = new Size(165, 27);
            textBox_SoDong.TabIndex = 2;
            // 
            // textBox_SoTu
            // 
            textBox_SoTu.Location = new Point(125, 295);
            textBox_SoTu.Name = "textBox_SoTu";
            textBox_SoTu.ReadOnly = true;
            textBox_SoTu.Size = new Size(165, 27);
            textBox_SoTu.TabIndex = 2;
            // 
            // textBox_SoKyTu
            // 
            textBox_SoKyTu.Location = new Point(125, 345);
            textBox_SoKyTu.Name = "textBox_SoKyTu";
            textBox_SoKyTu.ReadOnly = true;
            textBox_SoKyTu.Size = new Size(165, 27);
            textBox_SoKyTu.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 143);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 197);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "URL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 250);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Số Dòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 302);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Từ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 352);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "Số Ký Tự";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_SoKyTu);
            Controls.Add(textBox_SoTu);
            Controls.Add(textBox_SoDong);
            Controls.Add(textBox_URL);
            Controls.Add(textBox_TenFile);
            Controls.Add(button_DocFile);
            Controls.Add(richTextBox1);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_DocFile;
        private TextBox textBox_TenFile;
        private TextBox textBox_URL;
        private TextBox textBox_SoDong;
        private TextBox textBox_SoTu;
        private TextBox textBox_SoKyTu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}