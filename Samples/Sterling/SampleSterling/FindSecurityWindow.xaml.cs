﻿#region S# License
/******************************************************************************************
NOTICE!!!  This program and source code is owned and licensed by
StockSharp Algo Trading, LLC, www.stocksharp.com
Viewing or use of this code requires your acceptance of the license
agreement found at https://github.com/StockSharp/StockSharp/blob/master/LICENSE
Removal of this comment is a violation of the license agreement.

Project: SampleSterling.SampleSterlingPublic
File: FindSecurityWindow.xaml.cs
Created: 2015, 11, 11, 2:32 PM

Copyright 2010 by StockSharp Algo Trading, LLC
*******************************************************************************************/
#endregion S# License
namespace SampleSterling
{
	using System.Windows;
	using System.Windows.Controls;

	using Ecng.Common;

	using StockSharp.BusinessEntities;

	public partial class FindSecurityWindow
	{
		public FindSecurityWindow()
		{
			InitializeComponent();

			SecCode.Text = "AAPL";
		}

		private void Ok_Click(object sender, RoutedEventArgs e)
		{
			var criteria = new Security
			{
				Code = SecCode.Text,
				Type = SecType.SelectedType
			};

			MainWindow.Instance.Trader.LookupSecurities(criteria);
			DialogResult = true;
		}

		private void SecCode_TextChanged(object sender, TextChangedEventArgs e)
		{
			TryEnableOk();
		}

		private void TryEnableOk()
		{
			Ok.IsEnabled = !SecCode.Text.IsEmpty();
		}
	}
}