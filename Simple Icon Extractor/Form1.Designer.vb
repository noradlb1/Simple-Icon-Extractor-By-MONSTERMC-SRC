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
        Me.SlcTheme1 = New WindowsApplication1.SLCTheme()
        Me.SlcClose1 = New WindowsApplication1.SLCClose()
        Me.SlCbtn1 = New WindowsApplication1.SLCbtn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SlcContextMenu1 = New WindowsApplication1.SLCContextMenu()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn1)
        Me.SlcTheme1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(304, 423)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 2
        Me.SlcTheme1.Text = "Simple Icon Extactor By MONSTERMC"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New WindowsApplication1.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SlcClose1.Location = New System.Drawing.Point(284, 3)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 3
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New WindowsApplication1.Bloom(-1) {}
        Me.SlCbtn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = CType(resources.GetObject("SlCbtn1.Image"), System.Drawing.Image)
        Me.SlCbtn1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SlCbtn1.Location = New System.Drawing.Point(12, 77)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(280, 23)
        Me.SlCbtn1.TabIndex = 2
        Me.SlCbtn1.Text = "Select File(s)"
        Me.SlCbtn1.Transparent = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.CausesValidation = False
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 106)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(280, 264)
        Me.FlowLayoutPanel1.TabIndex = 1
        Me.FlowLayoutPanel1.TabStop = True
        '
        'SlcContextMenu1
        '
        Me.SlcContextMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.SlcContextMenu1.Name = "SlcContextMenu1"
        Me.SlcContextMenu1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 423)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Simple Icon Extactor"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlcTheme1 As SLCTheme
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SlCbtn1 As SLCbtn
    Friend WithEvents SlcClose1 As SLCClose
    Friend WithEvents SlcContextMenu1 As SLCContextMenu
End Class
