'----------------------------------------------
'-             File Name:                     -
'-             Part of Project:               -
'----------------------------------------------
'-             Written By: Nathan Gaffney     -
'-             Written On:                    -
'----------------------------------------------
'- File Purpose:                              -
'----------------------------------------------
Public Class frmReceiptScreen
    '------------------------------------------------------------
    '-         Subprogram Name:btnBackToBilling_Click           -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnBackToBilling_Click(sender As Object, e As EventArgs) Handles btnBackToBilling.Click
        Me.Hide()
        txtReceiptTextArea.Text = ""
        frmMainScreen.Show()
    End Sub
    '------------------------------------------------------------
    '-         Subprogram Name: btnProcessOrder_Click           -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click

    End Sub
    '------------------------------------------------------------
    '-         Subprogram Name: btnExitSystem_Click             -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnExitSystem_Click(sender As Object, e As EventArgs) Handles btnExitSystem.Click

    End Sub
End Class