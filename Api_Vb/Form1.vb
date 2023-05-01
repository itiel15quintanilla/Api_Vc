Imports Newtonsoft.Json.Linq
Imports System.Net.Http





Public Class Form1
    Private Sub btn_datos_Click(sender As Object, e As EventArgs) Handles btn_datos.Click
        Dim client As New HttpClient

        Using (client)

            Dim url = "https://gorest.co.in/public/v2/users?access-token=e6d48572f69d12208567df293314ee38f9ed8fd57d143adcd7d0b75638dab4a8"
            client.DefaultRequestHeaders.Clear()
            Dim response = client.GetAsync(url).Result
            Dim Res = response.Content.ReadAsStringAsync().Result
            Dim r = JArray.Parse(Res)
            DataGridView1.DataSource = r
        End Using
    End Sub
End Class
