namespace NewMotivationHR.PL.food
{
    partial class frmfood
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Genrat_Salary = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.foodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthOfAcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFood_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEarningWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfEnteriy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonthOfAcountImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Food_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EarningWorkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NetFoodTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Employee_idLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMonthOfAcount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNetFood = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFood_ = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEarningWork = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmployee_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthOfAcountImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EarningWorkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetFoodTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_idLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonthOfAcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFood_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEarningWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Genrat_Salary);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_delet);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 10;
            // 
            // btn_Genrat_Salary
            // 
            this.btn_Genrat_Salary.Location = new System.Drawing.Point(174, 4);
            this.btn_Genrat_Salary.Name = "btn_Genrat_Salary";
            this.btn_Genrat_Salary.Size = new System.Drawing.Size(83, 23);
            this.btn_Genrat_Salary.TabIndex = 5;
            this.btn_Genrat_Salary.Text = "توليد المواصلات";
            this.btn_Genrat_Salary.Click += new System.EventHandler(this.btn_Genrat_Salary_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(93, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "طباعة";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_delet
            // 
            this.btn_delet.Location = new System.Drawing.Point(263, 4);
            this.btn_delet.Name = "btn_delet";
            this.btn_delet.Size = new System.Drawing.Size(75, 23);
            this.btn_delet.TabIndex = 3;
            this.btn_delet.Text = "حذف";
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.MonthOfAcountImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.Food_TextEdit);
            this.dataLayoutControl1.Controls.Add(this.EarningWorkTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NetFoodTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Employee_idLookUpEdit);
            this.dataLayoutControl1.DataSource = this.foodBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 38);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 412);
            this.dataLayoutControl1.TabIndex = 11;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.foodBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 340);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // foodBindingSource1
            // 
            this.foodBindingSource1.DataSource = typeof(NewMotivationHR.DB.Food);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEmployee_id,
            this.colMonthOfAcount,
            this.colFood_,
            this.colEarningWork,
            this.colNetFood,
            this.colDateOfEnteriy,
            this.colEmployee});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colEmployee_id
            // 
            this.colEmployee_id.FieldName = "Employee.Name";
            this.colEmployee_id.Name = "colEmployee_id";
            this.colEmployee_id.Visible = true;
            this.colEmployee_id.VisibleIndex = 1;
            // 
            // colMonthOfAcount
            // 
            this.colMonthOfAcount.FieldName = "MonthOfAcount";
            this.colMonthOfAcount.Name = "colMonthOfAcount";
            this.colMonthOfAcount.Visible = true;
            this.colMonthOfAcount.VisibleIndex = 2;
            // 
            // colFood_
            // 
            this.colFood_.FieldName = "Food_";
            this.colFood_.Name = "colFood_";
            this.colFood_.Visible = true;
            this.colFood_.VisibleIndex = 3;
            // 
            // colEarningWork
            // 
            this.colEarningWork.FieldName = "EarningWork";
            this.colEarningWork.Name = "colEarningWork";
            this.colEarningWork.OptionsColumn.ReadOnly = true;
            this.colEarningWork.Visible = true;
            this.colEarningWork.VisibleIndex = 4;
            // 
            // colNetFood
            // 
            this.colNetFood.FieldName = "NetFood";
            this.colNetFood.Name = "colNetFood";
            this.colNetFood.Visible = true;
            this.colNetFood.VisibleIndex = 5;
            // 
            // colDateOfEnteriy
            // 
            this.colDateOfEnteriy.FieldName = "DateOfEnteriy";
            this.colDateOfEnteriy.Name = "colDateOfEnteriy";
            this.colDateOfEnteriy.Visible = true;
            this.colDateOfEnteriy.VisibleIndex = 6;
            // 
            // colEmployee
            // 
            this.colEmployee.FieldName = "Employee_id";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 7;
            // 
            // MonthOfAcountImageComboBoxEdit
            // 
            this.MonthOfAcountImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "MonthOfAcount", true));
            this.MonthOfAcountImageComboBoxEdit.Location = new System.Drawing.Point(12, 12);
            this.MonthOfAcountImageComboBoxEdit.Name = "MonthOfAcountImageComboBoxEdit";
            this.MonthOfAcountImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.MonthOfAcountImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.MonthOfAcountImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MonthOfAcountImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("يناير", NewMotivationHR.DB.Enume.Month.يناير, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("فبراير", NewMotivationHR.DB.Enume.Month.فبراير, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("مارس", NewMotivationHR.DB.Enume.Month.مارس, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("إبريل", NewMotivationHR.DB.Enume.Month.إبريل, 3),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("مايو", NewMotivationHR.DB.Enume.Month.مايو, 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("يونيو", NewMotivationHR.DB.Enume.Month.يونيو, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("يوليو", NewMotivationHR.DB.Enume.Month.يوليو, 6),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("اغسطس", NewMotivationHR.DB.Enume.Month.اغسطس, 7),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("سبتمبر", NewMotivationHR.DB.Enume.Month.سبتمبر, 8),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("اكتوبر", NewMotivationHR.DB.Enume.Month.اكتوبر, 9),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("نوفمبر", NewMotivationHR.DB.Enume.Month.نوفمبر, 10),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("ديسمبر", NewMotivationHR.DB.Enume.Month.ديسمبر, 11)});
            this.MonthOfAcountImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.MonthOfAcountImageComboBoxEdit.Size = new System.Drawing.Size(304, 20);
            this.MonthOfAcountImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.MonthOfAcountImageComboBoxEdit.TabIndex = 5;
            this.MonthOfAcountImageComboBoxEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.MonthOfAcountImageComboBoxEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataSource = typeof(NewMotivationHR.DB.Food);
            // 
            // Food_TextEdit
            // 
            this.Food_TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "Food_", true));
            this.Food_TextEdit.Location = new System.Drawing.Point(515, 36);
            this.Food_TextEdit.Name = "Food_TextEdit";
            this.Food_TextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Food_TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Food_TextEdit.Properties.Mask.EditMask = "N0";
            this.Food_TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Food_TextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Food_TextEdit.Properties.ReadOnly = true;
            this.Food_TextEdit.Size = new System.Drawing.Size(191, 20);
            this.Food_TextEdit.StyleController = this.dataLayoutControl1;
            this.Food_TextEdit.TabIndex = 6;
            this.Food_TextEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.Food_TextEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // EarningWorkTextEdit
            // 
            this.EarningWorkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "EarningWork", true));
            this.EarningWorkTextEdit.Location = new System.Drawing.Point(234, 36);
            this.EarningWorkTextEdit.Name = "EarningWorkTextEdit";
            this.EarningWorkTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.EarningWorkTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EarningWorkTextEdit.Properties.Mask.EditMask = "N0";
            this.EarningWorkTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.EarningWorkTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.EarningWorkTextEdit.Properties.ReadOnly = true;
            this.EarningWorkTextEdit.Size = new System.Drawing.Size(195, 20);
            this.EarningWorkTextEdit.StyleController = this.dataLayoutControl1;
            this.EarningWorkTextEdit.TabIndex = 7;
            this.EarningWorkTextEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.EarningWorkTextEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // NetFoodTextEdit
            // 
            this.NetFoodTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "NetFood", true));
            this.NetFoodTextEdit.Location = new System.Drawing.Point(12, 36);
            this.NetFoodTextEdit.Name = "NetFoodTextEdit";
            this.NetFoodTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NetFoodTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NetFoodTextEdit.Properties.Mask.EditMask = "N0";
            this.NetFoodTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NetFoodTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NetFoodTextEdit.Properties.ReadOnly = true;
            this.NetFoodTextEdit.Size = new System.Drawing.Size(136, 20);
            this.NetFoodTextEdit.StyleController = this.dataLayoutControl1;
            this.NetFoodTextEdit.TabIndex = 8;
            this.NetFoodTextEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.NetFoodTextEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // Employee_idLookUpEdit
            // 
            this.Employee_idLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.foodBindingSource, "Employee_id", true));
            this.Employee_idLookUpEdit.Location = new System.Drawing.Point(402, 12);
            this.Employee_idLookUpEdit.Name = "Employee_idLookUpEdit";
            this.Employee_idLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Employee_idLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Employee_idLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Employee_idLookUpEdit.Properties.NullText = "";
            this.Employee_idLookUpEdit.Size = new System.Drawing.Size(304, 20);
            this.Employee_idLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Employee_idLookUpEdit.TabIndex = 10;
            this.Employee_idLookUpEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.Employee_idLookUpEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 412);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMonthOfAcount,
            this.ItemForNetFood,
            this.ItemForFood_,
            this.ItemForEarningWork,
            this.layoutControlItem1,
            this.ItemForEmployee_id});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 392);
            // 
            // ItemForMonthOfAcount
            // 
            this.ItemForMonthOfAcount.Control = this.MonthOfAcountImageComboBoxEdit;
            this.ItemForMonthOfAcount.Location = new System.Drawing.Point(0, 0);
            this.ItemForMonthOfAcount.Name = "ItemForMonthOfAcount";
            this.ItemForMonthOfAcount.Size = new System.Drawing.Size(390, 24);
            this.ItemForMonthOfAcount.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForNetFood
            // 
            this.ItemForNetFood.Control = this.NetFoodTextEdit;
            this.ItemForNetFood.Location = new System.Drawing.Point(0, 24);
            this.ItemForNetFood.Name = "ItemForNetFood";
            this.ItemForNetFood.Size = new System.Drawing.Size(222, 24);
            this.ItemForNetFood.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForFood_
            // 
            this.ItemForFood_.Control = this.Food_TextEdit;
            this.ItemForFood_.Location = new System.Drawing.Point(503, 24);
            this.ItemForFood_.Name = "ItemForFood_";
            this.ItemForFood_.Size = new System.Drawing.Size(277, 24);
            this.ItemForFood_.TextSize = new System.Drawing.Size(70, 13);
            // 
            // ItemForEarningWork
            // 
            this.ItemForEarningWork.Control = this.EarningWorkTextEdit;
            this.ItemForEarningWork.Location = new System.Drawing.Point(222, 24);
            this.ItemForEarningWork.Name = "ItemForEarningWork";
            this.ItemForEarningWork.Size = new System.Drawing.Size(281, 24);
            this.ItemForEarningWork.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 344);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForEmployee_id
            // 
            this.ItemForEmployee_id.Control = this.Employee_idLookUpEdit;
            this.ItemForEmployee_id.Location = new System.Drawing.Point(390, 0);
            this.ItemForEmployee_id.Name = "ItemForEmployee_id";
            this.ItemForEmployee_id.Size = new System.Drawing.Size(390, 24);
            this.ItemForEmployee_id.TextSize = new System.Drawing.Size(70, 13);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(NewMotivationHR.DB.Employee);
            // 
            // frmfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmfood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmfood";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthOfAcountImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EarningWorkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetFoodTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_idLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonthOfAcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFood_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEarningWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_Genrat_Salary;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delet;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource foodBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthOfAcount;
        private DevExpress.XtraGrid.Columns.GridColumn colFood_;
        private DevExpress.XtraGrid.Columns.GridColumn colEarningWork;
        private DevExpress.XtraGrid.Columns.GridColumn colNetFood;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfEnteriy;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private DevExpress.XtraEditors.ImageComboBoxEdit MonthOfAcountImageComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit Food_TextEdit;
        private DevExpress.XtraEditors.TextEdit EarningWorkTextEdit;
        private DevExpress.XtraEditors.TextEdit NetFoodTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMonthOfAcount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNetFood;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFood_;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEarningWork;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit Employee_idLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployee_id;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}