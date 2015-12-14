#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.CQG.CQG
File: CQGTrader.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.CQG
{
	using Ecng.ComponentModel;

	using StockSharp.Algo;
	using StockSharp.BusinessEntities;

	/// <summary>
	/// The interface <see cref="IConnector"/> implementation which provides a connection to the CQG.
	/// </summary>
	[Icon("CQG_logo.png")]
	public class CQGTrader : Connector
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="CQGTrader"/>.
		/// </summary>
		public CQGTrader()
		{
			CreateAssociatedSecurity = true;
			Adapter.InnerAdapters.Add(new CQGMessageAdapter(TransactionIdGenerator));
		}
    }
}