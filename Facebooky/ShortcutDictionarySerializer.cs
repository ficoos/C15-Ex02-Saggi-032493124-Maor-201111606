using System.Collections.Generic;
using System.Xml;

namespace Facebooky
{
	public static class ShortcutDictionarySerializer
	{
		public static void Serialize(IDictionary<string, string> i_Dictionary, XmlWriter i_Writer)
		{
			i_Writer.WriteStartElement("Shortcuts");
			foreach (KeyValuePair<string, string> keyValuePair in i_Dictionary)
			{
				i_Writer.WriteStartElement("Shortcut");
				i_Writer.WriteAttributeString("from", keyValuePair.Key);
				i_Writer.WriteAttributeString("to", keyValuePair.Value);
				i_Writer.WriteEndElement();
			}

			i_Writer.WriteEndElement();
		}

		public static void Deserialize(IDictionary<string, string> i_Dictionary, XmlReader i_Reader)
		{
			i_Dictionary.Clear();
			i_Reader.ReadStartElement("Shortcuts");
			
			while (i_Reader.Name == "Shortcut")
			{
				string from = i_Reader.GetAttribute("from");
				string to = i_Reader.GetAttribute("to");
				i_Dictionary.Add(from, to);
				i_Reader.ReadToNextSibling("Shortcut");
			}

			i_Reader.ReadEndElement();
		}
	}
}
