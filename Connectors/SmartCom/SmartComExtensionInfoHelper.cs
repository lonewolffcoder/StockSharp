﻿#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.SmartCom.SmartCom
File: SmartComExtensionInfoHelper.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.SmartCom
{
	using StockSharp.BusinessEntities;
	using StockSharp.Messages;
	using StockSharp.SmartCom.Native;

	/// <summary>
	/// Вспомогательный класс, который используется для доступа к специфичной SmartCOM информации через <see cref="IExtendableEntity.ExtensionInfo"/>.
	/// </summary>
	public static class SmartComExtensionInfoHelper
	{
		#region SecurityOptionsMargin

		/// <summary>
		/// Гарантийное обеспечение продажи опционов.
		/// </summary>
		internal const string SecurityOptionsMargin = "SecurityOptionsMargin";

		internal static void SetOptionsMargin(this Security security, decimal value)
		{
			security.AddValue(SecurityOptionsMargin, value);
		}

		/// <summary>
		/// Получить гарантийное обеспечение продажи опционов для инструмента.
		/// </summary>
		/// <param name="security">Инструмент.</param>
		/// <returns>Гарантийное обеспечение продажи опционов. Если информация отсутствует, то будет возвращено <see langword="null"/>.</returns>
		public static decimal? GetOptionsMargin(this Security security)
		{
			return security.GetValue<decimal?>(SecurityOptionsMargin);
		}

		#endregion

		#region SecurityOptionsSyntheticMargin

		/// <summary>
		/// Гарантийное обеспечение по синтетическим позициям.
		/// </summary>
		internal const string SecurityOptionsSyntheticMargin = "SecurityOptionsSyntheticMargin";

		internal static void SetOptionsSyntheticMargin(this Security security, decimal value)
		{
			security.AddValue(SecurityOptionsSyntheticMargin, value);
		}

		/// <summary>
		/// Получить гарантийное обеспечение по синтетическим позициям для инструмента.
		/// </summary>
		/// <param name="security">Инструмент.</param>
		/// <returns>Гарантийное обеспечение по синтетическим позициям. Если информация отсутствует, то будет возвращено <see langword="null"/>.</returns>
		public static decimal? GetOptionsSyntheticMargin(this Security security)
		{
			return security.GetValue<decimal?>(SecurityOptionsSyntheticMargin);
		}

		#endregion

		#region PortfolioStatus

		/// <summary>
		/// Статус портфеля.
		/// </summary>
		internal const string PortfolioStatus = "PortfolioStatus";

		internal static void SetSmartStatus(this Portfolio portfolio, SmartPortfolioStatus value)
		{
			portfolio.AddValue(PortfolioStatus, value);
		}

		/// <summary>
		/// Получить SmartCOM статус портфеля.
		/// </summary>
		/// <param name="portfolio">Портфель.</param>
		/// <returns>Статус портфеля. Если статус отсутствует, то будет возвращено <see langword="null"/>.</returns>
		public static SmartPortfolioStatus GetSmartStatus(this Portfolio portfolio)
		{
			return portfolio.GetValue<SmartPortfolioStatus>(PortfolioStatus);
		}

		#endregion
	}
}