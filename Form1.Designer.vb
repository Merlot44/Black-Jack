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
        PictureBox1 = New PictureBox()
        TBXInstructions = New Label()
        LBLSelectBet = New Label()
        BTNSelect5 = New Label()
        BTNSelect10 = New Label()
        BTNSelect25 = New Label()
        BTNSelect50 = New Label()
        BTNSelect100 = New Label()
        BTNPlay = New Label()
        LBLBank = New Label()
        BTNLeave = New Label()
        LBLSelectCard = New Label()
        LBLTurn = New Label()
        LBLKeep = New Label()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
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
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Unmute
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(896, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
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
        ' 
        ' LBLBank
        ' 
        LBLBank.BackColor = Color.Transparent
        LBLBank.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLBank.ForeColor = Color.White
        LBLBank.Location = New Point(186, 551)
        LBLBank.Name = "LBLBank"
        LBLBank.Size = New Size(278, 97)
        LBLBank.TabIndex = 12
        LBLBank.Text = "Banque: 500"
        LBLBank.TextAlign = ContentAlignment.MiddleCenter
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
        ' 
        ' LBLSelectCard
        ' 
        LBLSelectCard.BackColor = Color.Transparent
        LBLSelectCard.Font = New Font("Comic Sans MS", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLSelectCard.ForeColor = Color.White
        LBLSelectCard.Location = New Point(219, 20)
        LBLSelectCard.Name = "LBLSelectCard"
        LBLSelectCard.Size = New Size(522, 75)
        LBLSelectCard.TabIndex = 14
        LBLSelectCard.Text = "Veuillez sélectionner un option" & vbCrLf & "(rappelez-vous de ne pas dépasser 21!)" & vbCrLf
        LBLSelectCard.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LBLTurn
        ' 
        LBLTurn.BackColor = Color.Transparent
        LBLTurn.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLTurn.ForeColor = Color.White
        LBLTurn.Location = New Point(47, 608)
        LBLTurn.Name = "LBLTurn"
        LBLTurn.Size = New Size(278, 95)
        LBLTurn.TabIndex = 15
        LBLTurn.Text = "Tourner"
        LBLTurn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LBLKeep
        ' 
        LBLKeep.BackColor = Color.Transparent
        LBLKeep.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLKeep.ForeColor = Color.White
        LBLKeep.Location = New Point(635, 607)
        LBLKeep.Name = "LBLKeep"
        LBLKeep.Size = New Size(278, 97)
        LBLKeep.TabIndex = 16
        LBLKeep.Text = "Garder"
        LBLKeep.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox5.Location = New Point(461, 122)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(139, 202)
        PictureBox5.TabIndex = 20
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(311, 122)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(139, 202)
        PictureBox6.TabIndex = 21
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(161, 122)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(139, 202)
        PictureBox7.TabIndex = 22
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox8.Location = New Point(11, 122)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(139, 202)
        PictureBox8.TabIndex = 23
        PictureBox8.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.Transparent
        PictureBox12.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox12.Location = New Point(767, 97)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(173, 253)
        PictureBox12.TabIndex = 27
        PictureBox12.TabStop = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.Transparent
        PictureBox13.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox13.Location = New Point(611, 122)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(139, 202)
        PictureBox13.TabIndex = 28
        PictureBox13.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(802, 367)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(139, 202)
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(12, 342)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(173, 253)
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(202, 367)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(139, 202)
        PictureBox4.TabIndex = 32
        PictureBox4.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.Location = New Point(352, 367)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(139, 202)
        PictureBox9.TabIndex = 31
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackColor = Color.Transparent
        PictureBox10.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox10.Location = New Point(502, 367)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(139, 202)
        PictureBox10.TabIndex = 30
        PictureBox10.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.Transparent
        PictureBox11.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox11.Location = New Point(652, 367)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(139, 202)
        PictureBox11.TabIndex = 29
        PictureBox11.TabStop = False
        ' 
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Page_6
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(958, 718)
        Controls.Add(LBLKeep)
        Controls.Add(LBLTurn)
        Controls.Add(BTNLeave)
        Controls.Add(LBLBank)
        Controls.Add(BTNPlay)
        Controls.Add(PictureBox1)
        Controls.Add(BTNInstructions)
        Controls.Add(LBLTitle)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox12)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(BTNSelect100)
        Controls.Add(BTNSelect50)
        Controls.Add(BTNSelect25)
        Controls.Add(BTNSelect10)
        Controls.Add(BTNSelect5)
        Controls.Add(TBXInstructions)
        Controls.Add(BTNStart)
        Controls.Add(LBLSelectCard)
        Controls.Add(LBLSelectBet)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "WNDMain"
        Text = "Black Jack"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LBLTitle As Label
    Friend WithEvents BTNStart As Label
    Friend WithEvents BTNInstructions As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBXInstructions As Label
    Friend WithEvents LBLSelectBet As Label
    Friend WithEvents BTNSelect5 As Label
    Friend WithEvents BTNSelect10 As Label
    Friend WithEvents BTNSelect25 As Label
    Friend WithEvents BTNSelect50 As Label
    Friend WithEvents BTNSelect100 As Label
    Friend WithEvents BTNPlay As Label
    Friend WithEvents LBLBank As Label
    Friend WithEvents BTNLeave As Label
    Friend WithEvents LBLSelectCard As Label
    Friend WithEvents LBLTurn As Label
    Friend WithEvents LBLKeep As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox

End Class
