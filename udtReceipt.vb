Public Class udtReceipt
    Private STRSECTIONBREAK As String
    Private strTitleSection As String
    Private strClientInformation As String
    Private strExamSection As String
    Private strGlassesSection As String
    Private strContactsSection As String
    Private dblGlassesSubtotal As Double
    Private dblContactsSubtotal As Double
    Private Const DBLSALESTAX As Double = 0.06
    Public Sub New()
        makeStringLineBreak()
        makeReceiptTitle()
        makeClientInformation()
        makeReceiptExam()
        makeReceiptContacts()
        makeReceiptGlasses()
    End Sub

    Private Sub makeStringLineBreak()
        STRSECTIONBREAK = vbCrLf '+ vbTab
        For intCounter = 1 To 30
            STRSECTIONBREAK += "- "
        Next
        STRSECTIONBREAK += vbCrLf + vbCrLf + vbCrLf
    End Sub

    Private Sub makeReceiptTitle()
        strTitleSection = ""
        Dim strDashedLine As String = ""
        For intCounter = 1 To 61
            strDashedLine += "- "
        Next
        strTitleSection += strDashedLine + vbCrLf + vbTab +
                            frmMainScreen.Text + vbCrLf _
                            + strDashedLine + vbCrLf + vbCrLf
    End Sub
    Private Sub makeClientInformation()
        strClientInformation = "  Client: "
        strClientInformation += frmMainScreen.txtClientName.Text +
                                vbCrLf + vbCrLf
    End Sub
    Private Sub makeReceiptExam()
        strExamSection = "EXAM SECTION HERE" + STRSECTIONBREAK
    End Sub
    Private Sub makeReceiptGlasses()
        strGlassesSection = "GLASSES SECTION HERE" + STRSECTIONBREAK
    End Sub
    Private Sub makeReceiptContacts()
        strContactsSection = "CONTACTS SECTION HERE" + STRSECTIONBREAK
    End Sub

    Public Overrides Function ToString() As String
        Return strTitleSection + strClientInformation + strExamSection +
               strGlassesSection + strContactsSection
    End Function
End Class
