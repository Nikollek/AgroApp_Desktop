using System.Windows.Forms;

namespace AgroApp_Desktop
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            labelUsuário = new Label();
            textBox1 = new TextBox();
            labelSenha = new Label();
            textBox2 = new TextBox();
            buttonEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(107, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelUsuário
            // 
            labelUsuário.AutoSize = true;
            labelUsuário.Font = new Font("Linik Sans ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsuário.Location = new Point(157, 194);
            labelUsuário.Name = "labelUsuário";
            labelUsuário.Size = new Size(57, 17);
            labelUsuário.TabIndex = 1;
            labelUsuário.Text = "Usuário:\r\n";
            labelUsuário.Click += labelUsuário_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(130, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Linik Sans ExtraBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSenha.Location = new Point(157, 267);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(49, 17);
            labelSenha.TabIndex = 3;
            labelSenha.Text = "Senha:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.Location = new Point(130, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 4;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Font = new Font("Linik Sans ExtraBold", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.Location = new Point(230, 351);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(103, 35);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "ENTRAR";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 455);
            Controls.Add(buttonEntrar);
            Controls.Add(textBox2);
            Controls.Add(labelSenha);
            Controls.Add(textBox1);
            Controls.Add(labelUsuário);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Login Administrador";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelUsuário;
        private TextBox textBox1;
        private Label labelSenha;
        private TextBox textBox2;
        private Button buttonEntrar;
    }
}