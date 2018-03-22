<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnPopulate = New System.Windows.Forms.Button()
        Me.btnMajors = New System.Windows.Forms.Button()
        Me.btnMinors = New System.Windows.Forms.Button()
        Me.btnBranches = New System.Windows.Forms.Button()
        Me.btnCGaskets = New System.Windows.Forms.Button()
        Me.btnCFlanges = New System.Windows.Forms.Button()
        Me.btnCValves = New System.Windows.Forms.Button()
        Me.btnCReducers = New System.Windows.Forms.Button()
        Me.btnCTees = New System.Windows.Forms.Button()
        Me.btnCElbows = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPaste = New System.Windows.Forms.TextBox()
        Me.lstAllLines = New System.Windows.Forms.ListBox()
        Me.btnListLines = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TreeView1.LineColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(309, 418)
        Me.TreeView1.TabIndex = 0
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnLoad.Location = New System.Drawing.Point(327, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(99, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load File"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnPopulate
        '
        Me.btnPopulate.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPopulate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnPopulate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnPopulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPopulate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnPopulate.Location = New System.Drawing.Point(325, 72)
        Me.btnPopulate.Name = "btnPopulate"
        Me.btnPopulate.Size = New System.Drawing.Size(99, 23)
        Me.btnPopulate.TabIndex = 2
        Me.btnPopulate.Text = "<- Populate"
        Me.btnPopulate.UseVisualStyleBackColor = False
        '
        'btnMajors
        '
        Me.btnMajors.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMajors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMajors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnMajors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMajors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnMajors.Location = New System.Drawing.Point(326, 173)
        Me.btnMajors.Name = "btnMajors"
        Me.btnMajors.Size = New System.Drawing.Size(99, 23)
        Me.btnMajors.TabIndex = 3
        Me.btnMajors.Text = "Count Majors"
        Me.btnMajors.UseVisualStyleBackColor = False
        '
        'btnMinors
        '
        Me.btnMinors.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMinors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnMinors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnMinors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnMinors.Location = New System.Drawing.Point(327, 203)
        Me.btnMinors.Name = "btnMinors"
        Me.btnMinors.Size = New System.Drawing.Size(98, 23)
        Me.btnMinors.TabIndex = 4
        Me.btnMinors.Text = "Count Minors"
        Me.btnMinors.UseVisualStyleBackColor = False
        '
        'btnBranches
        '
        Me.btnBranches.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnBranches.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnBranches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnBranches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBranches.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnBranches.Location = New System.Drawing.Point(327, 232)
        Me.btnBranches.Name = "btnBranches"
        Me.btnBranches.Size = New System.Drawing.Size(99, 23)
        Me.btnBranches.TabIndex = 5
        Me.btnBranches.Text = "Count Branches"
        Me.btnBranches.UseVisualStyleBackColor = False
        '
        'btnCGaskets
        '
        Me.btnCGaskets.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCGaskets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCGaskets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCGaskets.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCGaskets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCGaskets.Location = New System.Drawing.Point(328, 262)
        Me.btnCGaskets.Name = "btnCGaskets"
        Me.btnCGaskets.Size = New System.Drawing.Size(98, 23)
        Me.btnCGaskets.TabIndex = 6
        Me.btnCGaskets.Text = "Count Gaskets"
        Me.btnCGaskets.UseVisualStyleBackColor = False
        '
        'btnCFlanges
        '
        Me.btnCFlanges.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCFlanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCFlanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCFlanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCFlanges.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCFlanges.Location = New System.Drawing.Point(328, 291)
        Me.btnCFlanges.Name = "btnCFlanges"
        Me.btnCFlanges.Size = New System.Drawing.Size(98, 23)
        Me.btnCFlanges.TabIndex = 7
        Me.btnCFlanges.Text = "Count Flanges"
        Me.btnCFlanges.UseVisualStyleBackColor = False
        '
        'btnCValves
        '
        Me.btnCValves.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCValves.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCValves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCValves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCValves.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCValves.Location = New System.Drawing.Point(328, 320)
        Me.btnCValves.Name = "btnCValves"
        Me.btnCValves.Size = New System.Drawing.Size(98, 23)
        Me.btnCValves.TabIndex = 8
        Me.btnCValves.Text = "Count Valves"
        Me.btnCValves.UseVisualStyleBackColor = False
        '
        'btnCReducers
        '
        Me.btnCReducers.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCReducers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCReducers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCReducers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCReducers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCReducers.Location = New System.Drawing.Point(327, 349)
        Me.btnCReducers.Name = "btnCReducers"
        Me.btnCReducers.Size = New System.Drawing.Size(98, 23)
        Me.btnCReducers.TabIndex = 9
        Me.btnCReducers.Text = "Count Reducers"
        Me.btnCReducers.UseVisualStyleBackColor = False
        '
        'btnCTees
        '
        Me.btnCTees.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCTees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCTees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCTees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCTees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCTees.Location = New System.Drawing.Point(328, 378)
        Me.btnCTees.Name = "btnCTees"
        Me.btnCTees.Size = New System.Drawing.Size(98, 23)
        Me.btnCTees.TabIndex = 10
        Me.btnCTees.Text = "Count Tees"
        Me.btnCTees.UseVisualStyleBackColor = False
        '
        'btnCElbows
        '
        Me.btnCElbows.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCElbows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCElbows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCElbows.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCElbows.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnCElbows.Location = New System.Drawing.Point(328, 407)
        Me.btnCElbows.Name = "btnCElbows"
        Me.btnCElbows.Size = New System.Drawing.Size(98, 23)
        Me.btnCElbows.TabIndex = 11
        Me.btnCElbows.Text = "Count Elbows"
        Me.btnCElbows.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(328, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
        Me.TextBox1.TabIndex = 12
        '
        'txtPaste
        '
        Me.txtPaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtPaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtPaste.Location = New System.Drawing.Point(12, 436)
        Me.txtPaste.Multiline = True
        Me.txtPaste.Name = "txtPaste"
        Me.txtPaste.Size = New System.Drawing.Size(716, 256)
        Me.txtPaste.TabIndex = 13
        Me.txtPaste.Text = resources.GetString("txtPaste.Text")
        '
        'lstAllLines
        '
        Me.lstAllLines.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lstAllLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstAllLines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lstAllLines.FormattingEnabled = True
        Me.lstAllLines.Location = New System.Drawing.Point(431, 12)
        Me.lstAllLines.Name = "lstAllLines"
        Me.lstAllLines.Size = New System.Drawing.Size(297, 418)
        Me.lstAllLines.TabIndex = 15
        '
        'btnListLines
        '
        Me.btnListLines.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnListLines.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnListLines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnListLines.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListLines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnListLines.Location = New System.Drawing.Point(327, 41)
        Me.btnListLines.Name = "btnListLines"
        Me.btnListLines.Size = New System.Drawing.Size(99, 23)
        Me.btnListLines.TabIndex = 16
        Me.btnListLines.Text = "From Clipboard"
        Me.btnListLines.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(740, 704)
        Me.Controls.Add(Me.txtPaste)
        Me.Controls.Add(Me.btnListLines)
        Me.Controls.Add(Me.lstAllLines)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCElbows)
        Me.Controls.Add(Me.btnCTees)
        Me.Controls.Add(Me.btnCReducers)
        Me.Controls.Add(Me.btnCValves)
        Me.Controls.Add(Me.btnCFlanges)
        Me.Controls.Add(Me.btnCGaskets)
        Me.Controls.Add(Me.btnBranches)
        Me.Controls.Add(Me.btnMinors)
        Me.Controls.Add(Me.btnMajors)
        Me.Controls.Add(Me.btnPopulate)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.TreeView1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnPopulate As Button
    Friend WithEvents btnMajors As Button
    Friend WithEvents btnMinors As Button
    Friend WithEvents btnBranches As Button
    Friend WithEvents btnCGaskets As Button
    Friend WithEvents btnCFlanges As Button
    Friend WithEvents btnCValves As Button
    Friend WithEvents btnCReducers As Button
    Friend WithEvents btnCTees As Button
    Friend WithEvents btnCElbows As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPaste As TextBox
    Friend WithEvents lstAllLines As ListBox
    Friend WithEvents btnListLines As Button
End Class
