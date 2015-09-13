namespace Facebooky
{
	using System;
	using System.Linq;
	using System.Xml.Serialization;

	public static class SerializerFactory
	{
		public static XmlSerializer CreateSerializer(string i_Name, Func<Type, bool> i_Predicate)
		{
			Type type = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(i_Assembly => i_Assembly.GetTypes())
				.Where(i_Type => i_Type.Name == i_Name)
				.Where(i_Predicate)
				.FirstOrDefault();

			return type != null ? new XmlSerializer(type) : null;
		}
	}
}