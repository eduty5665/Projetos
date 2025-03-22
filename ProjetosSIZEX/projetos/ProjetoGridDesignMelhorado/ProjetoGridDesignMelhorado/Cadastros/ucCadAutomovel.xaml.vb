Public Class ucCadAutomovel
    Dim objVeiculo As New Veiculos

#Region "Metodos - SUB"
    Private Sub LimpaCamposVeiculo()
        Placatxt.Text = ""
        Desctxt.Text = ""
        Combcmb.Text = ""
        UltKMtxt.Text = ""
        ValorComptxt.Text = ""
        DataComptxt.Text = ""
        TipoCompcmb.Text = ""

        Placatxt.Focus()
    End Sub

    Private Sub LimpaCamposAbast()
        DataAbasttxt.Text = ""
        KMAbasttxt.Text = ""
        QtdLittxt.Text = ""
        ValorTottxt.Text = ""
        DataAbasttxt.Focus()
    End Sub
#End Region

#Region "Eventos Buttons - SUB"
    Private Sub MaisBtn_Click(sender As Object, e As RoutedEventArgs) Handles MaisBtn.Click

        If objVeiculo Is Nothing Then
            MsgBox("Para incluir Abastecimento, precisa salvar o veiculo primeiro.", MsgBoxStyle.Exclamation, "Validação")
            Exit Sub
        End If

        Dim objAbastecimento As New Abastecimento
        objAbastecimento.DataAbast = DataAbasttxt.Text
        objAbastecimento.KMVeiculo = KMAbasttxt.Text
        objAbastecimento.Litros = QtdLittxt.Text
        objAbastecimento.ValorTotal = ValorTottxt.Text

        objVeiculo.Abastecimento = New List(Of Abastecimento)
        objVeiculo.Abastecimento.Add(objAbastecimento)

        Dim mensagem As String = "Abastecimento salvo com sucesso! " & vbNewLine & "Total de Registros: " & objVeiculo.Abastecimento.Count
        MsgBox(mensagem, MsgBoxStyle.Information, "Parabens!")

        LimpaCamposAbast()

    End Sub

    Private Sub MenosBtn_Click(sender As Object, e As RoutedEventArgs) Handles MenosBtn.Click
        LimpaCamposAbast()
    End Sub

    Private Sub SalvarBtn_Click(sender As Object, e As RoutedEventArgs) Handles SalvarBtn.Click
        If Placatxt.Text = "" Then
            MsgBox("Placa do Veiculo não informada, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Placatxt.Focus()
            Exit Sub
        ElseIf Desctxt.Text = "" Then
            MsgBox("Descrição não informado, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Desctxt.Focus()
            Exit Sub
        ElseIf Not IsDate(Datatxt.Text) Then
            MsgBox("Data não informada, verifique!", MsgBoxStyle.Exclamation, "Validação")
            Datatxt.Focus()
            Exit Sub
        End If

        objVeiculo = New Veiculos

        objVeiculo.Placa = Placatxt.Text
        objVeiculo.Descricao = Desctxt.Text
        objVeiculo.Combustivel = Combcmb.Text
        objVeiculo.UltimoKM = UltKMtxt.Text
        objVeiculo.ValorCompra = ValorComptxt.Text
        objVeiculo.DateCompra = DataComptxt.Text
        objVeiculo.TipoPagCompra = TipoCompcmb.Text

        MsgBox("Registro salvo com sucesso", MsgBoxStyle.Information, "Parabens!")

        LimpaCamposVeiculo()

    End Sub

    Private Sub ExcluirBtn_Click(sender As Object, e As RoutedEventArgs) Handles ExcluirBtn.Click
        LimpaCamposVeiculo()
        LimpaCamposAbast()
    End Sub
#End Region
End Class
