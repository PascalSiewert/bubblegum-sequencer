using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace bubblegum_sequencer
{
    public class Grid : IObserverable 
    {
        private int rows;
        private int cols;
        private Size size = new Size();
        private Point[,] intersections;
        private bool intersectionsCalculated = false;

        public Grid(int aRows, int aCols)
        {
            Rows = aRows;
            Cols = aCols;
        }

        public void draw(Graphics graphic, Size aSize)
        {           
            int rowheight = Convert.ToInt32((double)aSize.Height / (double)(Rows + 1));
            int colwidth = Convert.ToInt32((double)aSize.Width / (double)(Cols + 1));

            for (int i = Rows; i > 0; i--)
            {
                graphic.DrawLine(new Pen(Brushes.Red), new Point(0, (i * rowheight)), new Point(aSize.Width, (i * rowheight)));
            }

            for (int i = Cols; i > 0; i--)
            {
                graphic.DrawLine(new Pen(Brushes.Red), new Point((i * colwidth), 0), new Point((i * colwidth), aSize.Height));
            }

            size = aSize;
        }

        public int Rows 
        {
            get
            {
                return rows;
            }
            set
            {
                if (value < 1)
                {
                    rows = 1;
                }
                else if (value > 16)
                {
                    rows = 16;
                }
                else
                {
                    rows = value;
                }
                notify();
                calcIntersections();
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
            set
            {
                if (value < 1)
                {
                    cols = 1;
                }
                else if (value > 16)
                {
                    cols = 16;
                }
                else
                {
                    cols = value;
                }
                notify();
                calcIntersections();
            }
        }

        public void calcIntersections()
        {
            intersections = new Point[Cols, Rows];

            int rowheight = Convert.ToInt32((double)size.Height / (double)(Rows + 1));
            int colwidth = Convert.ToInt32((double)size.Width / (double)(Cols + 1));

            for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    intersections[i, j] = new Point(colwidth * (i + 1), rowheight * (j + 1));
                }
            }

            intersectionsCalculated = true;
        }

        public Point getIntersectionAt(int colIndex, int rowIndex)
        {
            Point intersection = new Point(0,0);
            if (intersectionsCalculated)
            {
                if (intersections.GetLength(0) > colIndex)
                {
                    if (intersections.GetLength(1) > rowIndex)
                    {
                        intersection = intersections[colIndex, rowIndex];
                    }
                }
            }

            return intersection;
        }

        public Color getColorAtIntersection(int colIndex, int rowIndex, Bitmap picture)
        {
            Point intersection = getIntersectionAt(colIndex, rowIndex);
            return picture.GetPixel(intersection.X, intersection.Y);
        }

        public void setSize(Size aSize)
        {
            size = aSize;
        }
    }
}
