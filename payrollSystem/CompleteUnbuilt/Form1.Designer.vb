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
        GroupBox1 = New GroupBox()
        allowanceInput = New TextBox()
        Label5 = New Label()
        basicPayInput = New TextBox()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        nhifOutput = New Label()
        nssfOutput = New Label()
        taxOutput = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label = New Label()
        Label1 = New Label()
        grossOutput = New Label()
        Label2 = New Label()
        Label3 = New Label()
        deductionOutput = New Label()
        netOutput = New Label()
        Label8 = New Label()
        compute = New Button()
        exitB = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(allowanceInput)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(basicPayInput)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(231, 119)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GROSS PAY"
        ' 
        ' allowanceInput
        ' 
        allowanceInput.Location = New Point(92, 67)
        allowanceInput.Name = "allowanceInput"
        allowanceInput.PlaceholderText = "Allowance"
        allowanceInput.Size = New Size(123, 23)
        allowanceInput.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 15)
        Label5.TabIndex = 9
        Label5.Text = "Allowance"
        ' 
        ' basicPayInput
        ' 
        basicPayInput.Location = New Point(92, 29)
        basicPayInput.Name = "basicPayInput"
        basicPayInput.PlaceholderText = "Basic Pay"
        basicPayInput.Size = New Size(123, 23)
        basicPayInput.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 7
        Label4.Text = "Basic Pay"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(nhifOutput)
        GroupBox2.Controls.Add(nssfOutput)
        GroupBox2.Controls.Add(taxOutput)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBox2.Location = New Point(12, 189)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(231, 111)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "DEDUCTIONS"
        ' 
        ' nhifOutput
        ' 
        nhifOutput.BorderStyle = BorderStyle.Fixed3D
        nhifOutput.Location = New Point(94, 75)
        nhifOutput.Name = "nhifOutput"
        nhifOutput.Size = New Size(121, 23)
        nhifOutput.TabIndex = 13
        ' 
        ' nssfOutput
        ' 
        nssfOutput.BorderStyle = BorderStyle.Fixed3D
        nssfOutput.Location = New Point(94, 49)
        nssfOutput.Name = "nssfOutput"
        nssfOutput.Size = New Size(121, 23)
        nssfOutput.TabIndex = 12
        ' 
        ' taxOutput
        ' 
        taxOutput.BorderStyle = BorderStyle.Fixed3D
        taxOutput.Location = New Point(94, 22)
        taxOutput.Name = "taxOutput"
        taxOutput.Size = New Size(121, 23)
        taxOutput.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 15)
        Label7.TabIndex = 10
        Label7.Text = "NHIF"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 9
        Label6.Text = "NSSF"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(15, 30)
        Label.Name = "Label"
        Label.Size = New Size(26, 15)
        Label.TabIndex = 8
        Label.Text = "Tax"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(12, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 15)
        Label1.TabIndex = 2
        Label1.Text = "GROSS SALARY"
        ' 
        ' grossOutput
        ' 
        grossOutput.BorderStyle = BorderStyle.Fixed3D
        grossOutput.Location = New Point(106, 145)
        grossOutput.Name = "grossOutput"
        grossOutput.Size = New Size(121, 23)
        grossOutput.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(12, 317)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 15)
        Label2.TabIndex = 4
        Label2.Text = "TOTAL DEDUCTIONS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(137, 316)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 5
        ' 
        ' deductionOutput
        ' 
        deductionOutput.BorderStyle = BorderStyle.Fixed3D
        deductionOutput.Location = New Point(131, 316)
        deductionOutput.Name = "deductionOutput"
        deductionOutput.Size = New Size(109, 22)
        deductionOutput.TabIndex = 6
        ' 
        ' netOutput
        ' 
        netOutput.BorderStyle = BorderStyle.Fixed3D
        netOutput.Location = New Point(297, 42)
        netOutput.Name = "netOutput"
        netOutput.Size = New Size(121, 23)
        netOutput.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(318, 12)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 15)
        Label8.TabIndex = 8
        Label8.Text = "NET SALARY"
        ' 
        ' compute
        ' 
        compute.Location = New Point(44, 365)
        compute.Name = "compute"
        compute.Size = New Size(75, 23)
        compute.TabIndex = 9
        compute.Text = "COMPUTE"
        compute.UseVisualStyleBackColor = True
        ' 
        ' exitB
        ' 
        exitB.Location = New Point(137, 365)
        exitB.Name = "exitB"
        exitB.Size = New Size(75, 23)
        exitB.TabIndex = 10
        exitB.Text = "EXIT"
        exitB.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(800, 450)
        Controls.Add(exitB)
        Controls.Add(compute)
        Controls.Add(Label8)
        Controls.Add(netOutput)
        Controls.Add(deductionOutput)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(grossOutput)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Payroll System"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grossOutput As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents deductionOutput As Label
    Friend WithEvents allowanceInput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents basicPayInput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label As Label
    Friend WithEvents nhifOutput As Label
    Friend WithEvents nssfOutput As Label
    Friend WithEvents taxOutput As Label
    Friend WithEvents netOutput As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents compute As Button
    Friend WithEvents exitB As Button

End Class
