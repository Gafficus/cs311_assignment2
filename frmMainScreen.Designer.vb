<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.chkContacts = New System.Windows.Forms.CheckBox()
        Me.chkGlasses = New System.Windows.Forms.CheckBox()
        Me.chkEyeExam = New System.Windows.Forms.CheckBox()
        Me.grpGlassesOptions = New System.Windows.Forms.GroupBox()
        Me.chkProgressiveLens = New System.Windows.Forms.CheckBox()
        Me.chkPhotosensitiveLens = New System.Windows.Forms.CheckBox()
        Me.chkRolledLensEdges = New System.Windows.Forms.CheckBox()
        Me.chkComputerStrainLens = New System.Windows.Forms.CheckBox()
        Me.chkTintedLenses = New System.Windows.Forms.CheckBox()
        Me.chkAntiScratch = New System.Windows.Forms.CheckBox()
        Me.grpLensFrameType = New System.Windows.Forms.GroupBox()
        Me.rdoGlassesOptionsGlassLens = New System.Windows.Forms.RadioButton()
        Me.rdoGlassesOptionsPlasticLens = New System.Windows.Forms.RadioButton()
        Me.grpContactsOptions = New System.Windows.Forms.GroupBox()
        Me.lstColoredLensColors = New System.Windows.Forms.ListBox()
        Me.chkColoredLens = New System.Windows.Forms.CheckBox()
        Me.chkCleaningSupplies = New System.Windows.Forms.CheckBox()
        Me.chkReplacementInsurance = New System.Windows.Forms.CheckBox()
        Me.grpContactTypes = New System.Windows.Forms.GroupBox()
        Me.rboContactOptionsGasPermeable = New System.Windows.Forms.RadioButton()
        Me.rdoContactOptionsExtendedWear = New System.Windows.Forms.RadioButton()
        Me.rdoContactOptionsDailyWear = New System.Windows.Forms.RadioButton()
        Me.btnProceedToReceiptForm = New System.Windows.Forms.Button()
        Me.grpServices.SuspendLayout()
        Me.grpGlassesOptions.SuspendLayout()
        Me.grpLensFrameType.SuspendLayout()
        Me.grpContactsOptions.SuspendLayout()
        Me.grpContactTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(13, 13)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(67, 13)
        Me.lblClientName.TabIndex = 0
        Me.lblClientName.Text = "Client Name:"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(93, 10)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(338, 20)
        Me.txtClientName.TabIndex = 1
        '
        'grpServices
        '
        Me.grpServices.Controls.Add(Me.chkContacts)
        Me.grpServices.Controls.Add(Me.chkGlasses)
        Me.grpServices.Controls.Add(Me.chkEyeExam)
        Me.grpServices.Location = New System.Drawing.Point(13, 39)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(775, 47)
        Me.grpServices.TabIndex = 2
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Services:"
        '
        'chkContacts
        '
        Me.chkContacts.AutoSize = True
        Me.chkContacts.Location = New System.Drawing.Point(603, 19)
        Me.chkContacts.Name = "chkContacts"
        Me.chkContacts.Size = New System.Drawing.Size(68, 17)
        Me.chkContacts.TabIndex = 2
        Me.chkContacts.Text = "Contacts"
        Me.chkContacts.UseVisualStyleBackColor = True
        '
        'chkGlasses
        '
        Me.chkGlasses.AutoSize = True
        Me.chkGlasses.Location = New System.Drawing.Point(304, 19)
        Me.chkGlasses.Name = "chkGlasses"
        Me.chkGlasses.Size = New System.Drawing.Size(63, 17)
        Me.chkGlasses.TabIndex = 1
        Me.chkGlasses.Text = "Glasses"
        Me.chkGlasses.UseVisualStyleBackColor = True
        '
        'chkEyeExam
        '
        Me.chkEyeExam.AutoSize = True
        Me.chkEyeExam.Location = New System.Drawing.Point(6, 19)
        Me.chkEyeExam.Name = "chkEyeExam"
        Me.chkEyeExam.Size = New System.Drawing.Size(73, 17)
        Me.chkEyeExam.TabIndex = 0
        Me.chkEyeExam.Text = "Eye Exam"
        Me.chkEyeExam.UseVisualStyleBackColor = True
        '
        'grpGlassesOptions
        '
        Me.grpGlassesOptions.Controls.Add(Me.chkProgressiveLens)
        Me.grpGlassesOptions.Controls.Add(Me.chkPhotosensitiveLens)
        Me.grpGlassesOptions.Controls.Add(Me.chkRolledLensEdges)
        Me.grpGlassesOptions.Controls.Add(Me.chkComputerStrainLens)
        Me.grpGlassesOptions.Controls.Add(Me.chkTintedLenses)
        Me.grpGlassesOptions.Controls.Add(Me.chkAntiScratch)
        Me.grpGlassesOptions.Controls.Add(Me.grpLensFrameType)
        Me.grpGlassesOptions.Enabled = False
        Me.grpGlassesOptions.Location = New System.Drawing.Point(13, 97)
        Me.grpGlassesOptions.Name = "grpGlassesOptions"
        Me.grpGlassesOptions.Size = New System.Drawing.Size(775, 216)
        Me.grpGlassesOptions.TabIndex = 3
        Me.grpGlassesOptions.TabStop = False
        Me.grpGlassesOptions.Text = "Glasses Options:"
        Me.grpGlassesOptions.Visible = False
        '
        'chkProgressiveLens
        '
        Me.chkProgressiveLens.AutoSize = True
        Me.chkProgressiveLens.Location = New System.Drawing.Point(303, 175)
        Me.chkProgressiveLens.Name = "chkProgressiveLens"
        Me.chkProgressiveLens.Size = New System.Drawing.Size(107, 17)
        Me.chkProgressiveLens.TabIndex = 6
        Me.chkProgressiveLens.Text = "Progressive Lens"
        Me.chkProgressiveLens.UseVisualStyleBackColor = True
        '
        'chkPhotosensitiveLens
        '
        Me.chkPhotosensitiveLens.AutoSize = True
        Me.chkPhotosensitiveLens.Location = New System.Drawing.Point(304, 129)
        Me.chkPhotosensitiveLens.Name = "chkPhotosensitiveLens"
        Me.chkPhotosensitiveLens.Size = New System.Drawing.Size(121, 17)
        Me.chkPhotosensitiveLens.TabIndex = 5
        Me.chkPhotosensitiveLens.Text = "Photosensitive Lens"
        Me.chkPhotosensitiveLens.UseVisualStyleBackColor = True
        '
        'chkRolledLensEdges
        '
        Me.chkRolledLensEdges.AutoSize = True
        Me.chkRolledLensEdges.Location = New System.Drawing.Point(303, 78)
        Me.chkRolledLensEdges.Name = "chkRolledLensEdges"
        Me.chkRolledLensEdges.Size = New System.Drawing.Size(115, 17)
        Me.chkRolledLensEdges.TabIndex = 4
        Me.chkRolledLensEdges.Text = "Rolled Lens Edges"
        Me.chkRolledLensEdges.UseVisualStyleBackColor = True
        '
        'chkComputerStrainLens
        '
        Me.chkComputerStrainLens.AutoSize = True
        Me.chkComputerStrainLens.Location = New System.Drawing.Point(7, 175)
        Me.chkComputerStrainLens.Name = "chkComputerStrainLens"
        Me.chkComputerStrainLens.Size = New System.Drawing.Size(146, 17)
        Me.chkComputerStrainLens.TabIndex = 3
        Me.chkComputerStrainLens.Text = "Computer Strain HD Lens"
        Me.chkComputerStrainLens.UseVisualStyleBackColor = True
        '
        'chkTintedLenses
        '
        Me.chkTintedLenses.AutoSize = True
        Me.chkTintedLenses.Location = New System.Drawing.Point(7, 129)
        Me.chkTintedLenses.Name = "chkTintedLenses"
        Me.chkTintedLenses.Size = New System.Drawing.Size(93, 17)
        Me.chkTintedLenses.TabIndex = 2
        Me.chkTintedLenses.Text = "Tinted Lenses"
        Me.chkTintedLenses.UseVisualStyleBackColor = True
        '
        'chkAntiScratch
        '
        Me.chkAntiScratch.AutoSize = True
        Me.chkAntiScratch.Location = New System.Drawing.Point(7, 78)
        Me.chkAntiScratch.Name = "chkAntiScratch"
        Me.chkAntiScratch.Size = New System.Drawing.Size(123, 17)
        Me.chkAntiScratch.TabIndex = 1
        Me.chkAntiScratch.Text = "Anti-Scratch Coating"
        Me.chkAntiScratch.UseVisualStyleBackColor = True
        '
        'grpLensFrameType
        '
        Me.grpLensFrameType.Controls.Add(Me.rdoGlassesOptionsGlassLens)
        Me.grpLensFrameType.Controls.Add(Me.rdoGlassesOptionsPlasticLens)
        Me.grpLensFrameType.Location = New System.Drawing.Point(7, 20)
        Me.grpLensFrameType.Name = "grpLensFrameType"
        Me.grpLensFrameType.Size = New System.Drawing.Size(762, 37)
        Me.grpLensFrameType.TabIndex = 0
        Me.grpLensFrameType.TabStop = False
        '
        'rdoGlassesOptionsGlassLens
        '
        Me.rdoGlassesOptionsGlassLens.AutoSize = True
        Me.rdoGlassesOptionsGlassLens.Location = New System.Drawing.Point(514, 14)
        Me.rdoGlassesOptionsGlassLens.Name = "rdoGlassesOptionsGlassLens"
        Me.rdoGlassesOptionsGlassLens.Size = New System.Drawing.Size(111, 17)
        Me.rdoGlassesOptionsGlassLens.TabIndex = 1
        Me.rdoGlassesOptionsGlassLens.Text = "Glass Lens/Frame"
        Me.rdoGlassesOptionsGlassLens.UseVisualStyleBackColor = True
        '
        'rdoGlassesOptionsPlasticLens
        '
        Me.rdoGlassesOptionsPlasticLens.AutoSize = True
        Me.rdoGlassesOptionsPlasticLens.Checked = True
        Me.rdoGlassesOptionsPlasticLens.Location = New System.Drawing.Point(147, 14)
        Me.rdoGlassesOptionsPlasticLens.Name = "rdoGlassesOptionsPlasticLens"
        Me.rdoGlassesOptionsPlasticLens.Size = New System.Drawing.Size(116, 17)
        Me.rdoGlassesOptionsPlasticLens.TabIndex = 0
        Me.rdoGlassesOptionsPlasticLens.TabStop = True
        Me.rdoGlassesOptionsPlasticLens.Text = "Plastic Lens/Frame"
        Me.rdoGlassesOptionsPlasticLens.UseVisualStyleBackColor = True
        '
        'grpContactsOptions
        '
        Me.grpContactsOptions.Controls.Add(Me.lstColoredLensColors)
        Me.grpContactsOptions.Controls.Add(Me.chkColoredLens)
        Me.grpContactsOptions.Controls.Add(Me.chkCleaningSupplies)
        Me.grpContactsOptions.Controls.Add(Me.chkReplacementInsurance)
        Me.grpContactsOptions.Controls.Add(Me.grpContactTypes)
        Me.grpContactsOptions.Enabled = False
        Me.grpContactsOptions.Location = New System.Drawing.Point(13, 319)
        Me.grpContactsOptions.Name = "grpContactsOptions"
        Me.grpContactsOptions.Size = New System.Drawing.Size(775, 261)
        Me.grpContactsOptions.TabIndex = 4
        Me.grpContactsOptions.TabStop = False
        Me.grpContactsOptions.Text = "Contacts Options:"
        Me.grpContactsOptions.Visible = False
        '
        'lstColoredLensColors
        '
        Me.lstColoredLensColors.Enabled = False
        Me.lstColoredLensColors.FormattingEnabled = True
        Me.lstColoredLensColors.Items.AddRange(New Object() {"Maul Red", "C3PO Gold", "R2D2 Blue", "Yoda Green"})
        Me.lstColoredLensColors.Location = New System.Drawing.Point(274, 182)
        Me.lstColoredLensColors.Name = "lstColoredLensColors"
        Me.lstColoredLensColors.Size = New System.Drawing.Size(120, 30)
        Me.lstColoredLensColors.TabIndex = 4
        '
        'chkColoredLens
        '
        Me.chkColoredLens.AutoSize = True
        Me.chkColoredLens.Location = New System.Drawing.Point(14, 195)
        Me.chkColoredLens.Name = "chkColoredLens"
        Me.chkColoredLens.Size = New System.Drawing.Size(88, 17)
        Me.chkColoredLens.TabIndex = 3
        Me.chkColoredLens.Text = "Colored Lens"
        Me.chkColoredLens.UseVisualStyleBackColor = True
        '
        'chkCleaningSupplies
        '
        Me.chkCleaningSupplies.AutoSize = True
        Me.chkCleaningSupplies.Location = New System.Drawing.Point(14, 137)
        Me.chkCleaningSupplies.Name = "chkCleaningSupplies"
        Me.chkCleaningSupplies.Size = New System.Drawing.Size(173, 17)
        Me.chkCleaningSupplies.TabIndex = 2
        Me.chkCleaningSupplies.Text = "Cleaning Supplies for One Year"
        Me.chkCleaningSupplies.UseVisualStyleBackColor = True
        '
        'chkReplacementInsurance
        '
        Me.chkReplacementInsurance.AutoSize = True
        Me.chkReplacementInsurance.Location = New System.Drawing.Point(14, 80)
        Me.chkReplacementInsurance.Name = "chkReplacementInsurance"
        Me.chkReplacementInsurance.Size = New System.Drawing.Size(139, 17)
        Me.chkReplacementInsurance.TabIndex = 1
        Me.chkReplacementInsurance.Text = "Replacement Insurance"
        Me.chkReplacementInsurance.UseVisualStyleBackColor = True
        '
        'grpContactTypes
        '
        Me.grpContactTypes.Controls.Add(Me.rboContactOptionsGasPermeable)
        Me.grpContactTypes.Controls.Add(Me.rdoContactOptionsExtendedWear)
        Me.grpContactTypes.Controls.Add(Me.rdoContactOptionsDailyWear)
        Me.grpContactTypes.Location = New System.Drawing.Point(7, 20)
        Me.grpContactTypes.Name = "grpContactTypes"
        Me.grpContactTypes.Size = New System.Drawing.Size(762, 32)
        Me.grpContactTypes.TabIndex = 0
        Me.grpContactTypes.TabStop = False
        '
        'rboContactOptionsGasPermeable
        '
        Me.rboContactOptionsGasPermeable.AutoSize = True
        Me.rboContactOptionsGasPermeable.Location = New System.Drawing.Point(596, 9)
        Me.rboContactOptionsGasPermeable.Name = "rboContactOptionsGasPermeable"
        Me.rboContactOptionsGasPermeable.Size = New System.Drawing.Size(97, 17)
        Me.rboContactOptionsGasPermeable.TabIndex = 2
        Me.rboContactOptionsGasPermeable.Text = "Gas Permeable"
        Me.rboContactOptionsGasPermeable.UseVisualStyleBackColor = True
        '
        'rdoContactOptionsExtendedWear
        '
        Me.rdoContactOptionsExtendedWear.AutoSize = True
        Me.rdoContactOptionsExtendedWear.Location = New System.Drawing.Point(297, 9)
        Me.rdoContactOptionsExtendedWear.Name = "rdoContactOptionsExtendedWear"
        Me.rdoContactOptionsExtendedWear.Size = New System.Drawing.Size(99, 17)
        Me.rdoContactOptionsExtendedWear.TabIndex = 1
        Me.rdoContactOptionsExtendedWear.Text = "Extended Wear"
        Me.rdoContactOptionsExtendedWear.UseVisualStyleBackColor = True
        '
        'rdoContactOptionsDailyWear
        '
        Me.rdoContactOptionsDailyWear.AutoSize = True
        Me.rdoContactOptionsDailyWear.Checked = True
        Me.rdoContactOptionsDailyWear.Location = New System.Drawing.Point(7, 9)
        Me.rdoContactOptionsDailyWear.Name = "rdoContactOptionsDailyWear"
        Me.rdoContactOptionsDailyWear.Size = New System.Drawing.Size(77, 17)
        Me.rdoContactOptionsDailyWear.TabIndex = 0
        Me.rdoContactOptionsDailyWear.TabStop = True
        Me.rdoContactOptionsDailyWear.Text = "Daily Wear"
        Me.rdoContactOptionsDailyWear.UseVisualStyleBackColor = True
        '
        'btnProceedToReceiptForm
        '
        Me.btnProceedToReceiptForm.Location = New System.Drawing.Point(13, 587)
        Me.btnProceedToReceiptForm.Name = "btnProceedToReceiptForm"
        Me.btnProceedToReceiptForm.Size = New System.Drawing.Size(775, 66)
        Me.btnProceedToReceiptForm.TabIndex = 5
        Me.btnProceedToReceiptForm.Text = "Proceed to Receipt Screen"
        Me.btnProceedToReceiptForm.UseVisualStyleBackColor = True
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 691)
        Me.Controls.Add(Me.btnProceedToReceiptForm)
        Me.Controls.Add(Me.grpContactsOptions)
        Me.Controls.Add(Me.grpGlassesOptions)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.lblClientName)
        Me.Name = "frmMainScreen"
        Me.Text = "Obi-Wan Optometry -- Eye Care for Generations of Jedi"
        Me.grpServices.ResumeLayout(False)
        Me.grpServices.PerformLayout()
        Me.grpGlassesOptions.ResumeLayout(False)
        Me.grpGlassesOptions.PerformLayout()
        Me.grpLensFrameType.ResumeLayout(False)
        Me.grpLensFrameType.PerformLayout()
        Me.grpContactsOptions.ResumeLayout(False)
        Me.grpContactsOptions.PerformLayout()
        Me.grpContactTypes.ResumeLayout(False)
        Me.grpContactTypes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClientName As Label
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents grpServices As GroupBox
    Friend WithEvents chkContacts As CheckBox
    Friend WithEvents chkGlasses As CheckBox
    Friend WithEvents chkEyeExam As CheckBox
    Friend WithEvents grpGlassesOptions As GroupBox
    Friend WithEvents chkProgressiveLens As CheckBox
    Friend WithEvents chkPhotosensitiveLens As CheckBox
    Friend WithEvents chkRolledLensEdges As CheckBox
    Friend WithEvents chkComputerStrainLens As CheckBox
    Friend WithEvents chkTintedLenses As CheckBox
    Friend WithEvents chkAntiScratch As CheckBox
    Friend WithEvents grpLensFrameType As GroupBox
    Friend WithEvents rdoGlassesOptionsGlassLens As RadioButton
    Friend WithEvents rdoGlassesOptionsPlasticLens As RadioButton
    Friend WithEvents grpContactsOptions As GroupBox
    Friend WithEvents grpContactTypes As GroupBox
    Friend WithEvents rboContactOptionsGasPermeable As RadioButton
    Friend WithEvents rdoContactOptionsExtendedWear As RadioButton
    Friend WithEvents rdoContactOptionsDailyWear As RadioButton
    Friend WithEvents btnProceedToReceiptForm As Button
    Friend WithEvents lstColoredLensColors As ListBox
    Friend WithEvents chkColoredLens As CheckBox
    Friend WithEvents chkCleaningSupplies As CheckBox
    Friend WithEvents chkReplacementInsurance As CheckBox
End Class
