using Domain.Models;

using Localisation.Abstractions.Manufacturers;

using System;
using System.Globalization;

namespace Localisation.Abstractions
{
	public interface IManufacturerLocalisations : IDisposable
	{
		IManufacturer<string?>? ManufacturerTitles(CultureInfo? cultureInfo = null, IManufacturer<bool>? retriever = null);
		IManufacturer<string?>? ManufacturerDescriptions(CultureInfo? cultureInfo = null, IManufacturer<bool>? retriever = null);
		IManufacturer.ISortKeys? ManufacturerSortKeysTitles(CultureInfo? cultureInfo = null, IManufacturer.ISortKeys<bool>? retriever = null);
		IManufacturer.ISortKeys? ManufacturerSortKeysDescriptions(CultureInfo? cultureInfo = null, IManufacturer.ISortKeys<bool>? retriever = null);
		IManufacturerSingleLocalisation? ManufacturerSingle(CultureInfo? cultureInfo = null, IManufacturerSingleLocalisation<bool>? retriever = null);
		IManufacturerMultipleLocalisation? ManufacturerMultiple(CultureInfo? cultureInfo = null, IManufacturerMultipleLocalisation<bool>? retriever = null);
		IManufacturerSearchLocalisation? ManufacturerSearch(CultureInfo? cultureInfo = null, IManufacturerSearchLocalisationTyped<bool>? retriever = null);
		IManufacturer.ISearchContainables<string?>? ManufacturerSearchContainablesTitles(CultureInfo? cultureInfo = null, IManufacturer.ISearchContainables<bool>? retriever = null);
		IManufacturer.ISearchContainables<string?>? ManufacturerSearchContainablesDescriptions(CultureInfo? cultureInfo = null, IManufacturer.ISearchContainables<bool>? retriever = null);
	}
}
