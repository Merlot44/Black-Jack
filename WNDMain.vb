Imports System.ComponentModel.DataAnnotations
Imports System.Threading

Public Class WNDMain
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Public Points As Integer = 500
    Public Bet As Integer = 0
    Public Suit As Integer = 0
    Public Number As Integer = 0
    Public CardNumber As Integer = 0
    Public PlayerCards As Integer = 0
    Public DealerCards As Integer = 0
    Public PlayerPoints As Integer = 0
    Public DealerPoints As Integer = 0
    Public PlayerAces As Integer = 0
    Public DealerAces As Integer = 0
    Public GamesPlayed As Integer = 0
    Public GamesWon = 0
    Private Sub WNDMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
    End Sub
    Private Sub BTNStart_MouseHover(sender As Object, e As EventArgs) Handles BTNStart.MouseHover
        BTNStart.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNInstructions_MouseHover(sender As Object, e As EventArgs) Handles BTNInstructions.MouseHover
        BTNInstructions.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSound_MouseHover(sender As Object, e As EventArgs) Handles BTNSound.MouseHover
        BTNSound.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSelect5_MouseHover(sender As Object, e As EventArgs) Handles BTNSelect5.MouseHover
        BTNSelect5.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSelect10_MouseHover(sender As Object, e As EventArgs) Handles BTNSelect10.MouseHover
        BTNSelect10.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSelect25_MouseHover(sender As Object, e As EventArgs) Handles BTNSelect25.MouseHover
        BTNSelect25.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSelect50_MouseHover(sender As Object, e As EventArgs) Handles BTNSelect50.MouseHover
        BTNSelect50.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSelect100_MouseHover(sender As Object, e As EventArgs) Handles BTNSelect100.MouseHover
        BTNSelect100.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNPlay_MouseHover(sender As Object, e As EventArgs) Handles BTNPlay.MouseHover
        BTNPlay.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNTurn_MouseHover(sender As Object, e As EventArgs) Handles BTNTurn.MouseHover
        BTNTurn.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNInstructions_Click(sender As Object, e As EventArgs) Handles BTNInstructions.Click
        BTNInstructions.Visible = False
        BackgroundImage = My.Resources.Page_2
        TBXInstructions.Visible = True
        BTNStart.Location = New Point(37, 192)
    End Sub
    Private Sub BTNStart_Click(sender As Object, e As EventArgs) Handles BTNStart.Click
        LBLTitle.Visible = False
        BTNStart.Visible = False
        BTNInstructions.Visible = False
        TBXInstructions.Visible = False
        BackgroundImage = My.Resources.Page_3
        LBLSelectBet.Visible = True
        BTNSelect5.Visible = True
        BTNSelect10.Visible = True
        BTNSelect25.Visible = True
        BTNSelect50.Visible = True
        BTNSelect100.Visible = True
        LBLBet1.Text = "Mise: " + CStr(Bet)
        LBLBet1.Visible = True
        LBLPoints1.Text = "Points: " + CStr(Points)
        LBLPoints1.Visible = True
        BTNPlay.Visible = True
    End Sub
    Private Sub BTNSelect5_Click(sender As Object, e As EventArgs) Handles BTNSelect5.Click
        If Bet <= 95 And Points >= 5 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = False
            Bet += 5
            Points -= 5
        ElseIf Bet > 95 Then
            LBLBroke.Visible = False
            LBLMaxBet.Visible = True
        ElseIf Points < 5 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = True
        End If
        LBLBet1.Text = "Mise: " + CStr(Bet)
        LBLPoints1.Text = "Points: " + CStr(Points)
        LBLBet2.Text = "Mise: " + CStr(Bet)
        LBLPoints2.Text = "Points: " + CStr(Points)
    End Sub
    Private Sub BTNSelect10_Click(sender As Object, e As EventArgs) Handles BTNSelect10.Click
        If Bet <= 90 And Points >= 10 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = False
            Bet += 10
            Points -= 10
        ElseIf Bet > 90 Then
            LBLBroke.Visible = False
            LBLMaxBet.Visible = True
        ElseIf Points < 10 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = True
        End If
        LBLBet1.Text = "Mise: " + CStr(Bet)
        LBLPoints1.Text = "Points: " + CStr(Points)
        LBLBet2.Text = "Mise: " + CStr(Bet)
        LBLPoints2.Text = "Points: " + CStr(Points)
    End Sub
    Private Sub BTNSelect25_Click(sender As Object, e As EventArgs) Handles BTNSelect25.Click
        If Bet <= 75 And Points >= 25 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = False
            Bet += 25
            Points -= 25
        ElseIf Bet > 75 Then
            LBLBroke.Visible = False
            LBLMaxBet.Visible = True
        ElseIf Points < 25 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = True
        End If
        LBLBet1.Text = "Mise: " + CStr(Bet)
        LBLPoints1.Text = "Points: " + CStr(Points)
        LBLBet2.Text = "Mise: " + CStr(Bet)
        LBLPoints2.Text = "Points: " + CStr(Points)
    End Sub
    Private Sub BTNSelect50_Click(sender As Object, e As EventArgs) Handles BTNSelect50.Click
        If Bet <= 50 And Points >= 50 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = False
            Bet += 50
            Points -= 50
        ElseIf Bet > 50 Then
            LBLBroke.Visible = False
            LBLMaxBet.Visible = True
        ElseIf Points < 50 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = True
        End If
        LBLBet1.Text = "Mise: " + CStr(Bet)
        LBLPoints1.Text = "Points: " + CStr(Points)
        LBLBet2.Text = "Mise: " + CStr(Bet)
        LBLPoints2.Text = "Points: " + CStr(Points)
    End Sub
    Private Sub BTNSelect100_Click(sender As Object, e As EventArgs) Handles BTNSelect100.Click
        If Bet <= 0 And Points >= 100 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = False
            Bet += 100
            Points -= 100
        ElseIf Bet > 0 Then
            LBLBroke.Visible = False
            LBLMaxBet.Visible = True
        ElseIf Points < 100 Then
            LBLMaxBet.Visible = False
            LBLBroke.Visible = True
        End If
        LBLBet1.Text = "Mise: " + CStr(Bet)
        LBLPoints1.Text = "Points: " + CStr(Points)
        LBLBet2.Text = "Mise: " + CStr(Bet)
        LBLPoints2.Text = "Points: " + CStr(Points)
    End Sub
    Private Sub BTNPlay_Click(sender As Object, e As EventArgs) Handles BTNPlay.Click
        PlayerCards = 0
        PlayerPoints = 0
        BTNLeave.Visible = False
        LBLSelectBet.Visible = False
        BTNSelect5.Visible = False
        BTNSelect10.Visible = False
        BTNSelect25.Visible = False
        BTNSelect50.Visible = False
        BTNSelect100.Visible = False
        LBLBet1.Visible = False
        LBLPoints1.Visible = False
        LBLMaxBet.Visible = False
        LBLBroke.Visible = False
        BTNPlay.Visible = False
        BackgroundImage = My.Resources.Page_5
        LBLSelectCard.Visible = True
        PBXCardBackDealer.Visible = True
        PBXCardBackPlayer.Visible = True

        ' Turn the dealer's first card
        Suit = Fix(Rnd() * 4)
        Number = Fix(Rnd() * 13)
        CardNumber = (Suit * 100) + Number
        PBXCard1Dealer.BackgroundImage = My.Resources.ResourceManager.GetObject("Card" + CStr(Format(CardNumber, "000")))
        PBXCard1Dealer.Visible = True
        DealerCards += 1
        If Number > 9 Then
            DealerPoints += 10
        ElseIf Number <= 0 Then
            DealerAces += 1
            DealerPoints += 11
        Else
            DealerPoints += (Number + 1)
        End If

        ' Turn the player's first card
        Suit = Fix(Rnd() * 4)
        Number = Fix(Rnd() * 13)
        CardNumber = (Suit * 100) + Number
        PBXCard1Player.BackgroundImage = My.Resources.ResourceManager.GetObject("Card" + CStr(Format(CardNumber, "000")))
        PBXCard1Player.Visible = True
        PlayerCards += 1
        If Number > 9 Then
            PlayerPoints += 10
        ElseIf Number <= 0 Then
            PlayerAces += 1
            PlayerPoints += 11
        Else
            PlayerPoints += (Number + 1)
        End If

        BTNTurn.Visible = True
        BTNKeep.Visible = True
        LBLBet2.Visible = True
        LBLPoints2.Visible = True
    End Sub
    Private Sub BTNTurn_Click(sender As Object, e As EventArgs) Handles BTNTurn.Click
        ' If PlayerCards < 5 Then
        Suit = Fix(Rnd() * 4)
        Number = Fix(Rnd() * 13)
        CardNumber = (Suit * 100) + Number
        PlayerCards += 1
        Me.Controls("PBXCard" + CStr(PlayerCards) + "Player").BackgroundImage = My.Resources.ResourceManager.GetObject("Card" + CStr(Format(CardNumber, "000")))
        Me.Controls("PBXCard" + CStr(PlayerCards) + "Player").Visible = True
        If Number > 9 Then
            PlayerPoints += 10
        ElseIf Number <= 0 Then
            PlayerAces += 1
            PlayerPoints += 11
        Else
            PlayerPoints += (Number + 1)
        End If
        If PlayerPoints > 21 Then
            If PlayerAces > 0 Then
                While PlayerPoints > 21 Or PlayerAces > 0
                    PlayerAces -= 1
                    PlayerPoints -= 10
                End While
            End If
            If PlayerPoints > 21 Then
                GamesPlayed += 1
                LBLPoints2.Visible = False
                LBLBet2.Visible = False
                BTNTurn.Visible = False
                BTNKeep.Visible = False
                BackgroundImage = My.Resources.Page_8
                Application.DoEvents()
                Sleep(1500)
                LBLSelectCard.Visible = False
                PBXCardBackDealer.Visible = False
                PBXCard1Dealer.Visible = False
                PBXCard2Dealer.Visible = False
                PBXCard3Dealer.Visible = False
                PBXCard4Dealer.Visible = False
                PBXCard5Dealer.Visible = False
                PBXCardBackPlayer.Visible = False
                PBXCard1Player.Visible = False
                PBXCard2Player.Visible = False
                PBXCard3Player.Visible = False
                PBXCard4Player.Visible = False
                PBXCard5Player.Visible = False
                BackgroundImage = My.Resources.Page_6
                LBLWinPoints.Text = "Vous avez dépassé 21!" + vbCrLf + "Vous aves perdu vôtre mise!"
                LBLWinPoints.Visible = True
                Application.DoEvents()
                Sleep(2500)
                LBLWinPoints.Visible = False
                Bet = 0
                LBLBet1.Text = "Mise: 0"
                LBLBet2.Text = "Mise: 0"
                If GamesPlayed >= 5 Then
                    BackgroundImage = My.Resources.Page_7
                    If Points > 500 Then
                        LBLWinMessage.Text = "Le match est terminé, vous avez gagné!"
                    Else
                        LBLWinMessage.Text = "Le match est terminé, vous avez perdu!"
                    End If
                    LBLWinMessage.Visible = True
                    LBLStatPoints.Visible = True
                    LBLStatPointsValue.Text = CStr(Points)
                    LBLStatPointsValue.Visible = True
                    LBLStatGamesPlayed.Visible = True
                    LBLStatGamesPlayedValue.Text = CStr(GamesWon)
                    LBLStatGamesPlayedValue.Visible = True
                    BTNRestart.Visible = True
                    GamesPlayed = 0
                Else
                    BackgroundImage = My.Resources.Page_4
                    LBLSelectBet.Visible = True
                    BTNSelect5.Visible = True
                    BTNSelect10.Visible = True
                    BTNSelect25.Visible = True
                    BTNSelect50.Visible = True
                    BTNSelect100.Visible = True
                    BTNPlay.Location = New Point(635, 551)
                    BTNPlay.Visible = True
                    LBLPoints1.Location = New Point(341, 551)
                    LBLPoints1.Visible = True
                    LBLBet1.Visible = True
                    BTNLeave.Visible = True
                End If
            ElseIf PlayerCards >= 5 Then
                GamesPlayed += 1
                LBLBet2.Visible = False
                LBLPoints2.Visible = False
                BTNTurn.Visible = False
                BTNKeep.Visible = False
                BackgroundImage = My.Resources.Page_8
                Application.DoEvents()
                Sleep(1500)
                GamesWon += 1
                LBLSelectCard.Visible = False
                PBXCardBackDealer.Visible = False
                PBXCard1Dealer.Visible = False
                PBXCard2Dealer.Visible = False
                PBXCard3Dealer.Visible = False
                PBXCard4Dealer.Visible = False
                PBXCard5Dealer.Visible = False
                PBXCardBackPlayer.Visible = False
                PBXCard1Player.Visible = False
                PBXCard2Player.Visible = False
                PBXCard3Player.Visible = False
                PBXCard4Player.Visible = False
                PBXCard5Player.Visible = False
                BackgroundImage = My.Resources.Page_6
                LBLWinPoints.Text = "Vous avez tourné 5 cartes!" + vbCrLf + "Vous avez gagné " + CStr(Bet) + " points!"
                LBLWinPoints.Visible = True
                Points += Bet * 2
                Application.DoEvents()
                Sleep(2500)
                LBLWinPoints.Visible = False
                Bet = 0
                LBLBet1.Text = "Mise: 0"
                LBLBet2.Text = "Mise: 0"
                If GamesPlayed >= 5 Then
                    BackgroundImage = My.Resources.Page_7
                    If Points > 500 Then
                        LBLWinMessage.Text = "Le match est terminé, vous avez gagné!"
                    Else
                        LBLWinMessage.Text = "Le match est terminé, vous avez perdu!"
                    End If
                    LBLWinMessage.Visible = True
                    LBLStatPoints.Visible = True
                    LBLStatPointsValue.Text = CStr(Points)
                    LBLStatPointsValue.Visible = True
                    LBLStatGamesPlayed.Visible = True
                    LBLStatGamesPlayedValue.Text = CStr(GamesPlayed)
                    LBLStatGamesPlayedValue.Visible = True
                    BTNRestart.Visible = True
                    GamesPlayed = 0
                Else
                    BackgroundImage = My.Resources.Page_4
                    LBLSelectBet.Visible = True
                    BTNSelect5.Visible = True
                    BTNSelect10.Visible = True
                    BTNSelect25.Visible = True
                    BTNSelect50.Visible = True
                    BTNSelect100.Visible = True
                    BTNPlay.Location = New Point(635, 551)
                    BTNPlay.Visible = True
                    LBLPoints1.Location = New Point(341, 551)
                    LBLPoints1.Visible = True
                    LBLBet1.Visible = True
                    BTNLeave.Visible = True
                End If
            End If
        ElseIf PlayerCards >= 5 Then
            GamesPlayed += 1
            LBLBet2.Visible = False
            LBLPoints2.Visible = False
            BTNTurn.Visible = False
            BTNKeep.Visible = False
            BackgroundImage = My.Resources.Page_8
            Application.DoEvents()
            Sleep(1500)
            GamesWon += 1
            LBLSelectCard.Visible = False
            PBXCardBackDealer.Visible = False
            PBXCard1Dealer.Visible = False
            PBXCard2Dealer.Visible = False
            PBXCard3Dealer.Visible = False
            PBXCard4Dealer.Visible = False
            PBXCard5Dealer.Visible = False
            PBXCardBackPlayer.Visible = False
            PBXCard1Player.Visible = False
            PBXCard2Player.Visible = False
            PBXCard3Player.Visible = False
            PBXCard4Player.Visible = False
            PBXCard5Player.Visible = False
            BackgroundImage = My.Resources.Page_6
            LBLWinPoints.Text = "Vous avez tourné 5 cartes!" + vbCrLf + "Vous avez gagné " + CStr(Bet) + " points!"
            LBLWinPoints.Visible = True
            Points += Bet * 2
            Application.DoEvents()
            Sleep(2500)
            Bet = 0
            LBLBet1.Text = "Mise: 0"
            LBLBet2.Text = "Mise: 0"
            LBLWinPoints.Visible = False
            If GamesPlayed >= 5 Then
                BackgroundImage = My.Resources.Page_7
                If Points > 500 Then
                    LBLWinMessage.Text = "Le match est terminé, vous avez gagné!"
                Else
                    LBLWinMessage.Text = "Le match est terminé, vous avez perdu!"
                End If
                LBLWinMessage.Visible = True
                LBLStatPoints.Visible = True
                LBLStatPointsValue.Text = CStr(Points)
                LBLStatPointsValue.Visible = True
                LBLStatGamesPlayed.Visible = True
                LBLStatGamesPlayedValue.Text = CStr(GamesPlayed)
                LBLStatGamesPlayedValue.Visible = True
                BTNRestart.Visible = True
                GamesPlayed = 0
            Else
                BackgroundImage = My.Resources.Page_4
                LBLSelectBet.Visible = True
                BTNSelect5.Visible = True
                BTNSelect10.Visible = True
                BTNSelect25.Visible = True
                BTNSelect50.Visible = True
                BTNSelect100.Visible = True
                BTNPlay.Location = New Point(635, 551)
                BTNPlay.Visible = True
                LBLPoints1.Location = New Point(341, 551)
                LBLPoints1.Visible = True
                LBLBet1.Visible = True
                BTNLeave.Visible = True
            End If
        End If
        'End If
    End Sub
    Private Sub BTNKeep_Click(sender As Object, e As EventArgs) Handles BTNKeep.Click
        GamesPlayed += 1
        LBLBet2.Visible = False
        LBLPoints2.Visible = False
        BTNTurn.Visible = False
        BTNKeep.Visible = False
        BackgroundImage = My.Resources.Page_8

        While DealerCards < 5 And DealerPoints < 17
            Suit = Fix(Rnd() * 4)
            Number = Fix(Rnd() * 13)
            CardNumber = (Suit * 100) + Number
            DealerCards += 1
            Me.Controls("PBXCard" + CStr(DealerCards) + "Dealer").BackgroundImage = My.Resources.ResourceManager.GetObject("Card" + CStr(Format(CardNumber, "000")))
            Me.Controls("PBXCard" + CStr(DealerCards) + "Dealer").Visible = True
            If Number > 9 Then
                DealerPoints += 10
            ElseIf Number <= 0 Then
                DealerPoints += 11
            Else
                DealerPoints += (Number + 1)
            End If
            Application.DoEvents()
            Sleep(1000)
        End While


        LBLSelectCard.Visible = False
        PBXCardBackDealer.Visible = False
        PBXCard1Dealer.Visible = False
        PBXCard2Dealer.Visible = False
        PBXCard3Dealer.Visible = False
        PBXCard4Dealer.Visible = False
        PBXCard5Dealer.Visible = False
        PBXCardBackPlayer.Visible = False
        PBXCard1Player.Visible = False
        PBXCard2Player.Visible = False
        PBXCard3Player.Visible = False
        PBXCard4Player.Visible = False
        PBXCard5Player.Visible = False
        If DealerPoints > 21 Then
            BackgroundImage = My.Resources.Page_6
            LBLWinPoints.Text = "Le croupier a dépassé 21!" + vbCrLf + "Vous avez gagné " + CStr(Bet) + " points!"
            LBLWinPoints.Visible = True
            Points += Bet * 2
            Application.DoEvents()
            Sleep(2500)
            LBLWinPoints.Visible = False
            If GamesPlayed >= 5 Then
                BackgroundImage = My.Resources.Page_7
                If Points > 500 Then
                    LBLWinMessage.Text = "Le match est terminé, vous avez gagné!"
                Else
                    LBLWinMessage.Text = "Le match est terminé, vous avez perdu!"
                End If
                LBLWinMessage.Visible = True
                LBLStatPoints.Visible = True
                LBLStatPointsValue.Text = CStr(Points)
                LBLStatPointsValue.Visible = True
                LBLStatGamesPlayed.Visible = True
                LBLStatGamesPlayedValue.Text = CStr(GamesPlayed)
                LBLStatGamesPlayedValue.Visible = True
                BTNRestart.Visible = True
                GamesPlayed = 0
            Else
                BackgroundImage = My.Resources.Page_4
                LBLSelectBet.Visible = True
                BTNSelect5.Visible = True
                BTNSelect10.Visible = True
                BTNSelect25.Visible = True
                BTNSelect50.Visible = True
                BTNSelect100.Visible = True
                BTNPlay.Location = New Point(635, 551)
                BTNPlay.Visible = True
                LBLPoints1.Location = New Point(341, 551)
                LBLPoints1.Visible = True
                LBLBet1.Visible = True
                BTNLeave.Visible = True
            End If
        ElseIf PlayerPoints > DealerPoints Then

        End If
    End Sub
End Class