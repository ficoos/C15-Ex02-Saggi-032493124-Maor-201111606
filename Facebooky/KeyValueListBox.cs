using System;
using System.Reflection;
using System.Windows.Forms;

namespace Facebooky
{
	public class KeyValueListBox : ListBox
	{
		protected override void OnDrawItem(DrawItemEventArgs i_Args)
		{
			base.OnDrawItem(i_Args);
			if (Items.Count > 0)
			{
				object displayItem = Items[i_Args.Index];
				Type itemType = displayItem.GetType();

				// Use generics because there is no way to cast to a generic type.
				PropertyInfo keyProperty = itemType.GetProperty("Key");
				PropertyInfo valueProperty = itemType.GetProperty("Value");
				if (keyProperty != null && valueProperty != null)
				{
					i_Args.DrawBackground();
					TextRenderer.DrawText(
						i_Args.Graphics,
						(string)keyProperty.GetGetMethod().Invoke(displayItem, null),
						i_Args.Font,
						i_Args.Bounds,
						i_Args.ForeColor,
						TextFormatFlags.Default);
					TextRenderer.DrawText(
						i_Args.Graphics,
						":",
						i_Args.Font,
						i_Args.Bounds,
						i_Args.ForeColor,
						TextFormatFlags.HorizontalCenter);			
					TextRenderer.DrawText(
						i_Args.Graphics,
						(string)valueProperty.GetGetMethod().Invoke(displayItem, null),
						i_Args.Font,
						i_Args.Bounds,
						i_Args.ForeColor,
						TextFormatFlags.Right);
					i_Args.DrawFocusRectangle();
				}
			}
		}
	}
}
