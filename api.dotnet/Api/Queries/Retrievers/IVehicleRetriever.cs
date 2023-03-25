using Domain.Models;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Queries.Retrievers
{
	public interface IVehicleRetriever<T> : ITransporterRetriever<T>, IVehicle<T> { }
	public interface IVehicleRetrieverTyped<T> : ITransporterRetrieverTyped<T>, IVehicleTyped<T> { }
	public interface IVehicleRetriever : ITransporterRetriever, IVehicleRetrieverTyped<bool>
	{
		public new interface IRetrieved<T> : ITransporterRetriever.IRetrieved<T>, IVehicle<T> { }
		public new interface IRetrieved : ITransporterRetriever.IRetrieved, IVehicle
		{
			public new class Default : IVehicle.Default, IRetrieved
			{
				public Default(int id) : base(id) { }
				public Default(int id, JObject jobject) : base(id, jobject) 
				{
					Manufacturers = jobject.GetValue(nameof(Manufacturers), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new IManufacturerRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<IManufacturerRetriever.IRetrieved>();
					Pilots = jobject.GetValue(nameof(Pilots), StringComparison.OrdinalIgnoreCase)?
						.ToObject<JArray?>()?
						.Select(jtoken =>
						{
							if (jtoken.Value<int?>(nameof(Id)) is int id)
								return new ICharacterRetriever.IRetrieved.Default(id, JObject.FromObject(jtoken));

							return null;

						}).OfType<ICharacterRetriever.IRetrieved>();
				}
				public Default(IVehicle vehicle) : base(vehicle.Id)
				{
					CargoCapacity = vehicle.CargoCapacity;
					Consumables = vehicle.Consumables;
					CostInCredits = vehicle.CostInCredits;
					Description = vehicle.Description;
					Length = vehicle.Length;
					ManufacturerIds = vehicle.ManufacturerIds;
					MaxAtmospheringSpeed = vehicle.MaxAtmospheringSpeed;
					MaxCrew = vehicle.MaxCrew;
					MinCrew = vehicle.MinCrew;
					Model = vehicle.Model;
					Name = vehicle.Name;
					Passengers = vehicle.Passengers;
					PilotIds = vehicle.PilotIds;
				}

				public IEnumerable<IManufacturerRetriever.IRetrieved>? Manufacturers { get; set; }
				public IEnumerable<ICharacterRetriever.IRetrieved>? Pilots { get; set; }
			}
			public new class Default<T> : IVehicle.Default<T>, IRetrieved<T>
			{
				public Default(T defaultvalue) : base(defaultvalue)
				{
					Manufacturers = defaultvalue;
					Pilots = defaultvalue;
				}

				public T Manufacturers { get; set; }
				public T Pilots { get; set; }
			}
		}

		public new class Default : DefaultTyped<bool>, IVehicleRetriever
		{
			public Default(bool defaultvalue) : base(defaultvalue) { }

			public IPagination? Pagination { get; set; }
		}
		public new class Default<T> : IVehicle.Default<T>, IVehicleRetriever<T>
		{
			public Default(T defaultvalue) : base(defaultvalue)
			{
				Manufacturers = defaultvalue;
				Pilots = defaultvalue;
			}

			public T Manufacturers { get; set; }
			public T Pilots { get; set; }
		}	 
		public new class DefaultTyped<T> : IVehicle.DefaultTyped<T>, IVehicleRetrieverTyped<T>
		{
			public DefaultTyped(T defaultvalue) : base(defaultvalue) { }

			public IManufacturerRetrieverTyped<T>? Manufacturers { get; set; }
			public ICharacterRetrieverTyped<T>? Pilots { get; set; }
		}
	}
}
