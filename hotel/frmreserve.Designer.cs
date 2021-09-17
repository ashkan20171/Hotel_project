namespace hotel
{
    partial class frmreserve
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.cmbotagh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tblroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new hotel.hotelDataSet();
            this.cmbmoshtari = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbmoshtari2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.faDatePicker2 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.txtmadrak = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblgheymat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.txtbaghimandeh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcodesearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbl_reserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new hotel.hotelDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpardakhti = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbljamekol = new System.Windows.Forms.Label();
            this.tbl_reserveTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_reserveTableAdapter();
            this.tableAdapterManager = new hotel.hotelDataSetTableAdapters.TableAdapterManager();
            this.tbl_customerTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_customerTableAdapter();
            this.tbl_roomTableAdapter = new hotel.hotelDataSetTableAdapters.tbl_roomTableAdapter();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coderoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codecustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madrakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamekolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takhfifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pardakhtiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.خالیکردناتاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفاطلاعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel1.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(635, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::hotel.Properties.Resources._3;
            this.buttonX1.Location = new System.Drawing.Point(5, 48);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(88, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "ثبت";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtcode
            // 
            // 
            // 
            // 
            this.txtcode.Border.Class = "TextBoxBorder";
            this.txtcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcode.Location = new System.Drawing.Point(530, 7);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(100, 27);
            this.txtcode.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(704, 197);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.buttonX4);
            this.groupPanel4.Controls.Add(this.cmbotagh);
            this.groupPanel4.Controls.Add(this.cmbmoshtari);
            this.groupPanel4.Controls.Add(this.cmbmoshtari2);
            this.groupPanel4.Controls.Add(this.faDatePicker2);
            this.groupPanel4.Controls.Add(this.faDatePicker1);
            this.groupPanel4.Controls.Add(this.txtmadrak);
            this.groupPanel4.Controls.Add(this.label2);
            this.groupPanel4.Controls.Add(this.txtcode);
            this.groupPanel4.Controls.Add(this.label6);
            this.groupPanel4.Controls.Add(this.label5);
            this.groupPanel4.Controls.Add(this.label8);
            this.groupPanel4.Controls.Add(this.lblgheymat);
            this.groupPanel4.Controls.Add(this.label10);
            this.groupPanel4.Controls.Add(this.label7);
            this.groupPanel4.Controls.Add(this.label1);
            this.groupPanel4.Controls.Add(this.buttonX1);
            this.groupPanel4.Location = new System.Drawing.Point(3, 2);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(692, 92);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 7;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(498, 54);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(29, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 7;
            this.buttonX4.Text = "+";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // cmbotagh
            // 
            this.cmbotagh.DataSource = this.tblroomBindingSource;
            this.cmbotagh.DisplayMember = "code";
            this.cmbotagh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbotagh.FormattingEnabled = true;
            this.cmbotagh.ItemHeight = 21;
            this.cmbotagh.Location = new System.Drawing.Point(325, 48);
            this.cmbotagh.Name = "cmbotagh";
            this.cmbotagh.Size = new System.Drawing.Size(121, 27);
            this.cmbotagh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbotagh.TabIndex = 4;
            // 
            // tblroomBindingSource
            // 
            this.tblroomBindingSource.DataMember = "tbl_room";
            this.tblroomBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbmoshtari
            // 
            this.cmbmoshtari.DataSource = this.tblcustomerBindingSource;
            this.cmbmoshtari.DisplayMember = "code";
            this.cmbmoshtari.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmoshtari.FormattingEnabled = true;
            this.cmbmoshtari.ItemHeight = 21;
            this.cmbmoshtari.Location = new System.Drawing.Point(530, 52);
            this.cmbmoshtari.Name = "cmbmoshtari";
            this.cmbmoshtari.Size = new System.Drawing.Size(101, 27);
            this.cmbmoshtari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbmoshtari.TabIndex = 3;
            this.cmbmoshtari.ValueMember = "code";
            this.cmbmoshtari.Visible = false;
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tbl_customer";
            this.tblcustomerBindingSource.DataSource = this.hotelDataSet1;
            // 
            // cmbmoshtari2
            // 
            this.cmbmoshtari2.DataSource = this.tblcustomerBindingSource;
            this.cmbmoshtari2.DisplayMember = "famil";
            this.cmbmoshtari2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmoshtari2.FormattingEnabled = true;
            this.cmbmoshtari2.ItemHeight = 21;
            this.cmbmoshtari2.Location = new System.Drawing.Point(530, 51);
            this.cmbmoshtari2.Name = "cmbmoshtari2";
            this.cmbmoshtari2.Size = new System.Drawing.Size(101, 27);
            this.cmbmoshtari2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbmoshtari2.TabIndex = 3;
            this.cmbmoshtari2.ValueMember = "code";
            // 
            // faDatePicker2
            // 
            this.faDatePicker2.Location = new System.Drawing.Point(130, 7);
            this.faDatePicker2.Name = "faDatePicker2";
            this.faDatePicker2.Size = new System.Drawing.Size(118, 20);
            this.faDatePicker2.TabIndex = 2;
            this.faDatePicker2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(326, 9);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(120, 20);
            this.faDatePicker1.TabIndex = 1;
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // txtmadrak
            // 
            // 
            // 
            // 
            this.txtmadrak.Border.Class = "TextBoxBorder";
            this.txtmadrak.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmadrak.Location = new System.Drawing.Point(130, 48);
            this.txtmadrak.Name = "txtmadrak";
            this.txtmadrak.Size = new System.Drawing.Size(118, 27);
            this.txtmadrak.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(254, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "مدرک:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(254, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "تا تاریخ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(452, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "از تاریخ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(452, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "اتاق:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblgheymat
            // 
            this.lblgheymat.AutoSize = true;
            this.lblgheymat.BackColor = System.Drawing.Color.Transparent;
            this.lblgheymat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblroomBindingSource, "gheymat", true));
            this.lblgheymat.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblgheymat.ForeColor = System.Drawing.Color.Maroon;
            this.lblgheymat.Location = new System.Drawing.Point(29, 6);
            this.lblgheymat.Name = "lblgheymat";
            this.lblgheymat.Size = new System.Drawing.Size(0, 23);
            this.lblgheymat.TabIndex = 0;
            this.lblgheymat.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(68, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "کرایه:";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(636, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "مشتری:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.buttonX2);
            this.groupPanel2.Controls.Add(this.checkBox1);
            this.groupPanel2.Controls.Add(this.buttonX3);
            this.groupPanel2.Controls.Add(this.txtbaghimandeh);
            this.groupPanel2.Controls.Add(this.txtcodesearch);
            this.groupPanel2.Controls.Add(this.label4);
            this.groupPanel2.Controls.Add(this.label9);
            this.groupPanel2.Controls.Add(this.txtpardakhti);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Controls.Add(this.label11);
            this.groupPanel2.Controls.Add(this.lbljamekol);
            this.groupPanel2.Location = new System.Drawing.Point(3, 101);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(692, 85);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 4;
            this.groupPanel2.Click += new System.EventHandler(this.groupPanel2_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(110, 5);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(72, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "محاسبه";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(93, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "اقامت دارد";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(10, 48);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(57, 24);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 3;
            this.buttonX3.Text = "اعمال";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // txtbaghimandeh
            // 
            // 
            // 
            // 
            this.txtbaghimandeh.Border.Class = "TextBoxBorder";
            this.txtbaghimandeh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbaghimandeh.Location = new System.Drawing.Point(243, 47);
            this.txtbaghimandeh.Name = "txtbaghimandeh";
            this.txtbaghimandeh.Size = new System.Drawing.Size(100, 27);
            this.txtbaghimandeh.TabIndex = 2;
            this.txtbaghimandeh.Text = "0";
            // 
            // txtcodesearch
            // 
            // 
            // 
            // 
            this.txtcodesearch.Border.Class = "TextBoxBorder";
            this.txtcodesearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodesearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_reserveBindingSource, "code", true));
            this.txtcodesearch.Location = new System.Drawing.Point(527, 3);
            this.txtcodesearch.Name = "txtcodesearch";
            this.txtcodesearch.Size = new System.Drawing.Size(92, 27);
            this.txtcodesearch.TabIndex = 5;
            // 
            // tbl_reserveBindingSource
            // 
            this.tbl_reserveBindingSource.DataMember = "tbl_reserve";
            this.tbl_reserveBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(625, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "کد رزرو";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(340, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "باقیمانده حساب:";
            // 
            // txtpardakhti
            // 
            // 
            // 
            // 
            this.txtpardakhti.Border.Class = "TextBoxBorder";
            this.txtpardakhti.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpardakhti.Location = new System.Drawing.Point(527, 45);
            this.txtpardakhti.Name = "txtpardakhti";
            this.txtpardakhti.Size = new System.Drawing.Size(92, 27);
            this.txtpardakhti.TabIndex = 0;
            this.txtpardakhti.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(618, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "مبلغ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(338, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "جمع کل حساب:";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbljamekol
            // 
            this.lbljamekol.AutoSize = true;
            this.lbljamekol.BackColor = System.Drawing.Color.Transparent;
            this.lbljamekol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_reserveBindingSource, "jamekol", true));
            this.lbljamekol.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbljamekol.ForeColor = System.Drawing.Color.Maroon;
            this.lbljamekol.Location = new System.Drawing.Point(266, 2);
            this.lbljamekol.Name = "lbljamekol";
            this.lbljamekol.Size = new System.Drawing.Size(0, 23);
            this.lbljamekol.TabIndex = 0;
            this.lbljamekol.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbl_reserveTableAdapter
            // 
            this.tbl_reserveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_customerTableAdapter = null;
            this.tableAdapterManager.tbl_hazinehTableAdapter = null;
            this.tableAdapterManager.tbl_personelTableAdapter = null;
            this.tableAdapterManager.tbl_reserveTableAdapter = this.tbl_reserveTableAdapter;
            this.tableAdapterManager.tbl_roomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = hotel.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_customerTableAdapter
            // 
            this.tbl_customerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.date1DataGridViewTextBoxColumn,
            this.date2DataGridViewTextBoxColumn,
            this.coderoomDataGridViewTextBoxColumn,
            this.codecustomerDataGridViewTextBoxColumn,
            this.madrakDataGridViewTextBoxColumn,
            this.jamekolDataGridViewTextBoxColumn,
            this.takhfifDataGridViewTextBoxColumn,
            this.pardakhtiDataGridViewTextBoxColumn});
            this.dataGridViewX1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewX1.DataSource = this.tbl_reserveBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(9, 28);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(686, 190);
            this.dataGridViewX1.TabIndex = 1;
            this.dataGridViewX1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewX1_UserDeletingRow);
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "کد";
            this.code.Name = "code";
            // 
            // date1DataGridViewTextBoxColumn
            // 
            this.date1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date1DataGridViewTextBoxColumn.DataPropertyName = "date1";
            this.date1DataGridViewTextBoxColumn.HeaderText = "تاریخ شروع";
            this.date1DataGridViewTextBoxColumn.Name = "date1DataGridViewTextBoxColumn";
            // 
            // date2DataGridViewTextBoxColumn
            // 
            this.date2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date2DataGridViewTextBoxColumn.DataPropertyName = "date2";
            this.date2DataGridViewTextBoxColumn.HeaderText = "تاربخ اتمام";
            this.date2DataGridViewTextBoxColumn.Name = "date2DataGridViewTextBoxColumn";
            // 
            // coderoomDataGridViewTextBoxColumn
            // 
            this.coderoomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coderoomDataGridViewTextBoxColumn.DataPropertyName = "code_room";
            this.coderoomDataGridViewTextBoxColumn.HeaderText = "کد اتاق";
            this.coderoomDataGridViewTextBoxColumn.Name = "coderoomDataGridViewTextBoxColumn";
            // 
            // codecustomerDataGridViewTextBoxColumn
            // 
            this.codecustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codecustomerDataGridViewTextBoxColumn.DataPropertyName = "code_customer";
            this.codecustomerDataGridViewTextBoxColumn.HeaderText = "کد مشتری";
            this.codecustomerDataGridViewTextBoxColumn.Name = "codecustomerDataGridViewTextBoxColumn";
            // 
            // madrakDataGridViewTextBoxColumn
            // 
            this.madrakDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madrakDataGridViewTextBoxColumn.DataPropertyName = "madrak";
            this.madrakDataGridViewTextBoxColumn.HeaderText = "مدرک";
            this.madrakDataGridViewTextBoxColumn.Name = "madrakDataGridViewTextBoxColumn";
            // 
            // jamekolDataGridViewTextBoxColumn
            // 
            this.jamekolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jamekolDataGridViewTextBoxColumn.DataPropertyName = "jamekol";
            this.jamekolDataGridViewTextBoxColumn.HeaderText = "جمع کل";
            this.jamekolDataGridViewTextBoxColumn.Name = "jamekolDataGridViewTextBoxColumn";
            // 
            // takhfifDataGridViewTextBoxColumn
            // 
            this.takhfifDataGridViewTextBoxColumn.DataPropertyName = "takhfif";
            this.takhfifDataGridViewTextBoxColumn.HeaderText = "تخفیف";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خالیکردناتاقToolStripMenuItem,
            this.ویرایشاطلاعاتToolStripMenuItem,
            this.حذفاطلاعاتToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // خالیکردناتاقToolStripMenuItem
            // 
            this.خالیکردناتاقToolStripMenuItem.Name = "خالیکردناتاقToolStripMenuItem";
            this.خالیکردناتاقToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.خالیکردناتاقToolStripMenuItem.Text = "خالی کردن اتاق";
            this.خالیکردناتاقToolStripMenuItem.Click += new System.EventHandler(this.خالیکردناتاقToolStripMenuItem_Click);
            // 
            // ویرایشاطلاعاتToolStripMenuItem
            // 
            this.ویرایشاطلاعاتToolStripMenuItem.Name = "ویرایشاطلاعاتToolStripMenuItem";
            this.ویرایشاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ویرایشاطلاعاتToolStripMenuItem.Text = "ویرایش اطلاعات";
            this.ویرایشاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.ویرایشاطلاعاتToolStripMenuItem_Click);
            // 
            // حذفاطلاعاتToolStripMenuItem
            // 
            this.حذفاطلاعاتToolStripMenuItem.Name = "حذفاطلاعاتToolStripMenuItem";
            this.حذفاطلاعاتToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.حذفاطلاعاتToolStripMenuItem.Text = "حذف اطلاعات";
            this.حذفاطلاعاتToolStripMenuItem.Click += new System.EventHandler(this.حذفاطلاعاتToolStripMenuItem_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dataGridViewX1);
            this.groupPanel3.Location = new System.Drawing.Point(12, 216);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(704, 227);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            // 
            // frmreserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmreserve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم رزرو اتاق";
            this.Activated += new System.EventHandler(this.frmreserve_Activated);
            this.Load += new System.EventHandler(this.frmreserve_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_reserveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcode;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbotagh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbmoshtari2;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpardakhti;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmadrak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbaghimandeh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private hotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource tbl_reserveBindingSource;
        private hotelDataSetTableAdapters.tbl_reserveTableAdapter tbl_reserveTableAdapter;
        private hotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private hotelDataSet hotelDataSet1;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private hotelDataSetTableAdapters.tbl_customerTableAdapter tbl_customerTableAdapter;
        private System.Windows.Forms.BindingSource tblroomBindingSource;
        private hotelDataSetTableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.Label lblgheymat;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.Label lbljamekol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodesearch;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbmoshtari;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خالیکردناتاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشاطلاعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفاطلاعاتToolStripMenuItem;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
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