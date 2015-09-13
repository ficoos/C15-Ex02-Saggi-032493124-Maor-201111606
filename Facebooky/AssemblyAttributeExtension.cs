using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Facebooky
{
	public static class AssemblyAttributeExtension
	{
		public static IEnumerable<Type> GetAllTypesWithAttribute(this Assembly i_Assembly, Type i_Attribute, bool i_Inherit)
		{
			return i_Assembly.GetTypes().Where(i_Type => i_Type.GetCustomAttributes(i_Attribute, i_Inherit).Length > 0);
		}
	}
}
