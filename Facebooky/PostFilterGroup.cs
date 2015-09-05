using System;
using System.Collections.Generic;
using System.Linq;

using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	[PostFilterFactory.Register("Filter Group")]
	public class PostFilterGroup : IPostFilter
    {
        public string Name { get; set; }

		public bool Enabled { get; set; }

        public ePostPriority PostPriority { get; set; }

		private readonly List<IPostFilter> r_PostFilters;

	    public IList<IPostFilter> PostFilters
	    {
		    get
		    {
			    return r_PostFilters;
		    }
	    }

		public PostFilterGroup()
			: this(string.Empty)
		{
		}

        public override string ToString()
        {
            return Name;
        }

        public bool IsMatch(Post i_Post)
        {
	        return r_PostFilters.Any(i_PostFilter => i_PostFilter.IsMatch(i_Post));
        }

		public PostFilterGroup(string i_Name)
			: this(i_Name, ePostPriority.Hidden)
		{
		}

		public PostFilterGroup(string i_Name, ePostPriority i_PostPriority)
        {
            Name = i_Name;
            PostPriority = i_PostPriority; 
            r_PostFilters = new List<IPostFilter>();
            Enabled = true;
        }

        public void AddPostFilter(IPostFilter i_PostFilter)
        {
			r_PostFilters.Add(i_PostFilter);
        }

	    public void RemovePostFilter(IPostFilter i_PostFilter)
	    {
		    r_PostFilters.Remove(i_PostFilter);
	    }

		public XmlSchema GetSchema()
		{
			return null;
		}

		private XmlSerializer getSerializer(string i_Name)
		{
			return SerializerFactory.CreateSerializer(i_Name, i_Type => typeof(IPostFilter).IsAssignableFrom(i_Type));
		}

		public void ReadXml(XmlReader i_Reader)
		{
			Name = i_Reader.GetAttribute("Name");
			ePostPriority postPriority;
			Enum.TryParse(i_Reader.GetAttribute("PostPriority") ?? "hidden", out postPriority);
			PostPriority = postPriority;
			i_Reader.ReadStartElement();
			i_Reader.ReadStartElement("PostFilters");
			while (i_Reader.IsStartElement())
			{
				XmlSerializer serializer = getSerializer(i_Reader.Name);
				r_PostFilters.Add(serializer.Deserialize(i_Reader) as IPostFilter);
			}

			i_Reader.ReadEndElement();
			i_Reader.ReadEndElement();
		}

		public void WriteXml(XmlWriter i_Writer)
		{
			i_Writer.WriteAttributeString("Name", Name);
			i_Writer.WriteAttributeString("PostPriority", PostPriority.ToString());
			i_Writer.WriteStartElement("PostFilters");
			foreach (IPostFilter postFilter in r_PostFilters)
			{
				XmlSerializer serializer = new XmlSerializer(postFilter.GetType());
				serializer.Serialize(i_Writer, postFilter);
			}

			i_Writer.WriteEndElement();
		}
    }
}
