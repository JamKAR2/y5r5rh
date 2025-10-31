namespace WindowsFormsApp2
{
    partial class Form1212
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
            this.showtimeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяНачалаСеансаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сеансыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinoDataSet = new WindowsFormsApp2.kinoDataSet();
            this.сеансыTableAdapter = new WindowsFormsApp2.kinoDataSetTableAdapters.СеансыTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showtimeIDDataGridViewTextBoxColumn,
            this.movieIDDataGridViewTextBoxColumn,
            this.hallIDDataGridViewTextBoxColumn,
            this.времяНачалаСеансаDataGridViewTextBoxColumn,
            this.ценаБилетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сеансыBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // showtimeIDDataGridViewTextBoxColumn
            // 
            this.showtimeIDDataGridViewTextBoxColumn.DataPropertyName = "ShowtimeID";
            this.showtimeIDDataGridViewTextBoxColumn.HeaderText = "ShowtimeID";
            this.showtimeIDDataGridViewTextBoxColumn.Name = "showtimeIDDataGridViewTextBoxColumn";
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "HallID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "HallID";
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            // 
            // времяНачалаСеансаDataGridViewTextBoxColumn
            // 
            this.времяНачалаСеансаDataGridViewTextBoxColumn.DataPropertyName = "Время начала сеанса";
            this.времяНачалаСеансаDataGridViewTextBoxColumn.HeaderText = "Время начала сеанса";
            this.времяНачалаСеансаDataGridViewTextBoxColumn.Name = "времяНачалаСеансаDataGridViewTextBoxColumn";
            // 
            // ценаБилетаDataGridViewTextBoxColumn
            // 
            this.ценаБилетаDataGridViewTextBoxColumn.DataPropertyName = "Цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.HeaderText = "Цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.Name = "ценаБилетаDataGridViewTextBoxColumn";
            // 
            // сеансыBindingSource
            // 
            this.сеансыBindingSource.DataMember = "Сеансы";
            this.сеансыBindingSource.DataSource = this.kinoDataSet;
            // 
            // kinoDataSet
            // 
            this.kinoDataSet.DataSetName = "kinoDataSet";
            this.kinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сеансыTableAdapter
            // 
            this.сеансыTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1212
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 310);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1212";
            this.Text = "seans";
            this.Load += new System.EventHandler(this.seans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сеансыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public kinoDataSet kinoDataSet;
        public System.Windows.Forms.BindingSource сеансыBindingSource;
        public kinoDataSetTableAdapters.СеансыTableAdapter сеансыTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn showtimeIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn времяНачалаСеансаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn ценаБилетаDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
    }
}