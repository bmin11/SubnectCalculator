<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubnetCalculator
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
        Me.MenuStripTopMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxNetwork = New System.Windows.Forms.GroupBox()
        Me.TextBoxSubnetSize = New System.Windows.Forms.TextBox()
        Me.TextBoxHostPerSubnet = New System.Windows.Forms.TextBox()
        Me.TextBoxNetworkAddress = New System.Windows.Forms.TextBox()
        Me.LabelSubnetSize = New System.Windows.Forms.Label()
        Me.LabelHostPerSubnet = New System.Windows.Forms.Label()
        Me.LabelNetworkAddress = New System.Windows.Forms.Label()
        Me.GroupBoxIPRange = New System.Windows.Forms.GroupBox()
        Me.ListBoxAddresses = New System.Windows.Forms.ListBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.GroupBoxAddress = New System.Windows.Forms.GroupBox()
        Me.TextBoxHexOctets = New System.Windows.Forms.TextBox()
        Me.LabelHexOctets = New System.Windows.Forms.Label()
        Me.TextBoxBinaryOctets = New System.Windows.Forms.TextBox()
        Me.TextBoxDecimalAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxDecimalOctets = New System.Windows.Forms.TextBox()
        Me.LabelBirnaryOctets = New System.Windows.Forms.Label()
        Me.LabelDecimalAddress = New System.Windows.Forms.Label()
        Me.LabelDecimalOctets = New System.Windows.Forms.Label()
        Me.GroupBoxNetmask = New System.Windows.Forms.GroupBox()
        Me.TextBoxNumberOfSubnets = New System.Windows.Forms.TextBox()
        Me.LabelNumberOfSubnets = New System.Windows.Forms.Label()
        Me.TextBoxBinaryMask = New System.Windows.Forms.TextBox()
        Me.LabelBinaryMask = New System.Windows.Forms.Label()
        Me.TextBoxSubnetMask = New System.Windows.Forms.TextBox()
        Me.TextBoxNumberOfAddresses = New System.Windows.Forms.TextBox()
        Me.TextBoxClass = New System.Windows.Forms.TextBox()
        Me.LabelSubnetMask = New System.Windows.Forms.Label()
        Me.LabelNumberOfAddresses = New System.Windows.Forms.Label()
        Me.LabelClass = New System.Windows.Forms.Label()
        Me.OpenFileDialogLoad = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ProgressBarListbox = New System.Windows.Forms.ProgressBar()
        Me.MenuStripTopMenu.SuspendLayout()
        Me.GroupBoxNetwork.SuspendLayout()
        Me.GroupBoxIPRange.SuspendLayout()
        Me.GroupBoxAddress.SuspendLayout()
        Me.GroupBoxNetmask.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripTopMenu
        '
        Me.MenuStripTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.MenuStripTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripTopMenu.Name = "MenuStripTopMenu"
        Me.MenuStripTopMenu.Size = New System.Drawing.Size(882, 28)
        Me.MenuStripTopMenu.TabIndex = 0
        Me.MenuStripTopMenu.Text = "MenuStripTopMenu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(225, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'GroupBoxNetwork
        '
        Me.GroupBoxNetwork.Controls.Add(Me.TextBoxSubnetSize)
        Me.GroupBoxNetwork.Controls.Add(Me.TextBoxHostPerSubnet)
        Me.GroupBoxNetwork.Controls.Add(Me.TextBoxNetworkAddress)
        Me.GroupBoxNetwork.Controls.Add(Me.LabelSubnetSize)
        Me.GroupBoxNetwork.Controls.Add(Me.LabelHostPerSubnet)
        Me.GroupBoxNetwork.Controls.Add(Me.LabelNetworkAddress)
        Me.GroupBoxNetwork.Location = New System.Drawing.Point(12, 31)
        Me.GroupBoxNetwork.Name = "GroupBoxNetwork"
        Me.GroupBoxNetwork.Size = New System.Drawing.Size(400, 150)
        Me.GroupBoxNetwork.TabIndex = 1
        Me.GroupBoxNetwork.TabStop = False
        Me.GroupBoxNetwork.Text = "Network Information"
        '
        'TextBoxSubnetSize
        '
        Me.TextBoxSubnetSize.Location = New System.Drawing.Point(208, 102)
        Me.TextBoxSubnetSize.Name = "TextBoxSubnetSize"
        Me.TextBoxSubnetSize.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxSubnetSize.TabIndex = 7
        '
        'TextBoxHostPerSubnet
        '
        Me.TextBoxHostPerSubnet.Location = New System.Drawing.Point(208, 71)
        Me.TextBoxHostPerSubnet.Name = "TextBoxHostPerSubnet"
        Me.TextBoxHostPerSubnet.Size = New System.Drawing.Size(100, 25)
        Me.TextBoxHostPerSubnet.TabIndex = 6
        '
        'TextBoxNetworkAddress
        '
        Me.TextBoxNetworkAddress.Location = New System.Drawing.Point(208, 40)
        Me.TextBoxNetworkAddress.Name = "TextBoxNetworkAddress"
        Me.TextBoxNetworkAddress.Size = New System.Drawing.Size(186, 25)
        Me.TextBoxNetworkAddress.TabIndex = 5
        '
        'LabelSubnetSize
        '
        Me.LabelSubnetSize.AutoSize = True
        Me.LabelSubnetSize.Location = New System.Drawing.Point(19, 105)
        Me.LabelSubnetSize.Name = "LabelSubnetSize"
        Me.LabelSubnetSize.Size = New System.Drawing.Size(165, 15)
        Me.LabelSubnetSize.TabIndex = 4
        Me.LabelSubnetSize.Text = "Calculated Subnet Size:"
        '
        'LabelHostPerSubnet
        '
        Me.LabelHostPerSubnet.AutoSize = True
        Me.LabelHostPerSubnet.Location = New System.Drawing.Point(19, 74)
        Me.LabelHostPerSubnet.Name = "LabelHostPerSubnet"
        Me.LabelHostPerSubnet.Size = New System.Drawing.Size(160, 15)
        Me.LabelHostPerSubnet.TabIndex = 3
        Me.LabelHostPerSubnet.Text = "# of Hosts Per Subnet:"
        '
        'LabelNetworkAddress
        '
        Me.LabelNetworkAddress.AutoSize = True
        Me.LabelNetworkAddress.Location = New System.Drawing.Point(19, 43)
        Me.LabelNetworkAddress.Name = "LabelNetworkAddress"
        Me.LabelNetworkAddress.Size = New System.Drawing.Size(121, 15)
        Me.LabelNetworkAddress.TabIndex = 2
        Me.LabelNetworkAddress.Text = "Network Address:"
        '
        'GroupBoxIPRange
        '
        Me.GroupBoxIPRange.Controls.Add(Me.ProgressBarListbox)
        Me.GroupBoxIPRange.Controls.Add(Me.ListBoxAddresses)
        Me.GroupBoxIPRange.Location = New System.Drawing.Point(12, 187)
        Me.GroupBoxIPRange.Name = "GroupBoxIPRange"
        Me.GroupBoxIPRange.Size = New System.Drawing.Size(394, 356)
        Me.GroupBoxIPRange.TabIndex = 2
        Me.GroupBoxIPRange.TabStop = False
        Me.GroupBoxIPRange.Text = "List of IP Ranges"
        '
        'ListBoxAddresses
        '
        Me.ListBoxAddresses.FormattingEnabled = True
        Me.ListBoxAddresses.ItemHeight = 15
        Me.ListBoxAddresses.Location = New System.Drawing.Point(6, 31)
        Me.ListBoxAddresses.Name = "ListBoxAddresses"
        Me.ListBoxAddresses.Size = New System.Drawing.Size(378, 319)
        Me.ListBoxAddresses.TabIndex = 0
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(730, 513)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(140, 30)
        Me.ButtonCalculate.TabIndex = 11
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'GroupBoxAddress
        '
        Me.GroupBoxAddress.Controls.Add(Me.TextBoxHexOctets)
        Me.GroupBoxAddress.Controls.Add(Me.LabelHexOctets)
        Me.GroupBoxAddress.Controls.Add(Me.TextBoxBinaryOctets)
        Me.GroupBoxAddress.Controls.Add(Me.TextBoxDecimalAddress)
        Me.GroupBoxAddress.Controls.Add(Me.TextBoxDecimalOctets)
        Me.GroupBoxAddress.Controls.Add(Me.LabelBirnaryOctets)
        Me.GroupBoxAddress.Controls.Add(Me.LabelDecimalAddress)
        Me.GroupBoxAddress.Controls.Add(Me.LabelDecimalOctets)
        Me.GroupBoxAddress.Location = New System.Drawing.Point(418, 31)
        Me.GroupBoxAddress.Name = "GroupBoxAddress"
        Me.GroupBoxAddress.Size = New System.Drawing.Size(452, 180)
        Me.GroupBoxAddress.TabIndex = 8
        Me.GroupBoxAddress.TabStop = False
        Me.GroupBoxAddress.Text = "Address Information"
        '
        'TextBoxHexOctets
        '
        Me.TextBoxHexOctets.Location = New System.Drawing.Point(155, 133)
        Me.TextBoxHexOctets.Name = "TextBoxHexOctets"
        Me.TextBoxHexOctets.Size = New System.Drawing.Size(291, 25)
        Me.TextBoxHexOctets.TabIndex = 9
        '
        'LabelHexOctets
        '
        Me.LabelHexOctets.AutoSize = True
        Me.LabelHexOctets.Location = New System.Drawing.Point(19, 136)
        Me.LabelHexOctets.Name = "LabelHexOctets"
        Me.LabelHexOctets.Size = New System.Drawing.Size(88, 15)
        Me.LabelHexOctets.TabIndex = 8
        Me.LabelHexOctets.Text = "Hex Octets:"
        '
        'TextBoxBinaryOctets
        '
        Me.TextBoxBinaryOctets.Location = New System.Drawing.Point(155, 102)
        Me.TextBoxBinaryOctets.Name = "TextBoxBinaryOctets"
        Me.TextBoxBinaryOctets.Size = New System.Drawing.Size(291, 25)
        Me.TextBoxBinaryOctets.TabIndex = 7
        '
        'TextBoxDecimalAddress
        '
        Me.TextBoxDecimalAddress.Location = New System.Drawing.Point(155, 71)
        Me.TextBoxDecimalAddress.Name = "TextBoxDecimalAddress"
        Me.TextBoxDecimalAddress.Size = New System.Drawing.Size(291, 25)
        Me.TextBoxDecimalAddress.TabIndex = 6
        '
        'TextBoxDecimalOctets
        '
        Me.TextBoxDecimalOctets.Location = New System.Drawing.Point(155, 40)
        Me.TextBoxDecimalOctets.Name = "TextBoxDecimalOctets"
        Me.TextBoxDecimalOctets.Size = New System.Drawing.Size(291, 25)
        Me.TextBoxDecimalOctets.TabIndex = 5
        '
        'LabelBirnaryOctets
        '
        Me.LabelBirnaryOctets.AutoSize = True
        Me.LabelBirnaryOctets.Location = New System.Drawing.Point(19, 105)
        Me.LabelBirnaryOctets.Name = "LabelBirnaryOctets"
        Me.LabelBirnaryOctets.Size = New System.Drawing.Size(102, 15)
        Me.LabelBirnaryOctets.TabIndex = 4
        Me.LabelBirnaryOctets.Text = "Binary Octets:"
        '
        'LabelDecimalAddress
        '
        Me.LabelDecimalAddress.AutoSize = True
        Me.LabelDecimalAddress.Location = New System.Drawing.Point(19, 74)
        Me.LabelDecimalAddress.Name = "LabelDecimalAddress"
        Me.LabelDecimalAddress.Size = New System.Drawing.Size(121, 15)
        Me.LabelDecimalAddress.TabIndex = 3
        Me.LabelDecimalAddress.Text = "Decimal Address:"
        '
        'LabelDecimalOctets
        '
        Me.LabelDecimalOctets.AutoSize = True
        Me.LabelDecimalOctets.Location = New System.Drawing.Point(19, 43)
        Me.LabelDecimalOctets.Name = "LabelDecimalOctets"
        Me.LabelDecimalOctets.Size = New System.Drawing.Size(112, 15)
        Me.LabelDecimalOctets.TabIndex = 2
        Me.LabelDecimalOctets.Text = "Decimal Octets:"
        '
        'GroupBoxNetmask
        '
        Me.GroupBoxNetmask.Controls.Add(Me.TextBoxNumberOfSubnets)
        Me.GroupBoxNetmask.Controls.Add(Me.LabelNumberOfSubnets)
        Me.GroupBoxNetmask.Controls.Add(Me.TextBoxBinaryMask)
        Me.GroupBoxNetmask.Controls.Add(Me.LabelBinaryMask)
        Me.GroupBoxNetmask.Controls.Add(Me.TextBoxSubnetMask)
        Me.GroupBoxNetmask.Controls.Add(Me.TextBoxNumberOfAddresses)
        Me.GroupBoxNetmask.Controls.Add(Me.TextBoxClass)
        Me.GroupBoxNetmask.Controls.Add(Me.LabelSubnetMask)
        Me.GroupBoxNetmask.Controls.Add(Me.LabelNumberOfAddresses)
        Me.GroupBoxNetmask.Controls.Add(Me.LabelClass)
        Me.GroupBoxNetmask.Location = New System.Drawing.Point(418, 217)
        Me.GroupBoxNetmask.Name = "GroupBoxNetmask"
        Me.GroupBoxNetmask.Size = New System.Drawing.Size(450, 290)
        Me.GroupBoxNetmask.TabIndex = 10
        Me.GroupBoxNetmask.TabStop = False
        Me.GroupBoxNetmask.Text = "Netmask Information"
        '
        'TextBoxNumberOfSubnets
        '
        Me.TextBoxNumberOfSubnets.Location = New System.Drawing.Point(155, 204)
        Me.TextBoxNumberOfSubnets.Name = "TextBoxNumberOfSubnets"
        Me.TextBoxNumberOfSubnets.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxNumberOfSubnets.TabIndex = 11
        '
        'LabelNumberOfSubnets
        '
        Me.LabelNumberOfSubnets.AutoSize = True
        Me.LabelNumberOfSubnets.Location = New System.Drawing.Point(19, 207)
        Me.LabelNumberOfSubnets.Name = "LabelNumberOfSubnets"
        Me.LabelNumberOfSubnets.Size = New System.Drawing.Size(97, 15)
        Me.LabelNumberOfSubnets.TabIndex = 10
        Me.LabelNumberOfSubnets.Text = "# of Subnets:"
        '
        'TextBoxBinaryMask
        '
        Me.TextBoxBinaryMask.Location = New System.Drawing.Point(155, 163)
        Me.TextBoxBinaryMask.Name = "TextBoxBinaryMask"
        Me.TextBoxBinaryMask.Size = New System.Drawing.Size(289, 25)
        Me.TextBoxBinaryMask.TabIndex = 9
        '
        'LabelBinaryMask
        '
        Me.LabelBinaryMask.AutoSize = True
        Me.LabelBinaryMask.Location = New System.Drawing.Point(19, 166)
        Me.LabelBinaryMask.Name = "LabelBinaryMask"
        Me.LabelBinaryMask.Size = New System.Drawing.Size(93, 15)
        Me.LabelBinaryMask.TabIndex = 8
        Me.LabelBinaryMask.Text = "Binary Mask:"
        '
        'TextBoxSubnetMask
        '
        Me.TextBoxSubnetMask.Location = New System.Drawing.Point(155, 122)
        Me.TextBoxSubnetMask.Name = "TextBoxSubnetMask"
        Me.TextBoxSubnetMask.Size = New System.Drawing.Size(289, 25)
        Me.TextBoxSubnetMask.TabIndex = 7
        '
        'TextBoxNumberOfAddresses
        '
        Me.TextBoxNumberOfAddresses.Location = New System.Drawing.Point(155, 81)
        Me.TextBoxNumberOfAddresses.Name = "TextBoxNumberOfAddresses"
        Me.TextBoxNumberOfAddresses.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxNumberOfAddresses.TabIndex = 6
        '
        'TextBoxClass
        '
        Me.TextBoxClass.Location = New System.Drawing.Point(155, 40)
        Me.TextBoxClass.Name = "TextBoxClass"
        Me.TextBoxClass.Size = New System.Drawing.Size(72, 25)
        Me.TextBoxClass.TabIndex = 5
        '
        'LabelSubnetMask
        '
        Me.LabelSubnetMask.AutoSize = True
        Me.LabelSubnetMask.Location = New System.Drawing.Point(19, 125)
        Me.LabelSubnetMask.Name = "LabelSubnetMask"
        Me.LabelSubnetMask.Size = New System.Drawing.Size(98, 15)
        Me.LabelSubnetMask.TabIndex = 4
        Me.LabelSubnetMask.Text = "Subnet Mask:"
        '
        'LabelNumberOfAddresses
        '
        Me.LabelNumberOfAddresses.AutoSize = True
        Me.LabelNumberOfAddresses.Location = New System.Drawing.Point(19, 84)
        Me.LabelNumberOfAddresses.Name = "LabelNumberOfAddresses"
        Me.LabelNumberOfAddresses.Size = New System.Drawing.Size(130, 15)
        Me.LabelNumberOfAddresses.TabIndex = 3
        Me.LabelNumberOfAddresses.Text = "# of IP Addresses:"
        '
        'LabelClass
        '
        Me.LabelClass.AutoSize = True
        Me.LabelClass.Location = New System.Drawing.Point(19, 43)
        Me.LabelClass.Name = "LabelClass"
        Me.LabelClass.Size = New System.Drawing.Size(105, 15)
        Me.LabelClass.TabIndex = 2
        Me.LabelClass.Text = "Network Class:"
        '
        'OpenFileDialogLoad
        '
        Me.OpenFileDialogLoad.Filter = """Text files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = """Text files (*.txt)|*.txt|All files (*.*)|*.*"""
        '
        'ProgressBarListbox
        '
        Me.ProgressBarListbox.Location = New System.Drawing.Point(7, 17)
        Me.ProgressBarListbox.Name = "ProgressBarListbox"
        Me.ProgressBarListbox.Size = New System.Drawing.Size(377, 10)
        Me.ProgressBarListbox.TabIndex = 1
        Me.ProgressBarListbox.Visible = False
        '
        'SubnetCalculator
        '
        Me.AcceptButton = Me.ButtonCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 555)
        Me.Controls.Add(Me.GroupBoxNetmask)
        Me.Controls.Add(Me.GroupBoxAddress)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.GroupBoxIPRange)
        Me.Controls.Add(Me.GroupBoxNetwork)
        Me.Controls.Add(Me.MenuStripTopMenu)
        Me.MainMenuStrip = Me.MenuStripTopMenu
        Me.Name = "SubnetCalculator"
        Me.Text = "Subnet Calculator"
        Me.MenuStripTopMenu.ResumeLayout(False)
        Me.MenuStripTopMenu.PerformLayout()
        Me.GroupBoxNetwork.ResumeLayout(False)
        Me.GroupBoxNetwork.PerformLayout()
        Me.GroupBoxIPRange.ResumeLayout(False)
        Me.GroupBoxAddress.ResumeLayout(False)
        Me.GroupBoxAddress.PerformLayout()
        Me.GroupBoxNetmask.ResumeLayout(False)
        Me.GroupBoxNetmask.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripTopMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBoxNetwork As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxSubnetSize As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHostPerSubnet As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNetworkAddress As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubnetSize As System.Windows.Forms.Label
    Friend WithEvents LabelHostPerSubnet As System.Windows.Forms.Label
    Friend WithEvents LabelNetworkAddress As System.Windows.Forms.Label
    Friend WithEvents GroupBoxIPRange As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxAddresses As System.Windows.Forms.ListBox
    Friend WithEvents ButtonCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBoxAddress As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxHexOctets As System.Windows.Forms.TextBox
    Friend WithEvents LabelHexOctets As System.Windows.Forms.Label
    Friend WithEvents TextBoxBinaryOctets As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDecimalAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDecimalOctets As System.Windows.Forms.TextBox
    Friend WithEvents LabelBirnaryOctets As System.Windows.Forms.Label
    Friend WithEvents LabelDecimalAddress As System.Windows.Forms.Label
    Friend WithEvents LabelDecimalOctets As System.Windows.Forms.Label
    Friend WithEvents GroupBoxNetmask As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNumberOfSubnets As System.Windows.Forms.TextBox
    Friend WithEvents LabelNumberOfSubnets As System.Windows.Forms.Label
    Friend WithEvents TextBoxBinaryMask As System.Windows.Forms.TextBox
    Friend WithEvents LabelBinaryMask As System.Windows.Forms.Label
    Friend WithEvents TextBoxSubnetMask As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumberOfAddresses As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClass As System.Windows.Forms.TextBox
    Friend WithEvents LabelSubnetMask As System.Windows.Forms.Label
    Friend WithEvents LabelNumberOfAddresses As System.Windows.Forms.Label
    Friend WithEvents LabelClass As System.Windows.Forms.Label
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialogLoad As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ProgressBarListbox As System.Windows.Forms.ProgressBar

End Class
