Partial Class dseport
    Partial Class FACTUREDataTable

        Private Sub FACTUREDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ASSURANCEColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class


Namespace CLINIQUE.dseportTableAdapters
    
    Partial Public Class PATIENTTableAdapter
    End Class
End Namespace
