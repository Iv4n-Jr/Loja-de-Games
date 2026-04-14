Public Class Form2
    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Try
            'Chamada de Formulários Locais
            Form1.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao carregar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

End Class