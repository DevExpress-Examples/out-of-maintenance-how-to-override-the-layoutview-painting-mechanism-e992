namespace Q139427 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new Q139427.CarsDBDataSet();
            this.carsTableAdapter = new Q139427.CarsDBDataSetTableAdapters.CarsTableAdapter();
            this.myGridControl1 = new DXSample.MyGridControl();
            this.myLayoutView1 = new DXSample.MyLayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTrademark = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTrademark = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colModel = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colModel = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colHP = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colHP = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTrademark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.carsBindingSource;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myLayoutView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(764, 471);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myLayoutView1});
            // 
            // myLayoutView1
            // 
            this.myLayoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colHP});
            this.myLayoutView1.GridControl = this.myGridControl1;
            this.myLayoutView1.Name = "myLayoutView1";
            this.myLayoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 140;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(55, 13);
            // 
            // colTrademark
            // 
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.LayoutViewField = this.layoutViewField_colTrademark;
            this.colTrademark.Name = "colTrademark";
            // 
            // layoutViewField_colTrademark
            // 
            this.layoutViewField_colTrademark.EditorPreferredWidth = 140;
            this.layoutViewField_colTrademark.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colTrademark.Name = "layoutViewField_colTrademark";
            this.layoutViewField_colTrademark.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colTrademark.TextSize = new System.Drawing.Size(55, 13);
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.LayoutViewField = this.layoutViewField_colModel;
            this.colModel.Name = "colModel";
            // 
            // layoutViewField_colModel
            // 
            this.layoutViewField_colModel.EditorPreferredWidth = 140;
            this.layoutViewField_colModel.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colModel.Name = "layoutViewField_colModel";
            this.layoutViewField_colModel.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colModel.TextSize = new System.Drawing.Size(55, 13);
            // 
            // colHP
            // 
            this.colHP.FieldName = "HP";
            this.colHP.LayoutViewField = this.layoutViewField_colHP;
            this.colHP.Name = "colHP";
            // 
            // layoutViewField_colHP
            // 
            this.layoutViewField_colHP.EditorPreferredWidth = 140;
            this.layoutViewField_colHP.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colHP.Name = "layoutViewField_colHP";
            this.layoutViewField_colHP.Size = new System.Drawing.Size(203, 20);
            this.layoutViewField_colHP.TextSize = new System.Drawing.Size(55, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID,
            this.layoutViewField_colTrademark,
            this.layoutViewField_colModel,
            this.layoutViewField_colHP});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 471);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLayoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTrademark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Q139427.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private DXSample.MyGridControl myGridControl1;
        private DXSample.MyLayoutView myLayoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTrademark;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colTrademark;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colModel;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colModel;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHP;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colHP;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}

