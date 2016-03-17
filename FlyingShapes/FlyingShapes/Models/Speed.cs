namespace FlyingShapes.Models
{
    using System;
    using System.Runtime.Serialization;

    public class Speed
    {
        private const int MaxSpeed = 50;

        private const int MinSpeed = 1;

        private readonly double ratioX;

        private readonly double ratioY;

        public Speed(int value)
        {
            Value = value;
            ratioX = Math.Round(new Random().NextDouble(), 1);
            ratioY = Math.Round(1 - ratioX, 1);

            if (value >= 0)
            {
                XSpeed = (int)(ratioX * Value);
                YSpeed = (int)(ratioY * Value);
            }
            else
            {
                XSpeed = -(int)(ratioX * Value);
                YSpeed = -(int)(ratioY * Value);
            }
        }

        public Speed(Speed speed)
        {
            Value = speed.Value;
            XSpeed = speed.XSpeed;
            YSpeed = speed.YSpeed;
            ratioX = speed.ratioX;
            ratioY = speed.ratioY;
        }

        [DataMember]
        public int XSpeed { get; set; }

        [DataMember]
        public int YSpeed { get; set; }

        public int Value { get; set; }

        public void ReverseSpeedX()
        {
            XSpeed = -XSpeed;
        }

        public void ReverseSpeedY()
        {
            YSpeed = -YSpeed;
        }

        public void ChangeSpeed(int speedStep)
        {
            if (Value + speedStep >= MinSpeed && Value + speedStep <= MaxSpeed)
            {
                Value += speedStep;

                if (XSpeed >= 0)
                {
                    XSpeed = (int)(ratioX * Value);
                }
                else
                {
                    XSpeed = -(int)(ratioX * Value);
                }

                if (YSpeed >= 0)
                {
                    YSpeed = (int)(ratioY * Value);
                }
                else
                {
                    YSpeed = -(int)(ratioY * Value);
                }
            }
        }

        public bool CheckSpeedChangePossibility(int speedStep)
        {
            if (Value + speedStep >= MinSpeed && Value + speedStep <= MaxSpeed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}