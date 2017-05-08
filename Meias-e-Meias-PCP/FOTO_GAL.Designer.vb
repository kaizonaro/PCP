<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOTO_GAL
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
        Me.GAL_ID = New System.Windows.Forms.GroupBox()
        Me.GAL_TITULO = New System.Windows.Forms.TextBox()
        Me.GAL_DESCRICAO = New System.Windows.Forms.TextBox()
        Me.GAL_CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GAL_FOTO = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GAL_ID.SuspendLayout()
        CType(Me.GAL_FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GAL_ID
        '
        Me.GAL_ID.Controls.Add(Me.Button1)
        Me.GAL_ID.Controls.Add(Me.Label3)
        Me.GAL_ID.Controls.Add(Me.Label1)
        Me.GAL_ID.Controls.Add(Me.Label2)
        Me.GAL_ID.Controls.Add(Me.GAL_CATEGORIA)
        Me.GAL_ID.Controls.Add(Me.GAL_DESCRICAO)
        Me.GAL_ID.Controls.Add(Me.GAL_TITULO)
        Me.GAL_ID.Controls.Add(Me.GAL_FOTO)
        Me.GAL_ID.Location = New System.Drawing.Point(3, 3)
        Me.GAL_ID.Name = "GAL_ID"
        Me.GAL_ID.Size = New System.Drawing.Size(234, 449)
        Me.GAL_ID.TabIndex = 0
        Me.GAL_ID.TabStop = False
        Me.GAL_ID.Text = "Foto da Galeria"
        '
        'GAL_TITULO
        '
        Me.GAL_TITULO.Location = New System.Drawing.Point(6, 246)
        Me.GAL_TITULO.Name = "GAL_TITULO"
        Me.GAL_TITULO.Size = New System.Drawing.Size(222, 20)
        Me.GAL_TITULO.TabIndex = 1
        '
        'GAL_DESCRICAO
        '
        Me.GAL_DESCRICAO.Location = New System.Drawing.Point(7, 330)
        Me.GAL_DESCRICAO.Multiline = True
        Me.GAL_DESCRICAO.Name = "GAL_DESCRICAO"
        Me.GAL_DESCRICAO.Size = New System.Drawing.Size(221, 66)
        Me.GAL_DESCRICAO.TabIndex = 2
        '
        'GAL_CATEGORIA
        '
        Me.GAL_CATEGORIA.FormattingEnabled = True
        Me.GAL_CATEGORIA.Location = New System.Drawing.Point(6, 286)
        Me.GAL_CATEGORIA.Name = "GAL_CATEGORIA"
        Me.GAL_CATEGORIA.Size = New System.Drawing.Size(222, 21)
        Me.GAL_CATEGORIA.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Titulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descrição"
        '
        'GAL_FOTO
        '
        Me.GAL_FOTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GAL_FOTO.Location = New System.Drawing.Point(6, 19)
        Me.GAL_FOTO.Name = "GAL_FOTO"
        Me.GAL_FOTO.Size = New System.Drawing.Size(222, 208)
        Me.GAL_FOTO.TabIndex = 0
        Me.GAL_FOTO.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(75, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Apagar Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FOTO_GAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GAL_ID)
        Me.Name = "FOTO_GAL"
        Me.Size = New System.Drawing.Size(240, 455)
        Me.GAL_ID.ResumeLayout(False)
        Me.GAL_ID.PerformLayout()
        CType(Me.GAL_FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GAL_ID As GroupBox
    Friend WithEvents GAL_FOTO As PictureBox
    Friend WithEvents GAL_DESCRICAO As TextBox
    Friend WithEvents GAL_TITULO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GAL_CATEGORIA As ComboBox
    Friend WithEvents Button1 As Button
End Class
