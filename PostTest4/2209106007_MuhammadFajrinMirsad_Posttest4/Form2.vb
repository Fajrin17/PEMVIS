Imports MySql.Data.MySqlClient

Public Class Form2

    Sub aturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 200
        DataGridView1.Columns(0).HeaderText = "Kode Pos"
        DataGridView1.Columns(1).HeaderText = "Lokasi Pos"
        DataGridView1.Columns(2).HeaderText = "Jenis Pos"
        DataGridView1.Columns(3).HeaderText = "Tanggal Operasi Pos"
        DataGridView1.Columns(4).HeaderText = "Kecamatan Pos"
    End Sub

    Sub tampilJenis()
        DA = New MySqlDataAdapter("SELECT * FROM tb_pos", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "pos")
        DataGridView1.DataSource = DS.Tables("pos")
        DataGridView1.Refresh()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilJenis()
        aturGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class