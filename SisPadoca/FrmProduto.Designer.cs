namespace SisPadoca
{
    partial class FrmProduto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            LblNCM = new Label();
            BtnNovo = new Button();
            TxbNCM = new TextBox();
            PbxImagem = new PictureBox();
            CbxUnidade = new ComboBox();
            TxbDescricao = new TextBox();
            LblDescricao = new Label();
            TxbCodigoBarras = new TextBox();
            LblCodigoBarras = new Label();
            LblUnidade = new Label();
            LblLote = new Label();
            TbxLote = new TextBox();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ImgLista = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)PbxImagem).BeginInit();
            SuspendLayout();
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.Location = new Point(251, 41);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 0;
            LblNCM.Text = "NCM";
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(40, 325);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(143, 37);
            BtnNovo.TabIndex = 1;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // TxbNCM
            // 
            TxbNCM.Location = new Point(251, 69);
            TxbNCM.Name = "TxbNCM";
            TxbNCM.Size = new Size(150, 31);
            TxbNCM.TabIndex = 2;
            // 
            // PbxImagem
            // 
            PbxImagem.Image = (Image)resources.GetObject("PbxImagem.Image");
            PbxImagem.Location = new Point(40, 41);
            PbxImagem.Name = "PbxImagem";
            PbxImagem.Size = new Size(194, 237);
            PbxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImagem.TabIndex = 3;
            PbxImagem.TabStop = false;
            // 
            // CbxUnidade
            // 
            CbxUnidade.FormattingEnabled = true;
            CbxUnidade.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CbxUnidade.Location = new Point(525, 162);
            CbxUnidade.Name = "CbxUnidade";
            CbxUnidade.Size = new Size(182, 33);
            CbxUnidade.TabIndex = 4;
            // 
            // TxbDescricao
            // 
            TxbDescricao.Location = new Point(251, 162);
            TxbDescricao.Name = "TxbDescricao";
            TxbDescricao.Size = new Size(220, 31);
            TxbDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(251, 134);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 5;
            LblDescricao.Text = "Descrição";
            // 
            // TxbCodigoBarras
            // 
            TxbCodigoBarras.Location = new Point(251, 249);
            TxbCodigoBarras.Name = "TxbCodigoBarras";
            TxbCodigoBarras.Size = new Size(220, 31);
            TxbCodigoBarras.TabIndex = 8;
            // 
            // LblCodigoBarras
            // 
            LblCodigoBarras.AutoSize = true;
            LblCodigoBarras.Location = new Point(252, 221);
            LblCodigoBarras.Name = "LblCodigoBarras";
            LblCodigoBarras.Size = new Size(149, 25);
            LblCodigoBarras.TabIndex = 7;
            LblCodigoBarras.Text = "Código de Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.Location = new Point(525, 134);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(168, 25);
            LblUnidade.TabIndex = 9;
            LblUnidade.Text = "Unidade de Medida";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.Location = new Point(525, 221);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 10;
            LblLote.Text = "Lote";
            // 
            // TbxLote
            // 
            TbxLote.Location = new Point(525, 249);
            TbxLote.Name = "TbxLote";
            TbxLote.Size = new Size(182, 31);
            TbxLote.TabIndex = 11;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(220, 325);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(143, 37);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(391, 325);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(143, 37);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(564, 325);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(143, 37);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(743, 325);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(142, 37);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 536);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(TbxLote);
            Controls.Add(LblLote);
            Controls.Add(LblUnidade);
            Controls.Add(TxbCodigoBarras);
            Controls.Add(LblCodigoBarras);
            Controls.Add(TxbDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(CbxUnidade);
            Controls.Add(PbxImagem);
            Controls.Add(TxbNCM);
            Controls.Add(BtnNovo);
            Controls.Add(LblNCM);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)PbxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNCM;
        private Button BtnNovo;
        private TextBox TxbNCM;
        private PictureBox PbxImagem;
        private ComboBox CbxUnidade;
        private TextBox TxbDescricao;
        private Label LblDescricao;
        private TextBox TxbCodigoBarras;
        private Label LblCodigoBarras;
        private Label LblUnidade;
        private Label LblLote;
        private TextBox TbxLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
        private ImageList ImgLista;
    }
}