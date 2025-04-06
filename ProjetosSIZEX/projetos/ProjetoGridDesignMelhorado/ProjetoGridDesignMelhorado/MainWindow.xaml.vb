Class MainWindow 

    Private Sub ProdutoMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ProdutoMnu.MouseLeftButtonDown
        Dim uc As New ucCadProduto
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Produtos"
        Menutb.Items.Add(tb)
    End Sub

    Private Sub ClienteMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ClienteMnu.MouseLeftButtonDown
        Dim uc As New ucCadCliente
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Clientes"
        Menutb.Items.Add(tb)
    End Sub

    Private Sub VeiculosMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles VeiculosMnu.MouseLeftButtonDown
        Dim uc As New ucCadAutomovel
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Veículos"
        Menutb.Items.Add(tb)
    End Sub

    Private Sub FornMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles FornMnu.MouseLeftButtonDown
        Dim uc As New ucCadCliente("F")
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Fornecedores"
        Menutb.Items.Add(tb)
    End Sub
End Class
