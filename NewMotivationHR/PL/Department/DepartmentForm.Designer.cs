namespace NewMotivationHR.PL.Department
{
    partial class DepartmentForm
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
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delet = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ParentIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForParentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.IsMainCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForIsMain = new DevExpress.XtraLayout.LayoutControlItem();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsMainCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(775, 46);
            this.panel1.TabIndex = 8;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(182, 4);
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ParentIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsMainCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.DataSource = this.departmentBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 46);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(775, 441);
            this.dataLayoutControl1.TabIndex = 9;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.departmentBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(751, 369);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colParentId,
            this.colIsMain,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(775, 441);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.ItemForIsMain,
            this.ItemForName,
            this.ItemForDescription,
            this.ItemForParentId});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(755, 421);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(755, 373);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(NewMotivationHR.DB.Department);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(389, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(309, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 9;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(377, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(378, 24);
            this.ItemForName.TextSize = new System.Drawing.Size(53, 13);
            // 
            // ParentIdTextEdit
            // 
            this.ParentIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "ParentId", true));
            this.ParentIdTextEdit.Location = new System.Drawing.Point(12, 12);
            this.ParentIdTextEdit.Name = "ParentIdTextEdit";
            this.ParentIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ParentIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ParentIdTextEdit.Properties.Mask.EditMask = "N0";
            this.ParentIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ParentIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ParentIdTextEdit.Size = new System.Drawing.Size(308, 20);
            this.ParentIdTextEdit.StyleController = this.dataLayoutControl1;
            this.ParentIdTextEdit.TabIndex = 10;
            // 
            // ItemForParentId
            // 
            this.ItemForParentId.Control = this.ParentIdTextEdit;
            this.ItemForParentId.Location = new System.Drawing.Point(0, 0);
            this.ItemForParentId.Name = "ItemForParentId";
            this.ItemForParentId.Size = new System.Drawing.Size(377, 24);
            this.ItemForParentId.TextSize = new System.Drawing.Size(53, 13);
            // 
            // IsMainCheckEdit
            // 
            this.IsMainCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "IsMain", true));
            this.IsMainCheckEdit.Location = new System.Drawing.Point(12, 36);
            this.IsMainCheckEdit.Name = "IsMainCheckEdit";
            this.IsMainCheckEdit.Properties.Caption = "رئيسي ";
            this.IsMainCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsMainCheckEdit.Size = new System.Drawing.Size(373, 20);
            this.IsMainCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsMainCheckEdit.TabIndex = 11;
            // 
            // ItemForIsMain
            // 
            this.ItemForIsMain.Control = this.IsMainCheckEdit;
            this.ItemForIsMain.Location = new System.Drawing.Point(0, 24);
            this.ItemForIsMain.Name = "ItemForIsMain";
            this.ItemForIsMain.Size = new System.Drawing.Size(377, 24);
            this.ItemForIsMain.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsMain.TextVisible = false;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.departmentBindingSource, "Description", true));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(389, 36);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(309, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 12;
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(377, 24);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(378, 24);
            this.ItemForDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataSource = typeof(NewMotivationHR.DB.Department);
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
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 2;
            // 
            // colIsMain
            // 
            this.colIsMain.FieldName = "IsMain";
            this.colIsMain.Name = "colIsMain";
            this.colIsMain.Visible = true;
            this.colIsMain.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 487);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panel1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsMainCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private DevExpress.XtraEditors.SimpleButton btn_delet;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colParentId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsMain;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DevExpress.XtraEditors.TextEdit ParentIdTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsMainCheckEdit;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsMain;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForParentId;
    }
}