namespace FlyingShapes.Models
{
    using System;
    using System.Drawing;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public class Circle : Shape
    {
        public Circle()
        {
            Pen = new Pen(Color, 3f);
            Brush = new SolidBrush(Color);
        }

        public override void Draw(Graphics graphics)
        {
            if (IsFilled)
            {
                if (Brush == null)
                {
                    Brush = new SolidBrush(Color);
                }

                graphics.FillEllipse(Brush, XCoord, YCoord, Width, Width);
            }
            else
            {
                if (Pen == null)
                {
                    Pen = new Pen(Color, 3f);
                }

                graphics.DrawEllipse(Pen, XCoord, YCoord, Width, Width);
            }
        }
    }
}