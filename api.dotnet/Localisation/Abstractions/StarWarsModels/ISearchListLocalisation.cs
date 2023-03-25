using Localisation.Abstractions.Base;

using System;
using System.Text;

namespace Localisation.Abstractions.StarWarsModels
{
	public interface ISearchListLocalisation<T> : ISearchItemLocalisation<T> 
	{
		T AddButtonText { get; set; }
		T EntryPlaceholder { get; set; }
		T PickerCancel { get; set; }
		T PickerTitle { get; set; }
		T PromptCancel { get; set; }
		T PromptOk { get; set; }
		T PromptTitle { get; set; }
		T ToastInvalid { get; set; }
		T ToastAlreadySelected { get; set; }

		public new string ToString(StringBuilder? stringbuilder = null)
		{
			stringbuilder ??= new StringBuilder();

			stringbuilder
				.AppendFormat("{0}: {1}", nameof(AddButtonText), AddButtonText).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Description), Description).AppendLine()
				.AppendFormat("{0}: {1}", nameof(EntryPlaceholder), EntryPlaceholder).AppendLine()
				.AppendFormat("{0}: {1}", nameof(Title), Title).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PickerCancel), PickerCancel).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PickerTitle), PickerTitle).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PromptCancel), PromptCancel).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PromptOk), PromptOk).AppendLine()
				.AppendFormat("{0}: {1}", nameof(PromptTitle), PromptTitle).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ToastInvalid), ToastInvalid).AppendLine()
				.AppendFormat("{0}: {1}", nameof(ToastAlreadySelected), ToastAlreadySelected).AppendLine();

			return (this as IBaseSearchLocalisation<T>).ToString(stringbuilder);
		}
	}
	public interface ISearchListLocalisation : ISearchItemLocalisation
	{
		string? AddButtonText { get; set; }
		string? EntryPlaceholder { get; set; }
		string? PickerCancel { get; set; }
		string? PickerTitle { get; set; }
		string? PromptCancel { get; set; }
		string? PromptOk { get; set; }
		string? PromptTitle { get; set; }
		Func<string, string>? ToastInvalid { get; set; }
		Func<object, string>? ToastAlreadySelected { get; set; }

		public string ToString(StringBuilder? stringbuilder = null, ISearchListLocalisation<Func<object?, string>>? converter = null)
		{
			stringbuilder ??= new StringBuilder();

			if (converter?.AddButtonText is Func<object?, string> || AddButtonText is string) stringbuilder.Append(converter?.AddButtonText?.Invoke(AddButtonText) ?? AddButtonText);
			if (converter?.EntryPlaceholder is Func<object?, string> || EntryPlaceholder is string) stringbuilder.Append(converter?.EntryPlaceholder?.Invoke(EntryPlaceholder) ?? EntryPlaceholder);
			if (converter?.PickerCancel is Func<object?, string> || PickerCancel is string) stringbuilder.Append(converter?.PickerCancel?.Invoke(PickerCancel));
			if (converter?.PickerTitle is Func<object?, string> || PickerTitle is string) stringbuilder.Append(converter?.PickerTitle?.Invoke(PickerTitle));
			if (converter?.PromptCancel is Func<object?, string> || PromptCancel is string) stringbuilder.Append(converter?.PromptCancel?.Invoke(PromptCancel));
			if (converter?.PromptOk is Func<object?, string> || PromptOk is string) stringbuilder.Append(converter?.PromptOk?.Invoke(PromptOk));
			if (converter?.PromptTitle is Func<object?, string> || PromptTitle is string) stringbuilder.Append(converter?.PromptTitle?.Invoke(PromptTitle));
			if (converter?.ToastInvalid is Func<object?, string> || ToastInvalid is Func<string, string>) stringbuilder.Append(converter?.ToastInvalid?.Invoke(ToastInvalid) ?? ToastInvalid?.Invoke("{defaultvalue}"));
			if (converter?.ToastAlreadySelected is Func<object?, string> || ToastAlreadySelected is Func<object, string>) stringbuilder.Append(converter?.ToastAlreadySelected?.Invoke(ToastAlreadySelected) ?? ToastAlreadySelected?.Invoke("{defaultvalue}"));

			return (this as ISearchItemLocalisation).ToString(stringbuilder, converter);
		}

		public new class Default : ISearchItemLocalisation.Default, ISearchListLocalisation
		{
			public string? AddButtonText { get; set; }
			public string? EntryPlaceholder { get; set; }
			public string? PickerCancel { get; set; }
			public string? PickerTitle { get; set; }
			public string? PromptCancel { get; set; }
			public string? PromptOk { get; set; }
			public string? PromptTitle { get; set; }
			public Func<string, string>? ToastInvalid { get; set; }
			public Func<object, string>? ToastAlreadySelected { get; set; }
		}
		public new class Default<T> : ISearchItemLocalisation.Default<T>, ISearchListLocalisation<T>
		{
			public Default(T defaultvalue) : base(defaultvalue) 
			{
				AddButtonText = defaultvalue;
				EntryPlaceholder = defaultvalue;
				PickerCancel = defaultvalue;
				PickerTitle = defaultvalue;
				PromptCancel = defaultvalue;
				PromptOk = defaultvalue;
				PromptTitle = defaultvalue;
				ToastInvalid = defaultvalue;
				ToastAlreadySelected = defaultvalue;
			}

			public T AddButtonText { get; set; }
			public T EntryPlaceholder { get; set; }
			public T PickerCancel { get; set; }
			public T PickerTitle { get; set; }
			public T PromptCancel { get; set; }
			public T PromptOk { get; set; }
			public T PromptTitle { get; set; }
			public T ToastInvalid { get; set; }
			public T ToastAlreadySelected { get; set; }
		}
	}
}
