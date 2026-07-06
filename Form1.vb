Public Class Form1
    Public Data As New Collection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False

        Button19.FlatStyle = FlatStyle.Standard


        Me.Text = "ArrayCollection"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer
        i = MsgBox("Are you sure you want to add the data?", MsgBoxStyle.YesNo, "Add Data")
        If i = 6 Then
            Try
                If TextBox3.Text = "" And TextBox4.Text = "" Then
                    Data.Add(TextBox1.Text, TextBox2.Text)
                    MsgBox("Data Add Succesfully...")
                ElseIf TextBox4.Text = "" Then
                    Data.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text)
                    MsgBox("Data Add Succesfully...")

                ElseIf TextBox3.Text = "" Then
                    Data.Add(TextBox1.Text, TextBox2.Text,, TextBox4.Text)
                    MsgBox("Data Add Succesfully...")

                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else

        End If


        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        RichTextBox1.Clear()

        Dim i As Integer
        For i = 1 To Data.Count
            RichTextBox1.Text += " " & Data(i)
        Next


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = True


    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        MsgBox(Data.Count)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Dim i As Integer
            i = MsgBox("Are you sure you want to Remove the data?", MsgBoxStyle.YesNo, "Add Data")
            If i = 6 Then
                Dim v As Integer = TextBox6.Text
                Data.Remove(v)
                MsgBox("Data Remove Successfully")
                TextBox6.Text = ""

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel3.Visible = False


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim i As Integer
        i = MsgBox("Are you sure you want to Remove All the data?", MsgBoxStyle.YesNo, "Remove Data")
        If i = 6 Then
            Data.Clear()
            RichTextBox1.Clear()
        Else
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim i As Integer
        i = MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Exit")
        If i = 6 Then
            Me.Close()

        Else
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel2.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Panel2.Visible = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel4.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Panel5.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Panel5.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            Dim k As String
            k = Data.Item(TextBox7.Text)
            MsgBox(k)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox7.Text = ""



    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try

            Dim v As String
            v = Data.Item(Val(TextBox5.Text))
            MsgBox(v)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox5.Text = ""

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Button20.FlatStyle = FlatStyle.Standard
        Button19.FlatStyle = FlatStyle.Popup
        If Me.BackColor = Color.Bisque Then
            Panel1.BackColor = Color.DarkGray
            Panel2.BackColor = Color.DarkGray
            Panel3.BackColor = Color.DarkGray
            Panel4.BackColor = Color.DarkGray
            Panel5.BackColor = Color.DarkGray
            Panel1.ForeColor = Color.White
            Panel2.ForeColor = Color.White
            Panel3.ForeColor = Color.White
            Panel4.ForeColor = Color.White
            Panel5.ForeColor = Color.White
            Button1.ForeColor = Color.Black
            Button2.ForeColor = Color.Black
            Button3.ForeColor = Color.Black
            Button4.ForeColor = Color.Black
            Button5.ForeColor = Color.Black
            Button6.ForeColor = Color.Black
            Button7.ForeColor = Color.Black
            Button8.ForeColor = Color.Black
            Button9.ForeColor = Color.Black
            Button10.ForeColor = Color.Black
            Button11.ForeColor = Color.Black
            Button12.ForeColor = Color.Black
            Button13.ForeColor = Color.Black
            Button14.ForeColor = Color.Black
            Button15.ForeColor = Color.Black
            Button16.ForeColor = Color.Black
            Button17.ForeColor = Color.Black
            Button18.ForeColor = Color.Black
            Button19.ForeColor = Color.Black
            Button20.ForeColor = Color.Black
            Me.BackColor = Color.SlateGray
            Me.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Button20.FlatStyle = FlatStyle.Popup
        Button19.FlatStyle = FlatStyle.Standard
        If Me.BackColor = Color.SlateGray Then
            Panel1.BackColor = Color.PeachPuff
            Panel2.BackColor = Color.PeachPuff
            Panel3.BackColor = Color.PeachPuff
            Panel4.BackColor = Color.PeachPuff
            Panel5.BackColor = Color.PeachPuff
            Panel1.ForeColor = Color.Black
            Panel2.ForeColor = Color.Black
            Panel3.ForeColor = Color.Black
            Panel4.ForeColor = Color.Black
            Panel5.ForeColor = Color.Black
            Me.BackColor = Color.Bisque
            Me.ForeColor = Color.Black
        End If

    End Sub
End Class
