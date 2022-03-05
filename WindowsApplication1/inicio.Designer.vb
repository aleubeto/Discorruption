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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button_informacion = New System.Windows.Forms.Button()
        Me.Button_ayuda = New System.Windows.Forms.Button()
        Me.Button_contacto = New System.Windows.Forms.Button()
        Me.Label1_avatar = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(697, 469)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Button_informacion
        '
        Me.Button_informacion.BackColor = System.Drawing.Color.Blue
        Me.Button_informacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_informacion.ForeColor = System.Drawing.Color.White
        Me.Button_informacion.Location = New System.Drawing.Point(361, 12)
        Me.Button_informacion.Name = "Button_informacion"
        Me.Button_informacion.Size = New System.Drawing.Size(102, 25)
        Me.Button_informacion.TabIndex = 3
        Me.Button_informacion.Text = "INFORMACIÓN"
        Me.Button_informacion.UseVisualStyleBackColor = False
        '
        'Button_ayuda
        '
        Me.Button_ayuda.BackColor = System.Drawing.Color.Blue
        Me.Button_ayuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ayuda.ForeColor = System.Drawing.Color.White
        Me.Button_ayuda.Location = New System.Drawing.Point(469, 12)
        Me.Button_ayuda.Name = "Button_ayuda"
        Me.Button_ayuda.Size = New System.Drawing.Size(102, 25)
        Me.Button_ayuda.TabIndex = 4
        Me.Button_ayuda.Text = "AYUDA"
        Me.Button_ayuda.UseVisualStyleBackColor = False
        '
        'Button_contacto
        '
        Me.Button_contacto.BackColor = System.Drawing.Color.Blue
        Me.Button_contacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_contacto.ForeColor = System.Drawing.Color.White
        Me.Button_contacto.Location = New System.Drawing.Point(577, 12)
        Me.Button_contacto.Name = "Button_contacto"
        Me.Button_contacto.Size = New System.Drawing.Size(102, 25)
        Me.Button_contacto.TabIndex = 5
        Me.Button_contacto.Text = "EJEMPLOS"
        Me.Button_contacto.UseVisualStyleBackColor = False
        '
        'Label1_avatar
        '
        Me.Label1_avatar.AutoSize = True
        Me.Label1_avatar.Location = New System.Drawing.Point(38, 342)
        Me.Label1_avatar.Name = "Label1_avatar"
        Me.Label1_avatar.Size = New System.Drawing.Size(0, 13)
        Me.Label1_avatar.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(253, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 25)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "NOSOTROS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(253, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "DENUNCIAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(361, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 25)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "DATOS PERSONALES"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 472)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1_avatar)
        Me.Controls.Add(Me.Button_contacto)
        Me.Controls.Add(Me.Button_ayuda)
        Me.Controls.Add(Me.Button_informacion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_informacion As System.Windows.Forms.Button
    Friend WithEvents Button_ayuda As System.Windows.Forms.Button
    Friend WithEvents Button_contacto As System.Windows.Forms.Button
    Friend WithEvents Label1_avatar As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
