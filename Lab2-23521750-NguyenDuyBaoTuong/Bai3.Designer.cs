namespace Lab2_23521750_NguyenDuyBaoTuong
{
    partial class Bai3
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
            button_Doc = new Button();
            button_Tinh = new Button();
            button_Ghi = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // button_Doc
            // 
            button_Doc.Location = new Point(50, 31);
            button_Doc.Name = "button_Doc";
            button_Doc.Size = new Size(155, 68);
            button_Doc.TabIndex = 0;
            button_Doc.Text = "Đọc";
            button_Doc.UseVisualStyleBackColor = true;
            // 
            // button_Tinh
            // 
            button_Tinh.Location = new Point(322, 31);
            button_Tinh.Name = "button_Tinh";
            button_Tinh.Size = new Size(155, 68);
            button_Tinh.TabIndex = 0;
            button_Tinh.Text = "Tính";
            button_Tinh.UseVisualStyleBackColor = true;
            // 
            // button_Ghi
            // 
            button_Ghi.Location = new Point(567, 31);
            button_Ghi.Name = "button_Ghi";
            button_Ghi.Size = new Size(155, 68);
            button_Ghi.TabIndex = 0;
            button_Ghi.Text = "Ghi";
            button_Ghi.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 116);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(358, 322);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(417, 116);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(360, 322);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button_Ghi);
            Controls.Add(button_Tinh);
            Controls.Add(button_Doc);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Doc;
        private Button button_Tinh;
        private Button button_Ghi;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}