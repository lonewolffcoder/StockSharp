#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Studio.Core.Commands.CorePublic
File: PositionCommand.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Studio.Core.Commands
{
	using System;
	using System.Collections.Generic;

	using StockSharp.Messages;

	public class PositionCommand : BaseStudioCommand
	{
		public PositionCommand(DateTimeOffset time, KeyValuePair<Tuple<SecurityId, string>, decimal> position, bool isNew)
		{
			//if (position == null)
			//	throw new ArgumentNullException("position");

			Time = time;
			Position = position;
			IsNew = isNew;
		}

		public DateTimeOffset Time { get; private set; }
		public KeyValuePair<Tuple<SecurityId, string>, decimal> Position { get; private set; }
		public bool IsNew { get; private set; }
	}
}