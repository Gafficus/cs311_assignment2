'----------------------------------------------
'-             File Name:udtReceipt           -
'-             Part of Project:assignment2    -
'----------------------------------------------
'-             Written By: Nathan Gaffney     -
'-             Written On: 27 Jan 2020        -
'----------------------------------------------
'- File Purpose:This file contains the class  -
'- structure and methods that will be used to -
'- generate the receipt output.               -
'----------------------------------------------
Public Class udtReceipt
    Private STRSECTIONBREAK As String
    Private strTitleSection As String
    Private strClientInformation As String
    Private strExamSection As String
    Private strGlassesSection As String
    Private strContactsSection As String
    Private strSubtotalSection As String
    Private dblExamSubtotal As Double
    Private dblGlassesSubtotal As Double
    Private dblContactsSubtotal As Double

    Private Const DBLSALESTAXRATE As Double = 0.06

    'fmtStr is used to line up the strings in the receipt
    'Currently is does not line up all lines correctly,
    'I am unsure why.
    Private fmtStr As String = "{0, -70}{1, 10:C}"
    Private strGapString As String = "      "
    '------------------------------------------------------------
    '-                    Subprogram Name: New()                -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                     Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose:Creates the receipt object and calls  -
    '- the functions necessary to populate the receipt          -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New()
        makeStringLineBreak()
        makeReceiptTitle()
        makeClientInformation()
        makeReceiptExam()
        makeReceiptContacts()
        makeReceiptGlasses()
        makeReceiptSubtotal()
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name:makeStringLineBreak   -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                     Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose: This program creates a line seperator-
    '- string that will be used to break apart each section of  -
    '- the receipt.                                             -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeStringLineBreak()
        STRSECTIONBREAK = vbCrLf + "   "
        For intCounter = 1 To 46
            STRSECTIONBREAK += "- "
        Next
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name:makeReceiptTitle      -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                     Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram is to create the     -
    '- header of the receipt section                            -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeReceiptTitle()
        strTitleSection = ""
        Dim strDashedLine As String = ""
        For intCounter = 1 To 61
            strDashedLine += "- "
        Next
        'frmMainScreen.Text will get teh text of the main form
        'This is where the title comes from
        strTitleSection += strDashedLine + vbCrLf + vbTab +
                            frmMainScreen.Text + vbCrLf _
                            + strDashedLine + vbCrLf + vbCrLf
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name:makeClientInformation-
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                     Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose:This subprogram will write the client -
    '- name to the receipt.                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeClientInformation()
        strClientInformation = "  Client: "
        strClientInformation += frmMainScreen.txtClientName.Text +
                                vbCrLf + vbCrLf
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name: makeReceiptExam      -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                     Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose:This subprogram will write the client -
    '- name to the receipt.                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeReceiptExam()
        If frmMainScreen.chkEyeExam.Checked Then
            strExamSection = String.Format(fmtStr, strGapString + frmMainScreen.chkEyeExam.Text, 100)
            dblExamSubtotal = 100
            strExamSection += STRSECTIONBREAK
            strExamSection += vbCrLf
        End If
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name: makeReceiptGlasses   -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 29 January 2019           -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram will check the status-
    '- of each radio button and checkbox in the grpGlasses.     -
    '- If the control is checked it will be appended to the     -
    '- receipt. The cost of each item will then be added to the -
    '- section subtotal.                                        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeReceiptGlasses()
        If frmMainScreen.chkGlasses.Checked Then
            dblGlassesSubtotal = 0
            strGlassesSection = "   Glasses Order - -" + vbCrLf
            'Each of these if satements is based on control from the main form
            'The text of the control is passed to the format string function
            ' using the declared format in the class variables
            If frmMainScreen.rdoGlassesOptionsPlasticLens.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.rdoGlassesOptionsPlasticLens.Text, 175)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 175
            End If
            If frmMainScreen.rdoGlassesOptionsGlassLens.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.rdoGlassesOptionsGlassLens.Text, 225)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 225
            End If
            If frmMainScreen.chkAntiScratch.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.chkAntiScratch.Text, 50)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 50
            End If
            If frmMainScreen.chkTintedLenses.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.chkTintedLenses.Text, 50)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 50
            End If
            If frmMainScreen.chkComputerStrainLens.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.chkComputerStrainLens.Text, 50)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 50
            End If
            If frmMainScreen.chkRolledLensEdges.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.chkRolledLensEdges.Text, 50)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 50
            End If
            If frmMainScreen.chkPhotosensitiveLens.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.chkPhotosensitiveLens.Text, 50)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 50
            End If
            If frmMainScreen.chkProgressiveLens.Checked Then
                strGlassesSection += String.Format(fmtStr, strGapString + frmMainScreen.chkProgressiveLens.Text, 50)
                strGlassesSection += vbCrLf
                dblGlassesSubtotal += 50
            End If
            'The below code will inser the section break string
            'Create a new line then write the subtotal
            strGlassesSection += STRSECTIONBREAK
            strGlassesSection += vbCrLf
            strGlassesSection += String.Format(fmtStr, "Glasses Subtotal", dblGlassesSubtotal)
            strGlassesSection += vbCrLf
            strGlassesSection += vbCrLf
        End If
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name:                      -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney            -
    '-                    Written On: 29 January 2019           -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram will check the status-
    '- of each radio button and checkbox in the grpContacts.    -
    '- If the control is checked it will be appended to the     -
    '- receipt. The cost of each item will then be added to the -
    '- section subtotal.                                        -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeReceiptContacts()
        If frmMainScreen.chkContacts.Checked Then
            strContactsSection = "   Contacts Order - - " + vbCrLf
            dblContactsSubtotal = 0
            If frmMainScreen.rdoContactOptionsDailyWear.Checked Then
                strContactsSection += String.Format(fmtStr, strGapString + frmMainScreen.rdoContactOptionsDailyWear.Text, 100)
                strContactsSection += vbCrLf
                dblContactsSubtotal += 100
            End If
            If frmMainScreen.rdoContactOptionsExtendedWear.Checked Then
                strContactsSection += String.Format(fmtStr, strGapString + frmMainScreen.rdoContactOptionsExtendedWear.Text, 150)
                strContactsSection += vbCrLf
                dblContactsSubtotal += 150
            End If
            If frmMainScreen.rboContactOptionsGasPermeable.Checked Then
                strContactsSection += String.Format(fmtStr, strGapString + frmMainScreen.rboContactOptionsGasPermeable.Text, 200)
                strContactsSection += vbCrLf
                dblContactsSubtotal += 200
            End If
            If frmMainScreen.chkReplacementInsurance.Checked Then
                strContactsSection += String.Format(fmtStr, strGapString + frmMainScreen.chkReplacementInsurance.Text, 75)
                strContactsSection += vbCrLf
                dblContactsSubtotal += 75
            End If
            If frmMainScreen.chkCleaningSupplies.Checked Then
                strContactsSection += String.Format(fmtStr, strGapString + frmMainScreen.chkCleaningSupplies.Text, 75)
                strContactsSection += vbCrLf
                dblContactsSubtotal += 75
            End If
            If frmMainScreen.chkColoredLens.Checked Then
                strContactsSection += String.Format(fmtStr, strGapString +
                                                    "Colored Lens: " +
                                                    "(" + frmMainScreen.lstColoredLensColors.Text + ")", 75)
                strContactsSection += vbCrLf
                dblContactsSubtotal += 75
            End If
            strContactsSection += STRSECTIONBREAK
            strContactsSection += vbCrLf
            strContactsSection += String.Format(fmtStr, strGapString + "Contacts Subtotal", dblContactsSubtotal)
            strContactsSection += vbCrLf
            strContactsSection += vbCrLf
        End If
    End Sub
    '------------------------------------------------------------
    '-                    Subprogram Name:                      -
    '------------------------------------------------------------
    '-                    Written By: Nathan Gaffney           -
    '-                    Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub makeReceiptSubtotal()
        Dim dblSaleSubtotal As Double
        Dim dblSalesTax As Double
        Dim dblSalesTotal As Double
        dblSaleSubtotal = dblExamSubtotal + dblGlassesSubtotal + dblContactsSubtotal
        dblSalesTax = dblSaleSubtotal * DBLSALESTAXRATE
        dblSalesTotal = dblSaleSubtotal + dblSalesTax
        strSubtotalSection = vbCrLf
        strSubtotalSection += String.Format(fmtStr, strGapString + "Receipt Subtotal", dblSaleSubtotal)
        strSubtotalSection += vbCrLf
        strSubtotalSection += String.Format(fmtStr, strGapString + "Sales Tax", dblSalesTax)
        strSubtotalSection += STRSECTIONBREAK
        strSubtotalSection += vbCrLf
        strSubtotalSection += String.Format(fmtStr, strGapString + "Total", dblSalesTotal)
    End Sub
    '------------------------------------------------------------
    '-                     Function Name:                     -
    '------------------------------------------------------------
    '                      Written By: Nathan Gaffney           -
    '-                     Written On: 29 January 2019          -
    '------------------------------------------------------------
    '- Subprogram Purpose: This subprogram will return a string -
    '- that has each section appended. If the section is not    -
    '- checked in the main form then the string will be ""      -
    '- for teh corresponding section.                           - 
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order)                -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically)               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns: A long string of the receipt                    -
    '------------------------------------------------------------
    Public Overrides Function ToString() As String
        Return strTitleSection + strClientInformation + strExamSection +
               strGlassesSection + strContactsSection + strSubtotalSection
    End Function
End Class
