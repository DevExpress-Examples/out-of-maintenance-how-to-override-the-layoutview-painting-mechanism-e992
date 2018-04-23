Imports Microsoft.VisualBasic
Imports System
Namespace Q139427
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New Q139427.CarsDBDataSet()
			Me.carsTableAdapter = New Q139427.CarsDBDataSetTableAdapters.CarsTableAdapter()
			Me.myGridControl1 = New DXSample.MyGridControl()
			Me.myLayoutView1 = New DXSample.MyLayoutView()
			Me.colID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colID = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colTrademark = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colTrademark = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colModel = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colModel = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.colHP = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colHP = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myLayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colTrademark, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colModel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colHP, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' myGridControl1
			' 
			Me.myGridControl1.DataSource = Me.carsBindingSource
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myLayoutView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(764, 471)
			Me.myGridControl1.TabIndex = 0
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myLayoutView1})
			' 
			' myLayoutView1
			' 
			Me.myLayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colID, Me.colTrademark, Me.colModel, Me.colHP})
			Me.myLayoutView1.GridControl = Me.myGridControl1
			Me.myLayoutView1.Name = "myLayoutView1"
			Me.myLayoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.LayoutViewField = Me.layoutViewField_colID
			Me.colID.Name = "colID"
			' 
			' layoutViewField_colID
			' 
			Me.layoutViewField_colID.EditorPreferredWidth = 140
			Me.layoutViewField_colID.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colID.Name = "layoutViewField_colID"
			Me.layoutViewField_colID.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colID.TextSize = New System.Drawing.Size(55, 13)
			' 
			' colTrademark
			' 
			Me.colTrademark.FieldName = "Trademark"
			Me.colTrademark.LayoutViewField = Me.layoutViewField_colTrademark
			Me.colTrademark.Name = "colTrademark"
			' 
			' layoutViewField_colTrademark
			' 
			Me.layoutViewField_colTrademark.EditorPreferredWidth = 140
			Me.layoutViewField_colTrademark.Location = New System.Drawing.Point(0, 20)
			Me.layoutViewField_colTrademark.Name = "layoutViewField_colTrademark"
			Me.layoutViewField_colTrademark.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colTrademark.TextSize = New System.Drawing.Size(55, 13)
			' 
			' colModel
			' 
			Me.colModel.FieldName = "Model"
			Me.colModel.LayoutViewField = Me.layoutViewField_colModel
			Me.colModel.Name = "colModel"
			' 
			' layoutViewField_colModel
			' 
			Me.layoutViewField_colModel.EditorPreferredWidth = 140
			Me.layoutViewField_colModel.Location = New System.Drawing.Point(0, 40)
			Me.layoutViewField_colModel.Name = "layoutViewField_colModel"
			Me.layoutViewField_colModel.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colModel.TextSize = New System.Drawing.Size(55, 13)
			' 
			' colHP
			' 
			Me.colHP.FieldName = "HP"
			Me.colHP.LayoutViewField = Me.layoutViewField_colHP
			Me.colHP.Name = "colHP"
			' 
			' layoutViewField_colHP
			' 
			Me.layoutViewField_colHP.EditorPreferredWidth = 140
			Me.layoutViewField_colHP.Location = New System.Drawing.Point(0, 60)
			Me.layoutViewField_colHP.Name = "layoutViewField_colHP"
			Me.layoutViewField_colHP.Size = New System.Drawing.Size(203, 20)
			Me.layoutViewField_colHP.TextSize = New System.Drawing.Size(55, 13)
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colID, Me.layoutViewField_colTrademark, Me.layoutViewField_colModel, Me.layoutViewField_colHP})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(764, 471)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myLayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colID, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colTrademark, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colModel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colHP, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private carsDBDataSet As CarsDBDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As Q139427.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private myGridControl1 As DXSample.MyGridControl
		Private myLayoutView1 As DXSample.MyLayoutView
		Private colID As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colID As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colTrademark As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colTrademark As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colModel As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colModel As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private colHP As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colHP As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
	End Class
End Namespace

