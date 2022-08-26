<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RichTextBoxDisplay = New System.Windows.Forms.RichTextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RichTextBoxDisplay
        '
        Me.RichTextBoxDisplay.Location = New System.Drawing.Point(92, 39)
        Me.RichTextBoxDisplay.Name = "RichTextBoxDisplay"
        Me.RichTextBoxDisplay.ReadOnly = True
        Me.RichTextBoxDisplay.Size = New System.Drawing.Size(443, 255)
        Me.RichTextBoxDisplay.TabIndex = 0
        Me.RichTextBoxDisplay.Text = ""
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(413, 374)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(122, 38)
        Me.ButtonSearch.TabIndex = 1
        Me.ButtonSearch.Text = "Search "
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(92, 318)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(443, 20)
        Me.TextBoxSearch.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.RichTextBoxDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBoxDisplay As RichTextBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents OpenFileDialogShow As OpenFileDialog
    Friend WithEvents TextBoxSearch As TextBox
End Class
