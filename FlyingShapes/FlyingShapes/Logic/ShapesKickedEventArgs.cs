namespace FlyingShapes.Logic
{
    using System;

    using FlyingShapes.Models;

    internal class ShapesKickedEventArgs : EventArgs
    {
        public ShapesKickedEventArgs(Shape shape)
        {
            Shape = shape;
        }

        public Shape Shape { get; private set; }
    }
}