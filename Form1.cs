using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeyDrawn_Money_Manager
{
    public partial class Form1 : Form
    {
        Dados dados = new Dados();
        public Form1()
        {
            InitializeComponent();
        }

        #region Janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void iconButton_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Form
        


        
        private void Form1_Load(object sender, EventArgs e)
        {
            definicoes_btnReset_Click(null, null);

            dados.LoadData(table_Compras, table_Vendas, tabPage_Planos, tabPage_PlanosTlm, table_Stock);
            atualizarLabels();

            vendas_comboBoxTipos.Items.Add("Custom");
            compras_comboBoxTipos.Items.Add("Custom");

            if (dados.TiposVenda.Count > 0)
                foreach (string str in dados.TiposVenda)
                    if (str != null)
                        vendas_comboBoxTipos.Items.Add(str);

            if (dados.TiposCompra.Count > 0)
                foreach (string str in dados.TiposCompra)
                    if (str != null)
                        compras_comboBoxTipos.Items.Add(str);

            if (dados.TiposStock.Count > 0)
                foreach (string str in dados.TiposStock)
                    if (str != null)
                        stock_comboBoxMaterial.Items.Add(str);
        }
        private void ChangeTab(object sender, EventArgs e)
        {
            string tab = ((Button)sender).Tag.ToString();
            form_Tab.SelectedTab = (TabPage)form_Tab.Controls[tab];

            foreach (Control control in panel_Menu.Controls)
            {
                if (control is FontAwesome.Sharp.IconButton)
                {
                    control.BackColor = Color.White;
                }
            }

            ((Button)sender).BackColor = Color.LightGray;
        }
        #endregion

        #region Funções Ajuda
        private bool HasText(List<Control> controls)
        {
            foreach (Control control in controls)
                if (string.IsNullOrEmpty(control.Text)) return false;
            return true;
        }
        private void clearText(Control tab)
        {
            foreach (Control control in tab.Controls)
            {
                if (control is TextBox) control.Text = "";
                if (control is ComboBox) ((ComboBox)control).SelectedIndex = -1;
                if (control is CheckBox) ((CheckBox)control).Checked = false;
            }
        }
        #endregion

        #region Checkboxes
        private void check_EnvioMaterial_CheckedChanged(object sender, EventArgs e)
        {
            // esconde ou mostra caixas de texto
            vendas_txtEnvioMaterial.Visible = vendas_checkEnvioMaterial.Checked;

            //esconde ou mostra checkboxes
            vendas_checkEnvioDividido.Visible = vendas_checkEnvioMaterial.Checked;

            //limpa o texto
            vendas_txtEnvioMaterial.Text = "";
            vendas_txtEnvioDividido.Text = "";
            vendas_checkEnvioDividido.Checked = false;
        }
        private void check_EnvioDividido_CheckedChanged(object sender, EventArgs e)
        {
            vendas_txtEnvioDividido.Visible = vendas_checkEnvioDividido.Checked;
            vendas_txtEnvioDividido.Text = "";
        }
        private void compras_checkEnvioDividido_CheckedChanged(object sender, EventArgs e)
        {
            // esconde ou mostra caixas de texto
            compras_txtEnvioDividido.Visible = compras_checkEnvioDividido.Checked;

            //limpa o texto
            compras_txtEnvioDividido.Text = "";
        }
        private void stock_checkEnvioDividido_CheckedChanged(object sender, EventArgs e)
        {
            stock_txtEnvioDividido.Visible = stock_checkEnvioDividido.Checked;
            stock_txtEnvioDividido.Text = "";
        }
        #endregion

        #region Compras e Vendas
        private void vendas_btnConfirmar_Click(object sender, EventArgs e)
        {
            //Controlos que não podem ter texto vazio
            List<Control> controls = new List<Control>(){ vendas_comboBoxTipos, vendas_txtDescricao, vendas_txtPreco, vendas_txtEnvio };

            if (vendas_checkEnvioMaterial.Checked) controls.Add(vendas_txtEnvioMaterial);
            if (vendas_checkEnvioDividido.Checked) controls.Add(vendas_txtEnvioDividido);
            if (vendas_comboBoxTipos.SelectedIndex == 0) controls.Add(vendas_txtTipo);

            if (!HasText(controls))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            double preco;
            double envio;
            double custoMateriais;
            double envioMateriaisTotal = 0;
            int envioDividido = 1;

            bool formatoValido = double.TryParse(vendas_txtPreco.Text.Trim().Replace('.', ','), out preco) &
                                double.TryParse(vendas_txtEnvio.Text.Trim().Replace('.', ','), out envio) &
                                double.TryParse(vendas_txtMaterial.Text.Trim().Replace('.', ','), out custoMateriais);

            if (vendas_checkEnvioMaterial.Checked) formatoValido = formatoValido & double.TryParse(vendas_txtEnvioMaterial.Text.Trim().Replace('.', ','), out envioMateriaisTotal);
            if (vendas_checkEnvioDividido.Checked) formatoValido = formatoValido & int.TryParse(vendas_txtEnvioDividido.Text.Trim().Replace('.', ','), out envioDividido);

            if (!formatoValido)
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            String nome = (vendas_comboBoxTipos.SelectedIndex == 0)?vendas_txtTipo.Text:vendas_comboBoxTipos.Text;
            String descricao = vendas_txtDescricao.Text;
            double envioMaterial = envioMateriaisTotal / envioDividido;
            double custoMaterialTotal = custoMateriais + envioMaterial;

            ProdutoVenda venda = new ProdutoVenda(nome, descricao, preco, envio, custoMaterialTotal);
            dados.addVenda(venda, table_Vendas);
            
            if (custoMaterialTotal > 0 && !vendas_usarStock.Checked)
            {
                ProdutoCompra material = new ProdutoCompra("Materiais para " + nome, descricao, custoMateriais, envioMaterial);
                dados.addCompra(material, table_Compras);
            }
            else if(vendas_usarStock.Checked)
            {
                dados.RemoverStock(dados.FindStock(vendas_comboBoxTipos.Text));
                dados.RefreshStock(table_Stock);
            }

            atualizarLabels();
            clearText(tabPage_Vendas);

        }
        private void compras_btnConfirmar_Click(object sender, EventArgs e)
        {
            //Controlos que não podem ter texto vazio
            List<Control> controls = new List<Control>(){ compras_comboBoxTipos, compras_txtDescricao, compras_txtPreco, compras_txtEnvio };

            if (compras_checkEnvioDividido.Checked) controls.Append(compras_txtEnvioDividido);
            if (compras_comboBoxTipos.SelectedIndex == 0) controls.Add(compras_txtTipo);

            if (!HasText(controls))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            double preco;
            double envio;
            int envioDividido = 1;

            bool formatoValido = double.TryParse(compras_txtPreco.Text.Trim().Replace('.', ','), out preco) &
                                double.TryParse(compras_txtEnvio.Text.Trim().Replace('.', ','), out envio);

            if (vendas_checkEnvioDividido.Checked) formatoValido = formatoValido & int.TryParse(compras_txtEnvioDividido.Text.Trim().Replace('.', ','), out envioDividido);

            if (!formatoValido)
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            String nome = (compras_comboBoxTipos.SelectedIndex == 0) ? compras_txtTipo.Text : compras_comboBoxTipos.Text;
            String descricao = compras_txtDescricao.Text;
            double envioTotal = envio / envioDividido;

            ProdutoCompra produto = new ProdutoCompra(nome,descricao,preco,envioTotal);
            dados.addCompra(produto, table_Compras);

            atualizarLabels();
            clearText(tabPage_Compras);

            
        }
        private void atualizarLabels()
        {
            vendas_txtLucro.Text = dados.Lucro.ToString() + "€";
            compras_txtLucro.Text = dados.Lucro.ToString() + "€";
            if (dados.Lucro > 0)
            {
                vendas_txtLucro.ForeColor = Color.Green;
                compras_txtLucro.ForeColor = Color.Green;
            }
            else if (dados.Lucro < 0)
            {
                vendas_txtLucro.ForeColor = Color.Red;
                compras_txtLucro.ForeColor = Color.Red;
            }
            else
            {
                vendas_txtLucro.ForeColor = Color.Orange;
                compras_txtLucro.ForeColor = Color.Orange;
            }

            if (dados.Vendas.Count == 0) return;

            vendas_ProdutoMaisVendido.Text = "Produto Mais Vendido: " + dados.MaisVendido.Nome + " (" + dados.MaisVendido.Valor + ")";
            vendas_ProdutoMaisLucrado.Text = "Produto Mais Lucrado: " + dados.MaisLucrado.Nome + " (" + dados.MaisLucrado.Valor + "€)";

            compras_ProdutoMaisVendido.Text = "Produto Mais Vendido: " + dados.MaisVendido.Nome + " (" + dados.MaisVendido.Valor + ")";
            compras_ProdutoMaisLucrado.Text = "Produto Mais Lucrado: " + dados.MaisLucrado.Nome + " (" + dados.MaisLucrado.Valor + "€)";
        }
        private void vendas_comboBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string tag = comboBox.Tag.ToString();
            TextBox textBox = null;
            switch (tag)
            {
                case "vendas_txtTipo":
                    textBox = (TextBox)tabPage_Vendas.Controls[tag];
                    break;

                case "compras_txtTipo":
                    textBox = (TextBox)tabPage_Compras.Controls[tag];
                    break;
            }

            textBox.Text = "";
            bool custom = (comboBox.SelectedIndex == 0);
            comboBox.Width = (custom) ? 230 : 404;
            textBox.Visible = custom;
        }
        private void vendas_usarStock_CheckedChanged(object sender, EventArgs e)
        {
            vendas_txtMaterial.ReadOnly = vendas_usarStock.Checked;
            vendas_checkEnvioMaterial.Visible = !vendas_usarStock.Checked;
            vendas_checkEnvioMaterial.Checked = false;
            vendas_txtMaterial.Text = "";
            vendas_quantidadeStock.Text = "";

            ProdutoStock stock = dados.FindStock(vendas_comboBoxTipos.Text);

            if (stock == null && vendas_usarStock.Checked)
            {
                vendas_usarStock.Checked = false;
                MessageBox.Show("Não existe stock para o produto selecionado");
                return;
            }
            else if (!vendas_usarStock.Checked)
            {
                return;
            }

            vendas_txtMaterial.Text = stock.PrecoUnidade.ToString();
            vendas_quantidadeStock.Text = "Faltam " + stock.Quantidade + " unidades.";
        }
        #endregion

        #region Planos e PlanosTlm
        private void moverItemListboxPlanos(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = null;

            List<ListBox> listBoxes = new List<ListBox>();

            foreach(Control control in tabPage_Planos.Controls)
            {
                if (control is ListBox) listBoxes.Add((ListBox)control);
            }

            ListBox source = null;
            ListBox destiny;

            int nextListbox = int.Parse(((Control)sender).Tag.ToString());

            int numeroListbox = 0;

            foreach (ListBox listBox in listBoxes)
            {
                if(listBox.SelectedItem != null)
                {
                    source = listBox;
                    sourceItems = listBox.SelectedItems;
                    numeroListbox = int.Parse(listBox.Name.ToString()[12].ToString()) + nextListbox;
                }
            }

            destiny = (ListBox)tabPage_Planos.Controls["planos_Lista" + numeroListbox.ToString()];

            if (sourceItems == null) return;
            if (numeroListbox < 1 || numeroListbox > listBoxes.Count) return;

            foreach (var item in sourceItems)
            {
                destiny.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }
        private void moverItemListboxPlanosTlm(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection sourceItems = null;

            List<ListBox> listBoxes = new List<ListBox>();

            foreach (Control control in tabPage_PlanosTlm.Controls)
            {
                if (control is ListBox) listBoxes.Add((ListBox)control);
            }

            ListBox source = null;
            ListBox destiny;

            int nextListbox = int.Parse(((Control)sender).Tag.ToString());

            int numeroListbox = 0;

            foreach (ListBox listBox in listBoxes)
            {
                if (listBox.SelectedItem != null)
                {
                    source = listBox;
                    sourceItems = listBox.SelectedItems;
                    numeroListbox = int.Parse(listBox.Name.ToString()[15].ToString()) + nextListbox;
                }
            }

            destiny = (ListBox)tabPage_PlanosTlm.Controls["planosTlm_Lista" + numeroListbox.ToString()];

            if (sourceItems == null) return;
            if (numeroListbox < 1 || numeroListbox > listBoxes.Count) return;

            foreach (var item in sourceItems)
            {
                destiny.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }
        private void clearSelectedItem(object sender, EventArgs e)
        {
            ((ListBox)sender).Tag = "Selecionado";

            ListBox[] listBoxes = { planos_Lista1, planos_Lista2, planos_Lista3 };

            foreach (ListBox listBox in listBoxes)
            {
                if (listBox.Tag is null) {
                    listBox.ClearSelected();
                }
            }

            ((ListBox)sender).Tag = null;
        }
        private void planos_btnAdd_Click(object sender, EventArgs e)
        {
            if (!HasText(new List<Control>() { planos_txtNovoPlano })) return;
            planos_Lista1.Items.Add(planos_txtNovoPlano.Text);
            planos_txtNovoPlano.Clear();
        }

        private void planosTlm_btnAdd_Click(object sender, EventArgs e)
        {
            if (!HasText(new List<Control>() { planosTlm_txtNovoPlano })) return;
            planosTlm_Lista1.Items.Add(planosTlm_txtNovoPlano.Text);
            planosTlm_txtNovoPlano.Clear();
        }
        private void planos_btnApagar_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage_Planos.Controls)
            {
                if (control.Name.StartsWith("planos_Lista"))
                {
                    ((ListBox)control).Items.Remove(((ListBox)control).SelectedItem);
                }
            }
        }
        private void planosTlm_btnApagar_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage_PlanosTlm.Controls)
            {
                if (control.Name.StartsWith("planosTlm_Lista"))
                {
                    ((ListBox)control).Items.Remove(((ListBox)control).SelectedItem);
                }
            }
        }

        #endregion

        #region Stock
        private void stock_btnConfirmar_Click(object sender, EventArgs e)
		{
            //Controlos que não podem ter texto vazio
            List<Control> controls = new List<Control>() { stock_comboBoxMaterial, stock_txtQuantidade, stock_txtPreco, stock_txtEnvio };

            if (stock_checkEnvioDividido.Checked) controls.Append(stock_txtEnvioDividido);

            if (!HasText(controls))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            double preco;
            double envio;
            int quantidade;
            int envioDividido = 1;

            bool formatoValido = double.TryParse(stock_txtPreco.Text.Trim().Replace('.', ','), out preco) &
                                double.TryParse(stock_txtEnvio.Text.Trim().Replace('.', ','), out envio) &
                                int.TryParse(stock_txtQuantidade.Text, out quantidade);

            if (stock_checkEnvioDividido.Checked) formatoValido = formatoValido & int.TryParse(stock_txtEnvioDividido.Text, out envioDividido);

            if (!formatoValido)
            {
                MessageBox.Show("Preencha os campos corretamente!");
                return;
            }

            String nome = stock_comboBoxMaterial.Text;
            double envioTotal = envio / envioDividido;

            ProdutoStock produto = new ProdutoStock(nome, "stock", preco, envioTotal, quantidade);
            dados.addStock(produto, table_Stock);

            clearText(tabPage_Stock);

            atualizarLabels();
        }
        #endregion

        #region Definições
        private void definicoes_btnReset_Click(object sender, EventArgs e)
        {
            definicoes_Vendas.Items.Clear();
            foreach(string str in dados.TiposVenda)
                if(str != null)
                    definicoes_Vendas.Items.Add(str);

            definicoes_Compras.Items.Clear();
            foreach (string str in dados.TiposCompra)
                if (str != null)
                    definicoes_Compras.Items.Add(str);

            definicoes_Stock.Items.Clear();
            foreach (string str in dados.TiposStock)
                if (str != null)
                    definicoes_Stock.Items.Add(str);
        }

        private void definicoes_btnGuardar_Click(object sender, EventArgs e)
        {
            List<string> vendas = new List<string>();
            foreach (string str in definicoes_Vendas.Items)
                vendas.Add(str);
            dados.SetTipo(vendas, "/TiposVenda");

            List<string> compras = new List<string>();
            foreach (string str in definicoes_Compras.Items)
                compras.Add(str);
            dados.SetTipo(compras, "/TiposCompra");

            List<string> stock = new List<string>();
            foreach (string str in definicoes_Stock.Items)
                stock.Add(str);
            dados.SetTipo(stock, "/TiposStock");

            MessageBox.Show("Definições guardadas com sucesso!");

            vendas_comboBoxTipos.Items.Clear();
            vendas_comboBoxTipos.Items.Add("Custom");
            if (dados.TiposVenda.Count > 0)
                vendas_comboBoxTipos.Items.AddRange(dados.TiposVenda.ToArray());

            compras_comboBoxTipos.Items.Clear();
            compras_comboBoxTipos.Items.Add("Custom");
            if (dados.TiposCompra.Count > 0)
                compras_comboBoxTipos.Items.AddRange(dados.TiposCompra.ToArray());

            stock_comboBoxMaterial.Items.Clear();
            if (dados.TiposStock.Count > 0)
                stock_comboBoxMaterial.Items.AddRange(dados.TiposStock.ToArray());
        }

        private void definicoes_addButton_Click(object sender, EventArgs e)
        {
            string source = ((Button)sender).Tag.ToString();
            string target = tabPage_Definicoes.Controls[source].Tag.ToString();

            TextBox textBox = (TextBox)tabPage_Definicoes.Controls[source];
            ListBox listBox = (ListBox)tabPage_Definicoes.Controls[target];

            if (!HasText(new List<Control>() { textBox })) return;

            listBox.Items.Add(textBox.Text);
            textBox.Text = "";
        }

        private void definicoes_removeButton_Click(object sender, EventArgs e)
        {
            string target = ((Button)sender).Tag.ToString();

            ListBox listBox = (ListBox)tabPage_Definicoes.Controls[target];

            ((ListBox)listBox).Items.Remove(((ListBox)listBox).SelectedItem);
        }
        #endregion        
    }
}