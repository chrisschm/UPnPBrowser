<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root")
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(800, 25)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.StatusLabel.Text = "Status"
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip.TabIndex = 2
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuExit})
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(44, 24)
        Me.MenuFile.Text = "File"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(108, 26)
        Me.MenuExit.Text = "Exit"
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.TreeView)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.ListView)
        Me.SplitContainer.Size = New System.Drawing.Size(800, 397)
        Me.SplitContainer.SplitterDistance = 266
        Me.SplitContainer.TabIndex = 3
        '
        'TreeView
        '
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView.Location = New System.Drawing.Point(0, 0)
        Me.TreeView.Name = "TreeView"
        TreeNode6.Name = "RootNode"
        TreeNode6.Tag = "Root"
        TreeNode6.Text = "Root"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6})
        Me.TreeView.ShowNodeToolTips = True
        Me.TreeView.Size = New System.Drawing.Size(266, 397)
        Me.TreeView.TabIndex = 0
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView.Location = New System.Drawing.Point(0, 0)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(530, 397)
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Service ID"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Service Type Identifier"
        Me.ColumnHeader2.Width = 160
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormMain"
        Me.Text = "UPnP Browser"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuFile As ToolStripMenuItem
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents TreeView As TreeView
    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
