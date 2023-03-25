using Domain.Models;

using Localisation.Abstractions;
using Localisation.Utils.Vehicles;

using System.Globalization;

using Localisation.Abstractions.Vehicles;

using VehicleUtils = Localisation.Utils.Vehicles;

namespace Localisation.Implementation
{
	public class VehicleLocalisations : Base.BaseLocalisations, IVehicleLocalisations
	{
		public IVehicle<string?>? VehicleTitles(CultureInfo? cultureInfo = null, IVehicle<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleTitles.ResourceName, localisationcultureinfo)?
				.GetVehicleTitles(retriever);
		}
		public IVehicle<string?>? VehicleDescriptions(CultureInfo? cultureInfo = null, IVehicle<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleDescriptions.ResourceName, localisationcultureinfo)?
				.GetVehicleDescriptions(retriever);
		}
		public IVehicle.ISortKeys? VehicleSortKeysTitles(CultureInfo? cultureInfo = null, IVehicle.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleSortKeysTitles.ResourceName, localisationcultureinfo)?
				.GetVehicleSortKeysTitles(retriever);
		}
		public IVehicle.ISortKeys? VehicleSortKeysDescriptions(CultureInfo? cultureInfo = null, IVehicle.ISortKeys<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleSortKeysDescriptions.ResourceName, localisationcultureinfo)?
				.GetVehicleSortKeysDescriptions(retriever);
		}
		public IVehicleSingleLocalisation? VehicleSingle(CultureInfo? cultureInfo = null, IVehicleSingleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			IVehicle<string?>? titles = VehicleTitles(cultureInfo, retriever);

			return GetResourceManager(VehicleUtils.VehicleSingle.ResourceName, localisationcultureinfo)?
				.GetVehicleSingle(retriever, titles);
		}
		public IVehicleMultipleLocalisation? VehicleMultiple(CultureInfo? cultureInfo = null, IVehicleMultipleLocalisation<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleMultiple.ResourceName, localisationcultureinfo)?
				.GetVehicleMultiple(retriever);
		}
		public IVehicleSearchLocalisation? VehicleSearch(CultureInfo? cultureInfo = null, IVehicleSearchLocalisationTyped<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleSearch.ResourceName, localisationcultureinfo)?
				.GetVehicleSearch(retriever);
		}
		public IVehicle.ISearchContainables<string?>? VehicleSearchContainablesTitles(CultureInfo? cultureInfo = null, IVehicle.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleSearchContainablesTitles.ResourceName, localisationcultureinfo)?
				.GetVehicleSearchContainablesTitles(retriever);
		}
		public IVehicle.ISearchContainables<string?>? VehicleSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IVehicle.ISearchContainables<bool>? retriever = null)
		{
			LocalisationCultureInfo localisationcultureinfo = LocalisationCultureInfo.FromCultureInfo
				(cultureInfo ?? DefaultCultureInfo ?? CultureInfo.CurrentCulture);

			return GetResourceManager(VehicleUtils.VehicleSearchContainablesDescriptions.ResourceName, localisationcultureinfo)?
				.GetVehicleSearchContainablesDescriptions(retriever);
		}
	}
}
