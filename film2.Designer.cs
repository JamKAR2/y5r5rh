namespace WindowsFormsApp2
{
    partial class film2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длительностьФильмаВМинутахDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыходаФильмаВПрокатDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссерФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рейтингФильмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new WindowsFormsApp2.kinoDataSet();
            this.фильмыTableAdapter = new WindowsFormsApp2.kinoDataSetTableAdapters.ФильмыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.названиеФильмаDataGridViewTextBoxColumn,
            this.длительностьФильмаВМинутахDataGridViewTextBoxColumn,
            this.годВыходаФильмаВПрокатDataGridViewTextBoxColumn,
            this.жанрФильмаDataGridViewTextBoxColumn,
            this.режиссерФильмаDataGridViewTextBoxColumn,
            this.рейтингФильмаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.фильмыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // названиеФильмаDataGridViewTextBoxColumn
            // 
            this.названиеФильмаDataGridViewTextBoxColumn.DataPropertyName = "Название фильма";
            this.названиеФильмаDataGridViewTextBoxColumn.HeaderText = "Название фильма";
            this.названиеФильмаDataGridViewTextBoxColumn.Name = "названиеФильмаDataGridViewTextBoxColumn";
            // 
            // длительностьФильмаВМинутахDataGridViewTextBoxColumn
            // 
            this.длительностьФильмаВМинутахDataGridViewTextBoxColumn.DataPropertyName = "Длительность фильма в минутах";
            this.длительностьФильмаВМинутахDataGridViewTextBoxColumn.HeaderText = "Длительность фильма в минутах";
            this.длительностьФильмаВМинутахDataGridViewTextBoxColumn.Name = "длительностьФильмаВМинутахDataGridViewTextBoxColumn";
            // 
            // годВыходаФильмаВПрокатDataGridViewTextBoxColumn
            // 
            this.годВыходаФильмаВПрокатDataGridViewTextBoxColumn.DataPropertyName = "Год выхода фильма в прокат";
            this.годВыходаФильмаВПрокатDataGridViewTextBoxColumn.HeaderText = "Год выхода фильма в прокат";
            this.годВыходаФильмаВПрокатDataGridViewTextBoxColumn.Name = "годВыходаФильмаВПрокатDataGridViewTextBoxColumn";
            // 
            // жанрФильмаDataGridViewTextBoxColumn
            // 
            this.жанрФильмаDataGridViewTextBoxColumn.DataPropertyName = "Жанр фильма";
            this.жанрФильмаDataGridViewTextBoxColumn.HeaderText = "Жанр фильма";
            this.жанрФильмаDataGridViewTextBoxColumn.Name = "жанрФильмаDataGridViewTextBoxColumn";
            // 
            // режиссерФильмаDataGridViewTextBoxColumn
            // 
            this.режиссерФильмаDataGridViewTextBoxColumn.DataPropertyName = "Режиссер фильма";
            this.режиссерФильмаDataGridViewTextBoxColumn.HeaderText = "Режиссер фильма";
            this.режиссерФильмаDataGridViewTextBoxColumn.Name = "режиссерФильмаDataGridViewTextBoxColumn";
            // 
            // рейтингФильмаDataGridViewTextBoxColumn
            // 
            this.рейтингФильмаDataGridViewTextBoxColumn.DataPropertyName = "Рейтинг фильма";
            this.рейтингФильмаDataGridViewTextBoxColumn.HeaderText = "Рейтинг фильма";
            this.рейтингФильмаDataGridViewTextBoxColumn.Name = "рейтингФильмаDataGridViewTextBoxColumn";
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // film2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "film2";
            this.Text = "film2";
            this.Load += new System.EventHandler(this.film2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public kinoDataSet kinoDataSet;
        public System.Windows.Forms.BindingSource фильмыBindingSource;
        public kinoDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn названиеФильмаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn длительностьФильмаВМинутахDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn годВыходаФильмаВПрокатDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn жанрФильмаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn режиссерФильмаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn рейтингФильмаDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}