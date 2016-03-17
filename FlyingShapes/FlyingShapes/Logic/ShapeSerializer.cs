namespace FlyingShapes.Logic
{
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Runtime.Serialization.Json;
    using System.Xml.Serialization;

    using FlyingShapes.Models;

    public static class ShapeSerializer
    {
        private static readonly BinaryFormatter BinaryFormatter = new BinaryFormatter();
        private static readonly XmlSerializer XmlFormatter = new XmlSerializer(typeof(List<Shape>));
        private static readonly DataContractJsonSerializer JsonFormatter = new DataContractJsonSerializer(typeof(List<Shape>));

        public static void SerializeToBinary(List<Shape> shapes)
        {
            using (var fileStream = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                BinaryFormatter.Serialize(fileStream, shapes);
            }
        }

        public static void SerializeToXml(List<Shape> shapes)
        {
            using (var fileStream = new FileStream("shapes.xml", FileMode.OpenOrCreate))
            {
                XmlFormatter.Serialize(fileStream, shapes);
            }
        }

        public static void SerializeToJson(List<Shape> shapes)
        {
            using (var fileStream = new FileStream("shapes.json", FileMode.OpenOrCreate))
            {
                JsonFormatter.WriteObject(fileStream, shapes);
            }
        }

        public static List<Shape> DeserializeFromBinary()
        {
            using (var fileStream = new FileStream("shapes.dat", FileMode.OpenOrCreate))
            {
                var shapes = (List<Shape>)BinaryFormatter.Deserialize(fileStream);
                return shapes;
            }
        }

        public static List<Shape> DeserializeFromXml()
        {
            using (var fileStream = new FileStream("shapes.xml", FileMode.OpenOrCreate))
            {
                var shapes = (List<Shape>)XmlFormatter.Deserialize(fileStream);
                return shapes;
            }
        }

        public static List<Shape> DeserializeFromJson()
        {
            using (var fileStream = new FileStream("shapes.json", FileMode.OpenOrCreate))
            {
                var shapes = (List<Shape>)JsonFormatter.ReadObject(fileStream);
                return shapes;
            }
        }
    }
}
