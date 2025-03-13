Class MainWindow 

    Private Sub ProdutoMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ProdutoMnu.MouseLeftButtonDown
        Dim wd As New wdCadProduto
        wd.ShowDialog()
    End Sub

    Private Sub ClienteMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ClienteMnu.MouseLeftButtonDown
        Dim wd As New wdCadCliente
        wd.ShowDialog()
    End Sub

    Private Sub VeiculosMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles VeiculosMnu.MouseLeftButtonDown
        Dim uc As New ucCadAutomovel
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Veículos"
        Menutb.Items.Add(tb)
    End Sub
End Class
