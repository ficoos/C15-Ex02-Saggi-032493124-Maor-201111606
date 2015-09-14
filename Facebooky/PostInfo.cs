namespace Facebooky
{
	public class PostInfo
	{
		public PostInfo(string i_Text)
		{
			StatusText = i_Text;
		}
		public PostInfo() {}
		public string StatusText { get; set; }
	}
}