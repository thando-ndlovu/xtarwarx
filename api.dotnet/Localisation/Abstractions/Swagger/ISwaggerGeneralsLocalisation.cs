
namespace Localisation.Abstractions.Swagger
{
	public interface ISwaggerGeneralLocalisation<T>
	{
		T Description { get; set; }
		T Title { get; set; }
	}
	public interface ISwaggerGeneralLocalisation
	{
		string? Description { get; set; }
		string? Title { get; set; }

		#region Defaults

		public class Default : ISwaggerGeneralLocalisation
		{
			public string? Description { get; set; }
			public string? Title { get; set; }
		}
		public class Default<T> : ISwaggerGeneralLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				Description = defaultvalue;
				Title = defaultvalue;
			}

			public T Description { get; set; }
			public T Title { get; set; }
		}

		#endregion
	}
}
