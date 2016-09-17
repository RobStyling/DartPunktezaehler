Public Class Form1
    Dim Player1Name, Player1Score, Player1Check, Player1Plays, Player2Name, Player2Score, Player2Check, Player2Plays, Player3Name, Player3Score, Player3Check, Player3Plays, Player4Name, Player4Score, Player4Check, Player4Plays, TotalScore As String
    Dim Player1Played, Player2Played, Player3Played, Player4Played As Boolean
    Dim Player1Wuerfe, Player2Wuerfe, Player3Wuerfe, Player4Wuerfe As String


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Dim message, title, defaultValue As String
        message = "Gebe einen Spieler Namen ein"
        title = "Spielernamen Eingabe"
        defaultValue = ""

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
        TotalScore = 301
        Player1Score = TotalScore
        Player2Score = TotalScore
        Player3Score = TotalScore
        Player4Score = TotalScore
        UpdateScore()
        PlayerOne()
    End Sub
    Sub UpdateScore()
        TextBox1.Text = "Score " + Player1Name + " " + Player1Score
        TextBox2.Text = "Score " + Player2Name + " " + Player2Score
        TextBox3.Text = "Score " + Player3Name + " " + Player3Score
        TextBox4.Text = "Score " + Player4Name + " " + Player4Score
    End Sub
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
                    PlayerTwo()
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
End Class
