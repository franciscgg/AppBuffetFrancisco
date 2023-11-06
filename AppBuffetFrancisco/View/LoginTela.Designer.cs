namespace AppBuffetFrancisco.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            label2 = new Label();
            label3 = new Label();
            txb_user = new TextBox();
            tbx_senha = new TextBox();
            btn_acessar = new Button();
            pictureBox1 = new PictureBox();
            btn_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 206);
            label2.Name = "label2";
            label2.Size = new Size(124, 37);
            label2.TabIndex = 1;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 273);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // txb_user
            // 
            txb_user.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txb_user.Location = new Point(305, 206);
            txb_user.Name = "txb_user";
            txb_user.Size = new Size(295, 33);
            txb_user.TabIndex = 3;
            // 
            // tbx_senha
            // 
            tbx_senha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_senha.Location = new Point(305, 280);
            tbx_senha.Name = "tbx_senha";
            tbx_senha.PasswordChar = '*';
            tbx_senha.Size = new Size(295, 33);
            tbx_senha.TabIndex = 4;
            // 
            // btn_acessar
            // 
            btn_acessar.BackColor = Color.White;
            btn_acessar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_acessar.Location = new Point(370, 336);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(161, 30);
            btn_acessar.TabIndex = 5;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = false;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.White;
            btn_sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.Location = new Point(411, 374);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(88, 30);
            btn_sair.TabIndex = 7;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += button2_Click;
            // 
            // LoginTela
            // 
            AcceptButton = btn_acessar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 192, 255);
            CancelButton = btn_sair;
            ClientSize = new Size(815, 450);
            Controls.Add(btn_sair);
            Controls.Add(pictureBox1);
            Controls.Add(txb_user);
            Controls.Add(btn_acessar);
            Controls.Add(label2);
            Controls.Add(tbx_senha);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginTela";
            Load += LoginTela_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txb_user;
        private TextBox tbx_senha;
        private Button btn_acessar;
        private PictureBox pictureBox1;
        private Button btn_sair;
    }
}