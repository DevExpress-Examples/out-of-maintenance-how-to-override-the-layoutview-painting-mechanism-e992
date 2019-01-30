Imports DevExpress.XtraGrid

Namespace DXSample
    Public Class MyGridControl
        Inherits GridControl

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As DevExpress.XtraGrid.Registrator.InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyLayoutInfoRegistrator())
        End Sub
    End Class
End Namespace