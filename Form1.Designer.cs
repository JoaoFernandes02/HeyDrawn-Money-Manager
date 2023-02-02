namespace HeyDrawn_Money_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage_Stock = new System.Windows.Forms.TabPage();
            this.stock_txtEnvioDividido = new System.Windows.Forms.TextBox();
            this.stock_checkEnvioDividido = new System.Windows.Forms.CheckBox();
            this.stock_btnConfirmar = new System.Windows.Forms.Button();
            this.stock_txtEnvio = new System.Windows.Forms.TextBox();
            this.stock_txtQuantidade = new System.Windows.Forms.TextBox();
            this.stock_txtPreco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stock_comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.table_Stock = new System.Windows.Forms.DataGridView();
            this.stock_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_PlanosTlm = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.planosTlm_btnApagar = new System.Windows.Forms.Button();
            this.planosTlm_btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.planosTlm_txtNovoPlano = new System.Windows.Forms.TextBox();
            this.planosTlm_btnNext = new System.Windows.Forms.Button();
            this.planosTlm_btnPrevious = new System.Windows.Forms.Button();
            this.planosTlm_ListaEnviados = new System.Windows.Forms.ListBox();
            this.planosTlm_ListaPronto = new System.Windows.Forms.ListBox();
            this.planosTlm_ListaAtivo = new System.Windows.Forms.ListBox();
            this.planosTlm_ListaPendente = new System.Windows.Forms.ListBox();
            this.tabPage_Planos = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.planos_btnApagar = new System.Windows.Forms.Button();
            this.planos_btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.planos_txtNovoPlano = new System.Windows.Forms.TextBox();
            this.planos_ListaEnviados = new System.Windows.Forms.ListBox();
            this.planos_btnNext = new System.Windows.Forms.Button();
            this.planos_btnPrevious = new System.Windows.Forms.Button();
            this.planos_ListaPronto = new System.Windows.Forms.ListBox();
            this.planos_ListaAtivo = new System.Windows.Forms.ListBox();
            this.planos_ListaPendente = new System.Windows.Forms.ListBox();
            this.tabPage_Compras = new System.Windows.Forms.TabPage();
            this.compras_txtEnvioDividido = new System.Windows.Forms.NumericUpDown();
            this.compras_txtEnvio = new System.Windows.Forms.NumericUpDown();
            this.compras_txtPreco = new System.Windows.Forms.NumericUpDown();
            this.compras_txtTipo = new System.Windows.Forms.TextBox();
            this.compras_ProdutoMaisLucrado = new System.Windows.Forms.Label();
            this.compras_ProdutoMaisVendido = new System.Windows.Forms.Label();
            this.compras_txtLucro = new System.Windows.Forms.Label();
            this.compras_lblLucro = new System.Windows.Forms.Label();
            this.compras_btnConfirmar = new System.Windows.Forms.Button();
            this.compras_txtDescricao = new System.Windows.Forms.TextBox();
            this.compras_lblTipo = new System.Windows.Forms.Label();
            this.compras_checkEnvioDividido = new System.Windows.Forms.CheckBox();
            this.compras_lblDescricao = new System.Windows.Forms.Label();
            this.compras_lblPreco = new System.Windows.Forms.Label();
            this.compras_comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.compras_lblEnvio = new System.Windows.Forms.Label();
            this.table_Compras = new System.Windows.Forms.DataGridView();
            this.compras_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compras_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compras_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compras_Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compras_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Vendas = new System.Windows.Forms.TabPage();
            this.vendas_txtEnvioDividido = new System.Windows.Forms.NumericUpDown();
            this.vendas_txtEnvioMaterial = new System.Windows.Forms.NumericUpDown();
            this.vendas_txtMaterial = new System.Windows.Forms.NumericUpDown();
            this.vendas_txtEnvio = new System.Windows.Forms.NumericUpDown();
            this.vendas_txtPreco = new System.Windows.Forms.NumericUpDown();
            this.vendas_txtTipo = new System.Windows.Forms.TextBox();
            this.vendas_quantidadeStock = new System.Windows.Forms.Label();
            this.vendas_usarStock = new System.Windows.Forms.CheckBox();
            this.vendas_ProdutoMaisLucrado = new System.Windows.Forms.Label();
            this.vendas_ProdutoMaisVendido = new System.Windows.Forms.Label();
            this.vendas_txtLucro = new System.Windows.Forms.Label();
            this.vendas_btnConfirmar = new System.Windows.Forms.Button();
            this.vendas_lblLucro = new System.Windows.Forms.Label();
            this.table_Vendas = new System.Windows.Forms.DataGridView();
            this.vendas_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_Lucro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendas_txtDescricao = new System.Windows.Forms.TextBox();
            this.vendas_lblTipo = new System.Windows.Forms.Label();
            this.vendas_checkEnvioDividido = new System.Windows.Forms.CheckBox();
            this.vendas_lblDescricao = new System.Windows.Forms.Label();
            this.vendas_lblPreco = new System.Windows.Forms.Label();
            this.vendas_checkEnvioMaterial = new System.Windows.Forms.CheckBox();
            this.vendas_comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.vendas_lblEnvio = new System.Windows.Forms.Label();
            this.vendas_lblMateriais = new System.Windows.Forms.Label();
            this.form_Tab = new System.Windows.Forms.TabControl();
            this.tabPage_Definicoes = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.definicoes_txtStock = new System.Windows.Forms.TextBox();
            this.definicoes_txtCompras = new System.Windows.Forms.TextBox();
            this.definicoes_txtVendas = new System.Windows.Forms.TextBox();
            this.definicoes_Stock = new System.Windows.Forms.ListBox();
            this.definicoes_Compras = new System.Windows.Forms.ListBox();
            this.definicoes_Vendas = new System.Windows.Forms.ListBox();
            this.definicoes_btnReset = new System.Windows.Forms.Button();
            this.definicoes_btnGuardar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage_ToDoList = new System.Windows.Forms.TabPage();
            this.apontamentos_guardar = new System.Windows.Forms.Button();
            this.apontamentos_Text = new System.Windows.Forms.TextBox();
            this.panel_Barra = new System.Windows.Forms.Panel();
            this.label_Logo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.iconButton_Minimizar = new FontAwesome.Sharp.IconButton();
            this.iconButton_Fechar = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Menu = new System.Windows.Forms.Label();
            this.tabPage_Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Stock)).BeginInit();
            this.tabPage_PlanosTlm.SuspendLayout();
            this.tabPage_Planos.SuspendLayout();
            this.tabPage_Compras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compras_txtEnvioDividido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compras_txtEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compras_txtPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Compras)).BeginInit();
            this.tabPage_Vendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtEnvioDividido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtEnvioMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Vendas)).BeginInit();
            this.form_Tab.SuspendLayout();
            this.tabPage_Definicoes.SuspendLayout();
            this.tabPage_ToDoList.SuspendLayout();
            this.panel_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_Stock
            // 
            this.tabPage_Stock.Controls.Add(this.stock_txtEnvioDividido);
            this.tabPage_Stock.Controls.Add(this.stock_checkEnvioDividido);
            this.tabPage_Stock.Controls.Add(this.stock_btnConfirmar);
            this.tabPage_Stock.Controls.Add(this.stock_txtEnvio);
            this.tabPage_Stock.Controls.Add(this.stock_txtQuantidade);
            this.tabPage_Stock.Controls.Add(this.stock_txtPreco);
            this.tabPage_Stock.Controls.Add(this.label11);
            this.tabPage_Stock.Controls.Add(this.label12);
            this.tabPage_Stock.Controls.Add(this.label13);
            this.tabPage_Stock.Controls.Add(this.stock_comboBoxMaterial);
            this.tabPage_Stock.Controls.Add(this.label14);
            this.tabPage_Stock.Controls.Add(this.table_Stock);
            this.tabPage_Stock.Location = new System.Drawing.Point(4, 5);
            this.tabPage_Stock.Name = "tabPage_Stock";
            this.tabPage_Stock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Stock.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_Stock.TabIndex = 4;
            this.tabPage_Stock.UseVisualStyleBackColor = true;
            // 
            // stock_txtEnvioDividido
            // 
            this.stock_txtEnvioDividido.Location = new System.Drawing.Point(152, 260);
            this.stock_txtEnvioDividido.Name = "stock_txtEnvioDividido";
            this.stock_txtEnvioDividido.Size = new System.Drawing.Size(94, 22);
            this.stock_txtEnvioDividido.TabIndex = 52;
            this.stock_txtEnvioDividido.Visible = false;
            // 
            // stock_checkEnvioDividido
            // 
            this.stock_checkEnvioDividido.AutoSize = true;
            this.stock_checkEnvioDividido.Location = new System.Drawing.Point(42, 265);
            this.stock_checkEnvioDividido.Name = "stock_checkEnvioDividido";
            this.stock_checkEnvioDividido.Size = new System.Drawing.Size(104, 17);
            this.stock_checkEnvioDividido.TabIndex = 51;
            this.stock_checkEnvioDividido.Text = "Envio dividido?";
            this.stock_checkEnvioDividido.UseVisualStyleBackColor = true;
            this.stock_checkEnvioDividido.CheckedChanged += new System.EventHandler(this.stock_checkEnvioDividido_CheckedChanged);
            // 
            // stock_btnConfirmar
            // 
            this.stock_btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stock_btnConfirmar.Location = new System.Drawing.Point(184, 302);
            this.stock_btnConfirmar.Name = "stock_btnConfirmar";
            this.stock_btnConfirmar.Size = new System.Drawing.Size(196, 39);
            this.stock_btnConfirmar.TabIndex = 50;
            this.stock_btnConfirmar.Text = "Adicionar ao Stock";
            this.stock_btnConfirmar.UseVisualStyleBackColor = true;
            this.stock_btnConfirmar.Click += new System.EventHandler(this.stock_btnConfirmar_Click);
            // 
            // stock_txtEnvio
            // 
            this.stock_txtEnvio.Location = new System.Drawing.Point(158, 230);
            this.stock_txtEnvio.Name = "stock_txtEnvio";
            this.stock_txtEnvio.Size = new System.Drawing.Size(364, 22);
            this.stock_txtEnvio.TabIndex = 47;
            // 
            // stock_txtQuantidade
            // 
            this.stock_txtQuantidade.Location = new System.Drawing.Point(158, 162);
            this.stock_txtQuantidade.Name = "stock_txtQuantidade";
            this.stock_txtQuantidade.Size = new System.Drawing.Size(364, 22);
            this.stock_txtQuantidade.TabIndex = 44;
            // 
            // stock_txtPreco
            // 
            this.stock_txtPreco.Location = new System.Drawing.Point(158, 197);
            this.stock_txtPreco.Name = "stock_txtPreco";
            this.stock_txtPreco.Size = new System.Drawing.Size(364, 22);
            this.stock_txtPreco.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Material:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Quantidade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(37, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 42;
            this.label13.Text = "Preço:";
            // 
            // stock_comboBoxMaterial
            // 
            this.stock_comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stock_comboBoxMaterial.FormattingEnabled = true;
            this.stock_comboBoxMaterial.Location = new System.Drawing.Point(158, 124);
            this.stock_comboBoxMaterial.Name = "stock_comboBoxMaterial";
            this.stock_comboBoxMaterial.Size = new System.Drawing.Size(364, 21);
            this.stock_comboBoxMaterial.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 25);
            this.label14.TabIndex = 46;
            this.label14.Text = "Envio:";
            // 
            // table_Stock
            // 
            this.table_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock_ID,
            this.stock_Material,
            this.stock_Quantidade,
            this.stock_Preco,
            this.stock_Data});
            this.table_Stock.Location = new System.Drawing.Point(557, 0);
            this.table_Stock.Name = "table_Stock";
            this.table_Stock.Size = new System.Drawing.Size(514, 529);
            this.table_Stock.TabIndex = 1;
            // 
            // stock_ID
            // 
            this.stock_ID.HeaderText = "ID";
            this.stock_ID.Name = "stock_ID";
            this.stock_ID.ReadOnly = true;
            // 
            // stock_Material
            // 
            this.stock_Material.HeaderText = "Material";
            this.stock_Material.Name = "stock_Material";
            this.stock_Material.ReadOnly = true;
            this.stock_Material.Width = 90;
            // 
            // stock_Quantidade
            // 
            this.stock_Quantidade.HeaderText = "Quantidade";
            this.stock_Quantidade.Name = "stock_Quantidade";
            this.stock_Quantidade.ReadOnly = true;
            this.stock_Quantidade.Width = 90;
            // 
            // stock_Preco
            // 
            this.stock_Preco.HeaderText = "Preço por Unidade";
            this.stock_Preco.Name = "stock_Preco";
            this.stock_Preco.ReadOnly = true;
            this.stock_Preco.Width = 90;
            // 
            // stock_Data
            // 
            this.stock_Data.HeaderText = "Data";
            this.stock_Data.Name = "stock_Data";
            this.stock_Data.ReadOnly = true;
            // 
            // tabPage_PlanosTlm
            // 
            this.tabPage_PlanosTlm.Controls.Add(this.label7);
            this.tabPage_PlanosTlm.Controls.Add(this.label8);
            this.tabPage_PlanosTlm.Controls.Add(this.label9);
            this.tabPage_PlanosTlm.Controls.Add(this.label10);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_btnApagar);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_btnAdd);
            this.tabPage_PlanosTlm.Controls.Add(this.label2);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_txtNovoPlano);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_btnNext);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_btnPrevious);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_ListaEnviados);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_ListaPronto);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_ListaAtivo);
            this.tabPage_PlanosTlm.Controls.Add(this.planosTlm_ListaPendente);
            this.tabPage_PlanosTlm.Location = new System.Drawing.Point(4, 5);
            this.tabPage_PlanosTlm.Name = "tabPage_PlanosTlm";
            this.tabPage_PlanosTlm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PlanosTlm.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_PlanosTlm.TabIndex = 3;
            this.tabPage_PlanosTlm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(822, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Enviados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(605, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pronto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 30);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ativo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pendente";
            // 
            // planosTlm_btnApagar
            // 
            this.planosTlm_btnApagar.Location = new System.Drawing.Point(974, 468);
            this.planosTlm_btnApagar.Name = "planosTlm_btnApagar";
            this.planosTlm_btnApagar.Size = new System.Drawing.Size(75, 23);
            this.planosTlm_btnApagar.TabIndex = 17;
            this.planosTlm_btnApagar.Text = "Apagar";
            this.planosTlm_btnApagar.UseVisualStyleBackColor = true;
            this.planosTlm_btnApagar.Click += new System.EventHandler(this.planosTlm_btnApagar_Click);
            // 
            // planosTlm_btnAdd
            // 
            this.planosTlm_btnAdd.Location = new System.Drawing.Point(211, 468);
            this.planosTlm_btnAdd.Name = "planosTlm_btnAdd";
            this.planosTlm_btnAdd.Size = new System.Drawing.Size(23, 23);
            this.planosTlm_btnAdd.TabIndex = 16;
            this.planosTlm_btnAdd.Tag = "-1";
            this.planosTlm_btnAdd.Text = "+";
            this.planosTlm_btnAdd.UseVisualStyleBackColor = true;
            this.planosTlm_btnAdd.Click += new System.EventHandler(this.planosTlm_btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Novo plano:";
            // 
            // planosTlm_txtNovoPlano
            // 
            this.planosTlm_txtNovoPlano.Location = new System.Drawing.Point(16, 468);
            this.planosTlm_txtNovoPlano.Name = "planosTlm_txtNovoPlano";
            this.planosTlm_txtNovoPlano.Size = new System.Drawing.Size(189, 22);
            this.planosTlm_txtNovoPlano.TabIndex = 14;
            // 
            // planosTlm_btnNext
            // 
            this.planosTlm_btnNext.Location = new System.Drawing.Point(552, 468);
            this.planosTlm_btnNext.Name = "planosTlm_btnNext";
            this.planosTlm_btnNext.Size = new System.Drawing.Size(75, 23);
            this.planosTlm_btnNext.TabIndex = 13;
            this.planosTlm_btnNext.Tag = "1";
            this.planosTlm_btnNext.Text = "->";
            this.planosTlm_btnNext.UseVisualStyleBackColor = true;
            this.planosTlm_btnNext.Click += new System.EventHandler(this.planosTlm_btnMover_Click);
            // 
            // planosTlm_btnPrevious
            // 
            this.planosTlm_btnPrevious.Location = new System.Drawing.Point(438, 468);
            this.planosTlm_btnPrevious.Name = "planosTlm_btnPrevious";
            this.planosTlm_btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.planosTlm_btnPrevious.TabIndex = 12;
            this.planosTlm_btnPrevious.Tag = "-1";
            this.planosTlm_btnPrevious.Text = "<-";
            this.planosTlm_btnPrevious.UseVisualStyleBackColor = true;
            this.planosTlm_btnPrevious.Click += new System.EventHandler(this.planosTlm_btnMover_Click);
            // 
            // planosTlm_ListaEnviados
            // 
            this.planosTlm_ListaEnviados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planosTlm_ListaEnviados.FormattingEnabled = true;
            this.planosTlm_ListaEnviados.HorizontalScrollbar = true;
            this.planosTlm_ListaEnviados.ItemHeight = 21;
            this.planosTlm_ListaEnviados.Location = new System.Drawing.Point(778, 52);
            this.planosTlm_ListaEnviados.Name = "planosTlm_ListaEnviados";
            this.planosTlm_ListaEnviados.Size = new System.Drawing.Size(189, 382);
            this.planosTlm_ListaEnviados.TabIndex = 10;
            this.planosTlm_ListaEnviados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // planosTlm_ListaPronto
            // 
            this.planosTlm_ListaPronto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planosTlm_ListaPronto.FormattingEnabled = true;
            this.planosTlm_ListaPronto.HorizontalScrollbar = true;
            this.planosTlm_ListaPronto.ItemHeight = 21;
            this.planosTlm_ListaPronto.Location = new System.Drawing.Point(551, 52);
            this.planosTlm_ListaPronto.Name = "planosTlm_ListaPronto";
            this.planosTlm_ListaPronto.Size = new System.Drawing.Size(189, 382);
            this.planosTlm_ListaPronto.TabIndex = 9;
            this.planosTlm_ListaPronto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // planosTlm_ListaAtivo
            // 
            this.planosTlm_ListaAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planosTlm_ListaAtivo.FormattingEnabled = true;
            this.planosTlm_ListaAtivo.HorizontalScrollbar = true;
            this.planosTlm_ListaAtivo.ItemHeight = 21;
            this.planosTlm_ListaAtivo.Location = new System.Drawing.Point(324, 52);
            this.planosTlm_ListaAtivo.Name = "planosTlm_ListaAtivo";
            this.planosTlm_ListaAtivo.Size = new System.Drawing.Size(189, 382);
            this.planosTlm_ListaAtivo.TabIndex = 8;
            this.planosTlm_ListaAtivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // planosTlm_ListaPendente
            // 
            this.planosTlm_ListaPendente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planosTlm_ListaPendente.FormattingEnabled = true;
            this.planosTlm_ListaPendente.HorizontalScrollbar = true;
            this.planosTlm_ListaPendente.ItemHeight = 21;
            this.planosTlm_ListaPendente.Location = new System.Drawing.Point(97, 52);
            this.planosTlm_ListaPendente.Name = "planosTlm_ListaPendente";
            this.planosTlm_ListaPendente.Size = new System.Drawing.Size(189, 382);
            this.planosTlm_ListaPendente.TabIndex = 7;
            this.planosTlm_ListaPendente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // tabPage_Planos
            // 
            this.tabPage_Planos.Controls.Add(this.label6);
            this.tabPage_Planos.Controls.Add(this.label5);
            this.tabPage_Planos.Controls.Add(this.label4);
            this.tabPage_Planos.Controls.Add(this.label3);
            this.tabPage_Planos.Controls.Add(this.planos_btnApagar);
            this.tabPage_Planos.Controls.Add(this.planos_btnAdd);
            this.tabPage_Planos.Controls.Add(this.label1);
            this.tabPage_Planos.Controls.Add(this.planos_txtNovoPlano);
            this.tabPage_Planos.Controls.Add(this.planos_ListaEnviados);
            this.tabPage_Planos.Controls.Add(this.planos_btnNext);
            this.tabPage_Planos.Controls.Add(this.planos_btnPrevious);
            this.tabPage_Planos.Controls.Add(this.planos_ListaPronto);
            this.tabPage_Planos.Controls.Add(this.planos_ListaAtivo);
            this.tabPage_Planos.Controls.Add(this.planos_ListaPendente);
            this.tabPage_Planos.Location = new System.Drawing.Point(4, 5);
            this.tabPage_Planos.Name = "tabPage_Planos";
            this.tabPage_Planos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Planos.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_Planos.TabIndex = 2;
            this.tabPage_Planos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enviados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pronto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ativo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pendente";
            // 
            // planos_btnApagar
            // 
            this.planos_btnApagar.Location = new System.Drawing.Point(974, 468);
            this.planos_btnApagar.Name = "planos_btnApagar";
            this.planos_btnApagar.Size = new System.Drawing.Size(75, 23);
            this.planos_btnApagar.TabIndex = 10;
            this.planos_btnApagar.Text = "Apagar";
            this.planos_btnApagar.UseVisualStyleBackColor = true;
            this.planos_btnApagar.Click += new System.EventHandler(this.planos_btnApagar_Click);
            // 
            // planos_btnAdd
            // 
            this.planos_btnAdd.Location = new System.Drawing.Point(211, 468);
            this.planos_btnAdd.Name = "planos_btnAdd";
            this.planos_btnAdd.Size = new System.Drawing.Size(23, 23);
            this.planos_btnAdd.TabIndex = 9;
            this.planos_btnAdd.Tag = "-1";
            this.planos_btnAdd.Text = "+";
            this.planos_btnAdd.UseVisualStyleBackColor = true;
            this.planos_btnAdd.Click += new System.EventHandler(this.planos_btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Novo plano:";
            // 
            // planos_txtNovoPlano
            // 
            this.planos_txtNovoPlano.Location = new System.Drawing.Point(16, 468);
            this.planos_txtNovoPlano.Name = "planos_txtNovoPlano";
            this.planos_txtNovoPlano.Size = new System.Drawing.Size(189, 22);
            this.planos_txtNovoPlano.TabIndex = 7;
            // 
            // planos_ListaEnviados
            // 
            this.planos_ListaEnviados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planos_ListaEnviados.FormattingEnabled = true;
            this.planos_ListaEnviados.HorizontalScrollbar = true;
            this.planos_ListaEnviados.ItemHeight = 21;
            this.planos_ListaEnviados.Location = new System.Drawing.Point(778, 52);
            this.planos_ListaEnviados.Name = "planos_ListaEnviados";
            this.planos_ListaEnviados.Size = new System.Drawing.Size(189, 382);
            this.planos_ListaEnviados.TabIndex = 5;
            this.planos_ListaEnviados.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // planos_btnNext
            // 
            this.planos_btnNext.Location = new System.Drawing.Point(552, 468);
            this.planos_btnNext.Name = "planos_btnNext";
            this.planos_btnNext.Size = new System.Drawing.Size(75, 23);
            this.planos_btnNext.TabIndex = 4;
            this.planos_btnNext.Tag = "+1";
            this.planos_btnNext.Text = "->";
            this.planos_btnNext.UseVisualStyleBackColor = true;
            this.planos_btnNext.Click += new System.EventHandler(this.planos_btnMover_Click);
            // 
            // planos_btnPrevious
            // 
            this.planos_btnPrevious.Location = new System.Drawing.Point(438, 468);
            this.planos_btnPrevious.Name = "planos_btnPrevious";
            this.planos_btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.planos_btnPrevious.TabIndex = 3;
            this.planos_btnPrevious.Tag = "-1";
            this.planos_btnPrevious.Text = "<-";
            this.planos_btnPrevious.UseVisualStyleBackColor = true;
            this.planos_btnPrevious.Click += new System.EventHandler(this.planos_btnMover_Click);
            // 
            // planos_ListaPronto
            // 
            this.planos_ListaPronto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planos_ListaPronto.FormattingEnabled = true;
            this.planos_ListaPronto.HorizontalScrollbar = true;
            this.planos_ListaPronto.ItemHeight = 21;
            this.planos_ListaPronto.Location = new System.Drawing.Point(551, 52);
            this.planos_ListaPronto.Name = "planos_ListaPronto";
            this.planos_ListaPronto.Size = new System.Drawing.Size(189, 382);
            this.planos_ListaPronto.TabIndex = 2;
            this.planos_ListaPronto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // planos_ListaAtivo
            // 
            this.planos_ListaAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planos_ListaAtivo.FormattingEnabled = true;
            this.planos_ListaAtivo.HorizontalScrollbar = true;
            this.planos_ListaAtivo.ItemHeight = 21;
            this.planos_ListaAtivo.Location = new System.Drawing.Point(324, 52);
            this.planos_ListaAtivo.Name = "planos_ListaAtivo";
            this.planos_ListaAtivo.Size = new System.Drawing.Size(189, 382);
            this.planos_ListaAtivo.TabIndex = 1;
            this.planos_ListaAtivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // planos_ListaPendente
            // 
            this.planos_ListaPendente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planos_ListaPendente.FormattingEnabled = true;
            this.planos_ListaPendente.HorizontalScrollbar = true;
            this.planos_ListaPendente.ItemHeight = 21;
            this.planos_ListaPendente.Location = new System.Drawing.Point(97, 52);
            this.planos_ListaPendente.Name = "planos_ListaPendente";
            this.planos_ListaPendente.Size = new System.Drawing.Size(189, 382);
            this.planos_ListaPendente.TabIndex = 0;
            this.planos_ListaPendente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.planosItemClick_MouseClick);
            // 
            // tabPage_Compras
            // 
            this.tabPage_Compras.Controls.Add(this.compras_txtEnvioDividido);
            this.tabPage_Compras.Controls.Add(this.compras_txtEnvio);
            this.tabPage_Compras.Controls.Add(this.compras_txtPreco);
            this.tabPage_Compras.Controls.Add(this.compras_txtTipo);
            this.tabPage_Compras.Controls.Add(this.compras_ProdutoMaisLucrado);
            this.tabPage_Compras.Controls.Add(this.compras_ProdutoMaisVendido);
            this.tabPage_Compras.Controls.Add(this.compras_txtLucro);
            this.tabPage_Compras.Controls.Add(this.compras_lblLucro);
            this.tabPage_Compras.Controls.Add(this.compras_btnConfirmar);
            this.tabPage_Compras.Controls.Add(this.compras_txtDescricao);
            this.tabPage_Compras.Controls.Add(this.compras_lblTipo);
            this.tabPage_Compras.Controls.Add(this.compras_checkEnvioDividido);
            this.tabPage_Compras.Controls.Add(this.compras_lblDescricao);
            this.tabPage_Compras.Controls.Add(this.compras_lblPreco);
            this.tabPage_Compras.Controls.Add(this.compras_comboBoxTipos);
            this.tabPage_Compras.Controls.Add(this.compras_lblEnvio);
            this.tabPage_Compras.Controls.Add(this.table_Compras);
            this.tabPage_Compras.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Compras.Location = new System.Drawing.Point(4, 5);
            this.tabPage_Compras.Name = "tabPage_Compras";
            this.tabPage_Compras.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Compras.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_Compras.TabIndex = 1;
            this.tabPage_Compras.UseVisualStyleBackColor = true;
            // 
            // compras_txtEnvioDividido
            // 
            this.compras_txtEnvioDividido.DecimalPlaces = 2;
            this.compras_txtEnvioDividido.Location = new System.Drawing.Point(141, 167);
            this.compras_txtEnvioDividido.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.compras_txtEnvioDividido.Name = "compras_txtEnvioDividido";
            this.compras_txtEnvioDividido.Size = new System.Drawing.Size(94, 22);
            this.compras_txtEnvioDividido.TabIndex = 47;
            this.compras_txtEnvioDividido.Visible = false;
            // 
            // compras_txtEnvio
            // 
            this.compras_txtEnvio.DecimalPlaces = 2;
            this.compras_txtEnvio.Location = new System.Drawing.Point(141, 136);
            this.compras_txtEnvio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.compras_txtEnvio.Name = "compras_txtEnvio";
            this.compras_txtEnvio.Size = new System.Drawing.Size(404, 22);
            this.compras_txtEnvio.TabIndex = 46;
            // 
            // compras_txtPreco
            // 
            this.compras_txtPreco.DecimalPlaces = 2;
            this.compras_txtPreco.Location = new System.Drawing.Point(141, 102);
            this.compras_txtPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.compras_txtPreco.Name = "compras_txtPreco";
            this.compras_txtPreco.Size = new System.Drawing.Size(404, 22);
            this.compras_txtPreco.TabIndex = 45;
            // 
            // compras_txtTipo
            // 
            this.compras_txtTipo.Location = new System.Drawing.Point(349, 31);
            this.compras_txtTipo.Name = "compras_txtTipo";
            this.compras_txtTipo.Size = new System.Drawing.Size(196, 22);
            this.compras_txtTipo.TabIndex = 44;
            this.compras_txtTipo.Visible = false;
            // 
            // compras_ProdutoMaisLucrado
            // 
            this.compras_ProdutoMaisLucrado.AutoSize = true;
            this.compras_ProdutoMaisLucrado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_ProdutoMaisLucrado.Location = new System.Drawing.Point(594, 89);
            this.compras_ProdutoMaisLucrado.Name = "compras_ProdutoMaisLucrado";
            this.compras_ProdutoMaisLucrado.Size = new System.Drawing.Size(216, 25);
            this.compras_ProdutoMaisLucrado.TabIndex = 43;
            this.compras_ProdutoMaisLucrado.Text = "Produto Mais Lucrado:";
            // 
            // compras_ProdutoMaisVendido
            // 
            this.compras_ProdutoMaisVendido.AutoSize = true;
            this.compras_ProdutoMaisVendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_ProdutoMaisVendido.Location = new System.Drawing.Point(594, 60);
            this.compras_ProdutoMaisVendido.Name = "compras_ProdutoMaisVendido";
            this.compras_ProdutoMaisVendido.Size = new System.Drawing.Size(218, 25);
            this.compras_ProdutoMaisVendido.TabIndex = 42;
            this.compras_ProdutoMaisVendido.Text = "Produto Mais Vendido:";
            // 
            // compras_txtLucro
            // 
            this.compras_txtLucro.AutoSize = true;
            this.compras_txtLucro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_txtLucro.ForeColor = System.Drawing.Color.Orange;
            this.compras_txtLucro.Location = new System.Drawing.Point(669, 31);
            this.compras_txtLucro.Name = "compras_txtLucro";
            this.compras_txtLucro.Size = new System.Drawing.Size(34, 25);
            this.compras_txtLucro.TabIndex = 41;
            this.compras_txtLucro.Text = "0€";
            // 
            // compras_lblLucro
            // 
            this.compras_lblLucro.AutoSize = true;
            this.compras_lblLucro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_lblLucro.Location = new System.Drawing.Point(594, 31);
            this.compras_lblLucro.Name = "compras_lblLucro";
            this.compras_lblLucro.Size = new System.Drawing.Size(68, 25);
            this.compras_lblLucro.TabIndex = 40;
            this.compras_lblLucro.Text = "Lucro:";
            // 
            // compras_btnConfirmar
            // 
            this.compras_btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.compras_btnConfirmar.Location = new System.Drawing.Point(183, 215);
            this.compras_btnConfirmar.Name = "compras_btnConfirmar";
            this.compras_btnConfirmar.Size = new System.Drawing.Size(196, 39);
            this.compras_btnConfirmar.TabIndex = 39;
            this.compras_btnConfirmar.Text = "Confirmar Compra";
            this.compras_btnConfirmar.UseVisualStyleBackColor = true;
            this.compras_btnConfirmar.Click += new System.EventHandler(this.compras_btnConfirmar_Click);
            // 
            // compras_txtDescricao
            // 
            this.compras_txtDescricao.Location = new System.Drawing.Point(141, 69);
            this.compras_txtDescricao.Name = "compras_txtDescricao";
            this.compras_txtDescricao.Size = new System.Drawing.Size(404, 22);
            this.compras_txtDescricao.TabIndex = 29;
            // 
            // compras_lblTipo
            // 
            this.compras_lblTipo.AutoSize = true;
            this.compras_lblTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_lblTipo.Location = new System.Drawing.Point(36, 28);
            this.compras_lblTipo.Name = "compras_lblTipo";
            this.compras_lblTipo.Size = new System.Drawing.Size(53, 25);
            this.compras_lblTipo.TabIndex = 25;
            this.compras_lblTipo.Text = "Tipo:";
            // 
            // compras_checkEnvioDividido
            // 
            this.compras_checkEnvioDividido.AutoSize = true;
            this.compras_checkEnvioDividido.Location = new System.Drawing.Point(41, 172);
            this.compras_checkEnvioDividido.Name = "compras_checkEnvioDividido";
            this.compras_checkEnvioDividido.Size = new System.Drawing.Size(104, 17);
            this.compras_checkEnvioDividido.TabIndex = 37;
            this.compras_checkEnvioDividido.Text = "Envio dividido?";
            this.compras_checkEnvioDividido.UseVisualStyleBackColor = true;
            this.compras_checkEnvioDividido.CheckedChanged += new System.EventHandler(this.compras_checkEnvioDividido_CheckedChanged);
            // 
            // compras_lblDescricao
            // 
            this.compras_lblDescricao.AutoSize = true;
            this.compras_lblDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_lblDescricao.Location = new System.Drawing.Point(36, 65);
            this.compras_lblDescricao.Name = "compras_lblDescricao";
            this.compras_lblDescricao.Size = new System.Drawing.Size(98, 25);
            this.compras_lblDescricao.TabIndex = 26;
            this.compras_lblDescricao.Text = "Descrição:";
            // 
            // compras_lblPreco
            // 
            this.compras_lblPreco.AutoSize = true;
            this.compras_lblPreco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_lblPreco.Location = new System.Drawing.Point(36, 99);
            this.compras_lblPreco.Name = "compras_lblPreco";
            this.compras_lblPreco.Size = new System.Drawing.Size(64, 25);
            this.compras_lblPreco.TabIndex = 27;
            this.compras_lblPreco.Text = "Preço:";
            // 
            // compras_comboBoxTipos
            // 
            this.compras_comboBoxTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compras_comboBoxTipos.FormattingEnabled = true;
            this.compras_comboBoxTipos.Location = new System.Drawing.Point(141, 31);
            this.compras_comboBoxTipos.Name = "compras_comboBoxTipos";
            this.compras_comboBoxTipos.Size = new System.Drawing.Size(404, 21);
            this.compras_comboBoxTipos.TabIndex = 28;
            this.compras_comboBoxTipos.Tag = "compras_txtTipo";
            this.compras_comboBoxTipos.SelectedIndexChanged += new System.EventHandler(this.vendas_comboBoxTipos_SelectedIndexChanged);
            // 
            // compras_lblEnvio
            // 
            this.compras_lblEnvio.AutoSize = true;
            this.compras_lblEnvio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compras_lblEnvio.Location = new System.Drawing.Point(36, 133);
            this.compras_lblEnvio.Name = "compras_lblEnvio";
            this.compras_lblEnvio.Size = new System.Drawing.Size(62, 25);
            this.compras_lblEnvio.TabIndex = 33;
            this.compras_lblEnvio.Text = "Envio:";
            // 
            // table_Compras
            // 
            this.table_Compras.AllowUserToAddRows = false;
            this.table_Compras.AllowUserToDeleteRows = false;
            this.table_Compras.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.table_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compras_ID,
            this.compras_Tipo,
            this.compras_Descricao,
            this.compras_Preco,
            this.compras_Data});
            this.table_Compras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_Compras.Location = new System.Drawing.Point(3, 328);
            this.table_Compras.MultiSelect = false;
            this.table_Compras.Name = "table_Compras";
            this.table_Compras.ReadOnly = true;
            this.table_Compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Compras.Size = new System.Drawing.Size(1060, 206);
            this.table_Compras.TabIndex = 1;
            // 
            // compras_ID
            // 
            this.compras_ID.HeaderText = "ID";
            this.compras_ID.Name = "compras_ID";
            this.compras_ID.ReadOnly = true;
            this.compras_ID.Width = 117;
            // 
            // compras_Tipo
            // 
            this.compras_Tipo.HeaderText = "Tipo";
            this.compras_Tipo.Name = "compras_Tipo";
            this.compras_Tipo.ReadOnly = true;
            this.compras_Tipo.Width = 265;
            // 
            // compras_Descricao
            // 
            this.compras_Descricao.HeaderText = "Descrição";
            this.compras_Descricao.Name = "compras_Descricao";
            this.compras_Descricao.ReadOnly = true;
            this.compras_Descricao.Width = 265;
            // 
            // compras_Preco
            // 
            this.compras_Preco.HeaderText = "Preço";
            this.compras_Preco.Name = "compras_Preco";
            this.compras_Preco.ReadOnly = true;
            this.compras_Preco.Width = 265;
            // 
            // compras_Data
            // 
            this.compras_Data.HeaderText = "Data";
            this.compras_Data.Name = "compras_Data";
            this.compras_Data.ReadOnly = true;
            this.compras_Data.Width = 105;
            // 
            // tabPage_Vendas
            // 
            this.tabPage_Vendas.Controls.Add(this.vendas_txtEnvioDividido);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtEnvioMaterial);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtMaterial);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtEnvio);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtPreco);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtTipo);
            this.tabPage_Vendas.Controls.Add(this.vendas_quantidadeStock);
            this.tabPage_Vendas.Controls.Add(this.vendas_usarStock);
            this.tabPage_Vendas.Controls.Add(this.vendas_ProdutoMaisLucrado);
            this.tabPage_Vendas.Controls.Add(this.vendas_ProdutoMaisVendido);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtLucro);
            this.tabPage_Vendas.Controls.Add(this.vendas_btnConfirmar);
            this.tabPage_Vendas.Controls.Add(this.vendas_lblLucro);
            this.tabPage_Vendas.Controls.Add(this.table_Vendas);
            this.tabPage_Vendas.Controls.Add(this.vendas_txtDescricao);
            this.tabPage_Vendas.Controls.Add(this.vendas_lblTipo);
            this.tabPage_Vendas.Controls.Add(this.vendas_checkEnvioDividido);
            this.tabPage_Vendas.Controls.Add(this.vendas_lblDescricao);
            this.tabPage_Vendas.Controls.Add(this.vendas_lblPreco);
            this.tabPage_Vendas.Controls.Add(this.vendas_checkEnvioMaterial);
            this.tabPage_Vendas.Controls.Add(this.vendas_comboBoxTipos);
            this.tabPage_Vendas.Controls.Add(this.vendas_lblEnvio);
            this.tabPage_Vendas.Controls.Add(this.vendas_lblMateriais);
            this.tabPage_Vendas.Location = new System.Drawing.Point(4, 5);
            this.tabPage_Vendas.Name = "tabPage_Vendas";
            this.tabPage_Vendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Vendas.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_Vendas.TabIndex = 0;
            this.tabPage_Vendas.UseVisualStyleBackColor = true;
            // 
            // vendas_txtEnvioDividido
            // 
            this.vendas_txtEnvioDividido.DecimalPlaces = 2;
            this.vendas_txtEnvioDividido.Location = new System.Drawing.Point(156, 226);
            this.vendas_txtEnvioDividido.Name = "vendas_txtEnvioDividido";
            this.vendas_txtEnvioDividido.Size = new System.Drawing.Size(94, 22);
            this.vendas_txtEnvioDividido.TabIndex = 34;
            this.vendas_txtEnvioDividido.Visible = false;
            // 
            // vendas_txtEnvioMaterial
            // 
            this.vendas_txtEnvioMaterial.DecimalPlaces = 2;
            this.vendas_txtEnvioMaterial.Location = new System.Drawing.Point(156, 202);
            this.vendas_txtEnvioMaterial.Name = "vendas_txtEnvioMaterial";
            this.vendas_txtEnvioMaterial.Size = new System.Drawing.Size(94, 22);
            this.vendas_txtEnvioMaterial.TabIndex = 33;
            this.vendas_txtEnvioMaterial.Visible = false;
            // 
            // vendas_txtMaterial
            // 
            this.vendas_txtMaterial.DecimalPlaces = 2;
            this.vendas_txtMaterial.Location = new System.Drawing.Point(141, 171);
            this.vendas_txtMaterial.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vendas_txtMaterial.Name = "vendas_txtMaterial";
            this.vendas_txtMaterial.Size = new System.Drawing.Size(404, 22);
            this.vendas_txtMaterial.TabIndex = 32;
            // 
            // vendas_txtEnvio
            // 
            this.vendas_txtEnvio.DecimalPlaces = 2;
            this.vendas_txtEnvio.Location = new System.Drawing.Point(141, 136);
            this.vendas_txtEnvio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vendas_txtEnvio.Name = "vendas_txtEnvio";
            this.vendas_txtEnvio.Size = new System.Drawing.Size(404, 22);
            this.vendas_txtEnvio.TabIndex = 31;
            // 
            // vendas_txtPreco
            // 
            this.vendas_txtPreco.DecimalPlaces = 2;
            this.vendas_txtPreco.Location = new System.Drawing.Point(141, 102);
            this.vendas_txtPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.vendas_txtPreco.Name = "vendas_txtPreco";
            this.vendas_txtPreco.Size = new System.Drawing.Size(404, 22);
            this.vendas_txtPreco.TabIndex = 30;
            // 
            // vendas_txtTipo
            // 
            this.vendas_txtTipo.Location = new System.Drawing.Point(349, 31);
            this.vendas_txtTipo.Name = "vendas_txtTipo";
            this.vendas_txtTipo.Size = new System.Drawing.Size(196, 22);
            this.vendas_txtTipo.TabIndex = 29;
            this.vendas_txtTipo.Visible = false;
            // 
            // vendas_quantidadeStock
            // 
            this.vendas_quantidadeStock.AutoSize = true;
            this.vendas_quantidadeStock.Location = new System.Drawing.Point(671, 177);
            this.vendas_quantidadeStock.Name = "vendas_quantidadeStock";
            this.vendas_quantidadeStock.Size = new System.Drawing.Size(0, 13);
            this.vendas_quantidadeStock.TabIndex = 28;
            // 
            // vendas_usarStock
            // 
            this.vendas_usarStock.AutoSize = true;
            this.vendas_usarStock.Location = new System.Drawing.Point(551, 176);
            this.vendas_usarStock.Name = "vendas_usarStock";
            this.vendas_usarStock.Size = new System.Drawing.Size(80, 17);
            this.vendas_usarStock.TabIndex = 27;
            this.vendas_usarStock.Text = "Usar Stock";
            this.vendas_usarStock.UseVisualStyleBackColor = true;
            this.vendas_usarStock.CheckedChanged += new System.EventHandler(this.vendas_usarStock_CheckedChanged);
            // 
            // vendas_ProdutoMaisLucrado
            // 
            this.vendas_ProdutoMaisLucrado.AutoSize = true;
            this.vendas_ProdutoMaisLucrado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_ProdutoMaisLucrado.Location = new System.Drawing.Point(594, 89);
            this.vendas_ProdutoMaisLucrado.Name = "vendas_ProdutoMaisLucrado";
            this.vendas_ProdutoMaisLucrado.Size = new System.Drawing.Size(216, 25);
            this.vendas_ProdutoMaisLucrado.TabIndex = 26;
            this.vendas_ProdutoMaisLucrado.Text = "Produto Mais Lucrado:";
            // 
            // vendas_ProdutoMaisVendido
            // 
            this.vendas_ProdutoMaisVendido.AutoSize = true;
            this.vendas_ProdutoMaisVendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_ProdutoMaisVendido.Location = new System.Drawing.Point(594, 60);
            this.vendas_ProdutoMaisVendido.Name = "vendas_ProdutoMaisVendido";
            this.vendas_ProdutoMaisVendido.Size = new System.Drawing.Size(218, 25);
            this.vendas_ProdutoMaisVendido.TabIndex = 25;
            this.vendas_ProdutoMaisVendido.Text = "Produto Mais Vendido:";
            // 
            // vendas_txtLucro
            // 
            this.vendas_txtLucro.AutoSize = true;
            this.vendas_txtLucro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_txtLucro.ForeColor = System.Drawing.Color.Orange;
            this.vendas_txtLucro.Location = new System.Drawing.Point(669, 31);
            this.vendas_txtLucro.Name = "vendas_txtLucro";
            this.vendas_txtLucro.Size = new System.Drawing.Size(34, 25);
            this.vendas_txtLucro.TabIndex = 24;
            this.vendas_txtLucro.Text = "0€";
            // 
            // vendas_btnConfirmar
            // 
            this.vendas_btnConfirmar.Location = new System.Drawing.Point(349, 216);
            this.vendas_btnConfirmar.Name = "vendas_btnConfirmar";
            this.vendas_btnConfirmar.Size = new System.Drawing.Size(196, 39);
            this.vendas_btnConfirmar.TabIndex = 22;
            this.vendas_btnConfirmar.Text = "Confirmar Venda";
            this.vendas_btnConfirmar.UseVisualStyleBackColor = true;
            this.vendas_btnConfirmar.Click += new System.EventHandler(this.vendas_btnConfirmar_Click);
            // 
            // vendas_lblLucro
            // 
            this.vendas_lblLucro.AutoSize = true;
            this.vendas_lblLucro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_lblLucro.Location = new System.Drawing.Point(594, 31);
            this.vendas_lblLucro.Name = "vendas_lblLucro";
            this.vendas_lblLucro.Size = new System.Drawing.Size(68, 25);
            this.vendas_lblLucro.TabIndex = 23;
            this.vendas_lblLucro.Text = "Lucro:";
            // 
            // table_Vendas
            // 
            this.table_Vendas.AllowUserToAddRows = false;
            this.table_Vendas.AllowUserToDeleteRows = false;
            this.table_Vendas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.table_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendas_ID,
            this.vendas_Tipo,
            this.vendas_Descricao,
            this.vendas_Preco,
            this.vendas_Lucro,
            this.vendas_Data});
            this.table_Vendas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table_Vendas.Location = new System.Drawing.Point(3, 328);
            this.table_Vendas.MultiSelect = false;
            this.table_Vendas.Name = "table_Vendas";
            this.table_Vendas.ReadOnly = true;
            this.table_Vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_Vendas.Size = new System.Drawing.Size(1060, 206);
            this.table_Vendas.TabIndex = 0;
            // 
            // vendas_ID
            // 
            this.vendas_ID.HeaderText = "ID";
            this.vendas_ID.Name = "vendas_ID";
            this.vendas_ID.ReadOnly = true;
            this.vendas_ID.Width = 117;
            // 
            // vendas_Tipo
            // 
            this.vendas_Tipo.HeaderText = "Tipo";
            this.vendas_Tipo.Name = "vendas_Tipo";
            this.vendas_Tipo.ReadOnly = true;
            this.vendas_Tipo.Width = 175;
            // 
            // vendas_Descricao
            // 
            this.vendas_Descricao.HeaderText = "Descrição";
            this.vendas_Descricao.Name = "vendas_Descricao";
            this.vendas_Descricao.ReadOnly = true;
            this.vendas_Descricao.Width = 260;
            // 
            // vendas_Preco
            // 
            this.vendas_Preco.HeaderText = "Preço";
            this.vendas_Preco.Name = "vendas_Preco";
            this.vendas_Preco.ReadOnly = true;
            this.vendas_Preco.Width = 175;
            // 
            // vendas_Lucro
            // 
            this.vendas_Lucro.HeaderText = "Lucro";
            this.vendas_Lucro.Name = "vendas_Lucro";
            this.vendas_Lucro.ReadOnly = true;
            this.vendas_Lucro.Width = 175;
            // 
            // vendas_Data
            // 
            this.vendas_Data.HeaderText = "Data";
            this.vendas_Data.Name = "vendas_Data";
            this.vendas_Data.ReadOnly = true;
            this.vendas_Data.Width = 115;
            // 
            // vendas_txtDescricao
            // 
            this.vendas_txtDescricao.Location = new System.Drawing.Point(141, 69);
            this.vendas_txtDescricao.Name = "vendas_txtDescricao";
            this.vendas_txtDescricao.Size = new System.Drawing.Size(404, 22);
            this.vendas_txtDescricao.TabIndex = 10;
            // 
            // vendas_lblTipo
            // 
            this.vendas_lblTipo.AutoSize = true;
            this.vendas_lblTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_lblTipo.Location = new System.Drawing.Point(36, 28);
            this.vendas_lblTipo.Name = "vendas_lblTipo";
            this.vendas_lblTipo.Size = new System.Drawing.Size(53, 25);
            this.vendas_lblTipo.TabIndex = 6;
            this.vendas_lblTipo.Text = "Tipo:";
            // 
            // vendas_checkEnvioDividido
            // 
            this.vendas_checkEnvioDividido.AutoSize = true;
            this.vendas_checkEnvioDividido.Location = new System.Drawing.Point(46, 231);
            this.vendas_checkEnvioDividido.Name = "vendas_checkEnvioDividido";
            this.vendas_checkEnvioDividido.Size = new System.Drawing.Size(104, 17);
            this.vendas_checkEnvioDividido.TabIndex = 20;
            this.vendas_checkEnvioDividido.Text = "Envio dividido?";
            this.vendas_checkEnvioDividido.UseVisualStyleBackColor = true;
            this.vendas_checkEnvioDividido.Visible = false;
            this.vendas_checkEnvioDividido.CheckedChanged += new System.EventHandler(this.check_EnvioDividido_CheckedChanged);
            // 
            // vendas_lblDescricao
            // 
            this.vendas_lblDescricao.AutoSize = true;
            this.vendas_lblDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_lblDescricao.Location = new System.Drawing.Point(36, 65);
            this.vendas_lblDescricao.Name = "vendas_lblDescricao";
            this.vendas_lblDescricao.Size = new System.Drawing.Size(98, 25);
            this.vendas_lblDescricao.TabIndex = 7;
            this.vendas_lblDescricao.Text = "Descrição:";
            // 
            // vendas_lblPreco
            // 
            this.vendas_lblPreco.AutoSize = true;
            this.vendas_lblPreco.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_lblPreco.Location = new System.Drawing.Point(36, 99);
            this.vendas_lblPreco.Name = "vendas_lblPreco";
            this.vendas_lblPreco.Size = new System.Drawing.Size(64, 25);
            this.vendas_lblPreco.TabIndex = 8;
            this.vendas_lblPreco.Text = "Preço:";
            // 
            // vendas_checkEnvioMaterial
            // 
            this.vendas_checkEnvioMaterial.AutoSize = true;
            this.vendas_checkEnvioMaterial.Location = new System.Drawing.Point(46, 206);
            this.vendas_checkEnvioMaterial.Name = "vendas_checkEnvioMaterial";
            this.vendas_checkEnvioMaterial.Size = new System.Drawing.Size(102, 17);
            this.vendas_checkEnvioMaterial.TabIndex = 18;
            this.vendas_checkEnvioMaterial.Text = "Pagaste Envio?";
            this.vendas_checkEnvioMaterial.UseVisualStyleBackColor = true;
            this.vendas_checkEnvioMaterial.CheckedChanged += new System.EventHandler(this.check_EnvioMaterial_CheckedChanged);
            // 
            // vendas_comboBoxTipos
            // 
            this.vendas_comboBoxTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendas_comboBoxTipos.FormattingEnabled = true;
            this.vendas_comboBoxTipos.Location = new System.Drawing.Point(141, 31);
            this.vendas_comboBoxTipos.Name = "vendas_comboBoxTipos";
            this.vendas_comboBoxTipos.Size = new System.Drawing.Size(404, 21);
            this.vendas_comboBoxTipos.TabIndex = 9;
            this.vendas_comboBoxTipos.Tag = "vendas_txtTipo";
            this.vendas_comboBoxTipos.SelectedIndexChanged += new System.EventHandler(this.vendas_comboBoxTipos_SelectedIndexChanged);
            // 
            // vendas_lblEnvio
            // 
            this.vendas_lblEnvio.AutoSize = true;
            this.vendas_lblEnvio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_lblEnvio.Location = new System.Drawing.Point(36, 133);
            this.vendas_lblEnvio.Name = "vendas_lblEnvio";
            this.vendas_lblEnvio.Size = new System.Drawing.Size(62, 25);
            this.vendas_lblEnvio.TabIndex = 16;
            this.vendas_lblEnvio.Text = "Envio:";
            // 
            // vendas_lblMateriais
            // 
            this.vendas_lblMateriais.AutoSize = true;
            this.vendas_lblMateriais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendas_lblMateriais.Location = new System.Drawing.Point(36, 168);
            this.vendas_lblMateriais.Name = "vendas_lblMateriais";
            this.vendas_lblMateriais.Size = new System.Drawing.Size(94, 25);
            this.vendas_lblMateriais.TabIndex = 14;
            this.vendas_lblMateriais.Text = "Materiais:";
            // 
            // form_Tab
            // 
            this.form_Tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.form_Tab.Controls.Add(this.tabPage_Vendas);
            this.form_Tab.Controls.Add(this.tabPage_Compras);
            this.form_Tab.Controls.Add(this.tabPage_Planos);
            this.form_Tab.Controls.Add(this.tabPage_PlanosTlm);
            this.form_Tab.Controls.Add(this.tabPage_Stock);
            this.form_Tab.Controls.Add(this.tabPage_Definicoes);
            this.form_Tab.Controls.Add(this.tabPage_ToDoList);
            this.form_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_Tab.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_Tab.ItemSize = new System.Drawing.Size(0, 1);
            this.form_Tab.Location = new System.Drawing.Point(0, 0);
            this.form_Tab.Name = "form_Tab";
            this.form_Tab.SelectedIndex = 0;
            this.form_Tab.Size = new System.Drawing.Size(1074, 546);
            this.form_Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.form_Tab.TabIndex = 23;
            // 
            // tabPage_Definicoes
            // 
            this.tabPage_Definicoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Definicoes.Controls.Add(this.button5);
            this.tabPage_Definicoes.Controls.Add(this.button6);
            this.tabPage_Definicoes.Controls.Add(this.button3);
            this.tabPage_Definicoes.Controls.Add(this.button4);
            this.tabPage_Definicoes.Controls.Add(this.button2);
            this.tabPage_Definicoes.Controls.Add(this.button1);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_txtStock);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_txtCompras);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_txtVendas);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_Stock);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_Compras);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_Vendas);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_btnReset);
            this.tabPage_Definicoes.Controls.Add(this.definicoes_btnGuardar);
            this.tabPage_Definicoes.Controls.Add(this.label17);
            this.tabPage_Definicoes.Controls.Add(this.label16);
            this.tabPage_Definicoes.Controls.Add(this.label15);
            this.tabPage_Definicoes.Location = new System.Drawing.Point(4, 5);
            this.tabPage_Definicoes.Name = "tabPage_Definicoes";
            this.tabPage_Definicoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Definicoes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage_Definicoes.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_Definicoes.TabIndex = 5;
            this.tabPage_Definicoes.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(779, 311);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 19;
            this.button5.Tag = "definicoes_Stock";
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.definicoes_removeButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(747, 311);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(23, 23);
            this.button6.TabIndex = 18;
            this.button6.Tag = "definicoes_txtStock";
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.definicoes_addButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(592, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 17;
            this.button3.Tag = "definicoes_Compras";
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.definicoes_removeButton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(560, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 16;
            this.button4.Tag = "definicoes_txtCompras";
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.definicoes_addButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(405, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 15;
            this.button2.Tag = "definicoes_Vendas";
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.definicoes_removeButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 14;
            this.button1.Tag = "definicoes_txtVendas";
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.definicoes_addButton_Click);
            // 
            // definicoes_txtStock
            // 
            this.definicoes_txtStock.Location = new System.Drawing.Point(637, 311);
            this.definicoes_txtStock.Name = "definicoes_txtStock";
            this.definicoes_txtStock.Size = new System.Drawing.Size(100, 22);
            this.definicoes_txtStock.TabIndex = 13;
            this.definicoes_txtStock.Tag = "definicoes_Stock";
            // 
            // definicoes_txtCompras
            // 
            this.definicoes_txtCompras.Location = new System.Drawing.Point(450, 311);
            this.definicoes_txtCompras.Name = "definicoes_txtCompras";
            this.definicoes_txtCompras.Size = new System.Drawing.Size(100, 22);
            this.definicoes_txtCompras.TabIndex = 12;
            this.definicoes_txtCompras.Tag = "definicoes_Compras";
            // 
            // definicoes_txtVendas
            // 
            this.definicoes_txtVendas.Location = new System.Drawing.Point(263, 311);
            this.definicoes_txtVendas.Name = "definicoes_txtVendas";
            this.definicoes_txtVendas.Size = new System.Drawing.Size(100, 22);
            this.definicoes_txtVendas.TabIndex = 11;
            this.definicoes_txtVendas.Tag = "definicoes_Vendas";
            // 
            // definicoes_Stock
            // 
            this.definicoes_Stock.FormattingEnabled = true;
            this.definicoes_Stock.Location = new System.Drawing.Point(637, 40);
            this.definicoes_Stock.Name = "definicoes_Stock";
            this.definicoes_Stock.Size = new System.Drawing.Size(165, 264);
            this.definicoes_Stock.TabIndex = 10;
            // 
            // definicoes_Compras
            // 
            this.definicoes_Compras.FormattingEnabled = true;
            this.definicoes_Compras.Location = new System.Drawing.Point(450, 40);
            this.definicoes_Compras.Name = "definicoes_Compras";
            this.definicoes_Compras.Size = new System.Drawing.Size(165, 264);
            this.definicoes_Compras.TabIndex = 9;
            // 
            // definicoes_Vendas
            // 
            this.definicoes_Vendas.FormattingEnabled = true;
            this.definicoes_Vendas.Location = new System.Drawing.Point(263, 40);
            this.definicoes_Vendas.Name = "definicoes_Vendas";
            this.definicoes_Vendas.Size = new System.Drawing.Size(165, 264);
            this.definicoes_Vendas.TabIndex = 8;
            // 
            // definicoes_btnReset
            // 
            this.definicoes_btnReset.Location = new System.Drawing.Point(494, 404);
            this.definicoes_btnReset.Name = "definicoes_btnReset";
            this.definicoes_btnReset.Size = new System.Drawing.Size(75, 23);
            this.definicoes_btnReset.TabIndex = 7;
            this.definicoes_btnReset.Text = "Reset";
            this.definicoes_btnReset.UseVisualStyleBackColor = true;
            this.definicoes_btnReset.Click += new System.EventHandler(this.definicoes_btnReset_Click);
            // 
            // definicoes_btnGuardar
            // 
            this.definicoes_btnGuardar.Location = new System.Drawing.Point(450, 355);
            this.definicoes_btnGuardar.Name = "definicoes_btnGuardar";
            this.definicoes_btnGuardar.Size = new System.Drawing.Size(165, 43);
            this.definicoes_btnGuardar.TabIndex = 6;
            this.definicoes_btnGuardar.Text = "Guardar";
            this.definicoes_btnGuardar.UseVisualStyleBackColor = true;
            this.definicoes_btnGuardar.Click += new System.EventHandler(this.definicoes_btnGuardar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(691, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 25);
            this.label17.TabIndex = 5;
            this.label17.Text = "Stock";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(489, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "Compras";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(309, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Vendas";
            // 
            // tabPage_ToDoList
            // 
            this.tabPage_ToDoList.Controls.Add(this.apontamentos_guardar);
            this.tabPage_ToDoList.Controls.Add(this.apontamentos_Text);
            this.tabPage_ToDoList.Location = new System.Drawing.Point(4, 5);
            this.tabPage_ToDoList.Name = "tabPage_ToDoList";
            this.tabPage_ToDoList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ToDoList.Size = new System.Drawing.Size(1066, 537);
            this.tabPage_ToDoList.TabIndex = 6;
            this.tabPage_ToDoList.Text = "tabPage1";
            this.tabPage_ToDoList.UseVisualStyleBackColor = true;
            // 
            // apontamentos_guardar
            // 
            this.apontamentos_guardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.apontamentos_guardar.Location = new System.Drawing.Point(469, 486);
            this.apontamentos_guardar.Name = "apontamentos_guardar";
            this.apontamentos_guardar.Size = new System.Drawing.Size(126, 34);
            this.apontamentos_guardar.TabIndex = 24;
            this.apontamentos_guardar.Text = "Guardar";
            this.apontamentos_guardar.UseVisualStyleBackColor = true;
            this.apontamentos_guardar.Click += new System.EventHandler(this.apontamentos_guardar_Click);
            // 
            // apontamentos_Text
            // 
            this.apontamentos_Text.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apontamentos_Text.Location = new System.Drawing.Point(6, 6);
            this.apontamentos_Text.Multiline = true;
            this.apontamentos_Text.Name = "apontamentos_Text";
            this.apontamentos_Text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.apontamentos_Text.Size = new System.Drawing.Size(1052, 474);
            this.apontamentos_Text.TabIndex = 23;
            // 
            // panel_Barra
            // 
            this.panel_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel_Barra.Controls.Add(this.label_Logo);
            this.panel_Barra.Controls.Add(this.pictureBox2);
            this.panel_Barra.Controls.Add(this.iconButton_Minimizar);
            this.panel_Barra.Controls.Add(this.iconButton_Fechar);
            this.panel_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Barra.Location = new System.Drawing.Point(0, 0);
            this.panel_Barra.Name = "panel_Barra";
            this.panel_Barra.Size = new System.Drawing.Size(1239, 24);
            this.panel_Barra.TabIndex = 24;
            this.panel_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label_Logo
            // 
            this.label_Logo.AutoSize = true;
            this.label_Logo.BackColor = System.Drawing.Color.Transparent;
            this.label_Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Logo.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logo.ForeColor = System.Drawing.Color.Orange;
            this.label_Logo.Location = new System.Drawing.Point(24, 0);
            this.label_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.label_Logo.Name = "label_Logo";
            this.label_Logo.Size = new System.Drawing.Size(91, 23);
            this.label_Logo.TabIndex = 16;
            this.label_Logo.Text = "HeyDrawn";
            this.label_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::HeyDrawn_Money_Manager.Properties.Resources.logo_sem_fundo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // iconButton_Minimizar
            // 
            this.iconButton_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.iconButton_Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton_Minimizar.FlatAppearance.BorderSize = 0;
            this.iconButton_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Minimizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Minimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton_Minimizar.IconColor = System.Drawing.Color.White;
            this.iconButton_Minimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton_Minimizar.IconSize = 16;
            this.iconButton_Minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton_Minimizar.Location = new System.Drawing.Point(1151, 0);
            this.iconButton_Minimizar.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_Minimizar.Name = "iconButton_Minimizar";
            this.iconButton_Minimizar.Size = new System.Drawing.Size(44, 24);
            this.iconButton_Minimizar.TabIndex = 14;
            this.iconButton_Minimizar.UseCompatibleTextRendering = true;
            this.iconButton_Minimizar.UseVisualStyleBackColor = false;
            this.iconButton_Minimizar.Click += new System.EventHandler(this.iconButton_Minimizar_Click);
            // 
            // iconButton_Fechar
            // 
            this.iconButton_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.iconButton_Fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton_Fechar.FlatAppearance.BorderSize = 0;
            this.iconButton_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Fechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_Fechar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton_Fechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButton_Fechar.IconColor = System.Drawing.Color.White;
            this.iconButton_Fechar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton_Fechar.IconSize = 15;
            this.iconButton_Fechar.Location = new System.Drawing.Point(1195, 0);
            this.iconButton_Fechar.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton_Fechar.Name = "iconButton_Fechar";
            this.iconButton_Fechar.Size = new System.Drawing.Size(44, 24);
            this.iconButton_Fechar.TabIndex = 12;
            this.iconButton_Fechar.UseCompatibleTextRendering = true;
            this.iconButton_Fechar.UseVisualStyleBackColor = false;
            this.iconButton_Fechar.Click += new System.EventHandler(this.iconButton_Fechar_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.LightGray;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 25;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(0, 59);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(165, 44);
            this.iconButton6.TabIndex = 11;
            this.iconButton6.Tag = "tabPage_Vendas";
            this.iconButton6.Text = "       Vendas";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.UseCompatibleTextRendering = true;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.ChangeTab);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.form_Tab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(165, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 546);
            this.panel2.TabIndex = 26;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.White;
            this.panel_Menu.Controls.Add(this.iconButton7);
            this.panel_Menu.Controls.Add(this.iconButton5);
            this.panel_Menu.Controls.Add(this.iconButton4);
            this.panel_Menu.Controls.Add(this.iconButton3);
            this.panel_Menu.Controls.Add(this.iconButton2);
            this.panel_Menu.Controls.Add(this.iconButton1);
            this.panel_Menu.Controls.Add(this.iconButton6);
            this.panel_Menu.Controls.Add(this.panel4);
            this.panel_Menu.Controls.Add(this.panel3);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 24);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(165, 546);
            this.panel_Menu.TabIndex = 27;
            // 
            // iconButton7
            // 
            this.iconButton7.BackColor = System.Drawing.Color.White;
            this.iconButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton7.IconColor = System.Drawing.Color.Black;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 25;
            this.iconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.Location = new System.Drawing.Point(0, 279);
            this.iconButton7.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(165, 44);
            this.iconButton7.TabIndex = 20;
            this.iconButton7.Tag = "tabPage_ToDoList";
            this.iconButton7.Text = "       Apontamentos";
            this.iconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton7.UseCompatibleTextRendering = true;
            this.iconButton7.UseVisualStyleBackColor = false;
            this.iconButton7.Click += new System.EventHandler(this.ChangeTab);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 502);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(165, 44);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.Tag = "tabPage_Definicoes";
            this.iconButton5.Text = "       Definições";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.UseCompatibleTextRendering = true;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.ChangeTab);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 235);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(165, 44);
            this.iconButton4.TabIndex = 18;
            this.iconButton4.Tag = "tabPage_Stock";
            this.iconButton4.Text = "       Stock";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.UseCompatibleTextRendering = true;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.ChangeTab);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.MobilePhone;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 191);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(165, 44);
            this.iconButton3.TabIndex = 17;
            this.iconButton3.Tag = "tabPage_PlanosTlm";
            this.iconButton3.Text = "       Planos Tlm";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseCompatibleTextRendering = true;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.ChangeTab);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 147);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(165, 44);
            this.iconButton2.TabIndex = 16;
            this.iconButton2.Tag = "tabPage_Planos";
            this.iconButton2.Text = "       Planos";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseCompatibleTextRendering = true;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.ChangeTab);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 103);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 44);
            this.iconButton1.TabIndex = 15;
            this.iconButton1.Tag = "tabPage_Compras";
            this.iconButton1.Text = "       Compras";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseCompatibleTextRendering = true;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.ChangeTab);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(165, 14);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label_Menu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 45);
            this.panel3.TabIndex = 13;
            // 
            // label_Menu
            // 
            this.label_Menu.AutoSize = true;
            this.label_Menu.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Menu.Location = new System.Drawing.Point(37, 5);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(90, 39);
            this.label_Menu.TabIndex = 12;
            this.label_Menu.Text = "Menu";
            this.label_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 570);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeyDrawn Money Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage_Stock.ResumeLayout(false);
            this.tabPage_Stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Stock)).EndInit();
            this.tabPage_PlanosTlm.ResumeLayout(false);
            this.tabPage_PlanosTlm.PerformLayout();
            this.tabPage_Planos.ResumeLayout(false);
            this.tabPage_Planos.PerformLayout();
            this.tabPage_Compras.ResumeLayout(false);
            this.tabPage_Compras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compras_txtEnvioDividido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compras_txtEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compras_txtPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Compras)).EndInit();
            this.tabPage_Vendas.ResumeLayout(false);
            this.tabPage_Vendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtEnvioDividido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtEnvioMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendas_txtPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Vendas)).EndInit();
            this.form_Tab.ResumeLayout(false);
            this.tabPage_Definicoes.ResumeLayout(false);
            this.tabPage_Definicoes.PerformLayout();
            this.tabPage_ToDoList.ResumeLayout(false);
            this.tabPage_ToDoList.PerformLayout();
            this.panel_Barra.ResumeLayout(false);
            this.panel_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_Menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TabPage tabPage_Stock;
		private System.Windows.Forms.Button stock_btnConfirmar;
		private System.Windows.Forms.TextBox stock_txtEnvio;
		private System.Windows.Forms.TextBox stock_txtQuantidade;
		private System.Windows.Forms.TextBox stock_txtPreco;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox stock_comboBoxMaterial;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView table_Stock;
		private System.Windows.Forms.TabPage tabPage_PlanosTlm;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button planosTlm_btnApagar;
		private System.Windows.Forms.Button planosTlm_btnAdd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox planosTlm_txtNovoPlano;
		private System.Windows.Forms.Button planosTlm_btnNext;
		private System.Windows.Forms.Button planosTlm_btnPrevious;
		private System.Windows.Forms.ListBox planosTlm_ListaEnviados;
		private System.Windows.Forms.ListBox planosTlm_ListaPronto;
		private System.Windows.Forms.ListBox planosTlm_ListaAtivo;
		private System.Windows.Forms.ListBox planosTlm_ListaPendente;
		private System.Windows.Forms.TabPage tabPage_Planos;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button planos_btnApagar;
		private System.Windows.Forms.Button planos_btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox planos_txtNovoPlano;
		private System.Windows.Forms.ListBox planos_ListaEnviados;
		private System.Windows.Forms.Button planos_btnNext;
		private System.Windows.Forms.Button planos_btnPrevious;
		private System.Windows.Forms.ListBox planos_ListaPronto;
		private System.Windows.Forms.ListBox planos_ListaAtivo;
		private System.Windows.Forms.ListBox planos_ListaPendente;
		private System.Windows.Forms.TabPage tabPage_Compras;
		private System.Windows.Forms.Label compras_ProdutoMaisLucrado;
		private System.Windows.Forms.Label compras_ProdutoMaisVendido;
		private System.Windows.Forms.Label compras_txtLucro;
		private System.Windows.Forms.Label compras_lblLucro;
		private System.Windows.Forms.Button compras_btnConfirmar;
		private System.Windows.Forms.TextBox compras_txtDescricao;
		private System.Windows.Forms.Label compras_lblTipo;
		private System.Windows.Forms.CheckBox compras_checkEnvioDividido;
		private System.Windows.Forms.Label compras_lblDescricao;
		private System.Windows.Forms.Label compras_lblPreco;
		private System.Windows.Forms.Label compras_lblEnvio;
		private System.Windows.Forms.DataGridView table_Compras;
		private System.Windows.Forms.TabPage tabPage_Vendas;
		private System.Windows.Forms.Label vendas_ProdutoMaisLucrado;
		private System.Windows.Forms.Label vendas_ProdutoMaisVendido;
		private System.Windows.Forms.Label vendas_txtLucro;
		private System.Windows.Forms.Button vendas_btnConfirmar;
		private System.Windows.Forms.Label vendas_lblLucro;
		private System.Windows.Forms.DataGridView table_Vendas;
		private System.Windows.Forms.TextBox vendas_txtDescricao;
		private System.Windows.Forms.Label vendas_lblTipo;
		private System.Windows.Forms.CheckBox vendas_checkEnvioDividido;
		private System.Windows.Forms.Label vendas_lblDescricao;
		private System.Windows.Forms.Label vendas_lblPreco;
		private System.Windows.Forms.CheckBox vendas_checkEnvioMaterial;
		private System.Windows.Forms.ComboBox vendas_comboBoxTipos;
		private System.Windows.Forms.Label vendas_lblEnvio;
		private System.Windows.Forms.Label vendas_lblMateriais;
		private System.Windows.Forms.TabControl form_Tab;
		private System.Windows.Forms.ComboBox compras_comboBoxTipos;
        private System.Windows.Forms.TextBox stock_txtEnvioDividido;
        private System.Windows.Forms.CheckBox stock_checkEnvioDividido;
        private System.Windows.Forms.CheckBox vendas_usarStock;
        private System.Windows.Forms.Label vendas_quantidadeStock;
        private System.Windows.Forms.TabPage tabPage_Definicoes;
        private System.Windows.Forms.Button definicoes_btnGuardar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button definicoes_btnReset;
        private System.Windows.Forms.ListBox definicoes_Stock;
        private System.Windows.Forms.ListBox definicoes_Compras;
        private System.Windows.Forms.ListBox definicoes_Vendas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox definicoes_txtStock;
        private System.Windows.Forms.TextBox definicoes_txtCompras;
        private System.Windows.Forms.TextBox definicoes_txtVendas;
        private System.Windows.Forms.TextBox vendas_txtTipo;
        private System.Windows.Forms.TextBox compras_txtTipo;
        private System.Windows.Forms.Panel panel_Barra;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton_Minimizar;
        private FontAwesome.Sharp.IconButton iconButton_Fechar;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Label label_Logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.TabPage tabPage_ToDoList;
        private System.Windows.Forms.NumericUpDown vendas_txtPreco;
        private System.Windows.Forms.NumericUpDown vendas_txtEnvioDividido;
        private System.Windows.Forms.NumericUpDown vendas_txtEnvioMaterial;
        private System.Windows.Forms.NumericUpDown vendas_txtMaterial;
        private System.Windows.Forms.NumericUpDown vendas_txtEnvio;
        private System.Windows.Forms.NumericUpDown compras_txtEnvioDividido;
        private System.Windows.Forms.NumericUpDown compras_txtEnvio;
        private System.Windows.Forms.NumericUpDown compras_txtPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn compras_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn compras_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn compras_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn compras_Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn compras_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendas_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendas_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendas_Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendas_Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendas_Lucro;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendas_Data;
        private System.Windows.Forms.TextBox apontamentos_Text;
        private System.Windows.Forms.Button apontamentos_guardar;
    }
}

