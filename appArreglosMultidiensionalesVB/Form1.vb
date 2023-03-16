Imports System.Diagnostics.Contracts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub
    Dim contacto As String(,) = New String(9, 2) {}
    Dim i As Integer = 0
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If i < contacto.GetLength(0) Then
            contacto(i, 0) = txtNombre.Text
            contacto(i, 1) = txtCorreo.Text
            contacto(i, 2) = txtTelefono.Text
            ListView1.Items.Add(contacto(i, 0) & ", " + contacto(i, 1) & ", " + contacto(i, 2))
            i += 1
        End If
    End Sub
End Class
