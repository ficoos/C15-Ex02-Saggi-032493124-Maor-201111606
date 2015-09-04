using System.Xml.Serialization;

using FacebookWrapper.ObjectModel;

namespace Facebooky
{
	public interface IPostFilter : IXmlSerializable
	{
		bool IsMatch(Post i_Post);

		bool Enabled { get; set; }
		
		string Name { get; }
	}
}