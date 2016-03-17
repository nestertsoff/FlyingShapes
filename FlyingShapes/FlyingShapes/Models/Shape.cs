namespace FlyingShapes.Models
{
    using System;
    using System.Drawing;
    using System.Runtime.Serialization;
    using System.Threading;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using FlyingShapes.Interfaces;
    using FlyingShapes.Logic;

    using NLog;

    [Serializable, DataContract, XmlInclude(typeof(Square)), XmlInclude(typeof(Circle)), XmlInclude(typeof(Triangle)), 
     KnownType(typeof(Square)), KnownType(typeof(Circle)), KnownType(typeof(Triangle))]
    public abstract class Shape : IMovable, IDrawable
    {
        private static Logger logger;

        private readonly Random random = new Random();

        [NonSerialized]
        private SolidBrush brush;

        [NonSerialized]
        private Pen pen;

        protected Shape()
        {
            logger = LogManager.GetCurrentClassLogger();

            var size = random.Next(10, 100);
            Width += size;
            Height += size;

            Speed = new Speed(random.Next(-10, 10));

            Color = GetRandomColor();
        }

        internal event EventHandler<ShapesKickedEventArgs> ShapesKicked;

        [DataMember, XmlIgnore]
        public Color Color { get; set; }

        [XmlElement("Color")]
        public int ColorAsArgb
        {
            get
            {
                return Color.ToArgb();
            }

            set
            {
                Color = Color.FromArgb(value);
            }
        }

        [DataMember]
        public int Height { get; set; }

        [DataMember]
        public bool IsFilled { get; set; }

        [DataMember]
        public Speed Speed { get; set; }

        [DataMember]
        public int Width { get; set; }

        [DataMember]
        public int XCoord { get; set; }

        [DataMember]
        public int YCoord { get; set; }

        protected SolidBrush Brush
        {
            get
            {
                return brush;
            }

            set
            {
                brush = value;
            }
        }

        protected Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }

        public abstract void Draw(Graphics graphics);

        public Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        public Rectangle GetShapeBounds(int xSpeed = 0, int ySpeed = 0)
        {
            return new Rectangle(XCoord - xSpeed, YCoord - ySpeed, Width, Height);
        }

        public bool IntersectsWith(Shape shape)
        {
            var isEqual = ReferenceEquals(this, shape);
            var isIntersectsPrevent = GetShapeBounds(Speed.XSpeed, Speed.YSpeed).IntersectsWith(shape.GetShapeBounds());
            var isIntersects = GetShapeBounds().IntersectsWith(shape.GetShapeBounds());
            var result = !isEqual && isIntersects && !isIntersectsPrevent;
            if (result)
            {
                OnShapesKicked(new ShapesKickedEventArgs(this));
            }

            return result;
        }

        public void LogKick()
        {
            logger.Info(ToString);
        }

        public void Move(PictureBox pictureBox)
        {
            if (XCoord + Width >= pictureBox.Width || XCoord <= 0)
            {
                Speed.ReverseSpeedX();
            }

            if (YCoord + Height >= pictureBox.Height || YCoord <= 0)
            {
                Speed.ReverseSpeedY();
            }

            XCoord += Speed.XSpeed;
            YCoord += Speed.YSpeed;
        }

        public void ReverseDirection()
        {
            Speed.ReverseSpeedX();
            Speed.ReverseSpeedY();
        }

        public void Test1()
        {
            logger.Info("Test1 " + ToString());
        }

        public override string ToString()
        {
            return
                string.Format(
                    "Shape type: {0}; \nShape speed: {1}; X coordinate: {2}; Y coordinate: {3}; Width: {4}; Height: {5};", 
                    GetType().Name, 
                    Speed, 
                    XCoord, 
                    YCoord, 
                    Width, 
                    Height);
        }

        void IDrawable.Test2()
        {
            logger.Info("IDrawable.Test2 " + ToString());
        }

        void IMovable.Test2()
        {
            logger.Info("IMovable.Test2 " + ToString());
        }

        internal void OnShapesKicked(ShapesKickedEventArgs e)
        {
            var temp = Volatile.Read(ref ShapesKicked);
            temp?.Invoke(this, e);
        }
    }
}