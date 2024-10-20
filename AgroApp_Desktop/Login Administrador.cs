using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgroApp_Desktop;
using static System.Windows.Forms.DataFormats;

namespace AgroApp_Desktop
{


    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Cores dos elementos do Login
            this.BackColor = ColorPalette.VerdeClaro;
            textBox1.BackColor = ColorPalette.VerdeMedio;
            textBox2.BackColor = ColorPalette.VerdeMedio;
            buttonEntrar.BackColor = ColorPalette.VerdeMedio;
            buttonEntrar.ForeColor = ColorPalette.VerdeEscuro;
            labelSenha.ForeColor = ColorPalette.VerdeEscuro;
            labelUsuário.ForeColor = ColorPalette.VerdeEscuro;
            pictureBox1.Image = Properties.Resources.Logo;
            CentralizarComponente();  // Centraliza a imagem ao carregar o formulário
        }


        private void CentralizarComponente()
        {

            pictureBox1.Location = new Point(
                (this.ClientSize.Width - pictureBox1.Width) / 2,  // Centraliza horizontalmente
                ((this.ClientSize.Height - pictureBox1.Height) / 2) - 120  // Centraliza verticalmente
            );

            pictureBox1.Anchor = AnchorStyles.None;  // Remove as âncoras que tiverem

            // Centraliza o textBox1
            textBox1.Location = new Point(
                (this.ClientSize.Width - textBox1.Width) / 2,
                labelUsuário.Bottom + 5  // Ajusta a posição vertical abaixo do label1
            );

            // Centraliza o textBox2
            textBox2.Location = new Point(
                (this.ClientSize.Width - textBox2.Width) / 2,
                labelSenha.Bottom + 5  // Ajusta a posição vertical abaixo do label2
            );

            buttonEntrar.Location = new Point(
            (this.ClientSize.Width - buttonEntrar.Width) / 2, 
            ((this.ClientSize.Height - buttonEntrar.Height) / 2) - -140 // Centraliza verticalmente 
            );

            // Remove âncoras para permitir centralização 
            buttonEntrar.Anchor = AnchorStyles.None;
            labelUsuário.Anchor = AnchorStyles.None;
            textBox1.Anchor = AnchorStyles.None;
            labelSenha.Anchor = AnchorStyles.None;
            textBox2.Anchor = AnchorStyles.None;
            pictureBox1.Anchor = AnchorStyles.None;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos de texto estão preenchidos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // Mostra uma mensagem de erro se algum campo estiver vazio
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Cria uma nova instância do próximo formulário (por exemplo, Form2)
                AgroApp Form1 = new AgroApp();

                // Mostra o próximo formulário
                Form1.Show();

                // Fecha o formulário de login
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsuário_Click(object sender, EventArgs e)
        {

        }
    }
}
