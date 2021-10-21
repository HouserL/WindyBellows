using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace WindyBellows { 
    [Serializable]
    public class SerializableObjectBase
    {
        public enum SerializableObjectType
        {
            Json,
            Xml
        }
        public void AppendToNode(XmlNode node)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(ToXmlString());
            if (node.OwnerDocument == null) return;
            if (xmlDoc.DocumentElement == null) return;
            var importedNode = node.OwnerDocument.ImportNode(xmlDoc.DocumentElement, true);
            node.AppendChild(importedNode);
        }
        public static T FromJson<T>(string jsonString) where T : SerializableObjectBase
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
        public static T FromFile<T>(string filepath) where T : SerializableObjectBase
        {
            if (filepath.EndsWith(".json"))
            {
                return FromJson<T>(File.ReadAllText(filepath));
            }

            if (!filepath.EndsWith(".xml")) return null;

            using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                return FromXmlStream<T>(fs);
            }
        }
        public XmlDocument ToXml()
        {
            var x = new XmlDocument();
            x.LoadXml(ToXmlString(false));
            return x;
        }
        public static T FromXml<T>(string xml) where T : SerializableObjectBase
        {
            using (var sr = new StringReader(xml))
            {
                var xs = new XmlSerializer(typeof(T));
                return xs.Deserialize(sr) as T;
            }
        }
        public static T FromXml<T>(XmlNode node) where T : SerializableObjectBase
        {
            if (node != null)
            {
                return FromXml<T>(node.OuterXml);
            }
            throw new ArgumentNullException(nameof(node));
        }

        /// <summary>
        /// Writes to file as Xml or Json
        /// </summary>
        /// <param name="path"></param>
        /// <param name="format"></param>
        public void WriteToFile(string path, Formatting format = Formatting.Indented)
        {
            if (path.EndsWith(".json"))
            {
                WriteJsonToFile(path, format, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            }
            if (!path.EndsWith(".xml")) return;
            WriteXmlToFile(path, format);
        }
        public void WriteToStream(Stream output, SerializableObjectType type, Formatting format = Formatting.Indented)
        {
            switch (type)
            {
                case SerializableObjectType.Json:
                    WriteJsonToStream(output, format);
                    return;
                case SerializableObjectType.Xml:
                    WriteXmlToStream(output, format);
                    return;
            }
        }
        private void WriteXmlToFile(string path, Formatting format)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                WriteXmlToStream(fs, format);
            }
        }
        public static T FromStream<T>(Stream stream, SerializableObjectType type) where T : SerializableObjectBase
        {
            if (type == SerializableObjectType.Json)
            {
                return FromJsonStream<T>(stream);
            }
            return FromXmlStream<T>(stream);
        }
        private static T FromJsonStream<T>(Stream stream) where T : SerializableObjectBase
        {
            using (var x = new StreamReader(stream))
            {
                var jsonString = x.ReadToEnd();
                return FromJson<T>(jsonString);
            }
        }
        private static T FromXmlStream<T>(Stream stream) where T : SerializableObjectBase
        {
            var xs = new XmlSerializer(typeof(T));
            return xs.Deserialize(stream) as T;
        }
        public string ToJsonString(Formatting format = Formatting.Indented, JsonSerializerSettings settings = null)
        {
            return JsonConvert.SerializeObject(this, format, settings);
        }
        public string ToXmlString(bool removeSpecialCharacters = true)
        {
            using (var ms = new MemoryStream())
            {
                WriteXmlToStream(ms);
                ms.Seek(0, 0);
                var sr = new StreamReader(ms);

                var s = sr.ReadToEnd();
                if (!removeSpecialCharacters) return s;
                var reg = new Regex("[\x00-\x1f]|[\x7f-\uffff]");
                if (reg.IsMatch(s))
                {
                    s = reg.Replace(s, "");
                }
                return s;
            }
        }
        private void WriteJsonToFile(string path, Formatting format = Formatting.Indented, JsonSerializerSettings settings = null)
        {
            using (var sw = new StreamWriter(path))
            {
                var x = ToJsonString(format, settings);

                sw.Write(x);
            }
        }

        private void WriteXmlToStream(Stream output, Formatting format = Formatting.Indented)
        {
            var sw = new StreamWriter(output, Encoding.UTF8);
            var xw = XmlWriter.Create(sw, new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = format == Formatting.Indented });
            var xs = new XmlSerializer(GetType());

            xs.Serialize(xw, this);
        }
        private void WriteJsonToStream(Stream output, Formatting format)
        {
            var x = JsonConvert.SerializeObject(this, format, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var sw = new StreamWriter(output, Encoding.UTF8);
            sw.Write(x);
        }
    }
}
