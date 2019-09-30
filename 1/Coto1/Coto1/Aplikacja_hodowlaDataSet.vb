Partial Class Aplikacja_hodowlaDataSet
    Partial Class WAGI_SZCZENIATDataTable

        Private Sub WAGI_SZCZENIATDataTable_WAGI_SZCZENIATRowChanging(sender As System.Object, e As WAGI_SZCZENIATRowChangeEvent) Handles Me.WAGI_SZCZENIATRowChanging

        End Sub

    End Class

    Partial Class MASCIDataTable

        Private Sub MASCIDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MASCColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
