﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesignPatterns
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnSingleton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSingleton
        '
        Me.BtnSingleton.Location = New System.Drawing.Point(12, 12)
        Me.BtnSingleton.Name = "BtnSingleton"
        Me.BtnSingleton.Size = New System.Drawing.Size(173, 46)
        Me.BtnSingleton.TabIndex = 0
        Me.BtnSingleton.Text = "Check Singleton Pattern"
        Me.BtnSingleton.UseVisualStyleBackColor = True
        '
        'FrmDesignPatterns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSingleton)
        Me.Name = "FrmDesignPatterns"
        Me.Text = "Formulário de Testes de Design Patterns"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSingleton As Button
End Class