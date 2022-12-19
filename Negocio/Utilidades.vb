Public Class Utilidades

    Public Shared Function estaVacio(_val As String) As Boolean
        Return IIf(_val = "", True, False)
    End Function



End Class
