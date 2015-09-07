using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Facebooky
{
	public static class PostFilterFactory
	{
		private static readonly Dictionary<string, Type> sr_FactoryMapping = new Dictionary<string, Type>();

		static PostFilterFactory()
		{
			const bool v_Inherit = true;
			Assembly myAssembly = typeof(SerializerFactory).Assembly;
			foreach (Type type in myAssembly.GetAllTypesWithAttribute(typeof(RegisterAttribute), !v_Inherit))
			{
				foreach (RegisterAttribute registerAttribute in type.GetCustomAttributes(typeof(RegisterAttribute), !v_Inherit).Cast<RegisterAttribute>())
				{
					sr_FactoryMapping.Add(registerAttribute.Kind, type);
				}
			}
		}

		public class RegisterAttribute : Attribute
		{
			public string Kind { get; set; }

			public RegisterAttribute(string i_Kind)
			{
				Kind = i_Kind;
			} 
		}

		public static IEnumerable<string> Kinds
		{
			get
			{
				return sr_FactoryMapping.Keys;
			}
		}

		public static IPostFilter CreatePostFilter(string i_Kind, string i_Data)
		{
			ConstructorInfo constructorInfo = sr_FactoryMapping[i_Kind].GetConstructor(new[] { typeof(string) });
			IPostFilter result = null;
			if (constructorInfo != null)
			{
				result = constructorInfo.Invoke(new object[] { i_Data }) as IPostFilter;
			}

			return result;
		}
	}
}
