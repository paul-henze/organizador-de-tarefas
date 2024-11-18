namespace GerenciadordeTarefas
{
    partial class Main_frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_frm));
            FaixaMenu = new ToolStrip();
            AdicionarTarefa_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Tarefas_lbl = new Label();
            DataFim = new Label();
            label1 = new Label();
            LBListaAgSu = new ListBox();
            TarefaAdicionar = new TextBox();
            Tarefa_lbl = new Label();
            LBListaAnSu = new ListBox();
            LBListaFinSu = new ListBox();
            MoverDir1 = new Button();
            MoverDir2 = new Button();
            MoverEsq2 = new Button();
            MoverEsq1 = new Button();
            semUrgencia_btn = new RadioButton();
            importante_btn = new RadioButton();
            muitoImportante_btn = new RadioButton();
            label2 = new Label();
            LBListaAgImp = new ListBox();
            LBListaAgMImp = new ListBox();
            LBListaAnImp = new ListBox();
            LBListaAnMImp = new ListBox();
            LBListaFinImp = new ListBox();
            LBListaFinMImp = new ListBox();
            FaixaMenu.SuspendLayout();
            SuspendLayout();
            // 
            // FaixaMenu
            // 
            FaixaMenu.GripStyle = ToolStripGripStyle.Hidden;
            FaixaMenu.Items.AddRange(new ToolStripItem[] { AdicionarTarefa_btn, toolStripSeparator1, toolStripButton2, toolStripSeparator2 });
            FaixaMenu.Location = new Point(0, 0);
            FaixaMenu.Name = "FaixaMenu";
            FaixaMenu.Size = new Size(882, 25);
            FaixaMenu.TabIndex = 0;
            FaixaMenu.Text = "FaixaMenu";
            // 
            // AdicionarTarefa_btn
            // 
            AdicionarTarefa_btn.BackColor = SystemColors.Window;
            AdicionarTarefa_btn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            AdicionarTarefa_btn.Image = Properties.Resources.check;
            AdicionarTarefa_btn.ImageTransparentColor = Color.Magenta;
            AdicionarTarefa_btn.Name = "AdicionarTarefa_btn";
            AdicionarTarefa_btn.Size = new Size(23, 22);
            AdicionarTarefa_btn.ToolTipText = "Adicionar Tarefa";
            AdicionarTarefa_btn.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Remover Tarefa";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // Tarefas_lbl
            // 
            Tarefas_lbl.AutoSize = true;
            Tarefas_lbl.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tarefas_lbl.Location = new Point(56, 90);
            Tarefas_lbl.Name = "Tarefas_lbl";
            Tarefas_lbl.Size = new Size(167, 25);
            Tarefas_lbl.TabIndex = 1;
            Tarefas_lbl.Text = "AGUARDANDO";
            // 
            // DataFim
            // 
            DataFim.AutoSize = true;
            DataFim.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataFim.Location = new Point(344, 90);
            DataFim.Name = "DataFim";
            DataFim.Size = new Size(187, 25);
            DataFim.TabIndex = 2;
            DataFim.Text = "EM ANDAMENTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(682, 90);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 3;
            label1.Text = "FINALIZADO";
            // 
            // LBListaAgSu
            // 
            LBListaAgSu.BackColor = Color.FromArgb(128, 255, 128);
            LBListaAgSu.BorderStyle = BorderStyle.FixedSingle;
            LBListaAgSu.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBListaAgSu.FormattingEnabled = true;
            LBListaAgSu.Location = new Point(12, 326);
            LBListaAgSu.Name = "LBListaAgSu";
            LBListaAgSu.Size = new Size(260, 98);
            LBListaAgSu.TabIndex = 4;
            LBListaAgSu.SelectedIndexChanged += ListaAg_listbox_SelectedIndexChanged;
            // 
            // TarefaAdicionar
            // 
            TarefaAdicionar.Location = new Point(12, 55);
            TarefaAdicionar.Name = "TarefaAdicionar";
            TarefaAdicionar.Size = new Size(249, 23);
            TarefaAdicionar.TabIndex = 5;
            // 
            // Tarefa_lbl
            // 
            Tarefa_lbl.AutoSize = true;
            Tarefa_lbl.Font = new Font("Lato", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tarefa_lbl.Location = new Point(12, 36);
            Tarefa_lbl.Name = "Tarefa_lbl";
            Tarefa_lbl.Size = new Size(213, 16);
            Tarefa_lbl.TabIndex = 6;
            Tarefa_lbl.Text = "Digite a tarefa que deseja adicionar:";
            // 
            // LBListaAnSu
            // 
            LBListaAnSu.BackColor = Color.FromArgb(128, 255, 128);
            LBListaAnSu.BorderStyle = BorderStyle.FixedSingle;
            LBListaAnSu.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBListaAnSu.FormattingEnabled = true;
            LBListaAnSu.Location = new Point(311, 326);
            LBListaAnSu.Name = "LBListaAnSu";
            LBListaAnSu.Size = new Size(260, 98);
            LBListaAnSu.TabIndex = 7;
            LBListaAnSu.SelectedIndexChanged += ListaAn_listbox_SelectedIndexChanged;
            // 
            // LBListaFinSu
            // 
            LBListaFinSu.BackColor = Color.FromArgb(128, 255, 128);
            LBListaFinSu.BorderStyle = BorderStyle.FixedSingle;
            LBListaFinSu.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            LBListaFinSu.FormattingEnabled = true;
            LBListaFinSu.Location = new Point(613, 326);
            LBListaFinSu.Name = "LBListaFinSu";
            LBListaFinSu.Size = new Size(260, 98);
            LBListaFinSu.TabIndex = 8;
            // 
            // MoverDir1
            // 
            MoverDir1.AutoEllipsis = true;
            MoverDir1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoverDir1.Location = new Point(275, 230);
            MoverDir1.Name = "MoverDir1";
            MoverDir1.Size = new Size(30, 20);
            MoverDir1.TabIndex = 9;
            MoverDir1.TabStop = false;
            MoverDir1.Text = ">>";
            MoverDir1.UseVisualStyleBackColor = true;
            MoverDir1.Click += MoverDir1_Click;
            // 
            // MoverDir2
            // 
            MoverDir2.AutoEllipsis = true;
            MoverDir2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoverDir2.Location = new Point(577, 230);
            MoverDir2.Name = "MoverDir2";
            MoverDir2.Size = new Size(30, 20);
            MoverDir2.TabIndex = 13;
            MoverDir2.TabStop = false;
            MoverDir2.Tag = "mover esquerda";
            MoverDir2.Text = ">>";
            MoverDir2.UseVisualStyleBackColor = true;
            MoverDir2.Click += MoverDir2_Click;
            // 
            // MoverEsq2
            // 
            MoverEsq2.AutoEllipsis = true;
            MoverEsq2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoverEsq2.Location = new Point(577, 256);
            MoverEsq2.Name = "MoverEsq2";
            MoverEsq2.Size = new Size(30, 20);
            MoverEsq2.TabIndex = 14;
            MoverEsq2.TabStop = false;
            MoverEsq2.Text = "<<";
            MoverEsq2.UseVisualStyleBackColor = true;
            MoverEsq2.Click += MoverEsq2_Click;
            // 
            // MoverEsq1
            // 
            MoverEsq1.AutoEllipsis = true;
            MoverEsq1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MoverEsq1.Location = new Point(275, 256);
            MoverEsq1.Name = "MoverEsq1";
            MoverEsq1.Size = new Size(30, 20);
            MoverEsq1.TabIndex = 15;
            MoverEsq1.TabStop = false;
            MoverEsq1.Text = "<<";
            MoverEsq1.UseVisualStyleBackColor = true;
            MoverEsq1.Click += MoverEsq1_Click;
            // 
            // semUrgencia_btn
            // 
            semUrgencia_btn.AutoSize = true;
            semUrgencia_btn.Checked = true;
            semUrgencia_btn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            semUrgencia_btn.Location = new Point(288, 58);
            semUrgencia_btn.Name = "semUrgencia_btn";
            semUrgencia_btn.Size = new Size(115, 20);
            semUrgencia_btn.TabIndex = 16;
            semUrgencia_btn.TabStop = true;
            semUrgencia_btn.Text = "Sem Urgência";
            semUrgencia_btn.UseVisualStyleBackColor = true;
            // 
            // importante_btn
            // 
            importante_btn.AutoSize = true;
            importante_btn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importante_btn.Location = new Point(409, 58);
            importante_btn.Name = "importante_btn";
            importante_btn.Size = new Size(98, 20);
            importante_btn.TabIndex = 17;
            importante_btn.Text = "Importante";
            importante_btn.UseVisualStyleBackColor = true;
            importante_btn.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // muitoImportante_btn
            // 
            muitoImportante_btn.AutoSize = true;
            muitoImportante_btn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            muitoImportante_btn.Location = new Point(513, 58);
            muitoImportante_btn.Name = "muitoImportante_btn";
            muitoImportante_btn.Size = new Size(139, 20);
            muitoImportante_btn.TabIndex = 18;
            muitoImportante_btn.Text = "Muito Importante";
            muitoImportante_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 36);
            label2.Name = "label2";
            label2.Size = new Size(182, 16);
            label2.TabIndex = 19;
            label2.Text = "Selecione o nível de prioridade:";
            // 
            // LBListaAgImp
            // 
            LBListaAgImp.BackColor = Color.FromArgb(255, 255, 128);
            LBListaAgImp.BorderStyle = BorderStyle.FixedSingle;
            LBListaAgImp.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBListaAgImp.FormattingEnabled = true;
            LBListaAgImp.Location = new Point(12, 222);
            LBListaAgImp.Name = "LBListaAgImp";
            LBListaAgImp.Size = new Size(260, 98);
            LBListaAgImp.TabIndex = 20;
            // 
            // LBListaAgMImp
            // 
            LBListaAgMImp.BackColor = Color.FromArgb(255, 128, 128);
            LBListaAgMImp.BorderStyle = BorderStyle.FixedSingle;
            LBListaAgMImp.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBListaAgMImp.FormattingEnabled = true;
            LBListaAgMImp.Location = new Point(12, 118);
            LBListaAgMImp.Name = "LBListaAgMImp";
            LBListaAgMImp.Size = new Size(260, 98);
            LBListaAgMImp.TabIndex = 21;
            LBListaAgMImp.SelectedIndexChanged += LBListaAgMImp_SelectedIndexChanged;
            // 
            // LBListaAnImp
            // 
            LBListaAnImp.BackColor = Color.FromArgb(255, 255, 128);
            LBListaAnImp.BorderStyle = BorderStyle.FixedSingle;
            LBListaAnImp.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBListaAnImp.FormattingEnabled = true;
            LBListaAnImp.Location = new Point(311, 222);
            LBListaAnImp.Name = "LBListaAnImp";
            LBListaAnImp.Size = new Size(260, 98);
            LBListaAnImp.TabIndex = 22;
            // 
            // LBListaAnMImp
            // 
            LBListaAnMImp.BackColor = Color.FromArgb(255, 128, 128);
            LBListaAnMImp.BorderStyle = BorderStyle.FixedSingle;
            LBListaAnMImp.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBListaAnMImp.FormattingEnabled = true;
            LBListaAnMImp.Location = new Point(311, 118);
            LBListaAnMImp.Name = "LBListaAnMImp";
            LBListaAnMImp.Size = new Size(260, 98);
            LBListaAnMImp.TabIndex = 23;
            LBListaAnMImp.SelectedIndexChanged += LBListaAnMImp_SelectedIndexChanged;
            // 
            // LBListaFinImp
            // 
            LBListaFinImp.BackColor = Color.FromArgb(255, 255, 128);
            LBListaFinImp.BorderStyle = BorderStyle.FixedSingle;
            LBListaFinImp.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            LBListaFinImp.FormattingEnabled = true;
            LBListaFinImp.Location = new Point(613, 222);
            LBListaFinImp.Name = "LBListaFinImp";
            LBListaFinImp.Size = new Size(260, 98);
            LBListaFinImp.TabIndex = 24;
            LBListaFinImp.SelectedIndexChanged += LBListaFinImp_SelectedIndexChanged;
            // 
            // LBListaFinMImp
            // 
            LBListaFinMImp.BackColor = Color.FromArgb(255, 128, 128);
            LBListaFinMImp.BorderStyle = BorderStyle.FixedSingle;
            LBListaFinMImp.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            LBListaFinMImp.FormattingEnabled = true;
            LBListaFinMImp.Location = new Point(613, 118);
            LBListaFinMImp.Name = "LBListaFinMImp";
            LBListaFinMImp.Size = new Size(260, 98);
            LBListaFinMImp.TabIndex = 25;
            // 
            // Main_frm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(882, 430);
            Controls.Add(LBListaFinMImp);
            Controls.Add(LBListaFinImp);
            Controls.Add(LBListaAnMImp);
            Controls.Add(LBListaAnImp);
            Controls.Add(LBListaAgMImp);
            Controls.Add(LBListaAgImp);
            Controls.Add(label2);
            Controls.Add(muitoImportante_btn);
            Controls.Add(importante_btn);
            Controls.Add(semUrgencia_btn);
            Controls.Add(MoverEsq1);
            Controls.Add(MoverEsq2);
            Controls.Add(MoverDir2);
            Controls.Add(MoverDir1);
            Controls.Add(LBListaFinSu);
            Controls.Add(LBListaAnSu);
            Controls.Add(Tarefa_lbl);
            Controls.Add(TarefaAdicionar);
            Controls.Add(LBListaAgSu);
            Controls.Add(label1);
            Controls.Add(DataFim);
            Controls.Add(Tarefas_lbl);
            Controls.Add(FaixaMenu);
            Font = new Font("Lato", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Main_frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organizador de Tarefas";
            TopMost = true;
            Load += Main_frm_Load;
            FaixaMenu.ResumeLayout(false);
            FaixaMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip FaixaMenu;
        private ToolStripButton AdicionarTarefa_btn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private Label Tarefas_lbl;
        private Label DataFim;
        private Label label1;
        private ListBox LBListaAgSu;
        private TextBox TarefaAdicionar;
        private Label Tarefa_lbl;
        private Button MoverDir2;
        private ListBox LBListaAnSu;
        private ListBox LBListaFinSu;
        private Button MoverDir1;
        private Button MoverEsq2;
        private Button MoverEsq1;
        private RadioButton semUrgencia_btn;
        private RadioButton importante_btn;
        private RadioButton muitoImportante_btn;
        private Label label2;
        private ListBox LBListaAgImp;
        private ListBox LBListaAgMImp;
        private ListBox LBListaAnImp;
        private ListBox LBListaAnMImp;
        private ListBox LBListaFinImp;
        private ListBox LBListaFinMImp;
    }
}
