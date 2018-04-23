using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraPrinting;
// ...

namespace docGettingStarted {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private string imagePath = @"..\..\fish.bmp";

        private void button1_Click(object sender, EventArgs e) {
            Lesson1 lesson = new Lesson1(printingSystem1);
            lesson.ShowPreview();
        }

        private void button2_Click(object sender, EventArgs e) {
            Lesson2 lesson = new Lesson2(printingSystem1);
            lesson.ShowPreview();
        }

        private void button3_Click(object sender, EventArgs e) {
            Lesson3 lesson = new Lesson3(printingSystem1);
            lesson.ShowPreview();
        }

        private void button4_Click(object sender, EventArgs e) {
            Lesson4 lesson = new Lesson4(printingSystem1);
            lesson.ShowPreview();
        }

        private void button5_Click(object sender, EventArgs e) {
            Lesson5 lesson = new Lesson5(printingSystem1);
            lesson.ShowPreview();
        }

        private void button6_Click(object sender, EventArgs e) {
            Lesson6 lesson = new Lesson6(printingSystem1);
            lesson.ShowPreview();
        }

        private void button7_Click(object sender, EventArgs e) {
            Bitmap img = (Bitmap)Bitmap.FromFile(imagePath);
            img.MakeTransparent();

            Lesson7 lesson = new Lesson7(printingSystem1, img);
            lesson.ShowPreview();
        }

        private void button8_Click(object sender, EventArgs e) {
            Bitmap img = (Bitmap)Bitmap.FromFile(imagePath);
            img.MakeTransparent();

            Lesson8 lesson = new Lesson8(printingSystem1, img);
            lesson.ShowPreview();
        }

        private void button9_Click(object sender, EventArgs e) {
            Bitmap img = (Bitmap)Bitmap.FromFile(imagePath);
            img.MakeTransparent();

            Lesson9 lesson = new Lesson9(printingSystem1, img);
            lesson.ShowPreview();
        }

    }

    public class Lesson1 : Link {
        public Lesson1(PrintingSystem ps) {
            CreateDocument(ps);
        }
    }

    public class Lesson2 : Lesson1 {
        internal int top = 0;
        internal Rectangle r = new Rectangle(0, 0, 150, 50);
        internal string caption = "Hello World!";

        public Lesson2(PrintingSystem ps) : base(ps) { }

        protected override void BeforeCreate() {
            base.BeforeCreate();
            if (this.PrintingSystem != null) {
                BrickGraphics g = this.PrintingSystem.Graph;

                // Set the background color to White.
                g.BackColor = Color.White;

                // Set the border color to Black.
                g.BorderColor = Color.Black;

                // Set the font to the default font.
                g.Font = g.DefaultFont;

                // Set the line alignment.
                g.StringFormat = g.StringFormat.ChangeLineAlignment(StringAlignment.Near);
            }
        }

        // Add a text brick without borders with a "Hello World!" text.
        protected override void CreateDetail(BrickGraphics graph) {
            graph.DrawString(caption, Color.Black, r, BorderSide.None);
        }
    }

    public class Lesson3 : Lesson2 {
        public Lesson3(PrintingSystem ps) : base(ps) { }

        // Set the background color to Deep Sky Blue.
        protected override void CreateDetail(BrickGraphics graph) {
            graph.BackColor = Color.DeepSkyBlue;

            // Set the border color to Midnight Blue.
            graph.BorderColor = Color.MidnightBlue;

            // Add a text brick with all borders and a "Hello World!" text.
            graph.DrawString(caption, Color.Red, r, BorderSide.All);
        }
    }

    public class Lesson4 : Lesson3 {
        public Lesson4(PrintingSystem ps) : base(ps) { }

        // Change the brick font name to Tahoma, size to 16, and set bold and italic attributes.
        protected override void CreateDetail(BrickGraphics graph) {
            graph.Font = new Font("Tahoma", 16, FontStyle.Bold | FontStyle.Italic);
            base.CreateDetail(graph);
        }
    }

    public class Lesson5 : Lesson4 {
        public Lesson5(PrintingSystem ps) : base(ps) { }

        protected override void CreateDetail(BrickGraphics graph) {
            // Center the text string.
            graph.StringFormat = graph.StringFormat.ChangeLineAlignment(StringAlignment.Center);

            base.CreateDetail(graph);
            CreateRow(graph);
        }

        protected virtual void CreateRow(BrickGraphics graph) {
            // Set the brick font name to Arial, size to 14, and set the bold attribute.
            graph.Font = new Font("Arial", 14, FontStyle.Bold);

            // Add a text brick with all borders to a specific location 
            // with a "Good-bye!" text using the blue font color.
            graph.DrawString("Good-bye!", Color.Blue,
                new Rectangle(0, top += 50, 150, 50), BorderSide.All);
        }
    }

    public class Lesson6 : Lesson5 {
        public Lesson6(PrintingSystem ps) : base(ps) { }

        protected override void CreateDetail(BrickGraphics graph) {

            // Center the text string.
            graph.StringFormat = graph.StringFormat.ChangeLineAlignment(StringAlignment.Center);

            // Add an unchecked check box brick with all borders 
            // to a specific location using the Light Sky Blue background color.
            graph.DrawCheckBox(new Rectangle(150, 0, 50, 50),
               BorderSide.All, Color.LightSkyBlue, false);

            // Add an empty rectangle with all borders 
            // to a specific location using the Light Lavender background color.
            graph.DrawRect(new Rectangle(200, 0, 50, 50),
                BorderSide.All, Color.Lavender, graph.BorderColor);

            base.CreateDetail(graph);
        }

        protected override void CreateRow(BrickGraphics graph) {
            base.CreateRow(graph);

            // Add a checked check box brick with all borders 
            // to a specific location using the Light Sky Blue background color.
            graph.DrawCheckBox(new Rectangle(150, top, 50, 50),
                BorderSide.All, Color.LightSkyBlue, true);
        }
    }

    public class Lesson7 : Lesson6 {
        Bitmap img;
        internal Color bkImageColor = Color.Lavender;

        public Lesson7(PrintingSystem ps, Bitmap img)
            : base(null) {
            this.img = img;
            CreateDocument(ps);
        }

        protected override void CreateRow(BrickGraphics graph) {
            base.CreateRow(graph);

            // Add an empty rectangle with all borders 
            // to a specific location using a Lavender background color.
            graph.DrawRect(new Rectangle(200, top, 50, 50),
                BorderSide.All, bkImageColor, graph.BorderColor);

            if (img != null)

                // Add an image without borders 
                // to a specific location using a Transparent color.
                graph.DrawImage(img,
                    new Rectangle(200 + (50 - img.Width) / 2, top + (50 - img.Height) / 2, img.Width, img.Height),
                    BorderSide.None, Color.Transparent);

        }
    }

    public class Lesson8 : Lesson7 {
        public Lesson8(PrintingSystem ps, Bitmap img) : base(ps, img) { }

        protected override void CreateDetailHeader(BrickGraphics graph) {
            // Center a text string horizontally and vertically.
            graph.StringFormat = new BrickStringFormat(StringAlignment.Center, StringAlignment.Center);

            // Set the brick font name to Comic Sans MS, size to 12.
            graph.Font = new Font("Comic Sans MS", 12);

            // Set the background color to Light Green.
            graph.BackColor = Color.LightGreen;

            // Add a text brick with all borders to a specific location 
            // with an "I" text string using a Green font color.
            graph.DrawString("I", Color.Green, new Rectangle(0, 0, 150, 25), BorderSide.All);

            // Add a text brick with all borders to a specific location 
            // with a "love" text string using a Green font color.
            graph.DrawString("love", Color.Green, new Rectangle(150, 0, 50, 25), BorderSide.All);

            // Add a text brick with all borders to a specific location 
            // with a "you" text string using a Green font color.
            graph.DrawString("you", Color.Green, new Rectangle(200, 0, 50, 25), BorderSide.All);

            // Set the line alignment.
            graph.StringFormat = graph.StringFormat.ChangeAlignment(StringAlignment.Near);
        }
    }


    public class Lesson9 : Lesson8 {
        public Lesson9(PrintingSystem ps, Bitmap img) : base(ps, img) { }

        protected override void CreateRow(BrickGraphics graph) {
            // Set the number of iterations for row creation.
            int c = 230;

            for (int i = 0; i < 50; i++) {

                // Set the background color using RGB.
                bkImageColor = Color.FromArgb(c, c, c + 20);

                base.CreateRow(graph);
                c = c - 4 > 0 ? c - 4 : c;
            }
        }

        protected override void CreateMarginalHeader(BrickGraphics graph) {
            // Set the format string for a page info brick.
            string format = "Page {0} of {1}";

            // Set font to the default font.
            graph.Font = graph.DefaultFont;

            // Set the background color to Transparent.
            graph.BackColor = Color.Transparent;

            // Set the rectangle for drawing.
            RectangleF r = new RectangleF(0, 0, 0, graph.Font.Height);

            // Add a page info brick without borders that displays
            // the current page number from the total number of pages.
            PageInfoBrick brick = graph.DrawPageInfo(PageInfo.NumberOfTotal, format, Color.Black, r, BorderSide.None);

            // Set brick alignment.
            brick.Alignment = BrickAlignment.Far;

            // Enable auto width for a brick.
            brick.AutoWidth = true;

            // Add a page info brick without borders 
            // that displays date and time.
            brick = graph.DrawPageInfo(PageInfo.DateTime, "", Color.Black, r, BorderSide.None);

            // Set brick alignment.
            brick.Alignment = BrickAlignment.Near;

            // Enable auto width for a brick.
            brick.AutoWidth = true;
        }
    }

}