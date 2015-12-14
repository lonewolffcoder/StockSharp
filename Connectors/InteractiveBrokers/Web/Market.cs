#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.InteractiveBrokers.Web.InteractiveBrokers
File: Market.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.InteractiveBrokers.Web
{
	/// <summary>
	/// Exchange info.
	/// </summary>
	public class Market
	{
		/// <summary>
		/// Unique ID.
		/// </summary>
		public string Id;

		/// <summary>
		/// Name.
		/// </summary>
		public string Name;

		/// <summary>
		/// Country.
		/// </summary>
		public string Country;

		//public string Products;

		/// <summary>
		/// Work hours.
		/// </summary>
		public string Hours;
	}
}