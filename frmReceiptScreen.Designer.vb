<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBackToBilling = New System.Windows.Forms.Button()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnExitSystem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(372, 438)
        Me.TextBox1.TabIndex = 0
        '
        'btnBackToBilling
        '
        Me.btnBackToBilling.Location = New System.Drawing.Point(12, 456)
        Me.btnBackToBilling.Name = "btnBackToBilling"
        Me.btnBackToBilling.Size = New System.Drawing.Size(372, 43)
        Me.btnBackToBilling.TabIndex = 1
        Me.btnBackToBilling.Text = "Go Back To Billing"
        Me.btnBackToBilling.UseVisualStyleBackColor = True
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Location = New System.Drawing.Point(12, 505)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(372, 43)
        Me.btnProcessOrder.TabIndex = 1
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnExitSystem
        '
        Me.btnExitSystem.Location = New System.Drawing.Point(12, 554)
        Me.btnExitSystem.Name = "btnExitSystem"
        Me.btnExitSystem.Size = New System.Drawing.Size(372, 43)
        Me.btnExitSystem.TabIndex = 1
        Me.btnExitSystem.Text = "Exit System"
        Me.btnExitSystem.UseVisualStyleBackColor = True
        '
        'frmReceiptScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 605)
        Me.Controls.Add(Me.btnExitSystem)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.btnBackToBilling)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmReceiptScreen"
        Me.Text = "Obi_Wan Optometry -- Receipt Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBackToBilling As Button
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents btnExitSystem As Button
End Class
