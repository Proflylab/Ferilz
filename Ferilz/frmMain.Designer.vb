<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ListDetails = New System.Windows.Forms.ListView()
        Me.ColumnName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLocation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.StatusTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.Status.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListDetails
        '
        Me.ListDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnName, Me.ColumnData, Me.ColumnLocation})
        Me.ListDetails.FullRowSelect = True
        Me.ListDetails.Location = New System.Drawing.Point(12, 12)
        Me.ListDetails.Name = "ListDetails"
        Me.ListDetails.Size = New System.Drawing.Size(527, 235)
        Me.ListDetails.TabIndex = 0
        Me.ListDetails.UseCompatibleStateImageBehavior = False
        Me.ListDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnName
        '
        Me.ColumnName.Text = "Name"
        Me.ColumnName.Width = 100
        '
        'ColumnData
        '
        Me.ColumnData.Text = "Data"
        Me.ColumnData.Width = 250
        '
        'ColumnLocation
        '
        Me.ColumnLocation.Text = "Location"
        Me.ColumnLocation.Width = 150
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusTotal})
        Me.Status.Location = New System.Drawing.Point(0, 259)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(633, 22)
        Me.Status.SizingGrip = False
        Me.Status.TabIndex = 1
        '
        'StatusTotal
        '
        Me.StatusTotal.Name = "StatusTotal"
        Me.StatusTotal.Size = New System.Drawing.Size(131, 17)
        Me.StatusTotal.Text = "Ferilz - Application(x64)"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(545, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(545, 41)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(633, 281)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ListDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferilz 1.0"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListDetails As System.Windows.Forms.ListView
    Friend WithEvents ColumnName As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnData As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnLocation As System.Windows.Forms.ColumnHeader
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class
