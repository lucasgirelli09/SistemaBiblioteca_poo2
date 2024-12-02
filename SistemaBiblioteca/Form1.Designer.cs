namespace GerenciamentoLivros
{
    partial class GerenciamentoLivrosForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridLivros;
        private System.Windows.Forms.TextBox txtLivroTitulo;
        private System.Windows.Forms.TextBox txtLivroAno;
        private System.Windows.Forms.TextBox txtLivroGenero;
        private System.Windows.Forms.TextBox txtLivroAutor;
        private System.Windows.Forms.Button btnCriarLivro;
        private System.Windows.Forms.Button btnFiltrarLivro;
        private System.Windows.Forms.Button btnAtualizarLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblLivroTitulo;
        private System.Windows.Forms.Label lblLivroAno;
        private System.Windows.Forms.Label lblLivroGenero;
        private System.Windows.Forms.Label lblLivroAutor;

        private void InitializeComponent()
        {
            this.dataGridLivros = new System.Windows.Forms.DataGridView();
            this.txtLivroTitulo = new System.Windows.Forms.TextBox();
            this.txtLivroAno = new System.Windows.Forms.TextBox();
            this.txtLivroGenero = new System.Windows.Forms.TextBox();
            this.txtLivroAutor = new System.Windows.Forms.TextBox();
            this.btnCriarLivro = new System.Windows.Forms.Button();
            this.btnFiltrarLivro = new System.Windows.Forms.Button();
            this.btnAtualizarLivro = new System.Windows.Forms.Button();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblLivroTitulo = new System.Windows.Forms.Label();
            this.lblLivroAno = new System.Windows.Forms.Label();
            this.lblLivroGenero = new System.Windows.Forms.Label();
            this.lblLivroAutor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLivros
            // 
            this.dataGridLivros.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLivros.Location = new System.Drawing.Point(29, 188);
            this.dataGridLivros.Name = "dataGridLivros";
            this.dataGridLivros.Size = new System.Drawing.Size(561, 373);
            this.dataGridLivros.TabIndex = 0;
            this.dataGridLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLivros_CellClick);
            // Restante do código segue o mesmo padrão...
