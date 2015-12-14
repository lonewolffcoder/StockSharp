#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Messages.Messages
File: OrderStates.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Messages
{
	using System;
	using System.Runtime.Serialization;

	using StockSharp.Localization;

	/// <summary>
	/// Order states.
	/// </summary>
	[DataContract]
	[Serializable]
	public enum OrderStates
	{
		/// <summary>
		/// Not sent to the trading system.
		/// </summary>
		/// <remarks>
		/// The original state of the order, when the transaction is not sent to the trading system.
		/// </remarks>
		[EnumMember]
		[EnumDisplayNameLoc(LocalizedStrings.Str237Key)]
		None,

		/// <summary>
		/// The order is accepted by the exchange and is active.
		/// </summary>
		[EnumMember]
		[EnumDisplayNameLoc(LocalizedStrings.Str238Key)]
		Active,

		/// <summary>
		/// The order is no longer active on an exchange (it was fully matched or cancelled).
		/// </summary>
		[EnumMember]
		[EnumDisplayNameLoc(LocalizedStrings.Str239Key)]
		Done,

		/// <summary>
		/// The order is not accepted by the trading system.
		/// </summary>
		[EnumMember]
		[EnumDisplayNameLoc(LocalizedStrings.Str152Key)]
		Failed,

		/// <summary>
		/// Pending acception.
		/// </summary>
		[EnumMember]
		[EnumDisplayNameLoc(LocalizedStrings.Str238Key)]
		Pending,
	}
}