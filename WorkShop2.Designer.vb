<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class workshop2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.chkList1 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.Radio2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(778, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(778, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "..."
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(760, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 142)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "วัตถุดิบ"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(760, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 51)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เพศ"
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Chk1.Location = New System.Drawing.Point(149, 46)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(130, 41)
        Me.Chk1.TabIndex = 4
        Me.Chk1.Text = "HTML"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Chk2.Location = New System.Drawing.Point(149, 103)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(142, 47)
        Me.Chk2.TabIndex = 5
        Me.Chk2.Text = "CSS"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'chkList1
        '
        Me.chkList1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkList1.FormattingEnabled = True
        Me.chkList1.Items.AddRange(New Object() {"หมู", "เห็ด", "เป็ด", "ไก่"})
        Me.chkList1.Location = New System.Drawing.Point(149, 182)
        Me.chkList1.Name = "chkList1"
        Me.chkList1.Size = New System.Drawing.Size(424, 124)
        Me.chkList1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(149, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 64)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(393, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 64)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Radio1
        '
        Me.Radio1.AutoSize = True
        Me.Radio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Radio1.Location = New System.Drawing.Point(146, 354)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(89, 41)
        Me.Radio1.TabIndex = 9
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "ชาย"
        Me.Radio1.UseVisualStyleBackColor = True
        '
        'Radio2
        '
        Me.Radio2.AutoSize = True
        Me.Radio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Radio2.Location = New System.Drawing.Point(350, 354)
        Me.Radio2.Name = "Radio2"
        Me.Radio2.Size = New System.Drawing.Size(96, 41)
        Me.Radio2.TabIndex = 10
        Me.Radio2.TabStop = True
        Me.Radio2.Text = "หญิง"
        Me.Radio2.UseVisualStyleBackColor = True
        '
        'WorkShop2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 594)
        Me.Controls.Add(Me.Radio2)
        Me.Controls.Add(Me.Radio1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkList1)
        Me.Controls.Add(Me.Chk2)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WorkShop2"
        Me.Text = "WorkShop2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Chk1 As CheckBox
    Friend WithEvents Chk2 As CheckBox
    Friend WithEvents chkList1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Radio1 As RadioButton
    Friend WithEvents Radio2 As RadioButton
End Class
