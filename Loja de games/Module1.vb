Module Module1
    'Declaração de variáveis públicas
    Public diretorio As String
    Public db As New ADODB.Connection 'Varíavel do Banco de Dados
    Public rs As New ADODB.Recordset 'Variável das tabelas
    Public sql, aux_id, resp As String 'Query de Leitura e Escrita
    Public cont As Integer

    Sub Carregar_tipo()
        '
        Try
            With Form1.cmb_campo.Items
                .Add("nome")
                .Add("categoria")
                .Add("empresa_distribuidora")
            End With
            Form1.cmb_campo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub Carregar_dados()
        'Carregar registros do Banco no Datagridview
        Try
            sql = $"select * from Produtos order by nome asc"
            rs = db.Execute(sql)

            With Form1.dgv_dados
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


    Sub Conecta_banco() 'String de Conexão SQL-SERVER
        Try 'Tratamento de erros e exceções (Try e Catch)
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=.\SQLEXPRESS;Initial Catalog=loja_games;trusted_connection=yes;")
            'SQLOLEDB = SQL SERVER, nome tecnico
            'DataSource = nome do servidor SQL
            'Initial Catalog = nome do banco
            'trusted_connection = autenticação pelo windows, poderia ser usado também "user='xxxx';pwd='12';"

                MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO") 'Aviso de conexão bem sucedida
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO") 'Aviso de erro de conexão
        End Try
    End Sub

    Sub Limpar_cadastro()
        Try
            With Form1
                .txt_nome.Clear()
                .txt_categoria.Clear()
                .txt_empresa.Clear()
                .txt_cliente.Clear()
                .txt_custo.Clear()
                .txt_preco.Clear()
                .cmb_data_venda.Value = Now
                .img_foto.Load(Application.StartupPath & "\icones\produto_icone.png")

            End With
        Catch ex As Exception

        End Try
    End Sub
End Module
