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
        Me.Calcula = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.datoA = New System.Windows.Forms.TextBox()
        Me.datoB = New System.Windows.Forms.TextBox()
        Me.datoC = New System.Windows.Forms.TextBox()
        Me.raiz1 = New System.Windows.Forms.TextBox()
        Me.raiz2 = New System.Windows.Forms.TextBox()
        Me.tipo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Calcula
        '
        Me.Calcula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcula.Location = New System.Drawing.Point(228, 222)
        Me.Calcula.Name = "Calcula"
        Me.Calcula.Size = New System.Drawing.Size(195, 96)
        Me.Calcula.TabIndex = 4
        Me.Calcula.Text = "Calcular"
        Me.Calcula.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(899, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 78)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar los datos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(899, 265)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(133, 35)
        Me.Salir.TabIndex = 6
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(795, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "BIENVENIDO A LA CALCULADORA DE ECUACIONES DE SUGUNDO GRADO!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(491, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dada la formula general de la ecuacion segundo grado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(607, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " Ax2 + Bx +C = 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(559, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Introduce los valores de los parametros para obtener las raices:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "La solucion es de tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "B"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(470, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Raiz 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(470, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Raiz 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(490, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Calculadora realizada por Adrian Panes, Sergio Mendoza y Álvaro Gª de la Torre"
        '
        'datoA
        '
        Me.datoA.Location = New System.Drawing.Point(62, 213)
        Me.datoA.Name = "datoA"
        Me.datoA.Size = New System.Drawing.Size(100, 22)
        Me.datoA.TabIndex = 1
        '
        'datoB
        '
        Me.datoB.Location = New System.Drawing.Point(62, 259)
        Me.datoB.Name = "datoB"
        Me.datoB.Size = New System.Drawing.Size(100, 22)
        Me.datoB.TabIndex = 2
        '
        'datoC
        '
        Me.datoC.Location = New System.Drawing.Point(62, 302)
        Me.datoC.Name = "datoC"
        Me.datoC.Size = New System.Drawing.Size(100, 22)
        Me.datoC.TabIndex = 3
        '
        'raiz1
        '
        Me.raiz1.Location = New System.Drawing.Point(520, 222)
        Me.raiz1.Name = "raiz1"
        Me.raiz1.ReadOnly = True
        Me.raiz1.Size = New System.Drawing.Size(287, 22)
        Me.raiz1.TabIndex = 28
        '
        'raiz2
        '
        Me.raiz2.Location = New System.Drawing.Point(520, 262)
        Me.raiz2.Name = "raiz2"
        Me.raiz2.ReadOnly = True
        Me.raiz2.Size = New System.Drawing.Size(287, 22)
        Me.raiz2.TabIndex = 18
        '
        'tipo
        '
        Me.tipo.BackColor = System.Drawing.SystemColors.Menu
        Me.tipo.Location = New System.Drawing.Point(642, 159)
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Size = New System.Drawing.Size(225, 22)
        Me.tipo.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 432)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.raiz2)
        Me.Controls.Add(Me.raiz1)
        Me.Controls.Add(Me.datoC)
        Me.Controls.Add(Me.datoB)
        Me.Controls.Add(Me.datoA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Calcula)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calcula As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents datoA As TextBox
    Friend WithEvents datoB As TextBox
    Friend WithEvents datoC As TextBox
    Friend WithEvents raiz1 As TextBox
    Friend WithEvents raiz2 As TextBox
    Friend WithEvents tipo As TextBox
End Class
