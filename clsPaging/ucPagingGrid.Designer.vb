<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPagingGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tSearch = New System.Windows.Forms.TextBox()
        Me.cboEntries = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLast
        '
        Me.btnLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(437, 323)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(29, 29)
        Me.btnLast.TabIndex = 20
        Me.btnLast.Text = "»"
        Me.btnLast.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(402, 323)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(29, 29)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = "›"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(367, 323)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(29, 29)
        Me.btnPrevious.TabIndex = 22
        Me.btnPrevious.Text = "‹"
        Me.btnPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(332, 323)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(29, 29)
        Me.btnFirst.TabIndex = 23
        Me.btnFirst.Text = "«"
        Me.btnFirst.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(11, 42)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(461, 272)
        Me.dgv.TabIndex = 19
        '
        'tSearch
        '
        Me.tSearch.Location = New System.Drawing.Point(58, 10)
        Me.tSearch.Name = "tSearch"
        Me.tSearch.Size = New System.Drawing.Size(208, 20)
        Me.tSearch.TabIndex = 18
        '
        'cboEntries
        '
        Me.cboEntries.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEntries.FormattingEnabled = True
        Me.cboEntries.Items.AddRange(New Object() {"10", "25", "50", "100", "200"})
        Me.cboEntries.Location = New System.Drawing.Point(358, 10)
        Me.cboEntries.Name = "cboEntries"
        Me.cboEntries.Size = New System.Drawing.Size(70, 21)
        Me.cboEntries.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "entries"
        '
        'lblTotals
        '
        Me.lblTotals.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(8, 331)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(169, 13)
        Me.lblTotals.TabIndex = 14
        Me.lblTotals.Text = "Showing {1} to {10} of {57} entries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Search:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Show:"
        '
        'ucPagingGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.tSearch)
        Me.Controls.Add(Me.cboEntries)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ucPagingGrid"
        Me.Size = New System.Drawing.Size(484, 361)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLast As Windows.Forms.Button
    Friend WithEvents btnNext As Windows.Forms.Button
    Friend WithEvents btnPrevious As Windows.Forms.Button
    Friend WithEvents btnFirst As Windows.Forms.Button
    Friend WithEvents dgv As Windows.Forms.DataGridView
    Friend WithEvents tSearch As Windows.Forms.TextBox
    Friend WithEvents cboEntries As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lblTotals As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
