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
        Me.AutoScroll = True
    End Sub

    Private Sub Btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim custo As Double = CDbl(txt_custo.Text)
        Dim preco As Double = CDbl(txt_preco.Text)

        Dim custoSQL = custo.ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim precoSQL = preco.ToString(System.Globalization.CultureInfo.InvariantCulture)
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
                    {custoSQL},
                    {precoSQL},
                    '{cmb_data_venda.Value:yyyy-MM-dd}',
                    CASE 
                        WHEN {custoSQL} > 0 
                        THEN ({precoSQL} - {custoSQL})
                        ELSE 0
                    END, '{diretorio}')"
                rs = db.Execute(sql)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                sql = $"update Produtos set nome='{txt_nome.Text}', 
                                             categoria='{txt_categoria.Text}',
                                             empresa_distribuidora='{txt_empresa.Text}',
                                             cliente='{txt_cliente.Text}',
                                             custo={custoSQL},
                                             preco={precoSQL},
                                             data_venda='{cmb_data_venda.Value:yyyy-MM-dd}',
                                             lucro = CASE 
                                                WHEN {custoSQL} > 0 
                                                THEN ({precoSQL} - {custoSQL})
                                             ELSE 0
                                             END,
                                             img_foto='{diretorio}'
                                             where id='{aux_id}'"
                rs = db.Execute(sql)
                MsgBox("Dados editados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            Limpar_cadastro()
            Carregar_dados()

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
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                    rs.MoveNext() 'Mover para próximo registro
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub Dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(9).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value
                    sql = $"select * from Produtos where id='{aux_id}'"
                    rs = db.Execute(sql)

                    txt_nome.Text = rs.Fields(1).Value
                    txt_categoria.Text = rs.Fields(2).Value
                    txt_empresa.Text = rs.Fields(3).Value
                    txt_cliente.Text = rs.Fields(4).Value
                    txt_custo.Text = rs.Fields(5).Value
                    txt_preco.Text = rs.Fields(6).Value
                    cmb_data_venda.Value = rs.Fields(7).Value

                ElseIf .CurrentRow.Cells(10).Selected = True Then
                    aux_id = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja excluir o Produto de ID: " & aux_id & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"delete from Produtos where id='{aux_id}'"
                        rs = db.Execute(sql)
                        Carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

End Class