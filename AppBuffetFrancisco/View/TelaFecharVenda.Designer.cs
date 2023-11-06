namespace AppBuffetFrancisco.View
{
    partial class TelaFecharVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFecharVenda));
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lbl_data = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbl_totalfinal = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(117, 160);
            label2.Name = "label2";
            label2.Size = new Size(355, 32);
            label2.TabIndex = 1;
            label2.Text = "Rua Pepinha Serelepe - SBC - SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(148, 192);
            label3.Name = "label3";
            label3.Size = new Size(293, 32);
            label3.TabIndex = 2;
            label3.Text = "CPNJ: 77.312.124/7777-00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(196, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lbl_data
            // 
            lbl_data.AutoSize = true;
            lbl_data.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_data.Location = new Point(12, 9);
            lbl_data.Name = "lbl_data";
            lbl_data.Size = new Size(108, 25);
            lbl_data.TabIndex = 4;
            lbl_data.Text = "00/00/0000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(127, 224);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 5;
            label4.Text = "772138";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(225, 224);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 6;
            label5.Text = "CCF 0001";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(346, 224);
            label6.Name = "label6";
            label6.Size = new Size(128, 32);
            label6.TabIndex = 7;
            label6.Text = "COD: 0001";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(131, 279);
            label7.Name = "label7";
            label7.Size = new Size(72, 32);
            label7.TabIndex = 8;
            label7.Text = "Total:";
            // 
            // lbl_totalfinal
            // 
            lbl_totalfinal.AutoSize = true;
            lbl_totalfinal.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_totalfinal.Location = new Point(369, 279);
            lbl_totalfinal.Name = "lbl_totalfinal";
            lbl_totalfinal.Size = new Size(105, 32);
            lbl_totalfinal.TabIndex = 9;
            lbl_totalfinal.Text = "R$ 00,00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(167, 328);
            label9.Name = "label9";
            label9.Size = new Size(255, 32);
            label9.TabIndex = 10;
            label9.Text = "Pagamento Recebido";
            // 
            // TelaFecharVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(584, 372);
            Controls.Add(label9);
            Controls.Add(lbl_totalfinal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_data);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaFecharVenda";
            Text = "TelaFecharVenda";
            Load += TelaFecharVenda_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lbl_data;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbl_totalfinal;
        private Label label9;
    }
}