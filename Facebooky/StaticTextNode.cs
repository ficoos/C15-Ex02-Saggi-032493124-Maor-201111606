namespace Facebooky
{
	public class StaticTextNode : ITextNode
	{
		public string Text { get; private set; }

		public StaticTextNode(string i_Text)
		{
			this.Text = i_Text;
		}
	}
}