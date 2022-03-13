namespace NewMotivationHR.PL.Rewards
{
    partial class frmReward
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
            this.rewardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReward_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEarningWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetReward = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfEnteriy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Employee_idLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.TypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.Reward_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EarningWorkTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NetRewardTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForEmployee_id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReward_ = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNetReward = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEarningWork = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rewardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_idLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeImageComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reward_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EarningWorkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetRewardTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReward_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNetReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEarningWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 11;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(182, 3);
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.Employee_idLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.TypeImageComboBoxEdit);
            this.dataLayoutControl1.Controls.Add(this.Reward_TextEdit);
            this.dataLayoutControl1.Controls.Add(this.EarningWorkTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NetRewardTextEdit);
            this.dataLayoutControl1.DataSource = this.rewardBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 38);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 412);
            this.dataLayoutControl1.TabIndex = 12;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.rewardBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 340);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rewardBindingSource1
            // 
            this.rewardBindingSource1.DataSource = typeof(NewMotivationHR.DB.Reward);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEmployee_id,
            this.colType,
            this.colReward_,
            this.colEarningWork,
            this.colNetReward,
            this.colDateOfEnteriy});
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
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // colReward_
            // 
            this.colReward_.FieldName = "Reward_";
            this.colReward_.Name = "colReward_";
            this.colReward_.Visible = true;
            this.colReward_.VisibleIndex = 3;
            // 
            // colEarningWork
            // 
            this.colEarningWork.FieldName = "EarningWork";
            this.colEarningWork.Name = "colEarningWork";
            this.colEarningWork.OptionsColumn.ReadOnly = true;
            this.colEarningWork.Visible = true;
            this.colEarningWork.VisibleIndex = 4;
            // 
            // colNetReward
            // 
            this.colNetReward.FieldName = "NetReward";
            this.colNetReward.Name = "colNetReward";
            this.colNetReward.Visible = true;
            this.colNetReward.VisibleIndex = 5;
            // 
            // colDateOfEnteriy
            // 
            this.colDateOfEnteriy.FieldName = "DateOfEnteriy";
            this.colDateOfEnteriy.Name = "colDateOfEnteriy";
            this.colDateOfEnteriy.Visible = true;
            this.colDateOfEnteriy.VisibleIndex = 6;
            // 
            // Employee_idLookUpEdit
            // 
            this.Employee_idLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rewardBindingSource, "Employee_id", true));
            this.Employee_idLookUpEdit.Location = new System.Drawing.Point(413, 12);
            this.Employee_idLookUpEdit.Name = "Employee_idLookUpEdit";
            this.Employee_idLookUpEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Employee_idLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Employee_idLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Employee_idLookUpEdit.Properties.NullText = "";
            this.Employee_idLookUpEdit.Size = new System.Drawing.Size(312, 20);
            this.Employee_idLookUpEdit.StyleController = this.dataLayoutControl1;
            this.Employee_idLookUpEdit.TabIndex = 4;
            // 
            // TypeImageComboBoxEdit
            // 
            this.TypeImageComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rewardBindingSource, "Type", true));
            this.TypeImageComboBoxEdit.Location = new System.Drawing.Point(12, 12);
            this.TypeImageComboBoxEdit.Name = "TypeImageComboBoxEdit";
            this.TypeImageComboBoxEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TypeImageComboBoxEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeImageComboBoxEdit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("مكافئة", NewMotivationHR.DB.Enume.Type.مكافئة, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("تغذية", NewMotivationHR.DB.Enume.Type.تغذية, 1)});
            this.TypeImageComboBoxEdit.Properties.UseCtrlScroll = true;
            this.TypeImageComboBoxEdit.Size = new System.Drawing.Size(334, 20);
            this.TypeImageComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.TypeImageComboBoxEdit.TabIndex = 5;
            this.TypeImageComboBoxEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.TypeImageComboBoxEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // Reward_TextEdit
            // 
            this.Reward_TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rewardBindingSource, "Reward_", true));
            this.Reward_TextEdit.Location = new System.Drawing.Point(550, 36);
            this.Reward_TextEdit.Name = "Reward_TextEdit";
            this.Reward_TextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.Reward_TextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Reward_TextEdit.Properties.Mask.EditMask = "N0";
            this.Reward_TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Reward_TextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.Reward_TextEdit.Size = new System.Drawing.Size(175, 20);
            this.Reward_TextEdit.StyleController = this.dataLayoutControl1;
            this.Reward_TextEdit.TabIndex = 6;
            this.Reward_TextEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.Reward_TextEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // EarningWorkTextEdit
            // 
            this.EarningWorkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rewardBindingSource, "EarningWork", true));
            this.EarningWorkTextEdit.Location = new System.Drawing.Point(290, 36);
            this.EarningWorkTextEdit.Name = "EarningWorkTextEdit";
            this.EarningWorkTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.EarningWorkTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.EarningWorkTextEdit.Properties.Mask.EditMask = "N0";
            this.EarningWorkTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.EarningWorkTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.EarningWorkTextEdit.Properties.ReadOnly = true;
            this.EarningWorkTextEdit.Size = new System.Drawing.Size(193, 20);
            this.EarningWorkTextEdit.StyleController = this.dataLayoutControl1;
            this.EarningWorkTextEdit.TabIndex = 7;
            this.EarningWorkTextEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.EarningWorkTextEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // NetRewardTextEdit
            // 
            this.NetRewardTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.rewardBindingSource, "NetReward", true));
            this.NetRewardTextEdit.Location = new System.Drawing.Point(12, 36);
            this.NetRewardTextEdit.Name = "NetRewardTextEdit";
            this.NetRewardTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NetRewardTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NetRewardTextEdit.Properties.Mask.EditMask = "N0";
            this.NetRewardTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NetRewardTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NetRewardTextEdit.Properties.ReadOnly = true;
            this.NetRewardTextEdit.Size = new System.Drawing.Size(211, 20);
            this.NetRewardTextEdit.StyleController = this.dataLayoutControl1;
            this.NetRewardTextEdit.TabIndex = 8;
            this.NetRewardTextEdit.EditValueChanged += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            this.NetRewardTextEdit.Click += new System.EventHandler(this.Employee_idLookUpEdit_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 412);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForEmployee_id,
            this.ItemForReward_,
            this.ItemForType,
            this.ItemForNetReward,
            this.ItemForEarningWork});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(780, 48);
            // 
            // ItemForEmployee_id
            // 
            this.ItemForEmployee_id.Control = this.Employee_idLookUpEdit;
            this.ItemForEmployee_id.Location = new System.Drawing.Point(401, 0);
            this.ItemForEmployee_id.Name = "ItemForEmployee_id";
            this.ItemForEmployee_id.Size = new System.Drawing.Size(379, 24);
            this.ItemForEmployee_id.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForReward_
            // 
            this.ItemForReward_.Control = this.Reward_TextEdit;
            this.ItemForReward_.Location = new System.Drawing.Point(538, 24);
            this.ItemForReward_.Name = "ItemForReward_";
            this.ItemForReward_.Size = new System.Drawing.Size(242, 24);
            this.ItemForReward_.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForType
            // 
            this.ItemForType.Control = this.TypeImageComboBoxEdit;
            this.ItemForType.Location = new System.Drawing.Point(0, 0);
            this.ItemForType.Name = "ItemForType";
            this.ItemForType.Size = new System.Drawing.Size(401, 24);
            this.ItemForType.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForNetReward
            // 
            this.ItemForNetReward.Control = this.NetRewardTextEdit;
            this.ItemForNetReward.Location = new System.Drawing.Point(0, 24);
            this.ItemForNetReward.Name = "ItemForNetReward";
            this.ItemForNetReward.Size = new System.Drawing.Size(278, 24);
            this.ItemForNetReward.TextSize = new System.Drawing.Size(60, 13);
            // 
            // ItemForEarningWork
            // 
            this.ItemForEarningWork.Control = this.EarningWorkTextEdit;
            this.ItemForEarningWork.Location = new System.Drawing.Point(278, 24);
            this.ItemForEarningWork.Name = "ItemForEarningWork";
            this.ItemForEarningWork.Size = new System.Drawing.Size(260, 24);
            this.ItemForEarningWork.TextSize = new System.Drawing.Size(60, 13);
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
            // rewardBindingSource
            // 
            this.rewardBindingSource.DataSource = typeof(NewMotivationHR.DB.Reward);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(NewMotivationHR.DB.Employee);
            // 
            // frmReward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmReward";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmReward";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_idLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeImageComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reward_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EarningWorkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetRewardTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmployee_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReward_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNetReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEarningWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource rewardBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee_id;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colReward_;
        private DevExpress.XtraGrid.Columns.GridColumn colEarningWork;
        private DevExpress.XtraGrid.Columns.GridColumn colNetReward;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfEnteriy;
        private DevExpress.XtraEditors.LookUpEdit Employee_idLookUpEdit;
        private DevExpress.XtraEditors.ImageComboBoxEdit TypeImageComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit Reward_TextEdit;
        private DevExpress.XtraEditors.TextEdit EarningWorkTextEdit;
        private DevExpress.XtraEditors.TextEdit NetRewardTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmployee_id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReward_;
        private DevExpress.XtraLayout.LayoutControlItem ItemForType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNetReward;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEarningWork;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource rewardBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}