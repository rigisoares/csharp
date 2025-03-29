namespace App_Login
{
    partial class FrmLogin
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
            lbUsuario = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lbSenha = new Label();
            btAcesso = new Button();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(107, 60);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(47, 15);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(163, 57);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(163, 86);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Location = new Point(107, 89);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(39, 15);
            lbSenha.TabIndex = 2;
            lbSenha.Text = "Senha";
            // 
            // btAcesso
            // 
            btAcesso.Location = new Point(188, 128);
            btAcesso.Name = "btAcesso";
            btAcesso.Size = new Size(75, 23);
            btAcesso.TabIndex = 4;
            btAcesso.Text = "Acesso";
            btAcesso.UseVisualStyleBackColor = true;
            btAcesso.Click += btAcesso_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 297);
            Controls.Add(btAcesso);
            Controls.Add(txtSenha);
            Controls.Add(lbSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lbUsuario);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lbSenha;
        private Button btAcesso;
    }
}