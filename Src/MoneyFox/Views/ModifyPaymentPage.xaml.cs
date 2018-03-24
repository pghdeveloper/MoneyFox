﻿using MoneyFox.Foundation.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoneyFox.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ModifyPaymentPage
	{
		public ModifyPaymentPage ()
		{
			InitializeComponent ();

		    var savePaymentItem = new ToolbarItem
		    {
		        Command = new Command(() => ViewModel.SaveCommand.Execute()),
		        Text = Strings.SavePaymentLabel,
		        Priority = 0,
		        Order = ToolbarItemOrder.Primary,
                Icon = "IconSave.png"
		    };

		    ToolbarItems.Add(savePaymentItem);
        }
	}
}