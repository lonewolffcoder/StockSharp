#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: StockSharp.Algo.Latency.Algo
File: LatencyMessageAdapter.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace StockSharp.Algo.Latency
{
	using System;

	using Ecng.Common;

	using StockSharp.Messages;

	/// <summary>
	/// The message adapter, automatically calculating network delays.
	/// </summary>
	public class LatencyMessageAdapter : MessageAdapterWrapper
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LatencyMessageAdapter"/>.
		/// </summary>
		/// <param name="innerAdapter">The adapter, to which messages will be directed.</param>
		public LatencyMessageAdapter(IMessageAdapter innerAdapter)
			: base(innerAdapter)
		{
		}

		private ILatencyManager _latencyManager = new LatencyManager();

		/// <summary>
		/// Orders registration delay calculation manager.
		/// </summary>
		public ILatencyManager LatencyManager
		{
			get { return _latencyManager; }
			set
			{
				if (value == null)
					throw new ArgumentNullException(nameof(value));

				_latencyManager = value;
			}
		}

		/// <summary>
		/// Send message.
		/// </summary>
		/// <param name="message">Message.</param>
		public override void SendInMessage(Message message)
		{
			if (message.LocalTime.IsDefault())
				message.LocalTime = InnerAdapter.CurrentTime;

			LatencyManager.ProcessMessage(message);

			base.SendInMessage(message);
		}

		/// <summary>
		/// Process <see cref="MessageAdapterWrapper.InnerAdapter"/> output message.
		/// </summary>
		/// <param name="message">The message.</param>
		protected override void OnInnerAdapterNewOutMessage(Message message)
		{
			ProcessExecution(message);

			base.OnInnerAdapterNewOutMessage(message);
		}

		private void ProcessExecution(Message message)
		{
			if (message.Type != MessageTypes.Execution)
				return;

			var execMsg = (ExecutionMessage)message;

			if (execMsg.ExecutionType != ExecutionTypes.Order)
				return;

			var latency = LatencyManager.ProcessMessage(execMsg);

			if (latency != null)
				execMsg.Latency = latency;
		}

		/// <summary>
		/// Create a copy of <see cref="LatencyMessageAdapter"/>.
		/// </summary>
		/// <returns>Copy.</returns>
		public override IMessageChannel Clone()
		{
			return new LatencyMessageAdapter((IMessageAdapter)InnerAdapter.Clone());
		}
	}
}