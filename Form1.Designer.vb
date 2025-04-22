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
        LBLSelect = New Label()
        BTNSelect5 = New Label()
        BTNSelect10 = New Label()
        BTNSelect25 = New Label()
        BTNSelect50 = New Label()
        BTNSelect100 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' LBLSelect
        ' 
        LBLSelect.BackColor = Color.Transparent
        LBLSelect.Font = New Font("Comic Sans MS", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LBLSelect.ForeColor = Color.White
        LBLSelect.Location = New Point(219, 72)
        LBLSelect.Name = "LBLSelect"
        LBLSelect.Size = New Size(522, 117)
        LBLSelect.TabIndex = 5
        LBLSelect.Text = "Veuillez sélectionner une mise!"
        LBLSelect.TextAlign = ContentAlignment.MiddleCenter
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
        ' WNDMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Page_3
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(958, 718)
        Controls.Add(BTNSelect100)
        Controls.Add(BTNSelect50)
        Controls.Add(BTNSelect25)
        Controls.Add(BTNSelect10)
        Controls.Add(BTNSelect5)
        Controls.Add(LBLSelect)
        Controls.Add(PictureBox1)
        Controls.Add(BTNInstructions)
        Controls.Add(BTNStart)
        Controls.Add(LBLTitle)
        Controls.Add(TBXInstructions)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "WNDMain"
        Text = "Black Jack"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LBLTitle As Label
    Friend WithEvents BTNStart As Label
    Friend WithEvents BTNInstructions As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBXInstructions As Label
    Friend WithEvents LBLSelect As Label
    Friend WithEvents BTNSelect5 As Label
    Friend WithEvents BTNSelect10 As Label
    Friend WithEvents BTNSelect25 As Label
    Friend WithEvents BTNSelect50 As Label
    Friend WithEvents BTNSelect100 As Label

End Class
