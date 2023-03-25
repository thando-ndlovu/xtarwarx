using Localisation.Abstractions.Base;

using System;
using System.Text;

namespace Localisation.Abstractions.StarWarsModels
{
	public interface IStarWarsModelSearchLocalisation<T> : IBaseSearchLocalisation<T>
	{
		T Title { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine();

			return (this as IBaseSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface IStarWarsModelSearchLocalisationTyped<T> : IBaseSearchLocalisationTyped<T> 
	{
		T Title { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine();

			return (this as IBaseSearchLocalisationTyped<T>).ToString(stringbuilder);
		}
	}
	public interface IStarWarsModelSearchLocalisation : IBaseSearchLocalisation
	{
		string? Title { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, IStarWarsModelSearchLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine();

			return (this as IBaseSearchLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : IBaseSearchLocalisation.Default, IStarWarsModelSearchLocalisation 
		{
			public string? Title { get; set; }
		}
		public new class DefaultTyped<T> : IBaseSearchLocalisation.DefaultTyped<T>, IStarWarsModelSearchLocalisationTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) 
			{
				Title = defaultvalue;
			}

			public T Title { get; set; }
		}	  	
		public new class Default<T> : IBaseSearchLocalisation.Default<T>, IStarWarsModelSearchLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Title = defaultvalue;
			}

			public T Title { get; set; }
		}
	}
}
