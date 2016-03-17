namespace FlyingShapes.Models
{
    using System;
    using System.Drawing;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public class Triangle : Shape
    {
        private Point[] points;

        public Triangle()
        {
            Pen = new Pen(Color, 3f);
            Brush = new SolidBrush(Color);
        }

        public override void Draw(Graphics graphics)
        {
            points = new[]
                        {
                             new Point(XCoord + (Width / 2), YCoord), 
                             new Point(XCoord + Width, YCoord + Height), 
                             new Point(XCoord, YCoord + Height)
                         };

            if (IsFilled)
            {
                if (Brush == null)
                {
                    Brush = new SolidBrush(Color);
                }

                graphics.FillPolygon(Brush, points);
            }
            else
            {
                if (Pen == null)
                {
                    Pen = new Pen(Color, 3f);
                }

                graphics.DrawLine(Pen, points[0], points[1]);
                graphics.DrawLine(Pen, points[1], points[2]);
                graphics.DrawLine(Pen, points[2], points[0]);
            }
        }
    }
}