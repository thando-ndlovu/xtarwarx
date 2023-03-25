using Domain.Models;

using Localisation.Abstractions.Vehicles;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IVehicleLocalisations : IDisposable
	{
		IVehicle<string?>? VehicleTitles(CultureInfo? cultureInfo = null, IVehicle<bool>? retriever = null);
		IVehicle<string?>? VehicleDescriptions(CultureInfo? cultureInfo = null, IVehicle<bool>? retriever = null);
		IVehicle.ISortKeys? VehicleSortKeysTitles(CultureInfo? cultureInfo = null, IVehicle.ISortKeys<bool>? retriever = null);
		IVehicle.ISortKeys? VehicleSortKeysDescriptions(CultureInfo? cultureInfo = null, IVehicle.ISortKeys<bool>? retriever = null);
		IVehicleSingleLocalisation? VehicleSingle(CultureInfo? cultureInfo = null, IVehicleSingleLocalisation<bool>? retriever = null);
		IVehicleMultipleLocalisation? VehicleMultiple(CultureInfo? cultureInfo = null, IVehicleMultipleLocalisation<bool>? retriever = null);
		IVehicleSearchLocalisation? VehicleSearch(CultureInfo? cultureInfo = null, IVehicleSearchLocalisationTyped<bool>? retriever = null);
		IVehicle.ISearchContainables<string?>? VehicleSearchContainablesTitles(CultureInfo? cultureInfo = null, IVehicle.ISearchContainables<bool>? retriever = null);
		IVehicle.ISearchContainables<string?>? VehicleSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IVehicle.ISearchContainables<bool>? retriever = null);
	}
}
