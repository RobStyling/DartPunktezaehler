﻿Public Class Form1
    'Variabelen
    Dim Player1Name, Player1Score, Player1Check, Player1Plays, Player2Name, Player2Score, Player2Check, Player2Plays, Player3Name, Player3Score, Player3Check, Player3Plays, Player4Name, Player4Score, Player4Check, Player4Plays, TotalScore As String
    Dim Player1Played, Player2Played, Player3Played, Player4Played As Boolean
    Dim Player1Wuerfe, Player2Wuerfe, Player3Wuerfe, Player4Wuerfe As String


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Buttons deaktivieren
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False
        Button11.Enabled = False
        Button12.Enabled = False
        Button13.Enabled = False
        Button14.Enabled = False
        Button15.Enabled = False
        Button16.Enabled = False
        Button17.Enabled = False
        Button18.Enabled = False
        Button19.Enabled = False
        Button20.Enabled = False
        Button21.Enabled = False
        Button22.Enabled = False
        Button23.Enabled = False
        Button24.Enabled = False
        Button25.Enabled = False
        Button26.Enabled = False
        Button27.Enabled = False
        Button28.Enabled = False
        Button29.Enabled = False
        Button30.Enabled = False
        Button31.Enabled = False
        Button32.Enabled = False
        Button33.Enabled = False
        Button34.Enabled = False
        Button35.Enabled = False
        Button36.Enabled = False
        Button37.Enabled = False
        Button38.Enabled = False
        Button39.Enabled = False
        Button40.Enabled = False
        Button41.Enabled = False
        Button42.Enabled = False
        Button43.Enabled = False
        Button44.Enabled = False
        Button45.Enabled = False
        Button46.Enabled = False
        Button47.Enabled = False
        Button48.Enabled = False
        Button49.Enabled = False
        Button50.Enabled = False
        Button51.Enabled = False
        Button52.Enabled = False
        Button53.Enabled = False
        Button54.Enabled = False
        Button55.Enabled = False
        Button56.Enabled = False
        Button57.Enabled = False
        Button58.Enabled = False
        Button59.Enabled = False
        Button60.Enabled = False
        Button61.Enabled = False
        Button62.Enabled = False
        Button63.Enabled = False
        Button64.Enabled = False
        Button65.Enabled = False
        'All Variabelen setzen
        Player1Name = ""
        Player1Score = 0
        Player2Name = ""
        Player2Score = 0
        Player3Name = ""
        Player3Score = 0
        Player4Name = ""
        Player4Score = 0
        Player1Plays = "True"
        Player2Plays = "True"
        Player3Plays = "True"
        Player4Plays = "True"
        'Inputbox vorbereiten
        Dim message, title, defaultValue As String
        message = "Gebe einen Spieler Namen ein"
        title = "Spielernamen Eingabe"
        defaultValue = ""
        'Inputboxen
        Player1Name = InputBox(message, title, defaultValue, 100, 100)
        If Player1Name Is "" Then
            Player1Name = defaultValue
            TextBox1.Visible = False
            Player1Plays = "False"
        End If
        Player2Name = InputBox(message, title, defaultValue, 100, 100)
        If Player2Name Is "" Then
            Player2Name = defaultValue
            TextBox2.Visible = False
            Player2Plays = "False"
        End If
        Player3Name = InputBox(message, title, defaultValue, 100, 100)
        If Player3Name Is "" Then
            Player3Name = defaultValue
            TextBox3.Visible = False
            Player3Plays = "False"
        End If
        Player4Name = InputBox(message, title, defaultValue, 100, 100)
        If Player4Name Is "" Then
            Player4Name = defaultValue
            TextBox4.Visible = False
            Player4Plays = "False"
        End If
        UpdateScore()
    End Sub

    'Startet Spiel 301
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True
        Button21.Enabled = True
        Button22.Enabled = True
        Button23.Enabled = True
        Button24.Enabled = True
        Button25.Enabled = True
        Button26.Enabled = True
        Button27.Enabled = True
        Button28.Enabled = True
        Button29.Enabled = True
        Button30.Enabled = True
        Button31.Enabled = True
        Button32.Enabled = True
        Button33.Enabled = True
        Button34.Enabled = True
        Button35.Enabled = True
        Button36.Enabled = True
        Button37.Enabled = True
        Button38.Enabled = True
        Button39.Enabled = True
        Button40.Enabled = True
        Button41.Enabled = True
        Button42.Enabled = True
        Button43.Enabled = True
        Button44.Enabled = True
        Button45.Enabled = True
        Button46.Enabled = True
        Button47.Enabled = True
        Button48.Enabled = True
        Button49.Enabled = True
        Button50.Enabled = True
        Button51.Enabled = True
        Button52.Enabled = True
        Button53.Enabled = True
        Button54.Enabled = True
        Button55.Enabled = True
        Button56.Enabled = True
        Button57.Enabled = True
        Button58.Enabled = True
        Button59.Enabled = True
        Button60.Enabled = True
        Button61.Enabled = True
        Button62.Enabled = True
        Button63.Enabled = True
        Button64.Enabled = True
        Button65.Enabled = True
        TotalScore = 301
        Player1Score = TotalScore
        Player2Score = TotalScore
        Player3Score = TotalScore
        Player4Score = TotalScore
        UpdateScore()
        PlayerOne()
    End Sub
    'Startet Spiel 501
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True
        Button21.Enabled = True
        Button22.Enabled = True
        Button23.Enabled = True
        Button24.Enabled = True
        Button25.Enabled = True
        Button26.Enabled = True
        Button27.Enabled = True
        Button28.Enabled = True
        Button29.Enabled = True
        Button30.Enabled = True
        Button31.Enabled = True
        Button32.Enabled = True
        Button33.Enabled = True
        Button34.Enabled = True
        Button35.Enabled = True
        Button36.Enabled = True
        Button37.Enabled = True
        Button38.Enabled = True
        Button39.Enabled = True
        Button40.Enabled = True
        Button41.Enabled = True
        Button42.Enabled = True
        Button43.Enabled = True
        Button44.Enabled = True
        Button45.Enabled = True
        Button46.Enabled = True
        Button47.Enabled = True
        Button48.Enabled = True
        Button49.Enabled = True
        Button50.Enabled = True
        Button51.Enabled = True
        Button52.Enabled = True
        Button53.Enabled = True
        Button54.Enabled = True
        Button55.Enabled = True
        Button56.Enabled = True
        Button57.Enabled = True
        Button58.Enabled = True
        Button59.Enabled = True
        Button60.Enabled = True
        Button61.Enabled = True
        Button62.Enabled = True
        Button63.Enabled = True
        Button64.Enabled = True
        Button65.Enabled = True
        TotalScore = 501
        Player1Score = TotalScore
        Player2Score = TotalScore
        Player3Score = TotalScore
        Player4Score = TotalScore
        UpdateScore()
        PlayerOne()
    End Sub
    'Updated den Score

    Sub UpdateScore()
        TextBox1.Text = "Score " + Player1Name + " " + Player1Score
        TextBox2.Text = "Score " + Player2Name + " " + Player2Score
        TextBox3.Text = "Score " + Player3Name + " " + Player3Score
        TextBox4.Text = "Score " + Player4Name + " " + Player4Score
    End Sub
    'Spieler Handler

    Sub PlayerOne()
        Label3.Text = Player1Name + " ist dran!"
        MessageBox.Show(Player1Name + " ist dran!")
        Player1Check = "True"
        Player1Wuerfe = 3
        Label4.Text = "Würfe: " + Player1Wuerfe
    End Sub
    Sub PlayerTwo()
        Label3.Text = Player2Name + " ist dran!"
        MessageBox.Show(Player2Name + " ist dran!")
        Player2Check = "True"
        Player2Wuerfe = 3
        Label4.Text = "Würfe: " + Player2Wuerfe
    End Sub
    Sub PlayerThree()
        Label3.Text = Player3Name + " ist dran!"
        MessageBox.Show(Player3Name + " ist dran!")
        Player3Check = "True"
        Player3Wuerfe = 3
        Label4.Text = "Würfe: " + Player3Wuerfe
    End Sub
    Sub PlayerFour()
        Label3.Text = Player4Name + " ist dran!"
        MessageBox.Show(Player4Name + " ist dran!")
        Player4Check = "True"
        Player4Wuerfe = 3
        Label4.Text = "Würfe: " + Player4Wuerfe
    End Sub
    'Ersten zwanzig Buttons
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 1
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 1
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 1
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 1
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 4
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 4
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 4
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 4
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 5
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 5
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 5
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 5
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 6
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 6
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 6
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 6
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 7
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 7
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 7
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 7
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 8
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 8
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 8
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 8
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 9
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 9
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 9
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 9
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 10
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 10
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 10
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 10
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 11
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 11
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 11
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 11
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 12
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 12
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 12
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 12
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 13
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 13
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 13
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 13
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 14
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 14
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 14
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 14
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 15
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 15
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 15
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 15
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 16
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 16
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 16
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 16
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 17
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 17
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 17
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 17
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 18
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 18
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 18
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 18
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 19
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 19
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 19
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 19
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 20
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 20
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 20
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 20
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    'Next Player Check

    Sub CheckNextPlayer()
        If Player1Plays = "True" Then
            If Player1Played = False Then
                If Player2Plays = "True" Then
                    If Player2Played = False Then
                        If Player3Plays = "True" Then
                            If Player3Played = False Then
                                If Player4Plays = "True" Then
                                    If Player4Played = True Then
                                        PlayerOne()
                                        Player4Played = False
                                    End If
                                ElseIf Player4Plays = "False" Then
                                    PlayerOne()
                                    Player3Played = False
                                End If
                            ElseIf Player3Played = True Then
                                If Player4Plays = "True" Then
                                    If Player4Played = False Then
                                        PlayerFour()
                                        Player3Played = False
                                    End If
                                ElseIf Player4Plays = "False" Then
                                    PlayerOne()
                                    Player3Played = False
                                End If
                            End If
                        ElseIf Player3Plays = "False" Then
                            PlayerOne()
                            Player2Played = False
                        End If
                    ElseIf Player2Played = True Then
                        If Player3Plays = "True" Then
                            If Player3Played = False Then
                                PlayerThree()
                                Player2Played = False
                            End If
                        ElseIf Player3Plays = "False" Then
                            PlayerOne()
                            Player2Played = False
                        End If
                    End If
                ElseIf Player1Played = True Then
                    PlayerOne()
                    Player1Played = False
                End If
            ElseIf Player1Played = True Then
                If Player2Plays = "True" Then
                    PlayerTwo()
                    Player1Played = False

                Else
                    PlayerOne()
                    Player1Played = False
                End If
            End If
        End If

    End Sub
    'Wurfchecks
    Sub WurfcheckPlayer1()
        Do
            Player1Wuerfe = Player1Wuerfe - 1
            Player1Check = "True"
            If Player1Wuerfe > 0 Then
                Label4.Text = "Würfe: " + Player1Wuerfe
                Return
            End If
        Loop Until Player1Wuerfe <= 0
        Label4.Text = "Würfe: " + Player1Wuerfe
        Player1Check = "False"
        CheckNextPlayer()
    End Sub
    Sub WurfcheckPlayer2()
        Do
            Player2Wuerfe = Player2Wuerfe - 1
            Player2Check = "True"
            If Player2Wuerfe > 0 Then
                Label4.Text = "Würfe: " + Player2Wuerfe
                Return
            End If
        Loop Until Player2Wuerfe <= 0
        Label4.Text = "Würfe: " + Player2Wuerfe
        Player2Check = "False"
        CheckNextPlayer()
    End Sub
    Sub WurfcheckPlayer3()
        Do
            Player3Wuerfe = Player3Wuerfe - 1
            Player3Check = "True"
            If Player3Wuerfe > 0 Then
                Label4.Text = "Würfe: " + Player3Wuerfe
                Return
            End If
        Loop Until Player3Wuerfe <= 0
        Label4.Text = "Würfe: " + Player3Wuerfe
        Player3Check = "False"
        CheckNextPlayer()
    End Sub
    Sub WurfcheckPlayer4()
        Do
            Label4.Text = "Würfe: " + Player4Wuerfe
            Player4Wuerfe = Player4Wuerfe - 1
            Player4Check = "True"
            If Player4Wuerfe > 0 Then
                Label4.Text = "Würfe: " + Player3Wuerfe
                Return
            End If
        Loop Until Player4Wuerfe <= 0
        Label4.Text = "Würfe: " + Player3Wuerfe
        Player4Check = "False"
        CheckNextPlayer()
    End Sub
    'Skip Funktion

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button65.Click
        If Player1Check = "True" Then
            Player1Check = "False"
            Player1Played = True
            WurfcheckPlayer1()
        ElseIf Player2Check = "True" Then
            Player2Check = "False"
            Player2Played = True
            WurfcheckPlayer2()
        ElseIf Player3Check = "True" Then
            Player3Check = "False"
            Player3Played = True
            WurfcheckPlayer3()
        ElseIf Player4Check = "True" Then
            Player4Check = "False"
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub

    'Restliche Buttons
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 1 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 1 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 1 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 1 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 2 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 2 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 2 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 2 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 3 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 3 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 3 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 3 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 4 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 4 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 4 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 4 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 5 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 5 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 5 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 5 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 6 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 6 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 6 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 6 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 7 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 7 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 7 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 7 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 8 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 8 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 8 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 8 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 9 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 9 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 9 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 9 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 10 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 10 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 10 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 10 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 11 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 11 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 11 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 11 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 12 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 12 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 12 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 12 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 13 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 13 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 13 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 13 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 14 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 14 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 14 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 14 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 15 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 15 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 15 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 15 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 16 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 16 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 16 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 16 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button39.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 17 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 17 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 17 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 17 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 18 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 18 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 18 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 18 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button41.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 19 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 19 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 19 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 19 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button42.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 20 * 2
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 20 * 2
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 20 * 2
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 20 * 2
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button43.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 1 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 1 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 1 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 1 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 2 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 2 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 2 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 2 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 3 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 3 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 3 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 3 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 4 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 4 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 4 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 4 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 5 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 5 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 5 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 5 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 6 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 6 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 6 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 6 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 7 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 7 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 7 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 7 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button50.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 8 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 8 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 8 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 8 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button51.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 9 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 9 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 9 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 9 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 10 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 10 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 10 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 10 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button53.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 11 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 11 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 11 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 11 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button54.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 12 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 12 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 12 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 12 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button55.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 13 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 13 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 13 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 13 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button56.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 14 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 14 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 14 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 14 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button57.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 15 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 15 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 15 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 15 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button58.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 16 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 16 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 16 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 16 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button59.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 17 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 17 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 17 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 17 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button60.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 18 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 18 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 18 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 18 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button61.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 19 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 19 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 19 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 19 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button62.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 20 * 3
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 20 * 3
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 20 * 3
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 20 * 3
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button63.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 25
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 25
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 25
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 25
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
    Private Sub Button64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button64.Click
        If Player1Check = "True" Then
            Player1Score = Player1Score - 50
            Player1Check = "False"
            UpdateScore()
            Player1Played = True
            WurfcheckPlayer1()

        ElseIf Player2Check = "True" Then
            Player2Score = Player2Score - 50
            Player2Check = "False"
            UpdateScore()
            Player2Played = True
            WurfcheckPlayer2()

        ElseIf Player3Check = "True" Then

            Player3Score = Player3Score - 50
            Player3Check = "False"
            UpdateScore()
            Player3Played = True
            WurfcheckPlayer3()

        ElseIf Player4Check = "True" Then
            Player4Score = Player4Score - 50
            Player4Check = "False"
            UpdateScore()
            Player4Played = True
            WurfcheckPlayer4()
        End If
    End Sub
End Class
