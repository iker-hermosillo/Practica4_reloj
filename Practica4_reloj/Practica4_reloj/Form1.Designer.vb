<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.dia = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.Location = New System.Drawing.Point(26, 27)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(151, 108)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 108)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.Location = New System.Drawing.Point(222, 27)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(151, 108)
        Me.minutos.TabIndex = 2
        Me.minutos.Text = "00"
        '
        'dia
        '
        Me.dia.AutoSize = True
        Me.dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dia.Location = New System.Drawing.Point(24, 166)
        Me.dia.Name = "dia"
        Me.dia.Size = New System.Drawing.Size(121, 42)
        Me.dia.TabIndex = 3
        Me.dia.Text = "Lunes"
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(24, 225)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(349, 39)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de marzo del 2026"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 287)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dia)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.horas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents minutos As Label
    Friend WithEvents dia As Label
    Friend WithEvents fecha As Label
    Friend WithEvents Timer1 As Timer
End Class
