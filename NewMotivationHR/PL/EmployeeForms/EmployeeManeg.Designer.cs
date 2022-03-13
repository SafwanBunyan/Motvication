namespace NewMotivationHR.PL.EmployeeForms
{
    partial class EmployeeManeg
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransportation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Emp_IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SalaryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TransportationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sectionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmp_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSalary = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTransportation = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForsection = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.Food_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForFood_ = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.colFood_ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransportationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTransportation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsection)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Food_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFood_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Emp_IDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SalaryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TransportationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.sectionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Food_TextEdit);
            this.dataLayoutControl1.DataSource = this.employeeBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 46);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 404);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeeBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 331);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataSource = typeof(NewMotivationHR.DB.Employee);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colEmp_ID,
            this.colsection,
            this.colSalary,
            this.colTransportation,
            this.colFood_});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colEmp_ID
            // 
            this.colEmp_ID.FieldName = "Emp_ID";
            this.colEmp_ID.Name = "colEmp_ID";
            this.colEmp_ID.Visible = true;
            this.colEmp_ID.VisibleIndex = 2;
            // 
            // colsection
            // 
            this.colsection.FieldName = "section";
            this.colsection.Name = "colsection";
            this.colsection.Visible = true;
            this.colsection.VisibleIndex = 3;
            // 
            // colSalary
            // 
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 4;
            // 
            // colTransportation
            // 
            this.colTransportation.FieldName = "Transportation";
            this.colTransportation.Name = "colTransportation";
            this.colTransportation.Visible = true;
            this.colTransportation.VisibleIndex = 5;
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(535, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(191, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(NewMotivationHR.DB.Employee);
            // 
            // Emp_IDTextEdit
            // 
            this.Emp_IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Emp_ID", true));
            this.Emp_IDTextEdit.Location = new System.Drawing.Point(289, 12);
            this.Emp_IDTextEdit.Name = "Emp_IDTextEdit";
            this.Emp_IDTextEdit.Size = new System.Drawing.Size(180, 20);
            this.Emp_IDTextEdit.StyleController = this.dataLayoutControl1;
            this.Emp_IDTextEdit.TabIndex = 5;
            // 
            // SalaryTextEdit
            // 
            this.SalaryTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Salary", true));
            this.SalaryTextEdit.Location = new System.Drawing.Point(535, 36);
            this.SalaryTextEdit.Name = "SalaryTextEdit";
            this.SalaryTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SalaryTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SalaryTextEdit.Properties.Mask.EditMask = "N0";
            this.SalaryTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SalaryTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SalaryTextEdit.Size = new System.Drawing.Size(191, 20);
            this.SalaryTextEdit.StyleController = this.dataLayoutControl1;
            this.SalaryTextEdit.TabIndex = 6;
            // 
            // TransportationTextEdit
            // 
            this.TransportationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Transportation", true));
            this.TransportationTextEdit.Location = new System.Drawing.Point(289, 36);
            this.TransportationTextEdit.Name = "TransportationTextEdit";
            this.TransportationTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TransportationTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TransportationTextEdit.Properties.Mask.EditMask = "N0";
            this.TransportationTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TransportationTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TransportationTextEdit.Size = new System.Drawing.Size(180, 20);
            this.TransportationTextEdit.StyleController = this.dataLayoutControl1;
            this.TransportationTextEdit.TabIndex = 9;
            // 
            // sectionTextEdit
            // 
            this.sectionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "section", true));
            this.sectionTextEdit.Location = new System.Drawing.Point(12, 12);
            this.sectionTextEdit.Name = "sectionTextEdit";
            this.sectionTextEdit.Size = new System.Drawing.Size(211, 20);
            this.sectionTextEdit.StyleController = this.dataLayoutControl1;
            this.sectionTextEdit.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 404);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForEmp_ID,
            this.layoutControlItem1,
            this.ItemForSalary,
            this.ItemForTransportation,
            this.ItemForsection,
            this.ItemForFood_,
            this.simpleSeparator1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 384);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(523, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(257, 24);
            this.ItemForName.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForEmp_ID
            // 
            this.ItemForEmp_ID.Control = this.Emp_IDTextEdit;
            this.ItemForEmp_ID.Location = new System.Drawing.Point(277, 0);
            this.ItemForEmp_ID.Name = "ItemForEmp_ID";
            this.ItemForEmp_ID.Size = new System.Drawing.Size(246, 24);
            this.ItemForEmp_ID.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 335);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForSalary
            // 
            this.ItemForSalary.Control = this.SalaryTextEdit;
            this.ItemForSalary.Location = new System.Drawing.Point(523, 24);
            this.ItemForSalary.Name = "ItemForSalary";
            this.ItemForSalary.Size = new System.Drawing.Size(257, 24);
            this.ItemForSalary.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForTransportation
            // 
            this.ItemForTransportation.Control = this.TransportationTextEdit;
            this.ItemForTransportation.Location = new System.Drawing.Point(277, 24);
            this.ItemForTransportation.Name = "ItemForTransportation";
            this.ItemForTransportation.Size = new System.Drawing.Size(246, 24);
            this.ItemForTransportation.TextSize = new System.Drawing.Size(59, 13);
            // 
            // ItemForsection
            // 
            this.ItemForsection.Control = this.sectionTextEdit;
            this.ItemForsection.Location = new System.Drawing.Point(0, 0);
            this.ItemForsection.Name = "ItemForsection";
            this.ItemForsection.Size = new System.Drawing.Size(277, 24);
            this.ItemForsection.TextSize = new System.Drawing.Size(59, 13);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_delet);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
            this.panel1.TabIndex = 7;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(182, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "طباعة";
            // 
            // btn_delet
            // 
            this.btn_delet.Location = new System.Drawing.Point(263, 4);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(75, 23);
            this.btn_delet.TabIndex = 3;
            this.btn_delet.Text = "حذف";
            this.btn_delet.Click += new System.EventHandler(this.btn_delet_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(344, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "تعديل";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(425, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(506, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Food_TextEdit
            // 
            this.Food_TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Food_", true));
            this.Food_TextEdit.Location = new System.Drawing.Point(12, 36);
            this.Food_TextEdit.Name = "Food_TextEdit";
            this.Food_TextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Food_TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Food_TextEdit.Properties.Mask.EditMask = "N0";
            this.Food_TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Food_TextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Food_TextEdit.Size = new System.Drawing.Size(211, 20);
            this.Food_TextEdit.StyleController = this.dataLayoutControl1;
            this.Food_TextEdit.TabIndex = 11;
            // 
            // ItemForFood_
            // 
            this.ItemForFood_.Control = this.Food_TextEdit;
            this.ItemForFood_.Location = new System.Drawing.Point(0, 24);
            this.ItemForFood_.Name = "ItemForFood_";
            this.ItemForFood_.Size = new System.Drawing.Size(277, 24);
            this.ItemForFood_.TextSize = new System.Drawing.Size(59, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 383);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(780, 1);
            // 
            // colFood_
            // 
            this.colFood_.FieldName = "Food_";
            this.colFood_.Name = "colFood_";
            this.colFood_.Visible = true;
            this.colFood_.VisibleIndex = 6;
            // 
            // EmployeeManeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeManeg";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الموظفين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransportationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmp_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTransportation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsection)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Food_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFood_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit Emp_IDTextEdit;
        private DevExpress.XtraEditors.TextEdit SalaryTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmp_ID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSalary;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delet;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colsection;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportation;
        private DevExpress.XtraEditors.TextEdit TransportationTextEdit;
        private DevExpress.XtraEditors.TextEdit sectionTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTransportation;
        private DevExpress.XtraLayout.LayoutControlItem ItemForsection;
        private DevExpress.XtraGrid.Columns.GridColumn colFood_;
        private DevExpress.XtraEditors.TextEdit Food_TextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFood_;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}