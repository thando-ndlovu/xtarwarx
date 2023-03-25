
namespace Localisation.Abstractions.Swagger
{
	public interface ISwaggerResponsesLocalisation<T>
	{
		T X_200Desctiption { get; set; }
	}
	public interface ISwaggerResponsesLocalisation
	{
		string? X_200Desctiption { get; set; }

		#region Defaults

		public class Default : ISwaggerResponsesLocalisation
		{
			public string? X_200Desctiption { get; set; }
		}
		public class Default<T> : ISwaggerResponsesLocalisation<T>
		{
			public Default(T defaultvalue)
			{
				X_200Desctiption = defaultvalue;
			}

			public T X_200Desctiption { get; set; }
		}

		#endregion
	}
}
