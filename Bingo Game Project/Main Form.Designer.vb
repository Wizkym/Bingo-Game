<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelI1 = New System.Windows.Forms.Label()
        Me.LabelO5 = New System.Windows.Forms.Label()
        Me.LabelG5 = New System.Windows.Forms.Label()
        Me.LabelN4 = New System.Windows.Forms.Label()
        Me.LabelI5 = New System.Windows.Forms.Label()
        Me.LabelB5 = New System.Windows.Forms.Label()
        Me.LabelO4 = New System.Windows.Forms.Label()
        Me.LabelG4 = New System.Windows.Forms.Label()
        Me.LabelN3 = New System.Windows.Forms.Label()
        Me.LabelI4 = New System.Windows.Forms.Label()
        Me.LabelB4 = New System.Windows.Forms.Label()
        Me.LabelO3 = New System.Windows.Forms.Label()
        Me.LabelG3 = New System.Windows.Forms.Label()
        Me.LabelI3 = New System.Windows.Forms.Label()
        Me.LabelB3 = New System.Windows.Forms.Label()
        Me.LabelO2 = New System.Windows.Forms.Label()
        Me.LabelG2 = New System.Windows.Forms.Label()
        Me.LabelN2 = New System.Windows.Forms.Label()
        Me.LabelI2 = New System.Windows.Forms.Label()
        Me.LabelB2 = New System.Windows.Forms.Label()
        Me.LabelO1 = New System.Windows.Forms.Label()
        Me.LabelG1 = New System.Windows.Forms.Label()
        Me.LabelN1 = New System.Windows.Forms.Label()
        Me.LabelB1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.newGameButton = New System.Windows.Forms.Button()
        Me.getNumButton = New System.Windows.Forms.Button()
        Me.newNumLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.TableLayoutPanel.ColumnCount = 5
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Controls.Add(Me.LabelI1, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelO5, 4, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelG5, 3, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelN4, 2, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelI5, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelB5, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelO4, 4, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelG4, 3, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelN3, 2, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelI4, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelB4, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelO3, 4, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelG3, 3, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelI3, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelB3, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelO2, 4, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelG2, 3, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelN2, 2, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelI2, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelB2, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelO1, 4, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelG1, 3, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelN1, 2, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelB1, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.PictureBox2, 2, 2)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(7, 178)
        Me.TableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 5
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(420, 235)
        Me.TableLayoutPanel.TabIndex = 1
        '
        'LabelI1
        '
        Me.LabelI1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI1.AutoSize = True
        Me.LabelI1.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelI1.Location = New System.Drawing.Point(90, 3)
        Me.LabelI1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelI1.Name = "LabelI1"
        Me.LabelI1.Size = New System.Drawing.Size(72, 43)
        Me.LabelI1.TabIndex = 24
        Me.LabelI1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO5
        '
        Me.LabelO5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO5.AutoSize = True
        Me.LabelO5.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelO5.Location = New System.Drawing.Point(339, 187)
        Me.LabelO5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelO5.Name = "LabelO5"
        Me.LabelO5.Size = New System.Drawing.Size(74, 45)
        Me.LabelO5.TabIndex = 26
        Me.LabelO5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG5
        '
        Me.LabelG5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG5.AutoSize = True
        Me.LabelG5.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG5.Location = New System.Drawing.Point(256, 187)
        Me.LabelG5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelG5.Name = "LabelG5"
        Me.LabelG5.Size = New System.Drawing.Size(72, 45)
        Me.LabelG5.TabIndex = 25
        Me.LabelG5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN4
        '
        Me.LabelN4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN4.AutoSize = True
        Me.LabelN4.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelN4.Location = New System.Drawing.Point(173, 187)
        Me.LabelN4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelN4.Name = "LabelN4"
        Me.LabelN4.Size = New System.Drawing.Size(72, 45)
        Me.LabelN4.TabIndex = 24
        Me.LabelN4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI5
        '
        Me.LabelI5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI5.AutoSize = True
        Me.LabelI5.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelI5.Location = New System.Drawing.Point(90, 187)
        Me.LabelI5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelI5.Name = "LabelI5"
        Me.LabelI5.Size = New System.Drawing.Size(72, 45)
        Me.LabelI5.TabIndex = 23
        Me.LabelI5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB5
        '
        Me.LabelB5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB5.AutoSize = True
        Me.LabelB5.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB5.Location = New System.Drawing.Point(7, 187)
        Me.LabelB5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelB5.Name = "LabelB5"
        Me.LabelB5.Size = New System.Drawing.Size(72, 45)
        Me.LabelB5.TabIndex = 22
        Me.LabelB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO4
        '
        Me.LabelO4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO4.AutoSize = True
        Me.LabelO4.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelO4.Location = New System.Drawing.Point(339, 141)
        Me.LabelO4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelO4.Name = "LabelO4"
        Me.LabelO4.Size = New System.Drawing.Size(74, 43)
        Me.LabelO4.TabIndex = 21
        Me.LabelO4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG4
        '
        Me.LabelG4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG4.AutoSize = True
        Me.LabelG4.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG4.Location = New System.Drawing.Point(256, 141)
        Me.LabelG4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelG4.Name = "LabelG4"
        Me.LabelG4.Size = New System.Drawing.Size(72, 43)
        Me.LabelG4.TabIndex = 20
        Me.LabelG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN3
        '
        Me.LabelN3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN3.AutoSize = True
        Me.LabelN3.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelN3.Location = New System.Drawing.Point(173, 141)
        Me.LabelN3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelN3.Name = "LabelN3"
        Me.LabelN3.Size = New System.Drawing.Size(72, 43)
        Me.LabelN3.TabIndex = 19
        Me.LabelN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI4
        '
        Me.LabelI4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI4.AutoSize = True
        Me.LabelI4.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelI4.Location = New System.Drawing.Point(90, 141)
        Me.LabelI4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelI4.Name = "LabelI4"
        Me.LabelI4.Size = New System.Drawing.Size(72, 43)
        Me.LabelI4.TabIndex = 18
        Me.LabelI4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB4
        '
        Me.LabelB4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB4.AutoSize = True
        Me.LabelB4.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB4.Location = New System.Drawing.Point(7, 141)
        Me.LabelB4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelB4.Name = "LabelB4"
        Me.LabelB4.Size = New System.Drawing.Size(72, 43)
        Me.LabelB4.TabIndex = 17
        Me.LabelB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO3
        '
        Me.LabelO3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO3.AutoSize = True
        Me.LabelO3.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelO3.Location = New System.Drawing.Point(339, 95)
        Me.LabelO3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelO3.Name = "LabelO3"
        Me.LabelO3.Size = New System.Drawing.Size(74, 43)
        Me.LabelO3.TabIndex = 16
        Me.LabelO3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG3
        '
        Me.LabelG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG3.AutoSize = True
        Me.LabelG3.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG3.Location = New System.Drawing.Point(256, 95)
        Me.LabelG3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelG3.Name = "LabelG3"
        Me.LabelG3.Size = New System.Drawing.Size(72, 43)
        Me.LabelG3.TabIndex = 15
        Me.LabelG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI3
        '
        Me.LabelI3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI3.AutoSize = True
        Me.LabelI3.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelI3.Location = New System.Drawing.Point(90, 95)
        Me.LabelI3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelI3.Name = "LabelI3"
        Me.LabelI3.Size = New System.Drawing.Size(72, 43)
        Me.LabelI3.TabIndex = 13
        Me.LabelI3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB3
        '
        Me.LabelB3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB3.AutoSize = True
        Me.LabelB3.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB3.Location = New System.Drawing.Point(7, 95)
        Me.LabelB3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelB3.Name = "LabelB3"
        Me.LabelB3.Size = New System.Drawing.Size(72, 43)
        Me.LabelB3.TabIndex = 12
        Me.LabelB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO2
        '
        Me.LabelO2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO2.AutoSize = True
        Me.LabelO2.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelO2.Location = New System.Drawing.Point(339, 49)
        Me.LabelO2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelO2.Name = "LabelO2"
        Me.LabelO2.Size = New System.Drawing.Size(74, 43)
        Me.LabelO2.TabIndex = 11
        Me.LabelO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG2
        '
        Me.LabelG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG2.AutoSize = True
        Me.LabelG2.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG2.Location = New System.Drawing.Point(256, 49)
        Me.LabelG2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelG2.Name = "LabelG2"
        Me.LabelG2.Size = New System.Drawing.Size(72, 43)
        Me.LabelG2.TabIndex = 10
        Me.LabelG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN2
        '
        Me.LabelN2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN2.AutoSize = True
        Me.LabelN2.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelN2.Location = New System.Drawing.Point(173, 49)
        Me.LabelN2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelN2.Name = "LabelN2"
        Me.LabelN2.Size = New System.Drawing.Size(72, 43)
        Me.LabelN2.TabIndex = 9
        Me.LabelN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI2
        '
        Me.LabelI2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI2.AutoSize = True
        Me.LabelI2.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelI2.Location = New System.Drawing.Point(90, 49)
        Me.LabelI2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelI2.Name = "LabelI2"
        Me.LabelI2.Size = New System.Drawing.Size(72, 43)
        Me.LabelI2.TabIndex = 8
        Me.LabelI2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB2
        '
        Me.LabelB2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB2.AutoSize = True
        Me.LabelB2.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB2.Location = New System.Drawing.Point(7, 49)
        Me.LabelB2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelB2.Name = "LabelB2"
        Me.LabelB2.Size = New System.Drawing.Size(72, 43)
        Me.LabelB2.TabIndex = 7
        Me.LabelB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO1
        '
        Me.LabelO1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO1.AutoSize = True
        Me.LabelO1.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelO1.Location = New System.Drawing.Point(339, 3)
        Me.LabelO1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelO1.Name = "LabelO1"
        Me.LabelO1.Size = New System.Drawing.Size(74, 43)
        Me.LabelO1.TabIndex = 6
        Me.LabelO1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG1
        '
        Me.LabelG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG1.AutoSize = True
        Me.LabelG1.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelG1.Location = New System.Drawing.Point(256, 3)
        Me.LabelG1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelG1.Name = "LabelG1"
        Me.LabelG1.Size = New System.Drawing.Size(72, 43)
        Me.LabelG1.TabIndex = 5
        Me.LabelG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN1
        '
        Me.LabelN1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN1.AutoSize = True
        Me.LabelN1.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelN1.Location = New System.Drawing.Point(173, 3)
        Me.LabelN1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelN1.Name = "LabelN1"
        Me.LabelN1.Size = New System.Drawing.Size(72, 43)
        Me.LabelN1.TabIndex = 4
        Me.LabelN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB1
        '
        Me.LabelB1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB1.AutoSize = True
        Me.LabelB1.Font = New System.Drawing.Font("Jokerman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelB1.Location = New System.Drawing.Point(7, 3)
        Me.LabelB1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelB1.Name = "LabelB1"
        Me.LabelB1.Size = New System.Drawing.Size(72, 43)
        Me.LabelB1.TabIndex = 2
        Me.LabelB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Bingo_Game_Project.My.Resources.Resources.centerimg
        Me.PictureBox2.Location = New System.Drawing.Point(173, 99)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'newGameButton
        '
        Me.newGameButton.Location = New System.Drawing.Point(7, 424)
        Me.newGameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.newGameButton.Name = "newGameButton"
        Me.newGameButton.Size = New System.Drawing.Size(83, 53)
        Me.newGameButton.TabIndex = 1
        Me.newGameButton.Text = "&New Game"
        Me.newGameButton.UseVisualStyleBackColor = True
        '
        'getNumButton
        '
        Me.getNumButton.Location = New System.Drawing.Point(99, 424)
        Me.getNumButton.Margin = New System.Windows.Forms.Padding(4)
        Me.getNumButton.Name = "getNumButton"
        Me.getNumButton.Size = New System.Drawing.Size(83, 53)
        Me.getNumButton.TabIndex = 0
        Me.getNumButton.Text = "&Get Number"
        Me.getNumButton.UseVisualStyleBackColor = True
        '
        'newNumLabel
        '
        Me.newNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.newNumLabel.Location = New System.Drawing.Point(192, 424)
        Me.newNumLabel.Name = "newNumLabel"
        Me.newNumLabel.Size = New System.Drawing.Size(54, 54)
        Me.newNumLabel.TabIndex = 6
        Me.newNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(353, 424)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(74, 52)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bingo_Game_Project.My.Resources.Resources.bingoheader
        Me.PictureBox1.Location = New System.Drawing.Point(7, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'fontButton
        '
        Me.fontButton.Location = New System.Drawing.Point(263, 424)
        Me.fontButton.Margin = New System.Windows.Forms.Padding(4)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(82, 53)
        Me.fontButton.TabIndex = 3
        Me.fontButton.Text = "&Font"
        Me.fontButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(462, 181)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 214)
        Me.ListBox1.TabIndex = 9
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(435, 495)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.fontButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.newNumLabel)
        Me.Controls.Add(Me.getNumButton)
        Me.Controls.Add(Me.newGameButton)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BINGO"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelO5 As System.Windows.Forms.Label
    Friend WithEvents LabelG5 As System.Windows.Forms.Label
    Friend WithEvents LabelN4 As System.Windows.Forms.Label
    Friend WithEvents LabelI5 As System.Windows.Forms.Label
    Friend WithEvents LabelB5 As System.Windows.Forms.Label
    Friend WithEvents LabelO4 As System.Windows.Forms.Label
    Friend WithEvents LabelG4 As System.Windows.Forms.Label
    Friend WithEvents LabelN3 As System.Windows.Forms.Label
    Friend WithEvents LabelI4 As System.Windows.Forms.Label
    Friend WithEvents LabelB4 As System.Windows.Forms.Label
    Friend WithEvents LabelO3 As System.Windows.Forms.Label
    Friend WithEvents LabelG3 As System.Windows.Forms.Label
    Friend WithEvents LabelI3 As System.Windows.Forms.Label
    Friend WithEvents LabelB3 As System.Windows.Forms.Label
    Friend WithEvents LabelO2 As System.Windows.Forms.Label
    Friend WithEvents LabelG2 As System.Windows.Forms.Label
    Friend WithEvents LabelN2 As System.Windows.Forms.Label
    Friend WithEvents LabelI2 As System.Windows.Forms.Label
    Friend WithEvents LabelB2 As System.Windows.Forms.Label
    Friend WithEvents LabelO1 As System.Windows.Forms.Label
    Friend WithEvents LabelG1 As System.Windows.Forms.Label
    Friend WithEvents LabelN1 As System.Windows.Forms.Label
    Friend WithEvents LabelB1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents newGameButton As System.Windows.Forms.Button
    Friend WithEvents getNumButton As System.Windows.Forms.Button
    Friend WithEvents newNumLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents LabelI1 As System.Windows.Forms.Label
    Friend WithEvents FontDialog As FontDialog
    Friend WithEvents fontButton As Button
    Friend WithEvents ListBox1 As ListBox
End Class
