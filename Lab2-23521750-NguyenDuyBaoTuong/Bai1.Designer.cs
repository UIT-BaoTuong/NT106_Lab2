namespace Lab2_23521750_NguyenDuyBaoTuong
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            button_Doc = new Button();
            button_Ghi = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 13);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(773, 329);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button_Doc
            // 
            button_Doc.Location = new Point(118, 362);
            button_Doc.Name = "button_Doc";
            button_Doc.Size = new Size(221, 66);
            button_Doc.TabIndex = 1;
            button_Doc.Text = "Đọc File";
            button_Doc.UseVisualStyleBackColor = true;
            // 
            // button_Ghi
            // 
            button_Ghi.Location = new Point(474, 362);
            button_Ghi.Name = "button_Ghi";
            button_Ghi.Size = new Size(221, 66);
            button_Ghi.TabIndex = 1;
            button_Ghi.Text = "Ghi File";
            button_Ghi.UseVisualStyleBackColor = true;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Ghi);
            Controls.Add(button_Doc);
            Controls.Add(richTextBox1);
            Name = "Bai1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button_Doc;
        private Button button_Ghi;
    }
}
