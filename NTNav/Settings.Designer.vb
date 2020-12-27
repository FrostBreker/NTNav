<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ReactorTheme1 = New NTNav.ReactorTheme()
        Me.ReactorTabControl1 = New NTNav.ReactorTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ReactorButton3 = New NTNav.ReactorButton()
        Me.ReactorButton2 = New NTNav.ReactorButton()
        Me.ReactorButton1 = New NTNav.ReactorButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReactorButton7 = New NTNav.ReactorButton()
        Me.ReactorButton6 = New NTNav.ReactorButton()
        Me.ReactorButton5 = New NTNav.ReactorButton()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReactorTheme1.SuspendLayout()
        Me.ReactorTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ReactorTheme1
        '
        Me.ReactorTheme1.Controls.Add(Me.ReactorTabControl1)
        Me.ReactorTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReactorTheme1.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ReactorTheme1.Name = "ReactorTheme1"
        Me.ReactorTheme1.Size = New System.Drawing.Size(684, 311)
        Me.ReactorTheme1.TabIndex = 0
        Me.ReactorTheme1.Text = "NTNav Settings"
        '
        'ReactorTabControl1
        '
        Me.ReactorTabControl1.Controls.Add(Me.TabPage1)
        Me.ReactorTabControl1.Controls.Add(Me.TabPage2)
        Me.ReactorTabControl1.Controls.Add(Me.TabPage3)
        Me.ReactorTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ReactorTabControl1.Location = New System.Drawing.Point(0, 31)
        Me.ReactorTabControl1.Name = "ReactorTabControl1"
        Me.ReactorTabControl1.SelectedIndex = 0
        Me.ReactorTabControl1.Size = New System.Drawing.Size(684, 280)
        Me.ReactorTabControl1.TabBorderColor = System.Drawing.Color.White
        Me.ReactorTabControl1.TabIndex = 2
        Me.ReactorTabControl1.TabTextColor = System.Drawing.Color.White
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.ReactorButton3)
        Me.TabPage1.Controls.Add(Me.ReactorButton2)
        Me.TabPage1.Controls.Add(Me.ReactorButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 251)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Historique"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(88, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(568, 232)
        Me.ListBox1.TabIndex = 5
        '
        'ReactorButton3
        '
        Me.ReactorButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton3.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorButton3.Location = New System.Drawing.Point(6, 61)
        Me.ReactorButton3.Name = "ReactorButton3"
        Me.ReactorButton3.Size = New System.Drawing.Size(75, 23)
        Me.ReactorButton3.TabIndex = 3
        Me.ReactorButton3.Text = "Y Aller"
        '
        'ReactorButton2
        '
        Me.ReactorButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton2.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorButton2.Location = New System.Drawing.Point(6, 32)
        Me.ReactorButton2.Name = "ReactorButton2"
        Me.ReactorButton2.Size = New System.Drawing.Size(75, 23)
        Me.ReactorButton2.TabIndex = 2
        Me.ReactorButton2.Text = "Suprimer"
        '
        'ReactorButton1
        '
        Me.ReactorButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton1.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorButton1.Location = New System.Drawing.Point(6, 3)
        Me.ReactorButton1.Name = "ReactorButton1"
        Me.ReactorButton1.Size = New System.Drawing.Size(75, 23)
        Me.ReactorButton1.TabIndex = 1
        Me.ReactorButton1.Text = "Netoyer"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ReactorButton7)
        Me.TabPage2.Controls.Add(Me.ReactorButton6)
        Me.TabPage2.Controls.Add(Me.ReactorButton5)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 251)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Favoris"
        '
        'ReactorButton7
        '
        Me.ReactorButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton7.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorButton7.Location = New System.Drawing.Point(6, 32)
        Me.ReactorButton7.Name = "ReactorButton7"
        Me.ReactorButton7.Size = New System.Drawing.Size(75, 23)
        Me.ReactorButton7.TabIndex = 3
        Me.ReactorButton7.Text = "Suprimer"
        '
        'ReactorButton6
        '
        Me.ReactorButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton6.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorButton6.Location = New System.Drawing.Point(6, 61)
        Me.ReactorButton6.Name = "ReactorButton6"
        Me.ReactorButton6.Size = New System.Drawing.Size(75, 23)
        Me.ReactorButton6.TabIndex = 2
        Me.ReactorButton6.Text = "Y Aller"
        '
        'ReactorButton5
        '
        Me.ReactorButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton5.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorButton5.Location = New System.Drawing.Point(6, 3)
        Me.ReactorButton5.Name = "ReactorButton5"
        Me.ReactorButton5.Size = New System.Drawing.Size(75, 23)
        Me.ReactorButton5.TabIndex = 1
        Me.ReactorButton5.Text = "Netoyer"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Black
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(88, 7)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(568, 232)
        Me.ListBox2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(676, 251)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Personalisation"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 311)
        Me.Controls.Add(Me.ReactorTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ReactorTheme1.ResumeLayout(False)
        Me.ReactorTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReactorTheme1 As NTNav.ReactorTheme
    Friend WithEvents ReactorTabControl1 As NTNav.ReactorTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReactorButton3 As NTNav.ReactorButton
    Friend WithEvents ReactorButton2 As NTNav.ReactorButton
    Friend WithEvents ReactorButton1 As NTNav.ReactorButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ReactorButton5 As NTNav.ReactorButton
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ReactorButton6 As NTNav.ReactorButton
    Friend WithEvents ReactorButton7 As NTNav.ReactorButton
End Class
