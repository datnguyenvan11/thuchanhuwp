using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using thuchanh.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace thuchanh.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchContact : Page
    {
        private ModelContact modelContact;
        public SearchContact()
        {
            this.InitializeComponent();
            this.modelContact = new ModelContact();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var name = this.name.Text;
            var phone = this.phone.Text;
            var search=  modelContact.Search(name, phone);
            searchname.Text = search.Name;
            searchphone.Text = search.Phone;

        }
    }
}
