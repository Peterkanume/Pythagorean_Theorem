<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        ExitButton = New Button()
        ResetButton = New Button()
        CalculateButton = New Button()
        ACTextBox = New TextBox()
        BCTextBox = New TextBox()
        ABTextBox = New TextBox()
        AClbl = New Label()
        BCLbl = New Label()
        ABLbl = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ExitButton)
        GroupBox1.Controls.Add(ResetButton)
        GroupBox1.Controls.Add(CalculateButton)
        GroupBox1.Controls.Add(ACTextBox)
        GroupBox1.Controls.Add(BCTextBox)
        GroupBox1.Controls.Add(ABTextBox)
        GroupBox1.Controls.Add(AClbl)
        GroupBox1.Controls.Add(BCLbl)
        GroupBox1.Controls.Add(ABLbl)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(29, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(736, 362)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pythagorean Theorem"
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(457, 255)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 23)
        ExitButton.TabIndex = 9
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(261, 255)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(75, 23)
        ResetButton.TabIndex = 8
        ResetButton.Text = "Reset"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' CalculateButton
        ' 
        CalculateButton.Location = New Point(71, 255)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(75, 23)
        CalculateButton.TabIndex = 7
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = True
        ' 
        ' ACTextBox
        ' 
        ACTextBox.Location = New Point(74, 149)
        ACTextBox.Name = "ACTextBox"
        ACTextBox.Size = New Size(217, 23)
        ACTextBox.TabIndex = 6
        ACTextBox.Text = "0"
        ' 
        ' BCTextBox
        ' 
        BCTextBox.Location = New Point(74, 85)
        BCTextBox.Name = "BCTextBox"
        BCTextBox.Size = New Size(217, 23)
        BCTextBox.TabIndex = 5
        BCTextBox.Text = "0"
        ' 
        ' ABTextBox
        ' 
        ABTextBox.Location = New Point(74, 37)
        ABTextBox.Name = "ABTextBox"
        ABTextBox.Size = New Size(217, 23)
        ABTextBox.TabIndex = 4
        ABTextBox.Text = "0"
        ' 
        ' AClbl
        ' 
        AClbl.AutoSize = True
        AClbl.Location = New Point(23, 152)
        AClbl.Name = "AClbl"
        AClbl.Size = New Size(23, 15)
        AClbl.TabIndex = 3
        AClbl.Text = "AC"
        ' 
        ' BCLbl
        ' 
        BCLbl.AutoSize = True
        BCLbl.Location = New Point(23, 88)
        BCLbl.Name = "BCLbl"
        BCLbl.Size = New Size(22, 15)
        BCLbl.TabIndex = 2
        BCLbl.Text = "BC"
        ' 
        ' ABLbl
        ' 
        ABLbl.AutoSize = True
        ABLbl.Location = New Point(23, 37)
        ABLbl.Name = "ABLbl"
        ABLbl.Size = New Size(22, 15)
        ABLbl.TabIndex = 1
        ABLbl.Text = "AB"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(457, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 196)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCoral
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "sni"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AClbl As Label
    Friend WithEvents BCLbl As Label
    Friend WithEvents ABLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ACTextBox As TextBox
    Friend WithEvents BCTextBox As TextBox
    Friend WithEvents ABTextBox As TextBox

End Class
