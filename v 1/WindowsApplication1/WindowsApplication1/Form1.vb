Public Class Form1

    Private Sub bt_conek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_conek.Click
        SerialPort1.BaudRate = Val(tb_baudre.Text)
        SerialPort1.PortName = tb_com.Text
        Try
            SerialPort1.Open()
            If SerialPort1.IsOpen() Then
                pb_conek.BackColor = Color.Green

            End If

        Catch ex As Exception
            MessageBox.Show("KOMPUTER TIDAK TERKONEKSI KE MODUL DTF ROOL TO ROOL ! ! ! ! ")

        End Try
      



    End Sub

    Private Sub tb_baudre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_baudre.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label4.Click

    End Sub

    Private Sub tb_com_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_com.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
