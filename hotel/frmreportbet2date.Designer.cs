namespace hotel
{
    partial class frmreportbet2date
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
            this.date1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.date2 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codecustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamekolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takhfifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pardakhtiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblreserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.tbl_reserveTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_reserveTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreserveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(254, 50);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(118, 20);
            this.date1.TabIndex = 3;
            this.date1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(43, 50);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(118, 20);
            this.date2.TabIndex = 4;
            this.date2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "از تاریخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "تا تاریخ:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(12, 94);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(116, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "نمایش گزارش";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.date1DataGridViewTextBoxColumn,
            this.date2DataGridViewTextBoxColumn,
            this.coderoomDataGridViewTextBoxColumn,
            this.codecustomerDataGridViewTextBoxColumn,
            this.madrakDataGridViewTextBoxColumn,
            this.jamekolDataGridViewTextBoxColumn,
            this.takhfifDataGridViewTextBoxColumn,
            this.pardakhtiDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.tblreserveBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(10, 150);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(553, 234);
            this.dataGridViewX1.TabIndex = 7;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // date1DataGridViewTextBoxColumn
            // 
            this.date1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date1DataGridViewTextBoxColumn.DataPropertyName = "date1";
            this.date1DataGridViewTextBoxColumn.HeaderText = "از تاریخ";
            this.date1DataGridViewTextBoxColumn.Name = "date1DataGridViewTextBoxColumn";
            // 
            // date2DataGridViewTextBoxColumn
            // 
            this.date2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date2DataGridViewTextBoxColumn.DataPropertyName = "date2";
            this.date2DataGridViewTextBoxColumn.HeaderText = "تا تاریخ";
            this.date2DataGridViewTextBoxColumn.Name = "date2DataGridViewTextBoxColumn";
            // 
            // coderoomDataGridViewTextBoxColumn
            // 
            this.coderoomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coderoomDataGridViewTextBoxColumn.DataPropertyName = "code_room";
            this.coderoomDataGridViewTextBoxColumn.HeaderText = "اتاق";
            this.coderoomDataGridViewTextBoxColumn.Name = "coderoomDataGridViewTextBoxColumn";
            // 
            // codecustomerDataGridViewTextBoxColumn
            // 
            this.codecustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codecustomerDataGridViewTextBoxColumn.DataPropertyName = "code_customer";
            this.codecustomerDataGridViewTextBoxColumn.HeaderText = "مشتری";
            this.codecustomerDataGridViewTextBoxColumn.Name = "codecustomerDataGridViewTextBoxColumn";
            // 
            // madrakDataGridViewTextBoxColumn
            // 
            this.madrakDataGridViewTextBoxColumn.DataPropertyName = "madrak";
            this.madrakDataGridViewTextBoxColumn.HeaderText = "madrak";
            this.madrakDataGridViewTextBoxColumn.Name = "madrakDataGridViewTextBoxColumn";
            this.madrakDataGridViewTextBoxColumn.Visible = false;
            // 
            // jamekolDataGridViewTextBoxColumn
            // 
            this.jamekolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jamekolDataGridViewTextBoxColumn.DataPropertyName = "jamekol";
            this.jamekolDataGridViewTextBoxColumn.HeaderText = "مجموع";
            this.jamekolDataGridViewTextBoxColumn.Name = "jamekolDataGridViewTextBoxColumn";
            // 
            // takhfifDataGridViewTextBoxColumn
            // 
            this.takhfifDataGridViewTextBoxColumn.DataPropertyName = "takhfif";
            this.takhfifDataGridViewTextBoxColumn.HeaderText = "takhfif";
            this.takhfifDataGridViewTextBoxColumn.Name = "takhfifDataGridViewTextBoxColumn";
            this.takhfifDataGridViewTextBoxColumn.Visible = false;
            // 
            // pardakhtiDataGridViewTextBoxColumn
            // 
            this.pardakhtiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pardakhtiDataGridViewTextBoxColumn.DataPropertyName = "pardakhti";
            this.pardakhtiDataGridViewTextBoxColumn.HeaderText = "پرداختی";
            this.pardakhtiDataGridViewTextBoxColumn.Name = "pardakhtiDataGridViewTextBoxColumn";
            // 
            // tblreserveBindingSource
            // 
            this.tblreserveBindingSource.DataMember = "tbl_reserve";
            this.tblreserveBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_reserveTableAdapter
            // 
            this.tbl_reserveTableAdapter.ClearBeforeFill = true;
            // 
            // frmreportbet2date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(570, 396);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Font = new System.Drawing.Font("B Yekan", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmreportbet2date";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم گزارش بین دو تاریخ";
            this.Load += new System.EventHandler(this.frmreportbet2date_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblreserveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePicker date1;
        private FarsiLibrary.Win.Controls.FADatePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tblreserveBindingSource;
        private hotelDataSetTableAdapters.tbl_reserveTableAdapter tbl_reserveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coderoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madrakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamekolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takhfifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pardakhtiDataGridViewTextBoxColumn;
    }
}