namespace FlyingShapes.Models
{
    using System;
    using System.Drawing;
    using System.Runtime.Serialization;

    [Serializable, DataContract]
    public class Square : Shape
    {
        public Square()
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

                graphics.FillRectangle(Brush, XCoord, YCoord, Width, Height);
            }
            else
            {
                if (Pen == null)
                {
                    Pen = new Pen(Color, 3f);
                }

                graphics.DrawRectangle(Pen, XCoord, YCoord, Width, Height);
            }
        }
    }
}
