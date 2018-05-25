using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamSMS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

		private async void submitBtn_Clicked(object sender, EventArgs e)
        {
			var message = messageEntry.Text;
			var recipient = recipientEntry.Text;

			try
            {
				var smsMessage = new SmsMessage(message, recipient);
				await Sms.ComposeAsync(smsMessage);
            }
            catch (FeatureNotSupportedException ex)
            {
                // Sms is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}
