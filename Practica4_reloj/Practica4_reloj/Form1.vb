Public Class Form1
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' inicia los timers
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' crear una variable, le asigna un valor, el valor es la fecha del dia de hoy convertida a string en el formato de "dd 'de' MMMM 'del' yyyy"
        ' "dd" es el numero del dia, "MMMM" es el mes del año y "yyyy" el año
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o = ""

        ' Este es el formato de 24 horas
        If formato = True Then
            ' "08:06:56:12"
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
            ' HH es 24 horas y hh es de 12 horas
        End If

        Dim time_mod = Time_o.Split(":")
        ' time_mod(0) = "08"
        ' time mod(1) = "06"
        ' time_mod(2) = "56"
        ' time_mod(3) = "12"
        horas.Text = time_mod(0)
        minutos.Text = time_mod(1)
        segundos.Text = time_mod(2)
        dia.Text = Day_o
        fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub fecha_Click(sender As Object, e As EventArgs) Handles fecha.Click


    End Sub

    'boton configuraciones
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            horas.ForeColor = Color.White
            minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            dia.ForeColor = Color.White
            fecha.ForeColor = Color.White
            segundos.ForeColor = Color.White

        ElseIf color_texto = "Rojo" Then
            horas.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            dia.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            segundos.ForeColor = Color.Red

        ElseIf color_texto = "Azul" Then
            horas.ForeColor = Color.Blue
            minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            dia.ForeColor = Color.Blue
            fecha.ForeColor = Color.Blue
            segundos.ForeColor = Color.Blue

        ElseIf color_texto = "Amarillo" Then
            horas.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            dia.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
            segundos.ForeColor = Color.Yellow

        ElseIf color_texto = "Verde" Then
            horas.ForeColor = Color.Green
            minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            dia.ForeColor = Color.Green
            fecha.ForeColor = Color.Green
            segundos.ForeColor = Color.Green

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False

        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub
    '===========================
    ' codigo para el cronometro
    '===========================

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero   'tiempo que lleva transcurrido 

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            Start.Text = "Stop"
            startTime = DateTime.Now

        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            Start.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        elapsed = TimeSpan.Zero
        Timer3.Enabled = False
        Tiempo.Text = "00:00:00.00"
        boton_start = False
        Start.Text = "Start"
        'se reinicia a cero horas
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim current = elapsed + (DateTime.Now - startTime)
        Tiempo.Text = current.ToString("hh\:mm\:ss\.ff")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    'codigo del temporizador

    Private tiempoRestante As TimeSpan = TimeSpan.Zero
    Private temporizadorActivo As Boolean = False


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True
        End If
    End Sub

    Private Sub onemin_Click(sender As Object, e As EventArgs) Handles onemin.Click

        'boton 1 min
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(1))
        Label5.Text = tiempoRestante.ToString("mm\:ss")

    End Sub

    Private Sub fivemin_Click(sender As Object, e As EventArgs) Handles fivemin.Click

        'boton 5 min
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(5))
        Label5.Text = tiempoRestante.ToString("mm\:ss")

    End Sub

    Private Sub start_button_Click(sender As Object, e As EventArgs) Handles start_button.Click

        'boton start
        If tiempoRestante = TimeSpan.Zero Then
            MessageBox.Show("Agrega tiempo primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub
        End If

        If temporizadorActivo = False Then
            Timer4.Enabled = False
            temporizadorActivo = True
            start_button.Text = "Stop"
        Else
            Timer4.Enabled = False
            temporizadorActivo = False
            start_button.Text = "Start"
        End If

    End Sub

    Private Sub reset_button_Click(sender As Object, e As EventArgs) Handles reset_button.Click

        'boton reset
        Timer4.Enabled = False
        tiempoRestante = TimeSpan.Zero
        temporizadorActivo = False
        Label5.Text = "00:00"
        start_button.Text = "Start"
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        If tiempoRestante.TotalMilliseconds > 0 Then
            tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromMilliseconds(Timer4.Interval))
            Label5.Text = tiempoRestante.ToString("mm:ss")
        Else
            'tiempo terminado
            Timer4.Enabled = False
            temporizadorActivo = False
            temporizadorActivo = False
            tiempoRestante = TimeSpan.Zero
            Label5.Text = "00:00"
            start_button.Text = "Start"

            MessageBox.Show("⏰ ¡Tiempo terminado!", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
