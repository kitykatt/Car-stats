Public Class Form1
    Dim cars(10) As car
    Structure car
        Dim make As String
        Dim model As String
        Dim hp As Integer
        Dim mpg As Integer
        Dim price As Decimal
        Dim pic As Image
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = PictureBox2.Image
        Dim tt As car
        tt.make = "Audi"
        tt.model = "TT"
        tt.hp = 225
        tt.mpg = 28
        tt.price = 5000
        Label1.Text = "Make: " + tt.make
        Label2.Text = "Model: " + tt.model
        Label3.Text = "Horse Power:" + Str(tt.hp)
        Label4.Text = "Miles per Gallon:" + Str(tt.mpg)
        Label5.Text = "Price: " + tt.price.ToString("C2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = PictureBox6.Image
        Dim maxima As car
        maxima.make = "Nissan"
        maxima.model = "maxima"
        maxima.hp = 300
        maxima.mpg = 20
        maxima.price = 37090
        Label1.Text = "Make: " + maxima.make
        Label2.Text = "Model: " + maxima.model
        Label3.Text = "Horse Power:" + Str(maxima.hp)
        Label4.Text = "Miles per Gallon:" + Str(maxima.mpg)
        Label5.Text = "Price: " + maxima.price.ToString("C2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = PictureBox3.Image
        Dim Camry As car
        Camry.make = "Toyota"
        Camry.model = "Camry"
        Camry.hp = 301
        Camry.mpg = 28
        Camry.price = 25395
        Label1.Text = "Make: " + Camry.make
        Label2.Text = "Model: " + Camry.model
        Label3.Text = "Horse Power:" + Str(Camry.hp)
        Label4.Text = "Miles per Gallon:" + Str(Camry.mpg)
        Label5.Text = "Price: " + Camry.price.ToString("C2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = PictureBox5.Image
        Dim Corolla As car
        Corolla.make = "Toyota"
        Corolla.model = "Corolla"
        Corolla.hp = 169
        Corolla.mpg = 31
        Corolla.price = 20175
        Label1.Text = "Make: " + Corolla.make
        Label2.Text = "Model: " + Corolla.model
        Label3.Text = "Horse Power:" + Str(Corolla.hp)
        Label4.Text = "Miles per Gallon:" + Str(Corolla.mpg)
        Label5.Text = "Price: " + Corolla.price.ToString("C2")
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Image = PictureBox4.Image
        Dim Focus As car
        Focus.make = "Ford"
        Focus.model = "Focus"
        Focus.hp = 350
        Focus.mpg = 30
        Focus.price = 19000
        Label1.Text = "Make: " + Focus.make
        Label2.Text = "Model: " + Focus.model
        Label3.Text = "Horse Power:" + Str(Focus.hp)
        Label4.Text = "Miles per Gallon:" + Str(Focus.mpg)
        Label5.Text = "Price: " + Focus.price.ToString("C2")
    End Sub
End Class
