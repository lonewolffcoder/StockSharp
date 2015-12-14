﻿#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Oanda.Native.DataTypes.Oanda
File: Transaction.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Oanda.Native.DataTypes
{
	using Newtonsoft.Json;

	internal class Transaction
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("accountId")]
		public int AccountId { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("instrument")]
		public string Instrument { get; set; }

		[JsonProperty("side")]
		public string Side { get; set; }

		[JsonProperty("units")]
		public long Units { get; set; }

		[JsonProperty("time")]
		public long Time { get; set; }

		[JsonProperty("price")]
		public double Price { get; set; }

		[JsonProperty("accountBalance")]
		public double AccountBalance { get; set; }

		[JsonProperty("interest")]
		public double Interest { get; set; }

		[JsonProperty("pl")]
		public double ProfitLoss { get; set; }

		[JsonProperty("lowerBound")]
		public double LowerBound { get; set; }

		[JsonProperty("upperBound")]
		public double UpperBound { get; set; }

		[JsonProperty("amount")]
		public double Amount { get; set; }

		[JsonProperty("stopLossPrice")]
		public double StopLossPrice { get; set; }

		[JsonProperty("takeProfitPrice")]
		public double TakeProfitPrice { get; set; }

		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("tradeId")]
		public int TradeId { get; set; }

		[JsonProperty("orderId")]
		public int OrderId { get; set; }

		[JsonProperty("trailingStopLossDistance")]
		public int TrailingStopLossDistance { get; set; }

		[JsonProperty("marginUsed")]
		public double MarginUsed { get; set; }

		[JsonProperty("tradeOpened")]
		public Transaction TradeOpened { get; set; }

		[JsonProperty("tradeReduced")]
		public Transaction TradeReduced { get; set; }
	}
}