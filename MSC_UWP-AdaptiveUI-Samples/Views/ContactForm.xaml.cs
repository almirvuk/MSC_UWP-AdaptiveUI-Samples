using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Calls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MSC_UWP_AdaptiveUI_Samples.Views {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactForm : Page {
        public ContactForm() {
            this.InitializeComponent();
        }

        private async void CallUs(object sender, RoutedEventArgs e) {

            // Add mobile extension
            // Add phone capabillity

            if (ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0)) { 
            
                PhoneCallStore phoneCallStore = await PhoneCallManager.RequestStoreAsync();
                Guid lineID = await phoneCallStore.GetDefaultLineAsync();

                var line = await PhoneLine.FromIdAsync(lineID);

                if (line != null && line.CanDial){

                    line.Dial("060-000-000", "Almir Vuk");
                }
            }


        }
    }
}
