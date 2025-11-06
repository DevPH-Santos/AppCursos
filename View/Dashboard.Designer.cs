namespace AppCursos.UI
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCurso = new System.Windows.Forms.Button();
            this.dataGridCursos = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pk_id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link_curso = new System.Windows.Forms.DataGridViewLinkColumn();
            this.status_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acao = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCurso
            // 
            this.btnAddCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCurso.Location = new System.Drawing.Point(773, 12);
            this.btnAddCurso.Name = "btnAddCurso";
            this.btnAddCurso.Size = new System.Drawing.Size(89, 32);
            this.btnAddCurso.TabIndex = 1;
            this.btnAddCurso.Text = "Adicionar";
            this.btnAddCurso.UseVisualStyleBackColor = true;
            this.btnAddCurso.Click += new System.EventHandler(this.btnAddCurso_Click);
            // 
            // dataGridCursos
            // 
            this.dataGridCursos.AllowUserToAddRows = false;
            this.dataGridCursos.AllowUserToResizeColumns = false;
            this.dataGridCursos.AllowUserToResizeRows = false;
            this.dataGridCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(69)))));
            this.dataGridCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCursos.ColumnHeadersHeight = 35;
            this.dataGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_id_curso,
            this.nome_curso,
            this.link_curso,
            this.status_curso,
            this.Acao});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCursos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCursos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(69)))));
            this.dataGridCursos.Location = new System.Drawing.Point(37, 94);
            this.dataGridCursos.MultiSelect = false;
            this.dataGridCursos.Name = "dataGridCursos";
            this.dataGridCursos.ReadOnly = true;
            this.dataGridCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCursos.RowHeadersVisible = false;
            this.dataGridCursos.Size = new System.Drawing.Size(804, 352);
            this.dataGridCursos.TabIndex = 0;
            this.dataGridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCursos_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(686, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pk_id_curso
            // 
            this.pk_id_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pk_id_curso.HeaderText = "ID";
            this.pk_id_curso.Name = "pk_id_curso";
            this.pk_id_curso.ReadOnly = true;
            this.pk_id_curso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nome_curso
            // 
            this.nome_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome_curso.HeaderText = "Curso";
            this.nome_curso.Name = "nome_curso";
            this.nome_curso.ReadOnly = true;
            this.nome_curso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // link_curso
            // 
            this.link_curso.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.link_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.link_curso.DefaultCellStyle = dataGridViewCellStyle2;
            this.link_curso.HeaderText = "Link";
            this.link_curso.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_curso.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.link_curso.Name = "link_curso";
            this.link_curso.ReadOnly = true;
            this.link_curso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.link_curso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.link_curso.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // status_curso
            // 
            this.status_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_curso.HeaderText = "Status";
            this.status_curso.Name = "status_curso";
            this.status_curso.ReadOnly = true;
            this.status_curso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Acao
            // 
            this.Acao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Acao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Acao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acao.HeaderText = "Ação";
            this.Acao.Name = "Acao";
            this.Acao.ReadOnly = true;
            this.Acao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Acao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Acao.Text = "Deletar";
            this.Acao.UseColumnTextForButtonValue = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(89)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(874, 543);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddCurso);
            this.Controls.Add(this.dataGridCursos);
            this.MinimumSize = new System.Drawing.Size(890, 582);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCurso;
        private System.Windows.Forms.DataGridView dataGridCursos;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_curso;
        private System.Windows.Forms.DataGridViewLinkColumn link_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_curso;
        private System.Windows.Forms.DataGridViewButtonColumn Acao;
    }
}