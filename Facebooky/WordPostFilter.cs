using System.Xml;
using System.Xml.Schema;

using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	[PostFilterFactory.Register("Word Filter")]
	public class WordPostFilter : IPostFilter
	{
		private RegexPostFilter m_PostFilter;

		private string m_Word;

		public string Word
		{
			get
			{
				return m_Word;
			}

			set
			{
				m_Word = value;
				string regex = string.Format(@"(?-i)\b{0}\b", m_Word);
				m_PostFilter = new RegexPostFilter(regex);
			}
		}

		public WordPostFilter() : this(string.Empty)
		{
		}

		public WordPostFilter(string i_Word)
		{
			Word = i_Word;
			Enabled = true;
		}

		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader i_Reader)
		{
			string rawWord = i_Reader.GetAttribute("Word");
			Word = rawWord ?? string.Empty;
			string rawEnabled = i_Reader.GetAttribute("Enabled");
			if (rawEnabled == null)
			{
				Enabled = false;
			}
			else
			{
				Enabled = bool.Parse(rawEnabled);
			}

			i_Reader.ReadStartElement();
		}

		public void WriteXml(XmlWriter i_Writer)
		{
			i_Writer.WriteAttributeString("Word", Word);
			i_Writer.WriteAttributeString("Enabled", Enabled.ToString());
		}

		public bool IsMatch(Post i_Post)
		{
			return m_PostFilter.IsMatch(i_Post);
		}

		public bool Enabled { get; set; }

		public string Name
		{
			get
			{
				return Word;
			}
		}
	}
}
