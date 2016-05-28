namespace shahmatkaLocalDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxPlavka = new System.Windows.Forms.TextBox();
            this.textBoxNomer = new System.Windows.Forms.TextBox();
            this.comboBoxStorona = new System.Windows.Forms.ComboBox();
            this.comboBoxFio = new System.Windows.Forms.ComboBox();
            this.spisokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new shahmatkaLocalDB.Database1DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.spisokTableAdapter = new shahmatkaLocalDB.Database1DataSetTableAdapters.spisokTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.spisokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new shahmatkaLocalDB.Database1DataSet1();
            this.bazaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaTableAdapter = new shahmatkaLocalDB.Database1DataSet1TableAdapters.bazaTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new shahmatkaLocalDB.Database1DataSet2();
            this.bazaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaTableAdapter1 = new shahmatkaLocalDB.Database1DataSet2TableAdapters.bazaTableAdapter();
            this.plavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spisokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlavka
            // 
            this.textBoxPlavka.Location = new System.Drawing.Point(47, 57);
            this.textBoxPlavka.Name = "textBoxPlavka";
            this.textBoxPlavka.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlavka.TabIndex = 0;
            // 
            // textBoxNomer
            // 
            this.textBoxNomer.Location = new System.Drawing.Point(173, 57);
            this.textBoxNomer.Name = "textBoxNomer";
            this.textBoxNomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomer.TabIndex = 1;
            // 
            // comboBoxStorona
            // 
            this.comboBoxStorona.AutoCompleteCustomSource.AddRange(new string[] {
            "В/С",
            "Н/С"});
            this.comboBoxStorona.FormattingEnabled = true;
            this.comboBoxStorona.Items.AddRange(new object[] {
            "В/С",
            "Н/С"});
            this.comboBoxStorona.Location = new System.Drawing.Point(297, 55);
            this.comboBoxStorona.Name = "comboBoxStorona";
            this.comboBoxStorona.Size = new System.Drawing.Size(62, 21);
            this.comboBoxStorona.TabIndex = 2;
            // 
            // comboBoxFio
            // 
            this.comboBoxFio.DataSource = this.spisokBindingSource;
            this.comboBoxFio.DisplayMember = "tokar";
            this.comboBoxFio.FormattingEnabled = true;
            this.comboBoxFio.Location = new System.Drawing.Point(388, 57);
            this.comboBoxFio.Name = "comboBoxFio";
            this.comboBoxFio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFio.TabIndex = 3;
            // 
            // spisokBindingSource
            // 
            this.spisokBindingSource.DataMember = "spisok";
            this.spisokBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spisokTableAdapter
            // 
            this.spisokTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plavkaDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.storonaDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bazaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // spisokBindingSource1
            // 
            this.spisokBindingSource1.DataMember = "spisok";
            this.spisokBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bazaBindingSource
            // 
            this.bazaBindingSource.DataMember = "baza";
            this.bazaBindingSource.DataSource = this.database1DataSet1;
            // 
            // bazaTableAdapter
            // 
            this.bazaTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bazaBindingSource1
            // 
            this.bazaBindingSource1.DataMember = "baza";
            this.bazaBindingSource1.DataSource = this.database1DataSet2;
            // 
            // bazaTableAdapter1
            // 
            this.bazaTableAdapter1.ClearBeforeFill = true;
            // 
            // plavkaDataGridViewTextBoxColumn
            // 
            this.plavkaDataGridViewTextBoxColumn.DataPropertyName = "plavka";
            this.plavkaDataGridViewTextBoxColumn.HeaderText = "plavka";
            this.plavkaDataGridViewTextBoxColumn.Name = "plavkaDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // storonaDataGridViewTextBoxColumn
            // 
            this.storonaDataGridViewTextBoxColumn.DataPropertyName = "storona";
            this.storonaDataGridViewTextBoxColumn.HeaderText = "storona";
            this.storonaDataGridViewTextBoxColumn.Name = "storonaDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 320);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxFio);
            this.Controls.Add(this.comboBoxStorona);
            this.Controls.Add(this.textBoxNomer);
            this.Controls.Add(this.textBoxPlavka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spisokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlavka;
        private System.Windows.Forms.TextBox textBoxNomer;
        private System.Windows.Forms.ComboBox comboBoxStorona;
        private System.Windows.Forms.ComboBox comboBoxFio;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource spisokBindingSource;
        private Database1DataSetTableAdapters.spisokTableAdapter spisokTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spisokBindingSource1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource bazaBindingSource;
        private Database1DataSet1TableAdapters.bazaTableAdapter bazaTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource bazaBindingSource1;
        private Database1DataSet2TableAdapters.bazaTableAdapter bazaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
    }
}

