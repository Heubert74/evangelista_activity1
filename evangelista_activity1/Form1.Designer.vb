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
        txtFirstnum = New TextBox()
        txtSecondnum = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(27, 39)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 0
        txtFirstnum.Text = "Label1"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(27, 98)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(100, 23)
        txtSecondnum.TabIndex = 1
        txtSecondnum.Text = "Label2"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(25, 136)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 4
        Label1.Text = "1st number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 5
        Label2.Text = "2nd number"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(97, 182)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(39, 15)
        lblResult.TabIndex = 6
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(262, 206)
        Controls.Add(lblResult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(txtSecondnum)
        Controls.Add(txtFirstnum)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
End Class
