

Imports System.IO.Ports

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.BackColor = Color.DimGray Then
            Button1.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.BackColor = Color.DimGray Then
            Button2.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.BackColor = Color.DimGray Then
            Button3.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.BackColor = Color.DimGray Then
            Button4.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Button8.BackColor = Color.DimGray Then
            Button8.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Button7.BackColor = Color.DimGray Then
            Button7.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Button6.BackColor = Color.DimGray Then
            Button6.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Button5.BackColor = Color.DimGray Then
            Button5.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Button12.BackColor = Color.DimGray Then
            Button12.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button11.BackColor = Color.DimGray Then
            Button11.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Button10.BackColor = Color.DimGray Then
            Button10.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Button9.BackColor = Color.DimGray Then
            Button9.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Button16.BackColor = Color.DimGray Then
            Button16.BackColor = Color.LimeGreen
            SerialPort1.WriteLine("n")
        End If
    End Sub
End Class
