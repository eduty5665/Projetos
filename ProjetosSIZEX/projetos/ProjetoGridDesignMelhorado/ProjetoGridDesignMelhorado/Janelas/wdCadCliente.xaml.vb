Public Class wdCadCliente
    Dim objCliente As New Cliente
    Dim srcContatos As CollectionViewSource
    Dim srcCliente As CollectionViewSource
    Dim objContato As ClienteContatos
    Dim lstCliente As List(Of Cliente)
    Dim Verificar As Boolean

#Region "Métodos - SUB"
    Private Sub LimpaCampos(tipo As String)
        If tipo = "C" Or tipo = "T" Then
            Datatxt.Text = ""
            CPFtxt.Text = ""
            RGtxt.Text = ""
            Nometxt.Text = ""
            Statuschk.IsChecked = False
            Endtxt.Text = ""
            NumEndtxt.Text = ""
            BairroEndtxt.Text = ""
            CidEndtxt.Text = ""
            EstEndcmb.Text = ""
            CompEndtxt.Text = ""
            CEPEndtxt.Text = ""
            objCliente = Nothing
            srcContatos.Source = Nothing
            CPFtxt.Focus()
        End If
        If tipo = "CT" Or tipo = "T" Then
            Contatotxt.Text = ""
            OBSConttxt.Text = ""
            TipoContcmb.Text = ""
            objContato = Nothing
            Contatotxt.Focus()
        End If
    End Sub
    Private Function SalvarCliente() As Boolean
        If Nometxt.Text = "" Then
            MsgBox("Nome não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Nometxt.Focus()
            Return False
        ElseIf CPFtxt.Text = "" Then
            MsgBox("CPF não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            CPFtxt.Focus()
            Return False
        ElseIf Not IsDate(Datatxt.Text) Then
            MsgBox("Data não informada, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Datatxt.Focus()
            Return False
        End If

        If objCliente Is Nothing Then
            objCliente = New Cliente
        End If

        'Dim objCliente As New Cliente
        objCliente.DataCad = Datatxt.Text
        objCliente.CPF = CPFtxt.Text
        objCliente.RG = RGtxt.Text
        objCliente.Nome = Nometxt.Text
        objCliente.Status = Statuschk.IsChecked
        objCliente.Endereco = Endtxt.Text
        objCliente.Numero = NumEndtxt.Text
        objCliente.Bairro = BairroEndtxt.Text
        objCliente.Cidade = CidEndtxt.Text
        objCliente.Estado = EstEndcmb.Text
        objCliente.Complemento = CompEndtxt.Text
        objCliente.CEP = CEPEndtxt.Text

        If Not lstCliente.Contains(objCliente) Then
            lstCliente.Add(objCliente)
        End If

        Return True
    End Function

    Private Function ValidaCampos() As Boolean
        If Nometxt.Text = "" Then
            MsgBox("Nome não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Nometxt.Focus()
            Return False
        ElseIf CPFtxt.Text = "" Then
            MsgBox("CPF não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            CPFtxt.Focus()
            Return False
        ElseIf Not IsDate(Datatxt.Text) Then
            MsgBox("Data não informada, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Datatxt.Focus()
            Return False
        ElseIf Contatotxt.Text = "" Then
            MsgBox("Contato não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Contatotxt.Focus()
            Return False
        ElseIf OBSConttxt.Text = "" Then
            MsgBox("Observação de Contato não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            OBSConttxt.Focus()
            Return False
        ElseIf TipoContcmb.Text = "" Then
            MsgBox("Tipo de Contato não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            TipoContcmb.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

#Region "Eventos Buttons - SUB"
    Private Sub MaisBtn_Click(sender As Object, e As RoutedEventArgs) Handles MaisBtn.Click

        If ValidaCampos() = False Then
            Exit Sub
        End If

        If objCliente.Contatos Is Nothing Then
            objCliente.Contatos = New List(Of ClienteContatos)
        End If

        If objContato Is Nothing Then
            objContato = New ClienteContatos
            objCliente.Contatos.Add(objContato)
        End If
        objContato.Contato = Contatotxt.Text
        objContato.Observacao = OBSConttxt.Text
        objContato.Tipo = TipoContcmb.Text

        Dim msgSucessContat As String = "Contato salvo com sucesso! " & vbNewLine & "Total de Registros: " & objCliente.Contatos.Count
        MsgBox(msgSucessContat, MsgBoxStyle.Information, "Gravação de Contatos")

        srcContatos.Source = Nothing
        srcContatos.Source = objCliente.Contatos.ToList

        LimpaCampos("CT")

    End Sub

    Private Sub MenosBtn_Click(sender As Object, e As RoutedEventArgs) Handles MenosBtn.Click
        If objCliente.Contatos IsNot Nothing AndAlso objContato IsNot Nothing Then
            objCliente.Contatos.Remove(objContato)

            Dim msgSucessDel As String = "Contato excluido com sucesso! " & vbNewLine & "Total de Registros: " & objCliente.Contatos.Count
            MsgBox(msgSucessDel, MsgBoxStyle.Information, "Exclusão de Contato")

            srcContatos.Source = Nothing
            srcContatos.Source = objCliente.Contatos.ToList
        Else
            Dim msgErrorDel As String = "Nenhum contato selecionado para exclusão! " & vbNewLine & "Total de Registros: " & objCliente.Contatos.Count
            MsgBox(msgErrorDel, MsgBoxStyle.Information, "Exclusão de Contato")
        End If

        LimpaCampos("CT")
    End Sub

    Private Sub SalvarBtn_Click(sender As Object, e As RoutedEventArgs) Handles SalvarBtn.Click

        If SalvarCliente() = False Then
            Exit Sub
        End If

        Dim msgSucessCli As String = "Cliente salvo com sucesso! " & vbNewLine & "Total de Registros: " & objCliente.Contatos.Count
        MsgBox(msgSucessCli, MsgBoxStyle.Information, "Gravação de Clientes")

        srcCliente.Source = lstCliente.ToList

        LimpaCampos("T")

    End Sub

    Private Sub ExcluirBtn_Click(sender As Object, e As RoutedEventArgs) Handles ExcluirBtn.Click
        Me.Close()
    End Sub

    Private Sub DataGrid_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles ContatosDataGrid.MouseDoubleClick
        If sender.selectedItem IsNot Nothing Then
            objContato = CType(sender.selectedItem, ClienteContatos)
            Contatotxt.Text = objContato.Contato
            OBSConttxt.Text = objContato.Observacao
            TipoContcmb.Text = objContato.Tipo
        End If
    End Sub

#End Region

#Region "Chamada de Telas - SUB"
    Private Sub Window_Loaded_1(sender As Object, e As RoutedEventArgs)
        FotoCt.Content = New ucCadFoto
    End Sub

    Private Sub wdCadCliente(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Verificar = True
        If Verificar Then
            srcContatos = CType(Me.FindResource("ClienteContatosViewSource"), CollectionViewSource)
            srcCliente = CType(Me.FindResource("ExibirClienteViewSource"), CollectionViewSource)
            lstCliente = New List(Of Cliente)

            If objCliente.Contatos Is Nothing Then
                objCliente.Contatos = New List(Of ClienteContatos)
            End If

            srcContatos.Source = objCliente.Contatos.ToList
        End If
    End Sub
#End Region

    
End Class
