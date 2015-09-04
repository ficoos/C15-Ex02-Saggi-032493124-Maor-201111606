using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebooky
{
	using System.Reflection;
	using System.Windows.Forms;

	internal static class ListBoxExtension
	{
		public static void UpdateValueBinding(this CheckedListBox i_CheckedListBox)
		{
			for (int i = 0; i < i_CheckedListBox.Items.Count; i++)
			{
				object item = i_CheckedListBox.Items[i];
				Type itemType = item.GetType();
				PropertyInfo valueMemberProperty = itemType.GetProperty(i_CheckedListBox.ValueMember);
				i_CheckedListBox.SetItemChecked(i, (bool)valueMemberProperty.GetValue(item, new object[0]));
			}
		}
	}
}
