
namespace EvidencijaKursnihLista
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaValuceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifraValuteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivZemljeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaziZaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednjiKursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kupovniKursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodajniKursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkeKLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeKLBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(785, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(169, 17);
            this.toolStripStatusLabel1.Text = "Kursna lista na dan : 09.10.2021";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 69);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.oznakaValuceDataGridViewTextBoxColumn,
            this.sifraValuteDataGridViewTextBoxColumn,
            this.nazivZemljeDataGridViewTextBoxColumn,
            this.vaziZaDataGridViewTextBoxColumn,
            this.srednjiKursDataGridViewTextBoxColumn,
            this.kupovniKursDataGridViewTextBoxColumn,
            this.prodajniKursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stavkeKLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(257, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 503);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // oznakaValuceDataGridViewTextBoxColumn
            // 
            this.oznakaValuceDataGridViewTextBoxColumn.DataPropertyName = "OznakaValuce";
            this.oznakaValuceDataGridViewTextBoxColumn.HeaderText = "Oznaka valute";
            this.oznakaValuceDataGridViewTextBoxColumn.Name = "oznakaValuceDataGridViewTextBoxColumn";
            this.oznakaValuceDataGridViewTextBoxColumn.Width = 50;
            // 
            // sifraValuteDataGridViewTextBoxColumn
            // 
            this.sifraValuteDataGridViewTextBoxColumn.DataPropertyName = "SifraValute";
            this.sifraValuteDataGridViewTextBoxColumn.HeaderText = "Šifra valute";
            this.sifraValuteDataGridViewTextBoxColumn.Name = "sifraValuteDataGridViewTextBoxColumn";
            this.sifraValuteDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazivZemljeDataGridViewTextBoxColumn
            // 
            this.nazivZemljeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazivZemljeDataGridViewTextBoxColumn.DataPropertyName = "NazivZemlje";
            this.nazivZemljeDataGridViewTextBoxColumn.HeaderText = "Naziv zemlje";
            this.nazivZemljeDataGridViewTextBoxColumn.Name = "nazivZemljeDataGridViewTextBoxColumn";
            // 
            // vaziZaDataGridViewTextBoxColumn
            // 
            this.vaziZaDataGridViewTextBoxColumn.DataPropertyName = "VaziZa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vaziZaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.vaziZaDataGridViewTextBoxColumn.HeaderText = "Važi za";
            this.vaziZaDataGridViewTextBoxColumn.Name = "vaziZaDataGridViewTextBoxColumn";
            this.vaziZaDataGridViewTextBoxColumn.Width = 50;
            // 
            // srednjiKursDataGridViewTextBoxColumn
            // 
            this.srednjiKursDataGridViewTextBoxColumn.DataPropertyName = "SrednjiKurs";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.srednjiKursDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.srednjiKursDataGridViewTextBoxColumn.HeaderText = "Srednji kurs";
            this.srednjiKursDataGridViewTextBoxColumn.Name = "srednjiKursDataGridViewTextBoxColumn";
            this.srednjiKursDataGridViewTextBoxColumn.Width = 80;
            // 
            // kupovniKursDataGridViewTextBoxColumn
            // 
            this.kupovniKursDataGridViewTextBoxColumn.DataPropertyName = "KupovniKurs";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            this.kupovniKursDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.kupovniKursDataGridViewTextBoxColumn.HeaderText = "Kupovni kurs";
            this.kupovniKursDataGridViewTextBoxColumn.Name = "kupovniKursDataGridViewTextBoxColumn";
            this.kupovniKursDataGridViewTextBoxColumn.Width = 80;
            // 
            // prodajniKursDataGridViewTextBoxColumn
            // 
            this.prodajniKursDataGridViewTextBoxColumn.DataPropertyName = "ProdajniKurs";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N4";
            dataGridViewCellStyle4.NullValue = null;
            this.prodajniKursDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.prodajniKursDataGridViewTextBoxColumn.HeaderText = "Prodajni kurs";
            this.prodajniKursDataGridViewTextBoxColumn.Name = "prodajniKursDataGridViewTextBoxColumn";
            this.prodajniKursDataGridViewTextBoxColumn.Width = 80;
            // 
            // stavkeKLBindingSource
            // 
            this.stavkeKLBindingSource.DataSource = typeof(EvidencijaKursnihLista.Model.StavkeKL);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "10";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(6, 19);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Kupovni";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(6, 48);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(99, 23);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Prodajni";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(176, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "%";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(176, 48);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(20, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(29, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preračunaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kusna lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeKLBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stavkeKLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaValuceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifraValuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivZemljeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaziZaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednjiKursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kupovniKursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodajniKursDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

