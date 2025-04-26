<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WNDMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WNDMain))
        LBLTitle = New Label()
        BTNStart = New Label()
        BTNInstructions = New Label()
        BTNSound = New PictureBox()
        TBXInstructions = New Label()
        LBLSelectBet = New Label()
        BTNSelect5 = New Label()
        BTNSelect10 = New Label()
        BTNSelect25 = New Label()
        BTNSelect50 = New Label()
        BTNSelect100 = New Label()
        BTNPlay = New Label()
        LBLPoints1 = New Label()
        BTNLeave = New Label()
        LBLSelectCard = New Label()
        BTNTurn = New Label()
        BTNKeep = New Label()
        PBXCard2Dealer = New PictureBox()
        PBXCard3Dealer = New PictureBox()
        PBXCard4Dealer = New PictureBox()
        PBXCard5Dealer = New PictureBox()
        PBXCardBackDealer = New PictureBox()
        PBXCard1Dealer = New PictureBox()
        PBXCard5Player = New PictureBox()
        PBXCardBackPlayer = New PictureBox()
        PBXCard1Player = New PictureBox()
        PBXCard2Player = New PictureBox()
        PBXCard3Player = New PictureBox()
        PBXCard4Player = New PictureBox()
        LBLWinPoints = New Label()
        LBLWinMessage = New Label()
        LBLStatPoints = New Label()
        LBLStatGamesPlayed = New Label()
        LBLStatPointsValue = New Label()
        BTNRestart = New Label()
        LBLStatGamesPlayedValue = New Label()
        LBLBet1 = New Label()
        LBLMaxBet = New Label()
        LBLBroke = New Label()
        LBLBet2 = New Label()
        LBLPoints2 = New Label()
        LBLBuffer = New Label()
        CType(BTNSound, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard2Dealer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard3Dealer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard4Dealer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard5Dealer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCardBackDealer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard1Dealer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard5Player, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCardBackPlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard1Player, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard2Player, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard3Player, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBXCard4Player, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LBLTitle
        ' 
        LBLTitle.BackColor = Color.Transparent
        LBLTitle.Font = New Font("Comic Sans MS", 40F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLTitle.ForeColor = Color.White
        LBLTitle.Location = New Point(2, 2)
        LBLTitle.Name = "LBLTitle"
        LBLTitle.Size = New Size(339, 154)
        LBLTitle.TabIndex = 0
        LBLTitle.Text = "Black Jack"
        LBLTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BTNStart
        ' 
        BTNStart.BackColor = Color.Transparent
        BTNStart.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNStart.ForeColor = Color.White
        BTNStart.Location = New Point(37, 260)
        BTNStart.Name = "BTNStart"
        BTNStart.Size = New Size(269, 114)
        BTNStart.TabIndex = 1
        BTNStart.Text = "Commencer"
        BTNStart.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BTNInstructions
        ' 
        BTNInstructions.BackColor = Color.Transparent
        BTNInstructions.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNInstructions.ForeColor = Color.White
        BTNInstructions.Location = New Point(37, 504)
        BTNInstructions.Name = "BTNInstructions"
        BTNInstructions.Size = New Size(269, 113)
        BTNInstructions.TabIndex = 2
        BTNInstructions.Text = "Instructions"
        BTNInstructions.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BTNSound
        ' 
        BTNSound.BackColor = Color.Transparent
        BTNSound.BackgroundImage = My.Resources.Resources.Unmute
        BTNSound.BackgroundImageLayout = ImageLayout.Zoom
        BTNSound.Location = New Point(896, 12)
        BTNSound.Name = "BTNSound"
        BTNSound.Size = New Size(50, 50)
        BTNSound.TabIndex = 3
        BTNSound.TabStop = False
        ' 
        ' TBXInstructions
        ' 
        TBXInstructions.BackColor = Color.Transparent
        TBXInstructions.Font = New Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TBXInstructions.ForeColor = Color.White
        TBXInstructions.Location = New Point(37, 342)
        TBXInstructions.Margin = New Padding(3)
        TBXInstructions.Name = "TBXInstructions"
        TBXInstructions.Size = New Size(269, 340)
        TBXInstructions.TabIndex = 4
        TBXInstructions.Text = resources.GetString("TBXInstructions.Text")
        TBXInstructions.TextAlign = ContentAlignment.MiddleCenter
        TBXInstructions.Visible = False
        ' 
        ' LBLSelectBet
        ' 
        LBLSelectBet.BackColor = Color.Transparent
        LBLSelectBet.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLSelectBet.ForeColor = Color.White
        LBLSelectBet.Location = New Point(219, 72)
        LBLSelectBet.Name = "LBLSelectBet"
        LBLSelectBet.Size = New Size(522, 117)
        LBLSelectBet.TabIndex = 5
        LBLSelectBet.Text = "Veuillez sélectionner une mise!"
        LBLSelectBet.TextAlign = ContentAlignment.MiddleCenter
        LBLSelectBet.Visible = False
        ' 
        ' BTNSelect5
        ' 
        BTNSelect5.BackColor = Color.Transparent
        BTNSelect5.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNSelect5.ForeColor = Color.Black
        BTNSelect5.Location = New Point(186, 329)
        BTNSelect5.Name = "BTNSelect5"
        BTNSelect5.Size = New Size(100, 82)
        BTNSelect5.TabIndex = 6
        BTNSelect5.Text = "5"
        BTNSelect5.TextAlign = ContentAlignment.MiddleCenter
        BTNSelect5.Visible = False
        ' 
        ' BTNSelect10
        ' 
        BTNSelect10.BackColor = Color.Transparent
        BTNSelect10.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNSelect10.ForeColor = Color.Black
        BTNSelect10.Location = New Point(308, 329)
        BTNSelect10.Name = "BTNSelect10"
        BTNSelect10.Size = New Size(100, 82)
        BTNSelect10.TabIndex = 7
        BTNSelect10.Text = "10"
        BTNSelect10.TextAlign = ContentAlignment.MiddleCenter
        BTNSelect10.Visible = False
        ' 
        ' BTNSelect25
        ' 
        BTNSelect25.BackColor = Color.Transparent
        BTNSelect25.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNSelect25.ForeColor = Color.Black
        BTNSelect25.Location = New Point(430, 329)
        BTNSelect25.Name = "BTNSelect25"
        BTNSelect25.Size = New Size(100, 82)
        BTNSelect25.TabIndex = 8
        BTNSelect25.Text = "25"
        BTNSelect25.TextAlign = ContentAlignment.MiddleCenter
        BTNSelect25.Visible = False
        ' 
        ' BTNSelect50
        ' 
        BTNSelect50.BackColor = Color.Transparent
        BTNSelect50.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNSelect50.ForeColor = Color.Black
        BTNSelect50.Location = New Point(552, 329)
        BTNSelect50.Name = "BTNSelect50"
        BTNSelect50.Size = New Size(100, 82)
        BTNSelect50.TabIndex = 9
        BTNSelect50.Text = "50"
        BTNSelect50.TextAlign = ContentAlignment.MiddleCenter
        BTNSelect50.Visible = False
        ' 
        ' BTNSelect100
        ' 
        BTNSelect100.BackColor = Color.Transparent
        BTNSelect100.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNSelect100.ForeColor = Color.Black
        BTNSelect100.Location = New Point(674, 329)
        BTNSelect100.Name = "BTNSelect100"
        BTNSelect100.Size = New Size(100, 82)
        BTNSelect100.TabIndex = 10
        BTNSelect100.Text = "100"
        BTNSelect100.TextAlign = ContentAlignment.MiddleCenter
        BTNSelect100.Visible = False
        ' 
        ' BTNPlay
        ' 
        BTNPlay.BackColor = Color.Transparent
        BTNPlay.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNPlay.ForeColor = Color.White
        BTNPlay.Location = New Point(488, 551)
        BTNPlay.Name = "BTNPlay"
        BTNPlay.Size = New Size(278, 97)
        BTNPlay.TabIndex = 11
        BTNPlay.Text = "Débuter"
        BTNPlay.TextAlign = ContentAlignment.MiddleCenter
        BTNPlay.Visible = False
        ' 
        ' LBLPoints1
        ' 
        LBLPoints1.BackColor = Color.Transparent
        LBLPoints1.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLPoints1.ForeColor = Color.White
        LBLPoints1.Location = New Point(186, 551)
        LBLPoints1.Name = "LBLPoints1"
        LBLPoints1.Size = New Size(278, 97)
        LBLPoints1.TabIndex = 12
        LBLPoints1.Text = "Points: 500"
        LBLPoints1.TextAlign = ContentAlignment.MiddleCenter
        LBLPoints1.Visible = False
        ' 
        ' BTNLeave
        ' 
        BTNLeave.BackColor = Color.Transparent
        BTNLeave.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNLeave.ForeColor = Color.White
        BTNLeave.Location = New Point(47, 555)
        BTNLeave.Name = "BTNLeave"
        BTNLeave.Size = New Size(278, 96)
        BTNLeave.TabIndex = 13
        BTNLeave.Text = "Quitter"
        BTNLeave.TextAlign = ContentAlignment.MiddleCenter
        BTNLeave.Visible = False
        ' 
        ' LBLSelectCard
        ' 
        LBLSelectCard.BackColor = Color.Transparent
        LBLSelectCard.Font = New Font("Comic Sans MS", 19F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLSelectCard.ForeColor = Color.White
        LBLSelectCard.Location = New Point(219, 20)
        LBLSelectCard.Margin = New Padding(0)
        LBLSelectCard.Name = "LBLSelectCard"
        LBLSelectCard.Size = New Size(522, 75)
        LBLSelectCard.TabIndex = 14
        LBLSelectCard.Text = "Que voulez-vous faire?" & vbCrLf & "(rappelez-vous de ne pas dépasser 21!)" & vbCrLf
        LBLSelectCard.TextAlign = ContentAlignment.MiddleCenter
        LBLSelectCard.Visible = False
        ' 
        ' BTNTurn
        ' 
        BTNTurn.BackColor = Color.Transparent
        BTNTurn.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNTurn.ForeColor = Color.White
        BTNTurn.Location = New Point(47, 608)
        BTNTurn.Name = "BTNTurn"
        BTNTurn.Size = New Size(278, 95)
        BTNTurn.TabIndex = 15
        BTNTurn.Text = "Tourner"
        BTNTurn.TextAlign = ContentAlignment.MiddleCenter
        BTNTurn.Visible = False
        ' 
        ' BTNKeep
        ' 
        BTNKeep.BackColor = Color.Transparent
        BTNKeep.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNKeep.ForeColor = Color.White
        BTNKeep.Location = New Point(635, 607)
        BTNKeep.Name = "BTNKeep"
        BTNKeep.Size = New Size(278, 97)
        BTNKeep.TabIndex = 16
        BTNKeep.Text = "Garder"
        BTNKeep.TextAlign = ContentAlignment.MiddleCenter
        BTNKeep.Visible = False
        ' 
        ' PBXCard2Dealer
        ' 
        PBXCard2Dealer.BackColor = Color.Transparent
        PBXCard2Dealer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard2Dealer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard2Dealer.Location = New Point(461, 122)
        PBXCard2Dealer.Name = "PBXCard2Dealer"
        PBXCard2Dealer.Size = New Size(139, 202)
        PBXCard2Dealer.TabIndex = 20
        PBXCard2Dealer.TabStop = False
        PBXCard2Dealer.Visible = False
        ' 
        ' PBXCard3Dealer
        ' 
        PBXCard3Dealer.BackColor = Color.Transparent
        PBXCard3Dealer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard3Dealer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard3Dealer.Location = New Point(311, 122)
        PBXCard3Dealer.Name = "PBXCard3Dealer"
        PBXCard3Dealer.Size = New Size(139, 202)
        PBXCard3Dealer.TabIndex = 21
        PBXCard3Dealer.TabStop = False
        PBXCard3Dealer.Visible = False
        ' 
        ' PBXCard4Dealer
        ' 
        PBXCard4Dealer.BackColor = Color.Transparent
        PBXCard4Dealer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard4Dealer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard4Dealer.Location = New Point(161, 122)
        PBXCard4Dealer.Name = "PBXCard4Dealer"
        PBXCard4Dealer.Size = New Size(139, 202)
        PBXCard4Dealer.TabIndex = 22
        PBXCard4Dealer.TabStop = False
        PBXCard4Dealer.Visible = False
        ' 
        ' PBXCard5Dealer
        ' 
        PBXCard5Dealer.BackColor = Color.Transparent
        PBXCard5Dealer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard5Dealer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard5Dealer.Location = New Point(11, 122)
        PBXCard5Dealer.Name = "PBXCard5Dealer"
        PBXCard5Dealer.Size = New Size(139, 202)
        PBXCard5Dealer.TabIndex = 23
        PBXCard5Dealer.TabStop = False
        PBXCard5Dealer.Visible = False
        ' 
        ' PBXCardBackDealer
        ' 
        PBXCardBackDealer.BackColor = Color.Transparent
        PBXCardBackDealer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCardBackDealer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCardBackDealer.Location = New Point(767, 97)
        PBXCardBackDealer.Name = "PBXCardBackDealer"
        PBXCardBackDealer.Size = New Size(173, 253)
        PBXCardBackDealer.TabIndex = 27
        PBXCardBackDealer.TabStop = False
        PBXCardBackDealer.Visible = False
        ' 
        ' PBXCard1Dealer
        ' 
        PBXCard1Dealer.BackColor = Color.Transparent
        PBXCard1Dealer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard1Dealer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard1Dealer.Location = New Point(611, 122)
        PBXCard1Dealer.Name = "PBXCard1Dealer"
        PBXCard1Dealer.Size = New Size(139, 202)
        PBXCard1Dealer.TabIndex = 28
        PBXCard1Dealer.TabStop = False
        PBXCard1Dealer.Visible = False
        ' 
        ' PBXCard5Player
        ' 
        PBXCard5Player.BackColor = Color.Transparent
        PBXCard5Player.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard5Player.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard5Player.Location = New Point(802, 367)
        PBXCard5Player.Name = "PBXCard5Player"
        PBXCard5Player.Size = New Size(139, 202)
        PBXCard5Player.TabIndex = 34
        PBXCard5Player.TabStop = False
        PBXCard5Player.Visible = False
        ' 
        ' PBXCardBackPlayer
        ' 
        PBXCardBackPlayer.BackColor = Color.Transparent
        PBXCardBackPlayer.BackgroundImage = My.Resources.Resources.CardBack
        PBXCardBackPlayer.BackgroundImageLayout = ImageLayout.Zoom
        PBXCardBackPlayer.Location = New Point(12, 342)
        PBXCardBackPlayer.Name = "PBXCardBackPlayer"
        PBXCardBackPlayer.Size = New Size(173, 253)
        PBXCardBackPlayer.TabIndex = 33
        PBXCardBackPlayer.TabStop = False
        PBXCardBackPlayer.Visible = False
        ' 
        ' PBXCard1Player
        ' 
        PBXCard1Player.BackColor = Color.Transparent
        PBXCard1Player.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard1Player.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard1Player.Location = New Point(202, 367)
        PBXCard1Player.Name = "PBXCard1Player"
        PBXCard1Player.Size = New Size(139, 202)
        PBXCard1Player.TabIndex = 32
        PBXCard1Player.TabStop = False
        PBXCard1Player.Visible = False
        ' 
        ' PBXCard2Player
        ' 
        PBXCard2Player.BackColor = Color.Transparent
        PBXCard2Player.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard2Player.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard2Player.Location = New Point(352, 367)
        PBXCard2Player.Name = "PBXCard2Player"
        PBXCard2Player.Size = New Size(139, 202)
        PBXCard2Player.TabIndex = 31
        PBXCard2Player.TabStop = False
        PBXCard2Player.Visible = False
        ' 
        ' PBXCard3Player
        ' 
        PBXCard3Player.BackColor = Color.Transparent
        PBXCard3Player.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard3Player.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard3Player.Location = New Point(502, 367)
        PBXCard3Player.Name = "PBXCard3Player"
        PBXCard3Player.Size = New Size(139, 202)
        PBXCard3Player.TabIndex = 30
        PBXCard3Player.TabStop = False
        PBXCard3Player.Visible = False
        ' 
        ' PBXCard4Player
        ' 
        PBXCard4Player.BackColor = Color.Transparent
        PBXCard4Player.BackgroundImage = My.Resources.Resources.CardBack
        PBXCard4Player.BackgroundImageLayout = ImageLayout.Zoom
        PBXCard4Player.Location = New Point(652, 367)
        PBXCard4Player.Name = "PBXCard4Player"
        PBXCard4Player.Size = New Size(139, 202)
        PBXCard4Player.TabIndex = 29
        PBXCard4Player.TabStop = False
        PBXCard4Player.Visible = False
        ' 
        ' LBLWinPoints
        ' 
        LBLWinPoints.BackColor = Color.Transparent
        LBLWinPoints.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWinPoints.ForeColor = Color.White
        LBLWinPoints.Location = New Point(196, 282)
        LBLWinPoints.Name = "LBLWinPoints"
        LBLWinPoints.Size = New Size(568, 156)
        LBLWinPoints.TabIndex = 35
        LBLWinPoints.Text = "Vous avez gagné 999 points!"
        LBLWinPoints.TextAlign = ContentAlignment.MiddleCenter
        LBLWinPoints.Visible = False
        ' 
        ' LBLWinMessage
        ' 
        LBLWinMessage.BackColor = Color.Transparent
        LBLWinMessage.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLWinMessage.ForeColor = Color.White
        LBLWinMessage.Location = New Point(132, 50)
        LBLWinMessage.Name = "LBLWinMessage"
        LBLWinMessage.Size = New Size(696, 160)
        LBLWinMessage.TabIndex = 36
        LBLWinMessage.Text = "Le match est terminé," & vbCrLf & "Vous avez gagnés!"
        LBLWinMessage.TextAlign = ContentAlignment.MiddleCenter
        LBLWinMessage.Visible = False
        ' 
        ' LBLStatPoints
        ' 
        LBLStatPoints.BackColor = Color.Transparent
        LBLStatPoints.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLStatPoints.ForeColor = Color.White
        LBLStatPoints.Location = New Point(242, 300)
        LBLStatPoints.Name = "LBLStatPoints"
        LBLStatPoints.Size = New Size(354, 81)
        LBLStatPoints.TabIndex = 37
        LBLStatPoints.Text = "Points"
        LBLStatPoints.TextAlign = ContentAlignment.MiddleCenter
        LBLStatPoints.Visible = False
        ' 
        ' LBLStatGamesPlayed
        ' 
        LBLStatGamesPlayed.BackColor = Color.Transparent
        LBLStatGamesPlayed.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLStatGamesPlayed.ForeColor = Color.White
        LBLStatGamesPlayed.Location = New Point(242, 403)
        LBLStatGamesPlayed.Name = "LBLStatGamesPlayed"
        LBLStatGamesPlayed.Size = New Size(354, 81)
        LBLStatGamesPlayed.TabIndex = 38
        LBLStatGamesPlayed.Text = "Joutes gagnés"
        LBLStatGamesPlayed.TextAlign = ContentAlignment.MiddleCenter
        LBLStatGamesPlayed.Visible = False
        ' 
        ' LBLStatPointsValue
        ' 
        LBLStatPointsValue.BackColor = Color.Transparent
        LBLStatPointsValue.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLStatPointsValue.ForeColor = Color.White
        LBLStatPointsValue.Location = New Point(619, 300)
        LBLStatPointsValue.Name = "LBLStatPointsValue"
        LBLStatPointsValue.Size = New Size(98, 81)
        LBLStatPointsValue.TabIndex = 39
        LBLStatPointsValue.Text = "999"
        LBLStatPointsValue.TextAlign = ContentAlignment.MiddleCenter
        LBLStatPointsValue.Visible = False
        ' 
        ' BTNRestart
        ' 
        BTNRestart.BackColor = Color.Transparent
        BTNRestart.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNRestart.ForeColor = Color.White
        BTNRestart.Location = New Point(281, 574)
        BTNRestart.Name = "BTNRestart"
        BTNRestart.Size = New Size(398, 96)
        BTNRestart.TabIndex = 41
        BTNRestart.Text = "Recommencer"
        BTNRestart.TextAlign = ContentAlignment.MiddleCenter
        BTNRestart.Visible = False
        ' 
        ' LBLStatGamesPlayedValue
        ' 
        LBLStatGamesPlayedValue.BackColor = Color.Transparent
        LBLStatGamesPlayedValue.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLStatGamesPlayedValue.ForeColor = Color.White
        LBLStatGamesPlayedValue.Location = New Point(619, 403)
        LBLStatGamesPlayedValue.Name = "LBLStatGamesPlayedValue"
        LBLStatGamesPlayedValue.Size = New Size(98, 81)
        LBLStatGamesPlayedValue.TabIndex = 40
        LBLStatGamesPlayedValue.Text = "9"
        LBLStatGamesPlayedValue.TextAlign = ContentAlignment.MiddleCenter
        LBLStatGamesPlayedValue.Visible = False
        ' 
        ' LBLBet1
        ' 
        LBLBet1.BackColor = Color.Transparent
        LBLBet1.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLBet1.ForeColor = Color.White
        LBLBet1.Location = New Point(186, 447)
        LBLBet1.Name = "LBLBet1"
        LBLBet1.Size = New Size(588, 82)
        LBLBet1.TabIndex = 42
        LBLBet1.Text = "Mise: 0"
        LBLBet1.TextAlign = ContentAlignment.MiddleCenter
        LBLBet1.Visible = False
        ' 
        ' LBLMaxBet
        ' 
        LBLMaxBet.BackColor = Color.Transparent
        LBLMaxBet.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLMaxBet.ForeColor = Color.White
        LBLMaxBet.Location = New Point(47, 660)
        LBLMaxBet.Name = "LBLMaxBet"
        LBLMaxBet.Size = New Size(866, 43)
        LBLMaxBet.TabIndex = 43
        LBLMaxBet.Text = "Vous ne pouvez pas dépasser une mise de 100 points!"
        LBLMaxBet.TextAlign = ContentAlignment.MiddleCenter
        LBLMaxBet.Visible = False
        ' 
        ' LBLBroke
        ' 
        LBLBroke.BackColor = Color.Transparent
        LBLBroke.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLBroke.ForeColor = Color.White
        LBLBroke.Location = New Point(47, 661)
        LBLBroke.Name = "LBLBroke"
        LBLBroke.Size = New Size(866, 43)
        LBLBroke.TabIndex = 44
        LBLBroke.Text = "Vous n'avez plus de points disponibles!"
        LBLBroke.TextAlign = ContentAlignment.MiddleCenter
        LBLBroke.Visible = False
        ' 
        ' LBLBet2
        ' 
        LBLBet2.BackColor = Color.Transparent
        LBLBet2.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLBet2.ForeColor = Color.White
        LBLBet2.Location = New Point(352, 608)
        LBLBet2.Name = "LBLBet2"
        LBLBet2.Size = New Size(248, 40)
        LBLBet2.TabIndex = 45
        LBLBet2.Text = "Mise: 0"
        LBLBet2.TextAlign = ContentAlignment.MiddleCenter
        LBLBet2.Visible = False
        ' 
        ' LBLPoints2
        ' 
        LBLPoints2.BackColor = Color.Transparent
        LBLPoints2.Font = New Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLPoints2.ForeColor = Color.White
        LBLPoints2.Location = New Point(352, 660)
        LBLPoints2.Name = "LBLPoints2"
        LBLPoints2.Size = New Size(248, 40)
        LBLPoints2.TabIndex = 46
        LBLPoints2.Text = "Points: 500"
        LBLPoints2.TextAlign = ContentAlignment.MiddleCenter
        LBLPoints2.Visible = False
        ' 
        ' LBLBuffer
        ' 
        LBLBuffer.AutoSize = True
        LBLBuffer.BackColor = Color.Transparent
        LBLBuffer.ForeColor = Color.Transparent
        LBLBuffer.Location = New Point(359, 3)
        LBLBuffer.Name = "LBLBuffer"
        LBLBuffer.Size = New Size(0, 15)
        LBLBuffer.TabIndex = 47
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Page_8
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(958, 718)
        Controls.Add(LBLBuffer)
        Controls.Add(LBLWinPoints)
        Controls.Add(LBLPoints2)
        Controls.Add(LBLBet2)
        Controls.Add(PBXCard5Player)
        Controls.Add(PBXCardBackPlayer)
        Controls.Add(PBXCard1Player)
        Controls.Add(PBXCard2Player)
        Controls.Add(PBXCard3Player)
        Controls.Add(PBXCard4Player)
        Controls.Add(PBXCard1Dealer)
        Controls.Add(PBXCardBackDealer)
        Controls.Add(PBXCard5Dealer)
        Controls.Add(PBXCard4Dealer)
        Controls.Add(PBXCard3Dealer)
        Controls.Add(PBXCard2Dealer)
        Controls.Add(LBLBet1)
        Controls.Add(BTNKeep)
        Controls.Add(BTNTurn)
        Controls.Add(BTNLeave)
        Controls.Add(LBLPoints1)
        Controls.Add(BTNPlay)
        Controls.Add(BTNSound)
        Controls.Add(BTNInstructions)
        Controls.Add(LBLTitle)
        Controls.Add(BTNSelect100)
        Controls.Add(BTNSelect50)
        Controls.Add(BTNSelect25)
        Controls.Add(BTNSelect10)
        Controls.Add(BTNSelect5)
        Controls.Add(TBXInstructions)
        Controls.Add(BTNStart)
        Controls.Add(LBLSelectCard)
        Controls.Add(LBLSelectBet)
        Controls.Add(LBLStatGamesPlayedValue)
        Controls.Add(LBLStatPointsValue)
        Controls.Add(LBLStatGamesPlayed)
        Controls.Add(LBLStatPoints)
        Controls.Add(BTNRestart)
        Controls.Add(LBLBroke)
        Controls.Add(LBLMaxBet)
        Controls.Add(LBLWinMessage)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "WNDMain"
        Text = "Black Jack"
        CType(BTNSound, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard2Dealer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard3Dealer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard4Dealer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard5Dealer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCardBackDealer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard1Dealer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard5Player, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCardBackPlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard1Player, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard2Player, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard3Player, ComponentModel.ISupportInitialize).EndInit()
        CType(PBXCard4Player, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLTitle As Label
    Friend WithEvents BTNStart As Label
    Friend WithEvents BTNInstructions As Label
    Friend WithEvents BTNSound As PictureBox
    Friend WithEvents TBXInstructions As Label
    Friend WithEvents LBLSelectBet As Label
    Friend WithEvents BTNSelect5 As Label
    Friend WithEvents BTNSelect10 As Label
    Friend WithEvents BTNSelect25 As Label
    Friend WithEvents BTNSelect50 As Label
    Friend WithEvents BTNSelect100 As Label
    Friend WithEvents BTNPlay As Label
    Friend WithEvents LBLPoints1 As Label
    Friend WithEvents BTNLeave As Label
    Friend WithEvents LBLSelectCard As Label
    Friend WithEvents BTNTurn As Label
    Friend WithEvents BTNKeep As Label
    Friend WithEvents PBXCard2Dealer As PictureBox
    Friend WithEvents PBXCard3Dealer As PictureBox
    Friend WithEvents PBXCard4Dealer As PictureBox
    Friend WithEvents PBXCard5Dealer As PictureBox
    Friend WithEvents PBXCardBackDealer As PictureBox
    Friend WithEvents PBXCard1Dealer As PictureBox
    Friend WithEvents PBXCard5Player As PictureBox
    Friend WithEvents PBXCardBackPlayer As PictureBox
    Friend WithEvents PBXCard1Player As PictureBox
    Friend WithEvents PBXCard2Player As PictureBox
    Friend WithEvents PBXCard3Player As PictureBox
    Friend WithEvents PBXCard4Player As PictureBox
    Friend WithEvents LBLWinPoints As Label
    Friend WithEvents LBLWinMessage As Label
    Friend WithEvents LBLStatPoints As Label
    Friend WithEvents LBLStatGamesPlayed As Label
    Friend WithEvents LBLStatPointsValue As Label
    Friend WithEvents BTNRestart As Label
    Friend WithEvents LBLStatGamesPlayedValue As Label
    Friend WithEvents LBLBet1 As Label
    Friend WithEvents LBLMaxBet As Label
    Friend WithEvents LBLBroke As Label
    Friend WithEvents LBLBet2 As Label
    Friend WithEvents LBLPoints2 As Label
    Friend WithEvents LBLBuffer As Label

End Class
