<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class workshop4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักศึกษา"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(493, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อนักศึกษา"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(111, 203)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(699, 219)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(111, 110)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(313, 26)
        Me.Text1.TabIndex = 3
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(497, 110)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(313, 26)
        Me.Text2.TabIndex = 4
        '
        'Text3
        '
        Me.Text3.Location = New System.Drawing.Point(111, 480)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(313, 26)
        Me.Text3.TabIndex = 5
        '
        'Text4
        '
        Me.Text4.Location = New System.Drawing.Point(497, 480)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(313, 26)
        Me.Text4.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(536, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(247, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'workshop4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 594)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Text4)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "workshop4"
        Me.Text = "WorkShop4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
