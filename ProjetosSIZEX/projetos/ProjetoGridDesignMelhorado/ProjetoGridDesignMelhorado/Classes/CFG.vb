Public Class CFG
    Public Shared Function RetornaVrPadrao(valor As String) As Double
        If IsNumeric(valor) Then
            If CDbl(valor) > 0 Then
                Return CDbl(valor)
            End If
        End If
        Return 0
    End Function

    Public Shared Function FormataCPF(valor As String) As String
        Dim vr As String = valor
        vr = Replace(Replace(vr, ".", ""), "-", "")
        If IsNumeric(vr) = True Then
            If Len(vr) = 11 Then
                Return Left(vr, 3) & "." & Mid(vr, 4, 3) & "." & Mid(vr, 7, 3) & "-" & Right(vr, 2)
            End If
        End If
        Return "CPF INVÁLIDO"
    End Function

    Public Shared Function FormataRG(valor As String) As String
        Dim vr As String = valor
        vr = Replace(Replace(vr, ".", ""), "-", "")
        If IsNumeric(vr) = True Then
            If Len(vr) = 9 Then
                Return Left(vr, 2) & "." & Mid(vr, 3, 3) & "." & Mid(vr, 6, 3) & "-" & Right(vr, 1)
            End If
        End If
        Return "RG INVÁLIDO"
    End Function

    Public Shared Function FormataCNPJ(tipo As String, valor As String) As String
        Dim vr As String = valor
        vr = Replace(Replace(vr, ".", ""), "-", "")
        If IsNumeric(vr) = True Then
            If tipo = "F" Then
                If Len(vr) = 14 Then
                    Return Left(vr, 2) & "." & Mid(vr, 3, 3) & "." & Mid(vr, 6, 3) & "/" & Mid(vr, 9, 4) & "-" & Right(vr, 2)
                End If
            End If
        End If
        Return "CNPJ INVÁLIDO"
    End Function

    Public Shared Function FormataTipoContato(contato As String) As String
        Dim cont As String = contato
        If IsNumeric(cont) = True Then
            cont = Replace(Replace(Replace(Replace(cont, ".", ""), "-", ""), "(", ""), ")", "")
            If Len(cont) = 11 Then
                Return "(" & Left(cont, 2) & ")" & Mid(cont, 3, 5) & "-" & Right(cont, 4)
            End If
            'ElseIf IsNumeric(cont) = True Then
            '    cont = Replace(Replace(Replace(Replace(cont, ".", ""), "-", ""), "(", ""), ")", "")
            '    If Len(cont) = 10 Then
            '        Return "(" & Left(cont, 2) & ")" & Mid(cont, 3, 4) & "-" & Right(cont, 4)
            '    End If
        ElseIf cont.Contains("@") Then
            Return cont
        End If
        Return "TELEFONE INVÁLIDO"
    End Function

    Public Shared Function FormataPreco(custo As Double, margem As Double) As Double
        Dim c As Double = custo
        Dim m As Double = margem
        Dim Preco As Double = Math.Round(c + (c * (m / 100)), 2)
        Return Preco
    End Function

    Public Shared Function FormataMargem(custo As Double, preco As Double) As Double
        Dim c As Double = custo
        Dim p As Double = preco
        Dim Margem As Double = Math.Round(((p - c) / c) * 100, 2)
        Return Margem
    End Function
End Class