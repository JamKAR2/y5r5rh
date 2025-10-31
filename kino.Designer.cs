namespace WindowsFormsApp2
{
    partial class kino
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
            this.cinemaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеКинотеатраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресКинотеатраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кинотеатрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new WindowsFormsApp2.kinoDataSet();
            this.кинотеатрыTableAdapter = new WindowsFormsApp2.kinoDataSetTableAdapters.КинотеатрыTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cinemaIDDataGridViewTextBoxColumn,
            this.названиеКинотеатраDataGridViewTextBoxColumn,
            this.адресКинотеатраDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.кинотеатрыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // cinemaIDDataGridViewTextBoxColumn
            // 
            this.cinemaIDDataGridViewTextBoxColumn.DataPropertyName = "CinemaID";
            this.cinemaIDDataGridViewTextBoxColumn.HeaderText = "CinemaID";
            this.cinemaIDDataGridViewTextBoxColumn.Name = "cinemaIDDataGridViewTextBoxColumn";
            // 
            // названиеКинотеатраDataGridViewTextBoxColumn
            // 
            this.названиеКинотеатраDataGridViewTextBoxColumn.DataPropertyName = "Название кинотеатра";
            this.названиеКинотеатраDataGridViewTextBoxColumn.HeaderText = "Название кинотеатра";
            this.названиеКинотеатраDataGridViewTextBoxColumn.Name = "названиеКинотеатраDataGridViewTextBoxColumn";
            // 
            // адресКинотеатраDataGridViewTextBoxColumn
            // 
            this.адресКинотеатраDataGridViewTextBoxColumn.DataPropertyName = "Адрес кинотеатра";
            this.адресКинотеатраDataGridViewTextBoxColumn.HeaderText = "Адрес кинотеатра";
            this.адресКинотеатраDataGridViewTextBoxColumn.Name = "адресКинотеатраDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // кинотеатрыBindingSource
            // 
            this.кинотеатрыBindingSource.DataMember = "Кинотеатры";
            this.кинотеатрыBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кинотеатрыTableAdapter
            // 
            this.кинотеатрыTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 277);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kino";
            this.Text = "kino";
            this.Load += new System.EventHandler(this.kino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public kinoDataSet kinoDataSet;
        public System.Windows.Forms.BindingSource кинотеатрыBindingSource;
        public kinoDataSetTableAdapters.КинотеатрыTableAdapter кинотеатрыTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn cinemaIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn названиеКинотеатраDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn адресКинотеатраDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
    }
}