using System;
using System.Text;

namespace Localisation.Abstractions.StarWarsModels
{
	public interface ISearchRangeLocalisation<T> : ISearchItemLocalisation<T>
	{
		T LowerDescription { get; set; }
		T LowerErrorMessageInvalid { get; set; }
		T LowerGreaterThanUpperInfoMessage { get; set; }
		T LowerPlaceholder { get; set; }
		T LowerTitle { get; set; }
		T UpperDescription { get; set; }
		T UpperErrorMessageInvalid { get; set; }
		T UpperLessThanLowerInfoMessage { get; set; }
		T UpperPlaceholder { get; set; }
		T UpperTitle { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(LowerDescription), LowerDescription).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LowerErrorMessageInvalid), LowerErrorMessageInvalid).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LowerGreaterThanUpperInfoMessage), LowerGreaterThanUpperInfoMessage).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LowerPlaceholder), LowerPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(LowerTitle), LowerTitle).AppendLine()
				.AppendFormat("{0}: {1}", nameof(UpperDescription), UpperDescription).AppendLine()
				.AppendFormat("{0}: {1}", nameof(UpperErrorMessageInvalid), UpperErrorMessageInvalid).AppendLine()
				.AppendFormat("{0}: {1}", nameof(UpperLessThanLowerInfoMessage), UpperLessThanLowerInfoMessage).AppendLine()
				.AppendFormat("{0}: {1}", nameof(UpperPlaceholder), UpperPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(UpperTitle), UpperTitle).AppendLine();

			return (this as ISearchItemLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface ISearchRangeLocalisation : ISearchItemLocalisation
	{
		string? LowerDescription { get; set; }
		Func<object?, string>? LowerErrorMessageInvalid { get; set; }
		string? LowerGreaterThanUpperInfoMessage { get; set; }
		string? LowerPlaceholder { get; set; }
		string? LowerTitle { get; set; }
		string? UpperDescription { get; set; }
		Func<object?, string>? UpperErrorMessageInvalid { get; set; }
		string? UpperLessThanLowerInfoMessage { get; set; }
		string? UpperPlaceholder { get; set; }
		string? UpperTitle { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, ISearchRangeLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			if (converter?.LowerDescription is Func<object?, string> || LowerDescription is string) stringbuilder.Append(converter?.LowerDescription?.Invoke(LowerDescription) ?? LowerDescription);
			if (converter?.LowerErrorMessageInvalid is Func<object?, string> || LowerErrorMessageInvalid is Func<object?, string>) stringbuilder.Append(converter?.LowerErrorMessageInvalid?.Invoke(LowerErrorMessageInvalid) ?? LowerErrorMessageInvalid?.Invoke("{defaultvalue}"));
			if (converter?.LowerGreaterThanUpperInfoMessage is Func<object?, string> || LowerGreaterThanUpperInfoMessage is string) stringbuilder.Append(converter?.LowerGreaterThanUpperInfoMessage?.Invoke(LowerGreaterThanUpperInfoMessage) ?? LowerGreaterThanUpperInfoMessage);
			if (converter?.LowerPlaceholder is Func<object?, string> || LowerPlaceholder is string) stringbuilder.Append(converter?.LowerPlaceholder?.Invoke(LowerPlaceholder) ?? LowerPlaceholder);
			if (converter?.LowerTitle is Func<object?, string> || LowerTitle is string) stringbuilder.Append(converter?.LowerTitle?.Invoke(LowerTitle) ?? LowerTitle);
			if (converter?.UpperDescription is Func<object?, string> || UpperDescription is string) stringbuilder.Append(converter?.UpperDescription?.Invoke(UpperDescription) ?? UpperDescription);
			if (converter?.UpperErrorMessageInvalid is Func<object?, string> || UpperErrorMessageInvalid is Func<object?, string>) stringbuilder.Append(converter?.UpperErrorMessageInvalid?.Invoke(UpperErrorMessageInvalid) ?? UpperErrorMessageInvalid?.Invoke("{defaultvalue}"));
			if (converter?.UpperLessThanLowerInfoMessage is Func<object?, string> || UpperLessThanLowerInfoMessage is string) stringbuilder.Append(converter?.UpperLessThanLowerInfoMessage?.Invoke(UpperLessThanLowerInfoMessage) ?? UpperLessThanLowerInfoMessage);
			if (converter?.UpperPlaceholder is Func<object?, string> || UpperPlaceholder is string) stringbuilder.Append(converter?.UpperPlaceholder?.Invoke(UpperPlaceholder) ?? UpperPlaceholder);
			if (converter?.UpperTitle is Func<object?, string> || UpperTitle is string) stringbuilder.Append(converter?.UpperTitle?.Invoke(UpperTitle) ?? UpperTitle);

			return (this as ISearchItemLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : ISearchItemLocalisation.Default, ISearchRangeLocalisation
		{
			public string? LowerDescription { get; set; }
			public Func<object?, string>? LowerErrorMessageInvalid { get; set; }
			public string? LowerGreaterThanUpperInfoMessage { get; set; }
			public string? LowerPlaceholder { get; set; }
			public string? LowerTitle { get; set; }
			public string? UpperDescription { get; set; }
			public Func<object?, string>? UpperErrorMessageInvalid { get; set; }
			public string? UpperLessThanLowerInfoMessage { get; set; }
			public string? UpperPlaceholder { get; set; }
			public string? UpperTitle { get; set; }
		}
		public new class Default<T> : ISearchItemLocalisation.Default<T>, ISearchRangeLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				LowerDescription = defaultvalue;
				LowerErrorMessageInvalid = defaultvalue;
				LowerGreaterThanUpperInfoMessage = defaultvalue;
				LowerPlaceholder = defaultvalue;
				LowerTitle = defaultvalue;
				UpperDescription = defaultvalue;
				UpperErrorMessageInvalid = defaultvalue;
				UpperLessThanLowerInfoMessage = defaultvalue;
				UpperPlaceholder = defaultvalue;
				UpperTitle = defaultvalue;
			}

			public T LowerDescription { get; set; }
			public T LowerErrorMessageInvalid { get; set; }
			public T LowerGreaterThanUpperInfoMessage { get; set; }
			public T LowerPlaceholder { get; set; }
			public T LowerTitle { get; set; }
			public T UpperDescription { get; set; }
			public T UpperErrorMessageInvalid { get; set; }
			public T UpperLessThanLowerInfoMessage { get; set; }
			public T UpperPlaceholder { get; set; }
			public T UpperTitle { get; set; }
		}
	}
}
