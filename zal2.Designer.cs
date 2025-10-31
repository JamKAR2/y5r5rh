namespace WindowsFormsApp2
{
    partial class zal2
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
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinemaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеЗалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вместимостьЗалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new WindowsFormsApp2.kinoDataSet();
            this.залыTableAdapter = new WindowsFormsApp2.kinoDataSetTableAdapters.ЗалыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hallIDDataGridViewTextBoxColumn,
            this.cinemaIDDataGridViewTextBoxColumn,
            this.названиеЗалаDataGridViewTextBoxColumn,
            this.вместимостьЗалаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.залыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 314);
            this.dataGridView1.TabIndex = 1;
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "HallID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "HallID";
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            // 
            // cinemaIDDataGridViewTextBoxColumn
            // 
            this.cinemaIDDataGridViewTextBoxColumn.DataPropertyName = "CinemaID";
            this.cinemaIDDataGridViewTextBoxColumn.HeaderText = "CinemaID";
            this.cinemaIDDataGridViewTextBoxColumn.Name = "cinemaIDDataGridViewTextBoxColumn";
            // 
            // названиеЗалаDataGridViewTextBoxColumn
            // 
            this.названиеЗалаDataGridViewTextBoxColumn.DataPropertyName = "Название зала";
            this.названиеЗалаDataGridViewTextBoxColumn.HeaderText = "Название зала";
            this.названиеЗалаDataGridViewTextBoxColumn.Name = "названиеЗалаDataGridViewTextBoxColumn";
            // 
            // вместимостьЗалаDataGridViewTextBoxColumn
            // 
            this.вместимостьЗалаDataGridViewTextBoxColumn.DataPropertyName = "Вместимость зала";
            this.вместимостьЗалаDataGridViewTextBoxColumn.HeaderText = "Вместимость зала";
            this.вместимостьЗалаDataGridViewTextBoxColumn.Name = "вместимостьЗалаDataGridViewTextBoxColumn";
            // 
            // залыBindingSource
            // 
            this.залыBindingSource.DataMember = "Залы";
            this.залыBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залыTableAdapter
            // 
            this.залыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "zal2";
            this.Text = "zal2";
            this.Load += new System.EventHandler(this.zal2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public kinoDataSet kinoDataSet;
        public System.Windows.Forms.BindingSource залыBindingSource;
        public kinoDataSetTableAdapters.ЗалыTableAdapter залыTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn cinemaIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn названиеЗалаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn вместимостьЗалаDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}