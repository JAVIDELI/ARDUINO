<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estacion_Meteo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estacion_Meteo))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txttemp = New System.Windows.Forms.TextBox()
        Me.txthum = New System.Windows.Forms.TextBox()
        Me.txtluz = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ºC = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1900
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM5"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(84, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Temperatura"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Moccasin
        Me.Button2.Location = New System.Drawing.Point(84, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Luz"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Location = New System.Drawing.Point(84, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Humedad"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txttemp
        '
        Me.txttemp.BackColor = System.Drawing.SystemColors.Info
        Me.txttemp.Enabled = False
        Me.txttemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttemp.Location = New System.Drawing.Point(165, 98)
        Me.txttemp.Name = "txttemp"
        Me.txttemp.Size = New System.Drawing.Size(54, 20)
        Me.txttemp.TabIndex = 4
        '
        'txthum
        '
        Me.txthum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txthum.Enabled = False
        Me.txthum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthum.Location = New System.Drawing.Point(165, 150)
        Me.txthum.Name = "txthum"
        Me.txthum.Size = New System.Drawing.Size(54, 20)
        Me.txthum.TabIndex = 5
        '
        'txtluz
        '
        Me.txtluz.BackColor = System.Drawing.Color.Moccasin
        Me.txtluz.Enabled = False
        Me.txtluz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtluz.Location = New System.Drawing.Point(165, 204)
        Me.txtluz.Name = "txtluz"
        Me.txtluz.Size = New System.Drawing.Size(54, 20)
        Me.txtluz.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Wheat
        Me.Button4.Location = New System.Drawing.Point(12, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(290, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Estación Metereológica"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.Info
        Me.Button5.Location = New System.Drawing.Point(12, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(290, 32)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "JDD@Control"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ºC
        '
        Me.ºC.BackColor = System.Drawing.SystemColors.Info
        Me.ºC.Location = New System.Drawing.Point(214, 98)
        Me.ºC.Name = "ºC"
        Me.ºC.Size = New System.Drawing.Size(47, 20)
        Me.ºC.TabIndex = 9
        Me.ºC.Text = " ª C"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(214, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(47, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = " %HR"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Moccasin
        Me.TextBox2.Location = New System.Drawing.Point(214, 204)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(47, 20)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = " % LUX"
        '
        'Estacion_Meteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 266)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ºC)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtluz)
        Me.Controls.Add(Me.txthum)
        Me.Controls.Add(Me.txttemp)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estacion_Meteo"
        Me.Text = "Estacion Metereologica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txttemp As TextBox
    Friend WithEvents txthum As TextBox
    Friend WithEvents txtluz As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ºC As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
