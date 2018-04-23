Imports Microsoft.VisualBasic
Imports System
Namespace docGettingStarted
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button7 = New System.Windows.Forms.Button()
			Me.button8 = New System.Windows.Forms.Button()
			Me.button9 = New System.Windows.Forms.Button()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(116, 25)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(96, 35)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Lesson 1"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(116, 72)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(96, 35)
			Me.button2.TabIndex = 2
			Me.button2.Text = "Lesson 2"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' button3
			' 
			Me.button3.Location = New System.Drawing.Point(116, 119)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(96, 35)
			Me.button3.TabIndex = 3
			Me.button3.Text = "Lesson 3"
			Me.button3.UseVisualStyleBackColor = True
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button4
			' 
			Me.button4.Location = New System.Drawing.Point(116, 166)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(96, 35)
			Me.button4.TabIndex = 4
			Me.button4.Text = "Lesson 4"
			Me.button4.UseVisualStyleBackColor = True
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(116, 213)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(96, 35)
			Me.button5.TabIndex = 5
			Me.button5.Text = "Lesson 5"
			Me.button5.UseVisualStyleBackColor = True
'			Me.button5.Click += New System.EventHandler(Me.button5_Click);
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(116, 260)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(96, 35)
			Me.button6.TabIndex = 6
			Me.button6.Text = "Lesson 6"
			Me.button6.UseVisualStyleBackColor = True
'			Me.button6.Click += New System.EventHandler(Me.button6_Click);
			' 
			' button7
			' 
			Me.button7.Location = New System.Drawing.Point(116, 307)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(96, 35)
			Me.button7.TabIndex = 7
			Me.button7.Text = "Lesson 7"
			Me.button7.UseVisualStyleBackColor = True
'			Me.button7.Click += New System.EventHandler(Me.button7_Click);
			' 
			' button8
			' 
			Me.button8.Location = New System.Drawing.Point(116, 354)
			Me.button8.Name = "button8"
			Me.button8.Size = New System.Drawing.Size(96, 35)
			Me.button8.TabIndex = 8
			Me.button8.Text = "Lesson 8"
			Me.button8.UseVisualStyleBackColor = True
'			Me.button8.Click += New System.EventHandler(Me.button8_Click);
			' 
			' button9
			' 
			Me.button9.Location = New System.Drawing.Point(116, 401)
			Me.button9.Name = "button9"
			Me.button9.Size = New System.Drawing.Size(96, 35)
			Me.button9.TabIndex = 9
			Me.button9.Text = "Lesson 9"
			Me.button9.UseVisualStyleBackColor = True
'			Me.button9.Click += New System.EventHandler(Me.button9_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(340, 457)
			Me.Controls.Add(Me.button9)
			Me.Controls.Add(Me.button8)
			Me.Controls.Add(Me.button7)
			Me.Controls.Add(Me.button6)
			Me.Controls.Add(Me.button5)
			Me.Controls.Add(Me.button4)
			Me.Controls.Add(Me.button3)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private WithEvents button6 As System.Windows.Forms.Button
		Private WithEvents button7 As System.Windows.Forms.Button
		Private WithEvents button8 As System.Windows.Forms.Button
		Private WithEvents button9 As System.Windows.Forms.Button
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
	End Class
End Namespace

