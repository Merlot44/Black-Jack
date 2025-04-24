Public Class WNDMain
    Private Sub BTNStart_MouseHover(sender As Object, e As EventArgs) Handles BTNStart.MouseHover
        BTNStart.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNInstructions_MouseHover(sender As Object, e As EventArgs) Handles BTNInstructions.MouseHover
        BTNInstructions.Cursor = Cursors.Hand
    End Sub
    Private Sub BTNSound_MouseHover(sender As Object, e As EventArgs) Handles BTNSound.MouseHover
        BTNSound.Cursor = Cursors.Hand
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
        LBLBank.Visible = True
        BTNPlay.Visible = True
    End Sub
End Class