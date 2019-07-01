namespace __LPM.Clientes.VIEW
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.GrdClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponto_referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnInclude = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPonto_referencia = new System.Windows.Forms.TextBox();
            this.TxtComplemento = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.MskContato = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdClientes
            // 
            this.GrdClientes.AllowUserToAddRows = false;
            this.GrdClientes.AllowUserToDeleteRows = false;
            this.GrdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tipo_pessoa,
            this.documento,
            this.nome,
            this.sobrenome,
            this.contato,
            this.cidade,
            this.bairro,
            this.logradouro,
            this.numero,
            this.Complemento,
            this.ponto_referencia});
            this.GrdClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdClientes.Location = new System.Drawing.Point(0, 419);
            this.GrdClientes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.GrdClientes.Name = "GrdClientes";
            this.GrdClientes.Size = new System.Drawing.Size(1241, 262);
            this.GrdClientes.TabIndex = 27;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.Width = 40;
            // 
            // tipo_pessoa
            // 
            this.tipo_pessoa.DataPropertyName = "tipo_pessoa";
            this.tipo_pessoa.HeaderText = "Tipo de Pessoa";
            this.tipo_pessoa.MaxInputLength = 8;
            this.tipo_pessoa.Name = "tipo_pessoa";
            this.tipo_pessoa.ReadOnly = true;
            this.tipo_pessoa.Width = 80;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "CPF / CNPJ";
            this.documento.MaxInputLength = 20;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 80;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MaxInputLength = 50;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sobrenome
            // 
            this.sobrenome.DataPropertyName = "sobrenome";
            this.sobrenome.HeaderText = "Sobrenome";
            this.sobrenome.MaxInputLength = 50;
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.ReadOnly = true;
            // 
            // contato
            // 
            this.contato.DataPropertyName = "contato";
            this.contato.HeaderText = "Número de Contato";
            this.contato.Name = "contato";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MaxInputLength = 50;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MaxInputLength = 50;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // logradouro
            // 
            this.logradouro.DataPropertyName = "logradouro";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.MaxInputLength = 50;
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Número";
            this.numero.MaxInputLength = 10;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 80;
            // 
            // Complemento
            // 
            this.Complemento.DataPropertyName = "complemento";
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.MaxInputLength = 50;
            this.Complemento.Name = "Complemento";
            this.Complemento.ReadOnly = true;
            // 
            // ponto_referencia
            // 
            this.ponto_referencia.DataPropertyName = "ponto_referencia";
            this.ponto_referencia.HeaderText = "Ponto de Referência";
            this.ponto_referencia.MaxInputLength = 50;
            this.ponto_referencia.Name = "ponto_referencia";
            this.ponto_referencia.ReadOnly = true;
            this.ponto_referencia.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Celular / Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sobrenome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF / CNPJ";
            // 
            // BtnInclude
            // 
            this.BtnInclude.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnInclude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInclude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnInclude.Location = new System.Drawing.Point(20, 312);
            this.BtnInclude.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnInclude.Name = "BtnInclude";
            this.BtnInclude.Size = new System.Drawing.Size(173, 70);
            this.BtnInclude.TabIndex = 25;
            this.BtnInclude.Text = "Cadastrar";
            this.BtnInclude.UseVisualStyleBackColor = false;
            this.BtnInclude.Click += new System.EventHandler(this.BtnInclude_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExit.Location = new System.Drawing.Point(1020, 307);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(199, 81);
            this.BtnExit.TabIndex = 28;
            this.BtnExit.Text = "Sair";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancel.Location = new System.Drawing.Point(520, 312);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(173, 70);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDelete.Location = new System.Drawing.Point(770, 312);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(173, 70);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnUpdate.Location = new System.Drawing.Point(270, 312);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(173, 70);
            this.BtnUpdate.TabIndex = 23;
            this.BtnUpdate.Text = "Atualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Logradouro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Complemento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(576, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Ponto de Referência";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearch.BackgroundImage")));
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnSearch.Location = new System.Drawing.Point(200, 29);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(42, 36);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseMnemonic = false;
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(126, 37);
            this.TxtID.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(68, 23);
            this.TxtID.TabIndex = 1;
            // 
            // TxtPonto_referencia
            // 
            this.TxtPonto_referencia.Location = new System.Drawing.Point(626, 237);
            this.TxtPonto_referencia.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtPonto_referencia.Name = "TxtPonto_referencia";
            this.TxtPonto_referencia.Size = new System.Drawing.Size(361, 23);
            this.TxtPonto_referencia.TabIndex = 22;
            // 
            // TxtComplemento
            // 
            this.TxtComplemento.Location = new System.Drawing.Point(626, 157);
            this.TxtComplemento.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtComplemento.Name = "TxtComplemento";
            this.TxtComplemento.Size = new System.Drawing.Size(361, 23);
            this.TxtComplemento.TabIndex = 18;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(626, 197);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(79, 23);
            this.TxtNumero.TabIndex = 20;
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(626, 117);
            this.TxtLogradouro.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(361, 23);
            this.TxtLogradouro.TabIndex = 16;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(626, 77);
            this.TxtBairro.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(361, 23);
            this.TxtBairro.TabIndex = 14;
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(626, 37);
            this.TxtCidade.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtCidade.MaxLength = 50;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(361, 23);
            this.TxtCidade.TabIndex = 12;
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Location = new System.Drawing.Point(126, 117);
            this.TxtSobrenome.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(361, 23);
            this.TxtSobrenome.TabIndex = 6;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(126, 77);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(361, 23);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(126, 197);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TxtDocumento.MaxLength = 20;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(149, 23);
            this.TxtDocumento.TabIndex = 10;
            // 
            // MskContato
            // 
            this.MskContato.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.MskContato.Location = new System.Drawing.Point(126, 157);
            this.MskContato.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MskContato.Mask = "(99) 0000-00000";
            this.MskContato.Name = "MskContato";
            this.MskContato.Size = new System.Drawing.Size(116, 23);
            this.MskContato.TabIndex = 8;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1241, 681);
            this.Controls.Add(this.MskContato);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtLogradouro);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtComplemento);
            this.Controls.Add(this.TxtPonto_referencia);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnInclude);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdClientes);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FrmCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponto_referencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnInclude;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtPonto_referencia;
        private System.Windows.Forms.TextBox TxtComplemento;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtSobrenome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.MaskedTextBox MskContato;
    }
}

