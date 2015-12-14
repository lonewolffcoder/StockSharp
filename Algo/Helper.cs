#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Algo.Algo
File: Helper.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Algo
{
	using System;

	using Ecng.Collections;
	using Ecng.Common;

	using StockSharp.BusinessEntities;
	using StockSharp.Messages;
	using StockSharp.Localization;

	static class Helper
	{
		public static void CheckOption(this Security option)
		{
			if (option == null)
				throw new ArgumentNullException(nameof(option));

			if (option.Type != SecurityTypes.Option)
				throw new ArgumentException(LocalizedStrings.Str900Params.Put(option.Type), nameof(option));

			if (option.OptionType == null)
				throw new ArgumentException(LocalizedStrings.Str703Params.Put(option), nameof(option));

			if (option.ExpiryDate == null)
				throw new ArgumentException(LocalizedStrings.Str901Params.Put(option), nameof(option));

			if (option.UnderlyingSecurityId == null)
				throw new ArgumentException(LocalizedStrings.Str902Params.Put(option), nameof(option));
		}

		public static ExchangeBoard CheckExchangeBoard(this Security security)
		{
			if (security == null)
				throw new ArgumentNullException(nameof(security));

			if (security.Board == null)
				throw new ArgumentException(LocalizedStrings.Str903Params.Put(security), nameof(security));

			return security.Board;
		}

		public static Security CheckPriceStep(this Security security)
		{
			if (security == null)
				throw new ArgumentNullException(nameof(security));

			if (security.PriceStep == null)
				throw new ArgumentException(LocalizedStrings.Str905Params.Put(security.Id));

			return security;
		}

		public static int ChangeSubscribers<T>(this CachedSynchronizedDictionary<T, int> subscribers, T subscriber, bool isSubscribe)
		{
			if (subscribers == null)
				throw new ArgumentNullException(nameof(subscribers));

			lock (subscribers.SyncRoot)
			{
				var value = subscribers.TryGetValue2(subscriber) ?? 0;

				if (isSubscribe)
					value++;
				else
				{
					if (value > 0)
						value--;
				}

				if (value > 0)
					subscribers[subscriber] = value;
				else
					subscribers.Remove(subscriber);

				return value;
			}
		}

		public static long GetTradeId(this ExecutionMessage message)
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			var tradeId = message.TradeId;

			if (tradeId == null)
				throw new ArgumentOutOfRangeException(nameof(message), null, LocalizedStrings.Str1020);

			return tradeId.Value;
		}

		public static decimal GetTradePrice(this ExecutionMessage message)
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			var price = message.TradePrice;

			if (price == null)
				throw new ArgumentOutOfRangeException(nameof(message), null, LocalizedStrings.Str1021Params.Put(message.TradeId));

			return price.Value;
		}

		public static decimal GetBalance(this ExecutionMessage message)
		{
			if (message == null)
				throw new ArgumentNullException(nameof(message));

			var balance = message.Balance;

			if (balance != null)
				return balance.Value;

			throw new ArgumentOutOfRangeException(nameof(message));
		}
	}
}