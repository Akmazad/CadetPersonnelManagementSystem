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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnJobEntry = New System.Windows.Forms.Button
        Me.btnBrowseJob = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnJobEntry
        '
        Me.btnJobEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnJobEntry.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.btnJobEntry.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnJobEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnJobEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJobEntry.Location = New System.Drawing.Point(688, 591)
        Me.btnJobEntry.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnJobEntry.Name = "btnJobEntry"
        Me.btnJobEntry.Size = New System.Drawing.Size(129, 24)
        Me.btnJobEntry.TabIndex = 0
        Me.btnJobEntry.Text = "Enter Personal"
        Me.btnJobEntry.UseVisualStyleBackColor = False
        '
        'btnBrowseJob
        '
        Me.btnBrowseJob.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBrowseJob.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.btnBrowseJob.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.btnBrowseJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBrowseJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBrowseJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseJob.Location = New System.Drawing.Point(688, 636)
        Me.btnBrowseJob.Name = "btnBrowseJob"
        Me.btnBrowseJob.Size = New System.Drawing.Size(129, 23)
        Me.btnBrowseJob.TabIndex = 1
        Me.btnBrowseJob.Text = "Browse Personal"
        Me.btnBrowseJob.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(468, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Personal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(639, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 33)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Episode 1.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = Global.BEXCA.My.Resources.Resources.personel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(829, 671)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowseJob)
        Me.Controls.Add(Me.btnJobEntry)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJobEntry As System.Windows.Forms.Button
    Friend WithEvents btnBrowseJob As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
