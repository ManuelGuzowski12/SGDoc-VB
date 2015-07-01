<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permisos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ck_binding = New System.Windows.Forms.CheckBox()
        Me.ck_admifisica = New System.Windows.Forms.CheckBox()
        Me.ck_caja = New System.Windows.Forms.CheckBox()
        Me.ck_racks = New System.Windows.Forms.CheckBox()
        Me.ck_bodegas = New System.Windows.Forms.CheckBox()
        Me.ck_documentos = New System.Windows.Forms.CheckBox()
        Me.ck_crear = New System.Windows.Forms.CheckBox()
        Me.ck_modificar = New System.Windows.Forms.CheckBox()
        Me.ck_menu = New System.Windows.Forms.CheckBox()
        Me.ck_admi_usuario = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        '
        'ck_binding
        '
        Me.ck_binding.AutoSize = True
        Me.ck_binding.Location = New System.Drawing.Point(195, 61)
        Me.ck_binding.Name = "ck_binding"
        Me.ck_binding.Size = New System.Drawing.Size(73, 19)
        Me.ck_binding.TabIndex = 3
        Me.ck_binding.Text = "Binding"
        Me.ck_binding.UseVisualStyleBackColor = True
        '
        'ck_admifisica
        '
        Me.ck_admifisica.AutoSize = True
        Me.ck_admifisica.Location = New System.Drawing.Point(74, 22)
        Me.ck_admifisica.Name = "ck_admifisica"
        Me.ck_admifisica.Size = New System.Drawing.Size(167, 19)
        Me.ck_admifisica.TabIndex = 4
        Me.ck_admifisica.Text = "Administracion Fisica"
        Me.ck_admifisica.UseVisualStyleBackColor = True
        '
        'ck_caja
        '
        Me.ck_caja.AutoSize = True
        Me.ck_caja.Location = New System.Drawing.Point(310, 61)
        Me.ck_caja.Name = "ck_caja"
        Me.ck_caja.Size = New System.Drawing.Size(61, 19)
        Me.ck_caja.TabIndex = 5
        Me.ck_caja.Text = "Cajas"
        Me.ck_caja.UseVisualStyleBackColor = True
        '
        'ck_racks
        '
        Me.ck_racks.AutoSize = True
        Me.ck_racks.Location = New System.Drawing.Point(407, 61)
        Me.ck_racks.Name = "ck_racks"
        Me.ck_racks.Size = New System.Drawing.Size(65, 19)
        Me.ck_racks.TabIndex = 6
        Me.ck_racks.Text = "Racks"
        Me.ck_racks.UseVisualStyleBackColor = True
        '
        'ck_bodegas
        '
        Me.ck_bodegas.AutoSize = True
        Me.ck_bodegas.Location = New System.Drawing.Point(499, 61)
        Me.ck_bodegas.Name = "ck_bodegas"
        Me.ck_bodegas.Size = New System.Drawing.Size(80, 19)
        Me.ck_bodegas.TabIndex = 7
        Me.ck_bodegas.Text = "Bodegas"
        Me.ck_bodegas.UseVisualStyleBackColor = True
        '
        'ck_documentos
        '
        Me.ck_documentos.AutoSize = True
        Me.ck_documentos.Location = New System.Drawing.Point(74, 123)
        Me.ck_documentos.Name = "ck_documentos"
        Me.ck_documentos.Size = New System.Drawing.Size(160, 19)
        Me.ck_documentos.TabIndex = 8
        Me.ck_documentos.Text = "Gestion Documental"
        Me.ck_documentos.UseVisualStyleBackColor = True
        '
        'ck_crear
        '
        Me.ck_crear.AutoSize = True
        Me.ck_crear.Location = New System.Drawing.Point(195, 173)
        Me.ck_crear.Name = "ck_crear"
        Me.ck_crear.Size = New System.Drawing.Size(63, 19)
        Me.ck_crear.TabIndex = 9
        Me.ck_crear.Text = "Crear"
        Me.ck_crear.UseVisualStyleBackColor = True
        '
        'ck_modificar
        '
        Me.ck_modificar.AutoSize = True
        Me.ck_modificar.Location = New System.Drawing.Point(310, 173)
        Me.ck_modificar.Name = "ck_modificar"
        Me.ck_modificar.Size = New System.Drawing.Size(87, 19)
        Me.ck_modificar.TabIndex = 10
        Me.ck_modificar.Text = "Modificar"
        Me.ck_modificar.UseVisualStyleBackColor = True
        '
        'ck_menu
        '
        Me.ck_menu.AutoSize = True
        Me.ck_menu.Location = New System.Drawing.Point(74, 294)
        Me.ck_menu.Name = "ck_menu"
        Me.ck_menu.Size = New System.Drawing.Size(120, 19)
        Me.ck_menu.TabIndex = 11
        Me.ck_menu.Text = "Menu Principal"
        Me.ck_menu.UseVisualStyleBackColor = True
        '
        'ck_admi_usuario
        '
        Me.ck_admi_usuario.AutoSize = True
        Me.ck_admi_usuario.Location = New System.Drawing.Point(74, 249)
        Me.ck_admi_usuario.Name = "ck_admi_usuario"
        Me.ck_admi_usuario.Size = New System.Drawing.Size(283, 19)
        Me.ck_admi_usuario.TabIndex = 12
        Me.ck_admi_usuario.Text = "Administracion de Usuarios y Permisos"
        Me.ck_admi_usuario.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(499, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(662, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 43)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 358)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ck_admi_usuario)
        Me.Controls.Add(Me.ck_menu)
        Me.Controls.Add(Me.ck_modificar)
        Me.Controls.Add(Me.ck_crear)
        Me.Controls.Add(Me.ck_documentos)
        Me.Controls.Add(Me.ck_bodegas)
        Me.Controls.Add(Me.ck_racks)
        Me.Controls.Add(Me.ck_caja)
        Me.Controls.Add(Me.ck_admifisica)
        Me.Controls.Add(Me.ck_binding)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Permisos"
        Me.Text = "Permisos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ck_binding As System.Windows.Forms.CheckBox
    Friend WithEvents ck_admifisica As System.Windows.Forms.CheckBox
    Friend WithEvents ck_caja As System.Windows.Forms.CheckBox
    Friend WithEvents ck_racks As System.Windows.Forms.CheckBox
    Friend WithEvents ck_bodegas As System.Windows.Forms.CheckBox
    Friend WithEvents ck_documentos As System.Windows.Forms.CheckBox
    Friend WithEvents ck_crear As System.Windows.Forms.CheckBox
    Friend WithEvents ck_modificar As System.Windows.Forms.CheckBox
    Friend WithEvents ck_menu As System.Windows.Forms.CheckBox
    Friend WithEvents ck_admi_usuario As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
