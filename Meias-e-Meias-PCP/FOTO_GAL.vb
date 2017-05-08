Imports System.IO
Imports InnerLibs

Public Class FOTO_GAL
    Private Sub GAL_FOTO_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GAL_FOTO.MouseDoubleClick
        Dim tipos = New FileTypeList(New FileType(".jpg"), New FileType(".png"), New FileType(".bmp"))
        Dim d As New OpenFileDialog()
        d.Filter = tipos.ToFilterString
        d.Title = "Selecione uma foto para fazer o upload"
        If d.ShowDialog = DialogResult.OK AndAlso Path.GetExtension(d.FileName).IsIn(tipos.Extensions) Then
            GAL_FOTO.BackgroundImage = Image.FromFile(d.FileName)
            Banco.RunSQL("UPDATE `Galeria` SET GAL_FOTO = @foto", "@foto", New FileInfo(d.FileName))
        End If
    End Sub

    Private Sub GAL_TITULO_Leave(sender As Object, e As EventArgs) Handles GAL_TITULO.Leave, GAL_DESCRICAO.Leave, GAL_CATEGORIA.Leave
        Banco.RunSQL("UPDATE `Galeria` SET " & sender.Name & " = " & sender.Text.ToString.IsNull & " where GAL_ID = " & GAL_ID.Text)
    End Sub

    Private Sub FOTO_GAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GAL_CATEGORIA.Items.AddRange(Banco.RunSQL("SELECT DISTINCT GAL_CATEGORIA FROM `Galeria`").ToList(Of String)("GAL_CATEGORIA").ToArray)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Confirm("Deseja realmente apagar a foto #" & GAL_ID.Text & "?") Then
            Banco.DELETE("Galeria", "GAL_ID = " & GAL_ID.Text)
            TrazGaleria(Me.Parent)
        End If
    End Sub
End Class
