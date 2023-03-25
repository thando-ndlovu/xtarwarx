using Localisation.Abstractions.Base;

using System;
using System.Text;

namespace Localisation.Abstractions.StarWarsModels
{
	public interface ISearchItemLocalisation<T> : IBaseSearchLocalisation<T> 
	{
		T Description { get; set; }
		T Title { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine();

			return (this as IBaseSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface ISearchItemLocalisation : IBaseSearchLocalisation
	{
		string? Description { get; set; }
		string? Title { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, ISearchItemLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			if (converter?.Description is Func<object?, string> || Description is string) stringbuilder.Append(converter?.Description?.Invoke(Description) ?? Description);
			if (converter?.Title is Func<object?, string> || Title is string) stringbuilder.Append(converter?.Title?.Invoke(Title));

			return (this as IBaseSearchLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : IBaseSearchLocalisation.Default, ISearchItemLocalisation
		{
			public string? Description { get; set; }
			public string? Title { get; set; }
		}
		public new class Default<T> : IBaseSearchLocalisation.Default<T>, ISearchItemLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				Description = defaultvalue;
				Title = defaultvalue;
			}

			public T Description { get; set; }
			public T Title { get; set; }
		}
	}
}
