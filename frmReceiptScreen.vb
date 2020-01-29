'----------------------------------------------
'-             File Name: frmReceiptScreen    -
'-             Part of Project:  assignment2  -
'----------------------------------------------
'-             Written By: Nathan Gaffney     -
'-             Written On:   24 Jan 2020      -
'----------------------------------------------
'- File Purpose:This file will create the     -
'- Receipt form. The text of the receipt is   -
'- written by the udtReceiptObject.           -
'----------------------------------------------
Public Class frmReceiptScreen
    '------------------------------------------------------------
    '-         Subprogram Name:btnBackToBilling_Click           -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '------------------------------------------------------------
    '- Subprogram Purpose:This subprogram will bring the main   -
    '- screen to the foreground and remove any information in   -
    '-the receipt                                               -
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
    '- Subprogram Purpose:This subprogram will alert the user   -
    '- the order has been placed. Currently the is no           -
    '- functionality implemented. The user is the returned to   -
    '- main form.                                               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click
        MessageBox.Show("Your order has been placed.")
        clearMainForm()
        frmMainScreen.Show()
        Me.Hide()
    End Sub
    '------------------------------------------------------------
    '-         Subprogram Name: btnExitSystem_Click             -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '------------------------------------------------------------
    '- Subprogram Purpose:This subprogram allows the porogram to-
    '-close. Before closing a message box will alert the user   -
    '- If user selects yes then the p[rogram will shutdown      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnExitSystem_Click(sender As Object, e As EventArgs) Handles btnExitSystem.Click
        If MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmMainScreen.blnPreventsClose = False
            frmMainScreen.Close()
            Me.Close()
        End If

    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: clearMainForm                   -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '------------------------------------------------------------
    '- Subprogram Purpose:This subprogram clears the main form  -
    '- Each control is set to false and the default radio option-
    '- in this case determined by the programmer, will be       -
    '- selected.                                                -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub clearMainForm()
        frmMainScreen.chkGlasses.Checked = False
        frmMainScreen.chkContacts.Checked = False
        frmMainScreen.rdoGlassesOptionsPlasticLens.Checked = True
        frmMainScreen.chkAntiScratch.Checked = False
        frmMainScreen.chkTintedLenses.Checked = False
        frmMainScreen.chkComputerStrainLens.Checked = False
        frmMainScreen.chkRolledLensEdges.Checked = False
        frmMainScreen.chkPhotosensitiveLens.Checked = False
        frmMainScreen.chkProgressiveLens.Checked = False
        frmMainScreen.rdoContactOptionsDailyWear.Checked = True
        frmMainScreen.chkReplacementInsurance.Checked = False
        frmMainScreen.chkCleaningSupplies.Checked = False
        frmMainScreen.chkColoredLens.Checked = False
        frmMainScreen.lstColoredLensColors.Enabled = False
        frmMainScreen.grpGlassesOptions.Visible = False
        frmMainScreen.grpContactsOptions.Visible = False
        frmMainScreen.lstColoredLensColors.SelectedIndex = -1
    End Sub
End Class