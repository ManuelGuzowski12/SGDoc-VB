<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministracionDeUsuariosYPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDocumentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionFisicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevoBindingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarDocumentoEnBindingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevaCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarBindingEnCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RacksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevoRackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarRackEnBodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BodegasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearNuevaBodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarRackABodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionDeUsuariosYPermisosToolStripMenuItem, Me.GestionDocumentalToolStripMenuItem, Me.AdministracionFisicaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministracionDeUsuariosYPermisosToolStripMenuItem
        '
        Me.AdministracionDeUsuariosYPermisosToolStripMenuItem.Name = "AdministracionDeUsuariosYPermisosToolStripMenuItem"
        Me.AdministracionDeUsuariosYPermisosToolStripMenuItem.Size = New System.Drawing.Size(291, 20)
        Me.AdministracionDeUsuariosYPermisosToolStripMenuItem.Text = "Administracion de Usuarios  y Permisos"
        '
        'GestionDocumentalToolStripMenuItem
        '
        Me.GestionDocumentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.GestionDocumentalToolStripMenuItem.Name = "GestionDocumentalToolStripMenuItem"
        Me.GestionDocumentalToolStripMenuItem.Size = New System.Drawing.Size(158, 20)
        Me.GestionDocumentalToolStripMenuItem.Text = "Gestion Documental"
        '
        'CrearToolStripMenuItem
        '
        Me.CrearToolStripMenuItem.Name = "CrearToolStripMenuItem"
        Me.CrearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CrearToolStripMenuItem.Text = "Crear "
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'AdministracionFisicaToolStripMenuItem
        '
        Me.AdministracionFisicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingToolStripMenuItem, Me.CajasToolStripMenuItem, Me.RacksToolStripMenuItem, Me.BodegasToolStripMenuItem})
        Me.AdministracionFisicaToolStripMenuItem.Name = "AdministracionFisicaToolStripMenuItem"
        Me.AdministracionFisicaToolStripMenuItem.Size = New System.Drawing.Size(167, 20)
        Me.AdministracionFisicaToolStripMenuItem.Text = "Administracion Fisica"
        '
        'BindingToolStripMenuItem
        '
        Me.BindingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevoBindingToolStripMenuItem, Me.InsertarDocumentoEnBindingToolStripMenuItem})
        Me.BindingToolStripMenuItem.Name = "BindingToolStripMenuItem"
        Me.BindingToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BindingToolStripMenuItem.Text = "Binding"
        '
        'CrearNuevoBindingToolStripMenuItem
        '
        Me.CrearNuevoBindingToolStripMenuItem.Name = "CrearNuevoBindingToolStripMenuItem"
        Me.CrearNuevoBindingToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.CrearNuevoBindingToolStripMenuItem.Text = "Crear Nuevo Binding"
        '
        'InsertarDocumentoEnBindingToolStripMenuItem
        '
        Me.InsertarDocumentoEnBindingToolStripMenuItem.Name = "InsertarDocumentoEnBindingToolStripMenuItem"
        Me.InsertarDocumentoEnBindingToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.InsertarDocumentoEnBindingToolStripMenuItem.Text = "Insertar Documento en Binding"
        '
        'CajasToolStripMenuItem
        '
        Me.CajasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevaCajaToolStripMenuItem, Me.InsertarBindingEnCajaToolStripMenuItem})
        Me.CajasToolStripMenuItem.Name = "CajasToolStripMenuItem"
        Me.CajasToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CajasToolStripMenuItem.Text = "Cajas"
        '
        'CrearNuevaCajaToolStripMenuItem
        '
        Me.CrearNuevaCajaToolStripMenuItem.Name = "CrearNuevaCajaToolStripMenuItem"
        Me.CrearNuevaCajaToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.CrearNuevaCajaToolStripMenuItem.Text = "Crear Nueva Caja"
        '
        'InsertarBindingEnCajaToolStripMenuItem
        '
        Me.InsertarBindingEnCajaToolStripMenuItem.Name = "InsertarBindingEnCajaToolStripMenuItem"
        Me.InsertarBindingEnCajaToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.InsertarBindingEnCajaToolStripMenuItem.Text = "Insertar Binding a Caja"
        '
        'RacksToolStripMenuItem
        '
        Me.RacksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevoRackToolStripMenuItem, Me.InsertarRackEnBodegaToolStripMenuItem})
        Me.RacksToolStripMenuItem.Name = "RacksToolStripMenuItem"
        Me.RacksToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.RacksToolStripMenuItem.Text = "Racks"
        '
        'CrearNuevoRackToolStripMenuItem
        '
        Me.CrearNuevoRackToolStripMenuItem.Name = "CrearNuevoRackToolStripMenuItem"
        Me.CrearNuevoRackToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.CrearNuevoRackToolStripMenuItem.Text = "Crear Nuevo Rack"
        '
        'InsertarRackEnBodegaToolStripMenuItem
        '
        Me.InsertarRackEnBodegaToolStripMenuItem.Name = "InsertarRackEnBodegaToolStripMenuItem"
        Me.InsertarRackEnBodegaToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.InsertarRackEnBodegaToolStripMenuItem.Text = "Insertar Cajas a Racks"
        '
        'BodegasToolStripMenuItem
        '
        Me.BodegasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearNuevaBodegaToolStripMenuItem, Me.InsertarRackABodegaToolStripMenuItem})
        Me.BodegasToolStripMenuItem.Name = "BodegasToolStripMenuItem"
        Me.BodegasToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BodegasToolStripMenuItem.Text = "Bodegas"
        '
        'CrearNuevaBodegaToolStripMenuItem
        '
        Me.CrearNuevaBodegaToolStripMenuItem.Name = "CrearNuevaBodegaToolStripMenuItem"
        Me.CrearNuevaBodegaToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.CrearNuevaBodegaToolStripMenuItem.Text = "Crear Nueva Bodega"
        '
        'InsertarRackABodegaToolStripMenuItem
        '
        Me.InsertarRackABodegaToolStripMenuItem.Name = "InsertarRackABodegaToolStripMenuItem"
        Me.InsertarRackABodegaToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.InsertarRackABodegaToolStripMenuItem.Text = "Insertar Rack a Bodega"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Location = New System.Drawing.Point(329, 269)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGDoc.My.Resources.Resources.doc
        Me.PictureBox1.Location = New System.Drawing.Point(13, 45)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(725, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(802, 301)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Menu_Principal"
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministracionDeUsuariosYPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDocumentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionFisicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RacksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BodegasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CrearNuevoBindingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarDocumentoEnBindingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearNuevaCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarBindingEnCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearNuevoRackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarRackEnBodegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearNuevaBodegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarRackABodegaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
