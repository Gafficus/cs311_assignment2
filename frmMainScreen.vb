'----------------------------------------------
'-             File Name:                     -
'-             Part of Project:               -
'----------------------------------------------
'-             Written By: Nathan Gaffney     -
'-             Written On:                    -
'----------------------------------------------
'- File Purpose:                              -
'----------------------------------------------
'- Program Purpose:                           -
'- This program                               -
'----------------------------------------------
'- Global Variable Dictionary (alphabetically)-
'- bln
'----------------------------------------------
Imports System.ComponentModel

Public Class frmMainScreen
    '------------------------------------------------------------
    '-              Subprogram Name:chkGlasses_CheckedChanged   -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 27 Jan 2020               -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram is called            -
    '- when the Glasses checkbox is either checked or unchecked -
    '- this subprogram will then flip the visibility            -
    '- And the enaled state.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '- sender  - the object that called this subprogram         -
    '- e       - the event arguments sent to this subprogram    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- blnPreventsClose - flag that will prevent closing if true-                                                   -
    '------------------------------------------------------------
    Public blnPreventsClose As Boolean = True
    Private Sub chkGlasses_CheckedChanged(sender As Object, e As EventArgs) Handles chkGlasses.CheckedChanged
        grpGlassesOptions.Enabled = Not grpGlassesOptions.Enabled
        grpGlassesOptions.Visible = Not grpGlassesOptions.Visible
    End Sub
    '------------------------------------------------------------
    '-              Subprogram Name:chkContacts_CheckedChanged  -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 27 Jan 2020               -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram is called            -
    '- when the Glasses checkbox is either checked or unchecked -
    '- this subprogram will then flip the visibility            -
    '- And the enaled state.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '- sender  - the object that called this subprogram         -
    '- e       - the event arguments sent to this subprogram    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkContacts_CheckedChanged(sender As Object, e As EventArgs) Handles chkContacts.CheckedChanged
        grpContactsOptions.Enabled = Not grpContactsOptions.Enabled
        grpContactsOptions.Visible = Not grpContactsOptions.Visible
    End Sub
    '------------------------------------------------------------
    '-          Subprogram Name:chkColoredLens_CheckedChanged   -  
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 27 Jan 2020               -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram will flip the enabled-
    '- status of lstColoredLensColors, restricting this to only -
    '- being enabled when chkColoredLens is true                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '- sender  - the object that called this subprogram         -
    '- e       - the event arguments sent to this subprogram    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkColoredLens_CheckedChanged(sender As Object, e As EventArgs) Handles chkColoredLens.CheckedChanged
        lstColoredLensColors.Enabled = Not lstColoredLensColors.Enabled
    End Sub
    '------------------------------------------------------------
    '-          Subprogram Name:btnProceedToReceiptForm_Click   -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 27 Jan 2020               -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram will hide            -
    '- frmMainScreen, show frmReceiptScreen, then populate the  -
    '- receipt.                                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '- sender  - the object that called this subprogram         -
    '- e       - the event arguments sent to this subprogram    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnProceedToReceiptForm_Click(sender As Object, e As EventArgs) Handles btnProceedToReceiptForm.Click
        Me.Hide()
        'frmReceiptScreen.txtReceiptTextArea.Text = "Test"
        Dim objReceipt As New udtReceipt
        frmReceiptScreen.txtReceiptTextArea.Text = objReceipt.ToString()
        frmReceiptScreen.Show()
    End Sub
    '------------------------------------------------------------
    '-          Subprogram Name:frmMainScreen_Closing           -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 28 Jan 2020               -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram will prevent the     -
    '- program from exiting unless the blnPreventsClose is set  -
    '- to FALSE. This is set to false in the frmReceiptScreen   -
    '- closing method.                                          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '- sender  - the object that called this subprogram         -
    '- e       - the event arguments sent to this subprogram    -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- STREEXITMESSAGE - A string to hold the exit message      -
    '------------------------------------------------------------
    Private Sub frmMainScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim STREXITMESSAGE As String = "Program can only be exited from the receipt screen."
        If blnPreventsClose Then
            MessageBox.Show(STREXITMESSAGE)
            e.Cancel = True
        End If
    End Sub
End Class
