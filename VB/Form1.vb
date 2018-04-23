Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraPrinting
' ...

Namespace docGettingStarted
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private imagePath As String = "..\..\fish.bmp"

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button1.Click
            Dim lesson As New Lesson1(printingSystem1)
            lesson.ShowPreview()
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button2.Click
            Dim lesson As New Lesson2(printingSystem1)
            lesson.ShowPreview()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button3.Click
            Dim lesson As New Lesson3(printingSystem1)
            lesson.ShowPreview()
        End Sub

        Private Sub button4_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button4.Click
            Dim lesson As New Lesson4(printingSystem1)
            lesson.ShowPreview()
        End Sub

        Private Sub button5_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button5.Click
            Dim lesson As New Lesson5(printingSystem1)
            lesson.ShowPreview()
        End Sub

        Private Sub button6_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button6.Click
            Dim lesson As New Lesson6(printingSystem1)
            lesson.ShowPreview()
        End Sub

        Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button7.Click
            Dim img As Bitmap = CType(Bitmap.FromFile(imagePath), Bitmap)
            img.MakeTransparent()

            Dim lesson As New Lesson7(printingSystem1, img)
            lesson.ShowPreview()
        End Sub

        Private Sub button8_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button8.Click
            Dim img As Bitmap = CType(Bitmap.FromFile(imagePath), Bitmap)
            img.MakeTransparent()

            Dim lesson As New Lesson8(printingSystem1, img)
            lesson.ShowPreview()
        End Sub

        Private Sub button9_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles button9.Click
            Dim img As Bitmap = CType(Bitmap.FromFile(imagePath), Bitmap)
            img.MakeTransparent()

            Dim lesson As New Lesson9(printingSystem1, img)
            lesson.ShowPreview()
        End Sub

    End Class

    Public Class Lesson1
        Inherits Link

        Public Sub New(ByVal ps As PrintingSystem)
            CreateDocument(ps)
        End Sub
    End Class


    Public Class Lesson2
        Inherits Lesson1

        Friend top As Integer = 0

        Public Sub New(ByVal ps As PrintingSystem)
            MyBase.New(ps)
        End Sub

        Protected Overloads Overrides Sub BeforeCreate()
            MyBase.BeforeCreate()

            If Not Me.PrintingSystem Is Nothing Then
                Dim g As BrickGraphics = Me.PrintingSystem.Graph

                ' Set the background color to White.
                g.BackColor = Color.White

                ' Set the border color to Black.
                g.BorderColor = Color.Black

                ' Set the font to the default font.
                g.Font = g.DefaultFont

                ' Set the line alignment.
                g.StringFormat = g.StringFormat.ChangeLineAlignment(StringAlignment.Near)
            End If
        End Sub

        ' Add a text brick without borders with a "Hello World!" text.
        Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
            Dim r As RectangleF = New RectangleF(0, 0, 150, 50)
            Dim s As String = "Hello World!"
            graph.DrawString(s, Color.Black, r, BorderSide.None)
        End Sub
    End Class


    Public Class Lesson3
        Inherits Lesson2

        Public Sub New(ByVal ps As PrintingSystem)
            MyBase.New(ps)
        End Sub

        ' Set the background color to Deep Sky Blue.
        Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
            graph.BackColor = Color.DeepSkyBlue

            ' Set the border color to Midnight Blue.
            graph.BorderColor = Color.MidnightBlue

            ' Add a text brick with all borders and a "Hello World!" text.
            Dim r As RectangleF = New RectangleF(0, 0, 150, 50)
            Dim s As String = "Hello World!"
            graph.DrawString(s, Color.Red, r, BorderSide.All)
        End Sub
    End Class


    Public Class Lesson4
        Inherits Lesson3
        Public Sub New(ByVal ps As PrintingSystem)
            MyBase.New(ps)
        End Sub

        ' Change the brick font name to Tahoma, size to 16, and set bold and italic attributes.
        Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
            graph.Font = New Font("Tahoma", 16, FontStyle.Bold Or FontStyle.Italic)
            MyBase.CreateDetail(graph)
        End Sub
    End Class


    Public Class Lesson5
        Inherits Lesson4
        Public Sub New(ByVal ps As PrintingSystem)
            MyBase.New(ps)
        End Sub

        Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
            ' Center the text string.
            graph.StringFormat = graph.StringFormat.ChangeLineAlignment(StringAlignment.Center)

            MyBase.CreateDetail(graph)
            CreateRow(graph)
        End Sub

        Protected Overridable Sub CreateRow(ByVal graph As BrickGraphics)
            ' Set the brick font name to Arial, size to 14, and set the bold attribute.
            graph.Font = New Font("Arial", 14, FontStyle.Bold)

            top += 50

            ' Add a text brick with all borders to a specific location 
            ' with a "Good-bye!" text using the blue font color.
            graph.DrawString("Good-bye!", Color.Blue, _
                New RectangleF(0, top, 150, 50), BorderSide.All)
        End Sub
    End Class


    Public Class Lesson6
        Inherits Lesson5
        Public Sub New(ByVal ps As PrintingSystem)
            MyBase.New(ps)
        End Sub

        Protected Overrides Sub CreateDetail(ByVal graph As BrickGraphics)
            ' Center the text string.
            graph.StringFormat = graph.StringFormat.ChangeLineAlignment(StringAlignment.Center)

            ' Add an unchecked check box brick with all borders 
            ' to a specific location using the Light Sky Blue background color.
            graph.DrawCheckBox(New RectangleF(150, 0, 50, 50), _
                BorderSide.All, Color.LightSkyBlue, False)

            ' Add an empty rectangle with all borders 
            ' to a specific location using the Light Lavender background color.
            graph.DrawRect(New RectangleF(200, 0, 50, 50), _
                BorderSide.All, Color.Lavender, graph.BorderColor)

            MyBase.CreateDetail(graph)
        End Sub

        Protected Overrides Sub CreateRow(ByVal graph As BrickGraphics)
            MyBase.CreateRow(graph)

            ' Add a checked check box brick with all borders 
            ' to a specific location using the Light Sky Blue background color.
            graph.DrawCheckBox(New RectangleF(150, top, 50, 50), _
                BorderSide.All, Color.LightSkyBlue, True)

        End Sub
    End Class


    Public Class Lesson7
        Inherits Lesson6
        Private img As Bitmap
        Friend bkImageColor As Color = Color.Lavender

        Public Sub New(ByVal ps As PrintingSystem, ByVal img As Bitmap)
            MyBase.New(Nothing)
            Me.img = img
            CreateDocument(ps)
        End Sub

        Protected Overrides Sub CreateRow(ByVal graph As BrickGraphics)
            MyBase.CreateRow(graph)

            ' Add an empty rectangle with all borders 
            ' to a specific location using a Lavender background color.
            graph.DrawRect(New RectangleF(200, top, 50, 50), _
                BorderSide.All, bkImageColor, graph.BorderColor)

            ' Add an image without borders 
            ' to a specific location using a Transparent color.
            If Not img Is Nothing Then
                graph.DrawImage(img, New RectangleF(Convert.ToSingle(200 + (50 - img.Width) / 2), _
                    Convert.ToSingle(top + (50 - img.Height) / 2), img.Width, img.Height), _
                    BorderSide.None, Color.Transparent)
            End If
        End Sub

    End Class


    Public Class Lesson8
        Inherits Lesson7
        Public Sub New(ByVal ps As PrintingSystem, ByVal img As Bitmap)
            MyBase.New(ps, img)
        End Sub

        Protected Overrides Sub CreateDetailHeader(ByVal graph As BrickGraphics)
            ' Center a text string horizontally and vertically.
            graph.StringFormat = New BrickStringFormat(StringAlignment.Center, StringAlignment.Center)

            ' Set the brick font name to Comic Sans MS, size to 12.
            graph.Font = New Font("Comic Sans MS", 12)

            ' Set the background color to Light Green.
            graph.BackColor = Color.LightGreen

            ' Add a text brick with all borders to a specific location 
            ' with an "I" text string using a Green font color.
            graph.DrawString("I", Color.Green, New RectangleF(0, 0, 150, 25), BorderSide.All)

            ' Add a text brick with all borders to a specific location 
            ' with a "love" text string using a Green font color.
            graph.DrawString("love", Color.Green, New RectangleF(150, 0, 50, 25), BorderSide.All)

            ' Add a text brick with all borders to a specific location 
            ' with a "you" text string using a Green font color.
            graph.DrawString("you", Color.Green, New RectangleF(200, 0, 50, 25), BorderSide.All)

            ' Set the line alignment.
            graph.StringFormat = graph.StringFormat.ChangeAlignment(StringAlignment.Near)

        End Sub
    End Class


    Public Class Lesson9
        Inherits Lesson8

        Public Sub New(ByVal ps As PrintingSystem, ByVal img As Bitmap)
            MyBase.New(ps, img)
        End Sub

        Protected Overrides Sub CreateRow(ByVal graph As BrickGraphics)
            ' Set the number of iterations for row creation.
            Dim c As Integer = 230

            Dim i As Integer
            For i = 0 To 49

                ' Set the background color using RGB.
                bkImageColor = Color.FromArgb(c, c, c + 20)

                MyBase.CreateRow(graph)
                If c - 4 > 0 Then
                    c = c - 4
                Else
                    c = c
                End If
            Next
        End Sub

        Protected Overrides Sub CreateMarginalHeader(ByVal graph As BrickGraphics)
            ' Set the format string for a page info brick.
            Dim format As String = "Page {0} of {1}"

            ' Set font to the default font.
            graph.Font = graph.DefaultFont

            ' Set the background color to Transparent.
            graph.BackColor = Color.Transparent

            ' Set the rectangle for drawing.
            Dim r As RectangleF = New RectangleF(0, 0, 0, graph.Font.Height)

            ' Add a page info brick without borders that displays
            ' the current page number from the total number of pages.
            Dim brick As PageInfoBrick = graph.DrawPageInfo(PageInfo.NumberOfTotal, _
                format, Color.Black, r, BorderSide.None)

            ' Set brick alignment.
            brick.Alignment = BrickAlignment.Far

            ' Enable auto width for a brick.
            brick.AutoWidth = True

            ' Add a page info brick without borders 
            ' that displays date and time.
            brick = graph.DrawPageInfo(PageInfo.DateTime, "", Color.Black, r, _
                BorderSide.None)

            ' Set brick alignment.
            brick.Alignment = BrickAlignment.Near

            ' Enable auto width for a brick.
            brick.AutoWidth = True
        End Sub

    End Class


End Namespace