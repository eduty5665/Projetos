Public Class wdCadProduto
    Dim objProduto As New Produto
    Dim srcProdutos As CollectionViewSource

#Region "Metodos - SUB"
    Private Sub LimpaCamposProduto()
        Codigotxt.Text = ""
        Desctxt.Text = ""
        Datatxt.Text = ""
        Grupotxt.Text = ""
        Tipocmb.Text = ""
        Custotxt.Text = ""
        Margemtxt.Text = ""
        Precotxt.Text = ""
        Statuschk.IsChecked = False
        Codigotxt.Focus()
    End Sub

    Private Function SalvaCampos() As Boolean
        If Codigotxt.Text = "" Then
            MsgBox("Codigo não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Codigotxt.Focus()
            Return False
        ElseIf Desctxt.Text = "" Then
            MsgBox("Descrição não informada, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Desctxt.Focus()
            Return False
        ElseIf Not IsDate(Datatxt.Text) Then
            MsgBox("Data não informada, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Datatxt.Focus()
            Return False
        End If

        If objProduto Is Nothing Then
            objProduto = New Produto
            objProduto.ExibirProd = New List(Of ExibirProd)
        End If

        objProduto.Codigo = Codigotxt.Text
        objProduto.Descricao = Desctxt.Text
        objProduto.Data = Datatxt.Text
        objProduto.Grupo = Grupotxt.Text
        objProduto.Tipo = Tipocmb.Text
        objProduto.Custo = Custotxt.Text
        objProduto.Margem = Margemtxt.Text
        objProduto.Preco = Precotxt.Text
        objProduto.Status = Statuschk.IsChecked

        Return True
    End Function
#End Region

#Region "Eventos Buttons - SUB"
    Private Sub SairBtn_Click(sender As Object, e As RoutedEventArgs) Handles SairBtn.Click
        Me.Close()
    End Sub

    Private Sub SalvarBtn_Click(sender As Object, e As RoutedEventArgs) Handles SalvarBtn.Click
        If SalvaCampos() = False Then
            Exit Sub
        End If

        MsgBox("Registro salvo com sucesso", MsgBoxStyle.Information, "Parabens!")

        Dim objExibe As New ExibirProd
        objExibe.Codigo = Codigotxt.Text
        objExibe.Descricao = Desctxt.Text
        objExibe.Grupo = Grupotxt.Text
        objExibe.Custo = Custotxt.Text
        objExibe.Preco = Precotxt.Text

        If objProduto.ExibirProd Is Nothing Then
            objProduto.ExibirProd = New List(Of ExibirProd)
        End If
        objProduto.ExibirProd.Add(objExibe)

        srcProdutos.Source = objProduto.ExibirProd.ToList

        LimpaCamposProduto()
    End Sub

    Private Sub ExcluirBtn_Click(sender As Object, e As RoutedEventArgs) Handles ExcluirBtn.Click
        LimpaCamposProduto()
    End Sub

    Private Sub NovoBtn_Click(sender As Object, e As RoutedEventArgs) Handles NovoBtn.Click
        LimpaCamposProduto()
    End Sub
#End Region

#Region "Chamada de Tela - SUB"
    Private Sub wdCadProduto(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        srcProdutos = CType(Me.FindResource("ProdutosViewSource"), CollectionViewSource)
    End Sub
#End Region

End Class
