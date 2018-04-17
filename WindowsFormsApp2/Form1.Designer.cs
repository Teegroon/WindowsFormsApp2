namespace WindowsFormsApp2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCondom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCondom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.condomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подготовкаDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подготовкаDataSet = new WindowsFormsApp2.подготовкаDataSet();
            this.condomTableAdapter = new WindowsFormsApp2.подготовкаDataSetTableAdapters.condomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подготовкаDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подготовкаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCondom,
            this.NameCondom,
            this.Units,
            this.col});
            this.dataGridView1.Location = new System.Drawing.Point(117, 830);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(2987, 1421);
            this.dataGridView1.TabIndex = 0;
            // 
            // idCondom
            // 
            this.idCondom.HeaderText = "Ид Презерватива";
            this.idCondom.Name = "idCondom";
            this.idCondom.ReadOnly = true;
            // 
            // NameCondom
            // 
            this.NameCondom.HeaderText = "Наименование";
            this.NameCondom.Name = "NameCondom";
            this.NameCondom.ReadOnly = true;
            // 
            // Units
            // 
            this.Units.HeaderText = "Единицы измерения";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // col
            // 
            this.col.HeaderText = "Количество";
            this.col.Name = "col";
            this.col.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.condomBindingSource;
            this.comboBox1.DisplayMember = "Units";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2600, 561);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(491, 84);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Units";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // condomBindingSource
            // 
            this.condomBindingSource.DataMember = "condom";
            this.condomBindingSource.DataSource = this.подготовкаDataSetBindingSource;
            // 
            // подготовкаDataSetBindingSource
            // 
            this.подготовкаDataSetBindingSource.DataSource = this.подготовкаDataSet;
            this.подготовкаDataSetBindingSource.Position = 0;
            // 
            // подготовкаDataSet
            // 
            this.подготовкаDataSet.DataSetName = "подготовкаDataSet";
            this.подготовкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condomTableAdapter
            // 
            this.condomTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 76F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2628, 881);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(12, 18, 12, 18);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подготовкаDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подготовкаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCondom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCondom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.BindingSource подготовкаDataSetBindingSource;
        private подготовкаDataSet подготовкаDataSet;
        private System.Windows.Forms.BindingSource condomBindingSource;
        private подготовкаDataSetTableAdapters.condomTableAdapter condomTableAdapter;
    }
}

