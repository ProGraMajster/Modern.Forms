﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SkiaSharp;

namespace Modern.Forms
{
    public class MessageBoxForm : Form
    {
        private readonly Label label;

        public MessageBoxForm ()
        {
            Text = "Demo";
            StartPosition = FormStartPosition.CenterParent;
            AllowMinimize = false;
            AllowMaximize = false;

            label = new Label {
                Width = 397,
                Left = 1,
                Top = 50
            };

            label.Style.BackgroundColor = Style.BackgroundColor;
            label.Style.FontSize = 16;

            Controls.Add (label);

            var button = new Button {
                Text = "OK",
                Left = 150,
                Top = 150
            };

            button.Click += (o, e) => Close ();

            Controls.Add (button);
        }

        protected override Size DefaultSize => new Size (400, 200);

        public MessageBoxForm (string title, string text) : this ()
        {
            Text = title;

            label.Text = text;
        }
    }
}
