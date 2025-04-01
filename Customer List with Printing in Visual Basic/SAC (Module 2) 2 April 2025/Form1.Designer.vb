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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblName = New Label()
        lblState = New Label()
        lblABNACN = New Label()
        lblStructure = New Label()
        mnuMainStrip = New MenuStrip()
        FILEToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        btnClear = New Button()
        btnAdd = New Button()
        txtbName = New TextBox()
        rbtnCompany = New RadioButton()
        rbtnPartnership = New RadioButton()
        rbtnSoleTrader = New RadioButton()
        txtbABNACN = New TextBox()
        cbState = New ComboBox()
        grpSearch = New GroupBox()
        btnStructure = New Button()
        btnABNACN = New Button()
        btnState = New Button()
        btnName = New Button()
        ofdFilename = New OpenFileDialog()
        sfdFilename = New SaveFileDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        mnuMainStrip.SuspendLayout()
        grpSearch.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(34, 61)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.Location = New Point(34, 107)
        lblState.Name = "lblState"
        lblState.Size = New Size(33, 15)
        lblState.TabIndex = 1
        lblState.Text = "State"
        ' 
        ' lblABNACN
        ' 
        lblABNACN.AutoSize = True
        lblABNACN.Location = New Point(34, 153)
        lblABNACN.Name = "lblABNACN"
        lblABNACN.Size = New Size(86, 15)
        lblABNACN.TabIndex = 2
        lblABNACN.Text = "ABN / ACN No"
        ' 
        ' lblStructure
        ' 
        lblStructure.AutoSize = True
        lblStructure.Location = New Point(34, 204)
        lblStructure.Name = "lblStructure"
        lblStructure.Size = New Size(55, 15)
        lblStructure.TabIndex = 3
        lblStructure.Text = "Structure"
        ' 
        ' mnuMainStrip
        ' 
        mnuMainStrip.Items.AddRange(New ToolStripItem() {FILEToolStripMenuItem})
        mnuMainStrip.Location = New Point(0, 0)
        mnuMainStrip.Name = "mnuMainStrip"
        mnuMainStrip.Size = New Size(450, 24)
        mnuMainStrip.TabIndex = 4
        mnuMainStrip.Text = "MenuStrip1"
        ' 
        ' FILEToolStripMenuItem
        ' 
        FILEToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, PrintPreviewToolStripMenuItem, ExitToolStripMenuItem})
        FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        FILEToolStripMenuItem.Size = New Size(40, 20)
        FILEToolStripMenuItem.Text = "FILE"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(143, 22)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(143, 22)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(143, 22)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(143, 22)
        PrintPreviewToolStripMenuItem.Text = "Print Preview"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(143, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(69, 273)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(87, 31)
        btnClear.TabIndex = 5
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(231, 273)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(95, 31)
        btnAdd.TabIndex = 6
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtbName
        ' 
        txtbName.Location = New Point(136, 57)
        txtbName.Name = "txtbName"
        txtbName.Size = New Size(170, 23)
        txtbName.TabIndex = 7
        ' 
        ' rbtnCompany
        ' 
        rbtnCompany.AutoSize = True
        rbtnCompany.Location = New Point(139, 204)
        rbtnCompany.Name = "rbtnCompany"
        rbtnCompany.Size = New Size(77, 19)
        rbtnCompany.TabIndex = 8
        rbtnCompany.TabStop = True
        rbtnCompany.Text = "Company"
        rbtnCompany.UseVisualStyleBackColor = True
        ' 
        ' rbtnPartnership
        ' 
        rbtnPartnership.AutoSize = True
        rbtnPartnership.Location = New Point(241, 204)
        rbtnPartnership.Name = "rbtnPartnership"
        rbtnPartnership.Size = New Size(85, 19)
        rbtnPartnership.TabIndex = 9
        rbtnPartnership.TabStop = True
        rbtnPartnership.Text = "Partnership"
        rbtnPartnership.UseVisualStyleBackColor = True
        ' 
        ' rbtnSoleTrader
        ' 
        rbtnSoleTrader.AutoSize = True
        rbtnSoleTrader.Location = New Point(344, 204)
        rbtnSoleTrader.Name = "rbtnSoleTrader"
        rbtnSoleTrader.Size = New Size(83, 19)
        rbtnSoleTrader.TabIndex = 10
        rbtnSoleTrader.TabStop = True
        rbtnSoleTrader.Text = "Sole Trader"
        rbtnSoleTrader.UseVisualStyleBackColor = True
        ' 
        ' txtbABNACN
        ' 
        txtbABNACN.Location = New Point(139, 150)
        txtbABNACN.Name = "txtbABNACN"
        txtbABNACN.Size = New Size(167, 23)
        txtbABNACN.TabIndex = 11
        ' 
        ' cbState
        ' 
        cbState.FormattingEnabled = True
        cbState.Items.AddRange(New Object() {"VIC", "NSW", "QLD", "TAS", "WA", "SA"})
        cbState.Location = New Point(139, 104)
        cbState.Name = "cbState"
        cbState.Size = New Size(121, 23)
        cbState.TabIndex = 12
        ' 
        ' grpSearch
        ' 
        grpSearch.Controls.Add(btnStructure)
        grpSearch.Controls.Add(btnABNACN)
        grpSearch.Controls.Add(btnState)
        grpSearch.Controls.Add(btnName)
        grpSearch.Location = New Point(0, 339)
        grpSearch.Name = "grpSearch"
        grpSearch.Size = New Size(451, 194)
        grpSearch.TabIndex = 13
        grpSearch.TabStop = False
        grpSearch.Text = "SEARCH"
        ' 
        ' btnStructure
        ' 
        btnStructure.Font = New Font("Segoe UI", 11.25F)
        btnStructure.Location = New Point(231, 114)
        btnStructure.Name = "btnStructure"
        btnStructure.Size = New Size(111, 35)
        btnStructure.TabIndex = 3
        btnStructure.Text = "Structure"
        btnStructure.UseVisualStyleBackColor = True
        ' 
        ' btnABNACN
        ' 
        btnABNACN.Font = New Font("Segoe UI", 11.25F)
        btnABNACN.Location = New Point(69, 114)
        btnABNACN.Name = "btnABNACN"
        btnABNACN.Size = New Size(120, 35)
        btnABNACN.TabIndex = 2
        btnABNACN.Text = "ACN / ABN No"
        btnABNACN.UseVisualStyleBackColor = True
        ' 
        ' btnState
        ' 
        btnState.Font = New Font("Segoe UI", 11.25F)
        btnState.Location = New Point(231, 51)
        btnState.Name = "btnState"
        btnState.Size = New Size(111, 33)
        btnState.TabIndex = 1
        btnState.Text = "State"
        btnState.UseVisualStyleBackColor = True
        ' 
        ' btnName
        ' 
        btnName.Font = New Font("Segoe UI", 11.25F)
        btnName.Location = New Point(69, 51)
        btnName.Name = "btnName"
        btnName.Size = New Size(120, 33)
        btnName.TabIndex = 0
        btnName.Text = "Name"
        btnName.UseVisualStyleBackColor = True
        ' 
        ' ofdFilename
        ' 
        ofdFilename.FileName = "OpenFileDialog1"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 529)
        Controls.Add(grpSearch)
        Controls.Add(cbState)
        Controls.Add(txtbABNACN)
        Controls.Add(rbtnSoleTrader)
        Controls.Add(rbtnPartnership)
        Controls.Add(rbtnCompany)
        Controls.Add(txtbName)
        Controls.Add(btnAdd)
        Controls.Add(btnClear)
        Controls.Add(lblStructure)
        Controls.Add(lblABNACN)
        Controls.Add(lblState)
        Controls.Add(lblName)
        Controls.Add(mnuMainStrip)
        MainMenuStrip = mnuMainStrip
        Name = "Form1"
        Text = "SupplierList"
        mnuMainStrip.ResumeLayout(False)
        mnuMainStrip.PerformLayout()
        grpSearch.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblABNACN As Label
    Friend WithEvents lblStructure As Label
    Friend WithEvents mnuMainStrip As MenuStrip
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtbName As TextBox
    Friend WithEvents rbtnCompany As RadioButton
    Friend WithEvents rbtnPartnership As RadioButton
    Friend WithEvents rbtnSoleTrader As RadioButton
    Friend WithEvents txtbABNACN As TextBox
    Friend WithEvents cbState As ComboBox
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnStructure As Button
    Friend WithEvents btnABNACN As Button
    Friend WithEvents btnState As Button
    Friend WithEvents btnName As Button
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ofdFilename As OpenFileDialog
    Friend WithEvents sfdFilename As SaveFileDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
