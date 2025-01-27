﻿using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public void Draw()
        {

            DrawLine(this.width, '*', '*');

            for (int i = 1; i < this.height - 1; ++i)

                DrawLine(this.width, '*', ' ');

            DrawLine(this.width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {

            Console.Write(end);

            for (int i = 1; i < width - 1; ++i)

                Console.Write(mid);

            Console.WriteLine(end);
        }
    }
}
