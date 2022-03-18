namespace NewMotivationHR.PL.SalaryForms
{
    partial class frmMonth
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
            this.txt_year = new DevExpress.XtraEditors.TextEdit();
            this.MonthOfAcountImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMonthOfAcount = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_bank_print = new DevExpress.XtraEditors.SimpleButton();
            this.employeeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthOfAcountImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonthOfAcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txt_year);
            this.dataLayoutControl1.Controls.Add(this.MonthOfAcountImageComboBoxEdit);
            this.dataLayoutControl1.DataSource = this.employeeSalaryBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(33, 9);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(354, 92);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(12, 36);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(257, 20);
            this.txt_year.StyleController = this.dataLayoutControl1;
            this.txt_year.TabIndex = 5;
            // 
            // MonthOfAcountImageComboBoxEdit
            // 
            this.MonthOfAcountImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeSalaryBindingSource, "MonthOfAcount", true));
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
            this.MonthOfAcountImageComboBoxEdit.Size = new System.Drawing.Size(257, 20);
            this.MonthOfAcountImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.MonthOfAcountImageComboBoxEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(354, 92);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMonthOfAcount,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(334, 72);
            // 
            // ItemForMonthOfAcount
            // 
            this.ItemForMonthOfAcount.Control = this.MonthOfAcountImageComboBoxEdit;
            this.ItemForMonthOfAcount.Location = new System.Drawing.Point(0, 0);
            this.ItemForMonthOfAcount.Name = "ItemForMonthOfAcount";
            this.ItemForMonthOfAcount.Size = new System.Drawing.Size(334, 24);
            this.ItemForMonthOfAcount.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_year;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(334, 48);
            this.layoutControlItem1.Text = "السنة";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(300, 107);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "حفظ";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(33, 107);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "الغاء";
            // 
            // btn_bank_print
            // 
            this.btn_bank_print.Location = new System.Drawing.Point(161, 107);
            this.btn_bank_print.Name = "btn_bank_print";
            this.btn_bank_print.Size = new System.Drawing.Size(75, 23);
            this.btn_bank_print.TabIndex = 8;
            this.btn_bank_print.Text = "طباعة للبنك";
            this.btn_bank_print.Visible = false;
            this.btn_bank_print.Click += new System.EventHandler(this.btn_bank_print_Click);
            // 
            // employeeSalaryBindingSource
            // 
            this.employeeSalaryBindingSource.DataSource = typeof(NewMotivationHR.DB.EmployeeSalary);
            // 
            // frmMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 165);
            this.Controls.Add(this.btn_bank_print);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmMonth";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شهر احتساب الراتب";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_year.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthOfAcountImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMonthOfAcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource employeeSalaryBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMonthOfAcount;
        public DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        public DevExpress.XtraEditors.SimpleButton btn_bank_print;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraEditors.TextEdit txt_year;
        public DevExpress.XtraEditors.ImageComboBoxEdit MonthOfAcountImageComboBoxEdit;
    }
}