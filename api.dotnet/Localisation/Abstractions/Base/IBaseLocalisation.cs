using System;
using System.Text;

namespace Localisation.Abstractions.Base
{
	public interface IBaseLocalisation<T> 
	{
		public string ToString(StringBuilder? stringBuilder = null)
		{
			return string.Empty;
		}
	}
	public interface IBaseLocalisationTyped<T>
	{
		public string ToString(StringBuilder? stringBuilder = null)
		{
			return string.Empty;
		}
	}
	public interface IBaseLocalisation 
	{
		public string ToString(StringBuilder? stringBuilder = null, IBaseLocalisation<Func<object?, string>>? converter = null) 
		{
			return string.Empty;
		}

		public class Default : IBaseLocalisation { }
		public class DefaultTyped<T> : IBaseLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) { }
		}
		public class Default<T> : IBaseLocalisation<T>
		{
			public Default(T defaultvalue) { }
		}
	}
}
