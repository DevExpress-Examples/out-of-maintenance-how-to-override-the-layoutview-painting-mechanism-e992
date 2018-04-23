Imports Microsoft.VisualBasic
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
			MyBase.InitializePaintStyles()
			Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
			If lookAndFeelOwner IsNot Nothing Then
				PaintStyles.RemoveAt(1)
				PaintStyles.Add(New MyLayoutViewSkinPaintStyle(lookAndFeelOwner, View))
				Dim pi As PropertyInfo = GetType(LayoutPaintStyleCollection).GetProperty("List", BindingFlags.Instance Or BindingFlags.NonPublic)
				Dim list As IList = CType(pi.GetValue(PaintStyles, Nothing), IList)
				For i As Integer = 0 To list.Count - 1
					If (CType(list(i), LayoutPaintStyle)).PaintStyleName = "Skin" Then
						list(i) = New MyLayoutViewSkinPaintStyle(lookAndFeelOwner, View)
						Exit For
					End If
				Next i
				lookAndFeelOwner = Nothing
			End If
		End Sub
	End Class

	Public Class MyLayoutViewSkinPaintStyle
		Inherits LayoutViewSkinPaintStyle
		Public Sub New(ByVal owner As ISupportLookAndFeel, ByVal view As LayoutView)
			MyBase.New(owner, view)
		End Sub

		Public Overrides ReadOnly Property PaintStyleName() As String
			Get
				Return "SkinEx"
			End Get
		End Property

		Public Overrides Function GetRepositoryItemSkinPainter() As LayoutRepositoryItemSkinPainter
			If repositoryItemSkinPainter Is Nothing Then
				repositoryItemSkinPainter = New MyLayoutRepositoryItemSkinPainter()
			End If
			Return repositoryItemSkinPainter
		End Function
	End Class

	Public Class MyLayoutRepositoryItemSkinPainter
		Inherits LayoutRepositoryItemSkinPainter
		Public Sub New()
			MyBase.New()
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