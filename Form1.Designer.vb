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
        Me.btnDisplayRowWise = New System.Windows.Forms.Button()
        Me.BtnColumnWise = New System.Windows.Forms.Button()
        Me.btnDisplayAll = New System.Windows.Forms.Button()
        Me.btnLinearSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplayRowWise
        '
        Me.btnDisplayRowWise.Location = New System.Drawing.Point(38, 28)
        Me.btnDisplayRowWise.Name = "btnDisplayRowWise"
        Me.btnDisplayRowWise.Size = New System.Drawing.Size(185, 84)
        Me.btnDisplayRowWise.TabIndex = 0
        Me.btnDisplayRowWise.Text = "Display Items row wise"
        Me.btnDisplayRowWise.UseVisualStyleBackColor = True
        '
        'BtnColumnWise
        '
        Me.BtnColumnWise.Location = New System.Drawing.Point(39, 146)
        Me.BtnColumnWise.Name = "BtnColumnWise"
        Me.BtnColumnWise.Size = New System.Drawing.Size(184, 71)
        Me.BtnColumnWise.TabIndex = 1
        Me.BtnColumnWise.Text = "Display items column wise"
        Me.BtnColumnWise.UseVisualStyleBackColor = True
        '
        'btnDisplayAll
        '
        Me.btnDisplayAll.Location = New System.Drawing.Point(37, 247)
        Me.btnDisplayAll.Name = "btnDisplayAll"
        Me.btnDisplayAll.Size = New System.Drawing.Size(186, 69)
        Me.btnDisplayAll.TabIndex = 2
        Me.btnDisplayAll.Text = "Display all items at once"
        Me.btnDisplayAll.UseVisualStyleBackColor = True
        '
        'btnLinearSearch
        '
        Me.btnLinearSearch.Location = New System.Drawing.Point(39, 347)
        Me.btnLinearSearch.Name = "btnLinearSearch"
        Me.btnLinearSearch.Size = New System.Drawing.Size(184, 70)
        Me.btnLinearSearch.TabIndex = 3
        Me.btnLinearSearch.Text = "Search for a person"
        Me.btnLinearSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLinearSearch)
        Me.Controls.Add(Me.btnDisplayAll)
        Me.Controls.Add(Me.BtnColumnWise)
        Me.Controls.Add(Me.btnDisplayRowWise)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDisplayRowWise As Button
    Friend WithEvents BtnColumnWise As Button
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnLinearSearch As Button
End Class
