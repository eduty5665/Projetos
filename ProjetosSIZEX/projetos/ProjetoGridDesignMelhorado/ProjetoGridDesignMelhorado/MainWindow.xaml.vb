Class MainWindow 

    Private Sub ProdutoMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ProdutoMnu.MouseLeftButtonDown
        Dim wdP As New wdCadProduto
        wdP.ShowDialog()
    End Sub

    Private Sub ClienteMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ClienteMnu.MouseLeftButtonDown
        Dim wdC As New wdCadCliente
        wdC.ShowDialog()
    End Sub

    Private Sub VeiculosMnu_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles VeiculosMnu.MouseLeftButtonDown
        Dim uc As New ucCadAutomovel
        Dim tb As New TabItem
        tb.Content = uc
        tb.Header = "Veículos"
        Menutb.Items.Add(tb)
    End Sub
End Class
