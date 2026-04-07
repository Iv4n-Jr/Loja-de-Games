Imports System.Numerics

Public Class Form1
    Private Sub Img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        Carregar_dados()
        Carregar_tipo()
    End Sub

    Private Sub Btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            sql = $"select * from Produtos where Nome='{txt_nome.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = $"INSERT INTO Produtos 
                    (nome, categoria, empresa_distribuidora, cliente, custo, preco, data_venda, lucro, img_foto)
                    VALUES 
                    ('{txt_nome.Text}',
                    '{txt_categoria.Text}',
                    '{txt_empresa.Text}',
                    '{txt_cliente.Text}',
                    {txt_custo.Text},
                    {txt_preco.Text},
                    '{cmb_data_venda.Value:yyyy-MM-dd}',
                    CASE 
                        WHEN {txt_custo.Text} > 0 
                        THEN (({txt_preco.Text} - {txt_custo.Text}) / {txt_custo.Text}) * 100
                        ELSE 0
                    END, '{diretorio}')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Limpar_cadastro()
                Carregar_dados()
            Else
                MsgBox("Produto já cadastrado!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")

            End If

        Catch ex As Exception
            MsgBox("Erro ao Gravar: " & ex.Message)
        End Try
    End Sub



    Private Sub txt_nome_DoubleClick(sender As Object, e As EventArgs) Handles txt_nome.DoubleClick
        Limpar_cadastro()
    End Sub



    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            sql = $"select * from Produtos where {cmb_campo.Text} like '{txt_buscar.Text}%'"
            rs = db.Execute(sql)
            With dgv_dados
                cont = 0
                .Rows.Clear()
                Do While rs.EOF = False 'Faça enquanto existir registros
                    cont = cont + 1
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10))
                    rs.MoveNext() 'Mover para próximo registro
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class