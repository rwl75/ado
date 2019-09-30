Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Private Sub UpdateDG()
        Dim combo1 As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn

        combo1.HeaderText = "masci"
        combo1.Name = "combo1"
        combo1.Items.Add("sniada/y")
        combo1.Items.Add("tricolor")
        combo1.Items.Add("zolta")
        combo1.Items.Add("zielona")
        DataGridView1.Columns.Add(combo1)
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'Aplikacja_hodowlaDataSet.MIOTY' table. You can move, or remove it, as needed.
        Me.MIOTYTableAdapter.Fill(Me.Aplikacja_hodowlaDataSet.MIOTY)
        'TODO: This line of code loads data into the 'Aplikacja_hodowlaDataSet.WAGI_SZCZENIAT' table. You can move, or remove it, as needed.
        Me.WAGI_SZCZENIATTableAdapter.Fill(Me.Aplikacja_hodowlaDataSet.WAGI_SZCZENIAT)
        'TODO: This line of code loads data into the 'Aplikacja_hodowlaDataSet.SZCZENIETA' table. You can move, or remove it, as needed.
        Me.SZCZENIETATableAdapter.Fill(Me.Aplikacja_hodowlaDataSet.SZCZENIETA)
        'TODO: This line of code loads data into the 'Aplikacja_hodowlaDataSet.OJCOWIE' table. You can move, or remove it, as needed.
        Me.OJCOWIETableAdapter.Fill(Me.Aplikacja_hodowlaDataSet.OJCOWIE)
        'TODO: This line of code loads data into the 'Aplikacja_hodowlaDataSet.MATKI' table. You can move, or remove it, as needed.
        Me.MATKITableAdapter.Fill(Me.Aplikacja_hodowlaDataSet.MATKI)
    End Sub

    'Private Sub MATKIDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MATKIDataGridView.CellContentClick
    'Dim con As New OleDbConnection
    'Dim cmd As New OleDbCommand
    'Dim adp As OleDbDataAdapter
    'Dim dt As New DataTable()
    'Dim dc As DataColumn

    'con.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = Aplikacja_hodowla.mdb"


    'adp = New OleDbDataAdapter("SELECT * FROM Matki", con)

    'adp.Fill(dt)

    'adp.FillSchema(dt, SchemaType.Source) 'pobranie schematu źródłowego
    'For Each dc In dt.Columns
    '    DataGridView.Text = DataGridView.Text + dc.ColumnName + "     "
    'Next

    'DataGridView.Text += vbNewLine
    'DataGridView.Text += vbNewLine

    'For i = 0 To dt.Rows.Count - 1
    '    For j = 0 To dt.Columns.Count - 1
    '        DataGridView.Text += dt.Rows(i).Item(j).ToString() + "     "
    '    Next
    '    DataGridView.Text += vbNewLine
    ' End Sub




    Private Sub BindingNavigatorAddNewItem1_Click(sender As System.Object, e As System.EventArgs)
        MATKIBindingSource.AddNew()
    End Sub

    Private Sub BindingNavigatorDeleteItem1_Click(sender As System.Object, e As System.EventArgs)
        MATKIBindingSource.RemoveCurrent()
        MATKIBindingSource.EndEdit()
        MATKITableAdapter.Update(Me.Aplikacja_hodowlaDataSet)
        'Me.MATKITableAdapter.Fill(Me.Aplikacja_hodowlaDataSet)
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs)
        Try
            Me.Validate()
            Me.MATKIBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub


    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.MATKITableAdapter.FillBy(Me.Aplikacja_hodowlaDataSet.MATKI)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
    '    MATKIBindingSource.AddNew()
    '    OJCOWIEBindingSource.AddNew()
    '    MIOTYBindingSource.AddNew()
    '    SZCZENIETABindingSource.AddNew()
    '    WAGI_SZCZENIATBindingSource.AddNew()

    'Me.DataGridView1.Rows.Add(IMIE_MTextBox.Text, MASCTextBox.Text, TYTULY_MTextBox.Text)
    'End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs)
        MATKIBindingSource.RemoveCurrent()
        MATKIBindingSource.EndEdit()

        OJCOWIEBindingSource.RemoveCurrent()
        OJCOWIEBindingSource.EndEdit()

        MIOTYBindingSource.RemoveCurrent()
        MIOTYBindingSource.RemoveCurrent()

        SZCZENIETABindingSource.RemoveCurrent()
        SZCZENIETABindingSource.RemoveCurrent()

        WAGI_SZCZENIATBindingSource.RemoveCurrent()
        WAGI_SZCZENIATBindingSource.RemoveCurrent()

        'MATKITableAdapter.Update(Me.Aplikacja_hodowlaDataSet)
        'OJCOWIETableAdapter.Update(Me.Aplikacja_hodowlaDataSet)
        'MIOTYTableAdapter.Update(Me.Aplikacja_hodowlaDataSet)
        'SZCZENIETATableAdapter.Update(Me.Aplikacja_hodowlaDataSet)
        'WAGI_SZCZENIATTableAdapter.Update(Me.Aplikacja_hodowlaDataSet)

    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Validate()
            Me.MATKIBindingSource.EndEdit()
            Me.OJCOWIEBindingSource.EndEdit()
            Me.MIOTYBindingSource.EndEdit()
            Me.SZCZENIETABindingSource.EndEdit()
            Me.WAGI_SZCZENIATBindingSource.EndEdit()

            'Me.TableAdapterManager.UpdateAll(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub



    Private Sub BindingNavigator1_RefreshItems(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_2(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.MATKIBindingSource.EndEdit()
            Me.MATKITableAdapter.Update(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Me.Validate()
            Me.OJCOWIEBindingSource.EndEdit()
            Me.OJCOWIETableAdapter.Update(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Try
            Me.Validate()
            Me.MIOTYBindingSource.EndEdit()
            Me.MIOTYTableAdapter.Update(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Me.Validate()
            Me.SZCZENIETABindingSource.EndEdit()
            Me.SZCZENIETATableAdapter.Update(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Try
            Me.Validate()
            Me.WAGI_SZCZENIATBindingSource.EndEdit()
            Me.WAGI_SZCZENIATTableAdapter.Update(Me.Aplikacja_hodowlaDataSet)

            MessageBox.Show("Dane zostały zapisane")

        Catch ex As Exception
            MessageBox.Show("Bład podczas zapisywania danych")
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.MATKITableAdapter.Fill(Aplikacja_hodowlaDataSet.MATKI)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.OJCOWIETableAdapter.Fill(Aplikacja_hodowlaDataSet.OJCOWIE)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.MIOTYTableAdapter.Fill(Aplikacja_hodowlaDataSet.MIOTY)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.SZCZENIETATableAdapter.Fill(Aplikacja_hodowlaDataSet.SZCZENIETA)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.WAGI_SZCZENIATTableAdapter.Fill(Aplikacja_hodowlaDataSet.WAGI_SZCZENIAT)
    End Sub


End Class
