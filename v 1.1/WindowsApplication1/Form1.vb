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

   

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Process.Start("https://wa.me/6285890557246")

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Process.Start("https://www.facebook.com/ricky.moch.75/")
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Process.Start("https://github.com/RIKIADVERTISING")
    End Sub
End Class
