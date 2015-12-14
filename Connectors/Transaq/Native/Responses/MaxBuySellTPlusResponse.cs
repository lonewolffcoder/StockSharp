﻿#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Transaq.Native.Responses.Transaq
File: MaxBuySellTPlusResponse.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Transaq.Native.Responses
{
	using System.Collections.Generic;

	class MaxBuySellTPlusResponse : BaseResponse
	{
		/// <summary>
		/// Код клиента.
		/// </summary>
		public string Client { get; set; }

		/// <summary>
		/// Информация по инструментам.
		/// </summary>
		public IEnumerable<MaxBuySellTPlusSecurity> Securities { get; set; }
	}

	class MaxBuySellTPlusSecurity
	{
		/// <summary>
		/// Id инструмента.
		/// </summary>
		public string SecId { get; set; }

		/// <summary>
		/// Id рынка.
		/// </summary>
		public int Market { get; set; }

		/// <summary>
		/// Обозначение инструмента.
		/// </summary>
		public string SecCode { get; set; }

		/// <summary>
		/// Максимум купить (лот).
		/// </summary>
		public long MaxBuy { get; set; }

		/// <summary>
		/// Максимум продать (лот).
		/// </summary>
		public long MaxSell { get; set; }
	}
}