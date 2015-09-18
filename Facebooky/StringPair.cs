using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebooky
{
	public class StringPair
	{
		public string Key {get; set;}
		public string Value { get; set; }

		public StringPair(string i_Key, string i_Value)
		{
			Key = i_Key ?? string.Empty;
			Value = i_Value ?? string.Empty; 
		}
		public StringPair() { }
	}
}
