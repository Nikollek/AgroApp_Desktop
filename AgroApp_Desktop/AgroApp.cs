using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AgroApp_Desktop
{



    public partial class AgroApp : Form
    {

        public AgroApp()
        {

            InitializeComponent();

            // Quais elementos devem aparecer ao iniciar o programa
            panelMenu.Visible = true;
            pictureLogoInicio.Visible = true;
            panelFaixa1.Visible = false;
            panelFaixa2.Visible = false;
            panelFaixa3.Visible = false;
            panelFaixa.Visible = false;
            panelAreaVendas.Visible = false;
            panelProdução.Visible = false;
            dataGridVendas.Visible = false;
            dataGridProdução.Visible = false;
            dataGridFornecedores.Visible = false;
            panelFornecedores.Visible = false;
            panelRelatórios.Visible = false;

            // Tirando a estilização padrão dos links
            linkVendas.LinkBehavior = LinkBehavior.NeverUnderline;
            linkProduçao.LinkBehavior = LinkBehavior.NeverUnderline;
            linkFornecedor.LinkBehavior = LinkBehavior.NeverUnderline;
            linkRelatorio.LinkBehavior = LinkBehavior.NeverUnderline;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Paleta de cores dos elementos no menu
            panelMenu.BackColor = ColorPalette.VerdeClaro; 
            panelFaixa1.BackColor = ColorPalette.VerdeMedio;
            panelFaixa2.BackColor = ColorPalette.VerdeMedio;
            panelFaixa3.BackColor = ColorPalette.VerdeMedio;
            panelFaixa.BackColor = ColorPalette.VerdeMedio;
            linkVendas.LinkColor = ColorPalette.VerdeEscuro;
            labelVendas.ForeColor = ColorPalette.VerdeEscuro;
            linkProduçao.LinkColor = ColorPalette.VerdeEscuro;
            labelProdução.ForeColor = ColorPalette.VerdeEscuro;
            buttonAdicionarProdução.BackColor = ColorPalette.VerdeClaro;
            buttonAdicionarProdução.ForeColor = ColorPalette.VerdeEscuro;
            linkFornecedor.LinkColor = ColorPalette.VerdeEscuro;
            labelFornecedores.ForeColor = ColorPalette.VerdeEscuro;
            linkRelatorio.LinkColor = ColorPalette.VerdeEscuro;
            panelVendaIngresso.BackColor = ColorPalette.VerdeClaro;
            panelVendaAlimento.BackColor = ColorPalette.VerdeClaro;
            panelGanhoTotal.BackColor = ColorPalette.VerdeClaro;
            labelAlimentoFornecido.ForeColor = ColorPalette.VerdeEscuro;
            labelAlimentoIngresso.ForeColor = ColorPalette.VerdeEscuro;
            labelVendaIngresso.ForeColor = ColorPalette.VerdeEscuro;
            labelVendaAlimento.ForeColor = ColorPalette.VerdeEscuro;
            labelGanhoTotal.ForeColor = ColorPalette.VerdeEscuro;
            labelRelatórios.ForeColor = ColorPalette.VerdeEscuro;
            pictureAgroApp.BackColor = ColorPalette.VerdeClaro;

            // Configurando o primeiro gráfico
            chartAlimentosFornecidos.Series.Clear(); // Limpa as séries existentes
            var series1 = chartAlimentosFornecidos.Series.Add("Série 1");
            series1.ChartType = SeriesChartType.Doughnut; // Tipo de gráfico

            // Adicionando os dados
            series1.Points.AddXY(1, 10);
            series1.Points[0].Label = "Batata"; 
            series1.Points[0].LabelForeColor = System.Drawing.Color.White;
            series1.Points.AddXY(2, 20);
            series1.Points[1].Label = "Alface";         
            series1.Points[1].LabelForeColor = System.Drawing.Color.White;
            series1.Points.AddXY(3, 30);
            series1.Points[2].Label = "Cenoura"; 
            series1.Points[2].LabelForeColor = System.Drawing.Color.White;
            series1.Points.AddXY(4, 40);
            series1.Points[3].Label = "Cebola"; 
            series1.Points[3].LabelForeColor = System.Drawing.Color.White;

            // Adicionando a paleta de cores
            series1.Points[0].Color = ColorPalette.Verde;        
            series1.Points[1].Color = ColorPalette.VerdeClaro;   
            series1.Points[2].Color = ColorPalette.VerdeMedio;   
            series1.Points[3].Color = ColorPalette.VerdeEscuro;  




            // Configurando o segundo gráfico
            chartAlimentosIngresso.Series.Clear(); // Limpa as séries existentes
            var series2 = chartAlimentosIngresso.Series.Add("Série 2");
            series2.ChartType = SeriesChartType.Column; // Tipo de gráfico

            // Adicionando os dados
            series2.Points.AddXY(1, 10);
            series2.Points[0].Label = "Cebola";
            series2.Points.AddXY(2, 30);
            series2.Points[1].Label = "tomate"; 
            series2.Points.AddXY(3, 50);
            series2.Points[2].Label = "Batata";

            // Adicionando a paleta de cores
            series2.Points[0].Color = ColorPalette.VerdeMedio;      
            series2.Points[1].Color = ColorPalette.VerdeMedio;   
            series2.Points[2].Color = ColorPalette.VerdeMedio;   

            series1.IsValueShownAsLabel = true; // Exibir os dados
            series1.Font = new Font("Linik Sans", 10, FontStyle.Bold); // Para alterar a fonte dos dados

            series2.IsValueShownAsLabel = true; // Exibir os dados
            series2.Font = new Font("Linik Sans", 10, FontStyle.Bold); // Para alterar a fonte dos dados

            ConfigurarDataGridVendasAsync();
            ConfigurarDataGridProdução();
            ConfigurarDataGridFornecedores();
        }


        private async Task ConfigurarDataGridVendasAsync()
        {
            dataGridVendas.AllowUserToAddRows = false;

            // Limpa colunas e linhas existentes, se houver
            dataGridVendas.Columns.Clear();
            dataGridVendas.Rows.Clear();

            // Adicionando as colunas 
            dataGridVendas.Columns.Add("Coluna1", "Vendas realizadas");
            dataGridVendas.Columns.Add("Coluna2", "Quantidade");
            dataGridVendas.Columns.Add("Coluna3", "Valor total");

            dataGridVendas.DefaultCellStyle.ForeColor = ColorPalette.VerdeEscuro; // Cor do texto
            dataGridVendas.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.VerdeEscuro; // Cor do texto do cabeçalho

            // Centraliza o texto dos cabeçalhos
            foreach (DataGridViewColumn column in dataGridVendas.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridVendas.Columns[0].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a primeira coluna
            dataGridVendas.Columns[1].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a segunda coluna 
            dataGridVendas.Columns[2].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a terceira coluna

            try
            {
                // Chama o método para obter os dados da API
                ConexaoBackEnd conexao = new ConexaoBackEnd();
                List<VendasEfetivadas> vendas = await conexao.deveRetornarVendasEfetivadas();

                // Adiciona os dados ao DataGridView
                foreach (var venda in vendas)
                {
                    dataGridVendas.Rows.Add(venda.nome_alimento, venda.quantidade_vendida, venda.total_vendido);
                }
                dataGridVendas.Height = 242; //Altura do datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void ConfigurarDataGridProdução()
        {

            dataGridProdução.AllowUserToAddRows = false;

            // Adicionando as colunas 
            dataGridProdução.Columns.Add("Coluna1", "Alimentos Cadastrados");
            dataGridProdução.Columns.Add("Coluna2", "Data do cadastro");
            dataGridProdução.Columns.Add("Coluna3", "Clima e região");
            dataGridProdução.Columns.Add("Coluna4", "Tempo para ser feito");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "PRONTO";  // Cabeçalho da coluna
            checkBoxColumn.Name = "ColunaCheckBox";     // Nome da coluna
            checkBoxColumn.Width = 50;                   // Largura da coluna
            checkBoxColumn.ReadOnly = false;             // Permitir edição
            dataGridProdução.Columns.Add(checkBoxColumn); // Adiciona a coluna CheckBox

            dataGridProdução.DefaultCellStyle.ForeColor = ColorPalette.VerdeEscuro; // Cor do texto
            dataGridProdução.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.VerdeEscuro; // Cor do texto do cabeçalho

            // Centraliza o texto dos cabeçalhos
            foreach (DataGridViewColumn column in dataGridProdução.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridProdução.Columns[0].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a primeira coluna
            dataGridProdução.Columns[1].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a segunda coluna
            dataGridProdução.Columns[2].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a terceira coluna
            dataGridProdução.Columns[3].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a quarta coluna
            dataGridProdução.Columns[4].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;// Cor para a quinta coluna

            // Adicionando os dados
            dataGridProdução.Rows.Add("Tomate");
            dataGridProdução.Rows.Add("Batata");
            dataGridProdução.Rows.Add("Cenoura");
            dataGridProdução.Rows.Add("Alface");
            dataGridProdução.Rows.Add("Tomate");
            dataGridProdução.Rows.Add("Batata");
            dataGridProdução.Rows.Add("Cenoura");
            dataGridProdução.Rows.Add("Alface");

            dataGridProdução.Height = 243; // Altura do datagrid

            dataGridProdução.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }


        private async void ConfigurarDataGridFornecedores()
        {
            dataGridFornecedores.AllowUserToAddRows = false;

            // Adicionando as colunas 
            dataGridFornecedores.Columns.Add("Coluna1", "Fornecedores");
            dataGridFornecedores.Columns.Add("Coluna2", "Tipo pessoa");
            dataGridFornecedores.Columns.Add("Coluna3", "Telefone");

            dataGridFornecedores.DefaultCellStyle.ForeColor = ColorPalette.VerdeEscuro; // Cor do texto
            dataGridFornecedores.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.VerdeEscuro; // Cor do texto do cabeçalho

            // Centraliza o texto dos cabeçalhos
            foreach (DataGridViewColumn column in dataGridFornecedores.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridFornecedores.Columns[0].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;  // Cor para a primeira coluna
            dataGridFornecedores.Columns[1].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;  // Cor para a primeira coluna
            dataGridFornecedores.Columns[2].HeaderCell.Style.BackColor = ColorPalette.VerdeClaro;  // Cor para a primeira coluna

            try
            {
                // Chama o método para obter os dados da API
                ConexaoBackEnd conexao = new ConexaoBackEnd();
                List<Fornecedores> fornecedores = await conexao.deveRetornarFornecedores();

                // Adiciona os dados ao DataGridView
                foreach (var forncedor in fornecedores)
                {
                    dataGridFornecedores.Rows.Add(forncedor.nome_fornecedor, forncedor.tipo_pessoa, forncedor.telefone);
                }
                dataGridVendas.Height = 242; //Altura do datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkVendas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mostra a parte das vendas e oculta as demais
            panelAreaVendas.Visible = true;
            dataGridVendas.Visible = true;
            panelProdução.Visible = false;
            dataGridProdução.Visible = false;
            panelFornecedores.Visible = false;
            dataGridFornecedores.Visible = false;
            panelRelatórios.Visible = false;
            pictureLogoInicio.Visible = false;
        }

        private void linkFornecedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mostra a parte dos fornecedores e oculta as demais
            panelFornecedores.Visible = true;
            dataGridFornecedores.Visible = true;
            panelProdução.Visible = false;
            dataGridProdução.Visible = false;
            panelAreaVendas.Visible = false;
            dataGridVendas.Visible = false;
            panelRelatórios.Visible = false;
            pictureLogoInicio.Visible = false;
        }

        private void linkProduçao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mostra a parte da produção e oculta as demais
            panelProdução.Visible = true;
            dataGridProdução.Visible = true;
            panelAreaVendas.Visible = false;
            dataGridVendas.Visible = false;
            panelFornecedores.Visible = false;
            dataGridFornecedores.Visible = false;
            panelRelatórios.Visible = false;
            pictureLogoInicio.Visible = false;
        }

        private void linkRelatorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mostra a parte dos relatórios e oculta as demais
            panelRelatórios.Visible = true;
            chartAlimentosFornecidos.Visible = true;
            chartAlimentosIngresso.Visible = true;
            panelProdução.Visible = false;
            dataGridProdução.Visible = false;
            panelAreaVendas.Visible = false;
            dataGridVendas.Visible = false;
            panelFornecedores.Visible = false;
            dataGridFornecedores.Visible = false;
            pictureLogoInicio.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            // Mostra a parte do menu inicial e oculta as demais
            panelMenu.Visible = true;
            panelRelatórios.Visible = false;
            chartAlimentosFornecidos.Visible = false;
            chartAlimentosIngresso.Visible = false;
            panelProdução.Visible = false;
            dataGridProdução.Visible = false;
            panelAreaVendas.Visible = false;
            dataGridVendas.Visible = false;
            panelFornecedores.Visible = false;
            dataGridFornecedores.Visible = false;
            pictureLogoInicio.Visible = true;
        }

        private void linkVendas_MouseEnter(object sender, EventArgs e)
        {
            // Faixa verde da parte de vendas ao passar o mouse 
            panelFaixa1.Visible = true; 
            linkVendas.BackColor = panelFaixa1.BackColor;
            pictureVendas.BackColor = panelFaixa1.BackColor;
        }

        private void linkVendas_MouseLeave(object sender, EventArgs e)
        {
            // Faixa verde da parte de vendas ao tirar o mouse
            panelFaixa1.Visible = false; 
            linkVendas.BackColor = panelMenu.BackColor;
            pictureVendas.BackColor = panelMenu.BackColor;
        }

        private void linkProduçao_MouseEnter(object sender, EventArgs e)
        {
            // Faixa verde da parte de produção ao passar o mouse 
            panelFaixa2.Visible = true; 
            linkProduçao.BackColor = panelFaixa2.BackColor;
            pictureProduçao.BackColor = panelFaixa2.BackColor;
        }

        private void linkProduçao_MouseLeave(object sender, EventArgs e)
        {
            // Faixa verde da parte de produção ao tirar o mouse
            panelFaixa2.Visible = false;
            linkProduçao.BackColor = panelMenu.BackColor;
            pictureProduçao.BackColor = panelMenu.BackColor;
        }

        private void linkFornecedor_MouseEnter(object sender, EventArgs e)
        {
            // Faixa verde da parte de fornecedores ao passar o mouse
            panelFaixa3.Visible = true; 
            linkFornecedor.BackColor = panelFaixa3.BackColor;
            pictureFornecedor.BackColor = panelFaixa3.BackColor;
        }

        private void linkFornecedor_MouseLeave(object sender, EventArgs e)
        {
            // Faixa verde da parte de fornecedores ao tirar o mouse
            panelFaixa3.Visible = false;
            linkFornecedor.BackColor = panelMenu.BackColor;
            pictureFornecedor.BackColor = panelMenu.BackColor;
        }

        private void linkRelatorio_MouseEnter(object sender, EventArgs e)
        {
            // Faixa verde da parte de relatórios ao passar o mouse
            panelFaixa.Visible = true; 
            linkRelatorio.BackColor = panelFaixa.BackColor;
            pictureRelatorio.BackColor = panelFaixa.BackColor;
        }

        private void linkRelatorio_MouseLeave(object sender, EventArgs e)
        {
            // Faixa verde da parte de relatórios ao tirar o mouse
            panelFaixa.Visible = false; 
            linkRelatorio.BackColor = panelMenu.BackColor;
            pictureRelatorio.BackColor = panelMenu.BackColor;
        }

        private void panelFaixa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFaixa_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panelAreaVendas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridProdução_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelProdução_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridProdução_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridProdução_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridFornecedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelFormasPagamento_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelVendaIngresso_Click(object sender, EventArgs e)
        {

        }

        private void panelFornecedores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRelatórios_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
