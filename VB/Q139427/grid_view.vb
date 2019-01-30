Imports DevExpress.XtraGrid.Views.Layout
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.LookAndFeel
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Layout.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports System.Collections
Imports System.Drawing
Imports DevExpress.XtraEditors.Controls


Namespace DXSample
	Public Class MyLayoutView
		Inherits LayoutView

		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal ownerGrid As GridControl)
			MyBase.New(ownerGrid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyLayoutView"
			End Get
		End Property

		Protected Overrides Sub CreateILayoutControlImplementor()
			Dim fi As FieldInfo = GetType(LayoutView).GetField("implementorCore", BindingFlags.Instance Or BindingFlags.NonPublic)
			fi.SetValue(Me, New MyLayoutViewLayoutControlImplementor(Me))
		End Sub
	End Class

	Public Class MyLayoutViewLayoutControlImplementor
		Inherits LayoutViewLayoutControlImplementor

		Public Sub New(ByVal owner As ILayoutControlOwner)
			MyBase.New(owner)
		End Sub

		Protected Overrides Sub InitializePaintStyles()
			Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
			If lookAndFeelOwner IsNot Nothing Then
				PaintStyles.Add(New MyLayoutViewSkinPaintStyle(lookAndFeelOwner, View))
				PaintStyles.Add(New LayoutWindowsXPPaintStyle(lookAndFeelOwner))
				PaintStyles.Add(New LayoutViewOffice2003PaintStyle(lookAndFeelOwner, View))
				PaintStyles.Add(New LayoutViewStyle3DPaintStyle(lookAndFeelOwner, View))
				PaintStyles.Add(New LayoutViewUltraFlatPaintStyle(lookAndFeelOwner, View))
				PaintStyles.Add(New LayoutViewFlatPaintStyle(lookAndFeelOwner, View))
			End If
			lookAndFeelOwner = Nothing
		End Sub
	End Class

	Public Class MyLayoutViewSkinPaintStyle
		Inherits LayoutViewSkinPaintStyle

		Public Sub New(ByVal owner As ISupportLookAndFeel, ByVal view As LayoutView)
			MyBase.New(owner, view)
		End Sub

		Public Overrides Function GetPainter(ByVal item As BaseLayoutItem) As DevExpress.XtraLayout.Painting.BaseLayoutItemPainter
			Return MyBase.GetPainter(item)
		End Function

		Private cardFieldPainter As MyLayoutViewFieldSkinPainter = Nothing
		Public Overrides Function GetFieldPainter() As LayoutViewFieldSkinPainter
			If cardFieldPainter Is Nothing Then
				cardFieldPainter = New MyLayoutViewFieldSkinPainter(View)
			End If
			Return cardFieldPainter
		End Function
	End Class

	Public Class MyLayoutViewFieldSkinPainter
		Inherits LayoutViewFieldSkinPainter

		Public Sub New(ByVal layoutView As LayoutView)
			MyBase.New(layoutView)
		End Sub

		Protected Overrides Sub DrawFieldValue(ByVal viewInfo As LayoutRepositoryItemViewInfo)
			MyBase.DrawFieldValue(viewInfo)
			Dim r As Rectangle = viewInfo.RepositoryItemViewInfo.BorderRect
			r.Inflate(1, 1)
			viewInfo.Graphics.DrawRectangle(Pens.BurlyWood, r)
		End Sub
	End Class

	Public Class MyLayoutInfoRegistrator
		Inherits DevExpress.XtraGrid.Registrator.LayoutViewInfoRegistrator

		Public Sub New()
			MyBase.New()
		End Sub
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyLayoutView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As DevExpress.XtraGrid.Views.Base.BaseView
			Return New MyLayoutView(grid)
		End Function
	End Class
End Namespace