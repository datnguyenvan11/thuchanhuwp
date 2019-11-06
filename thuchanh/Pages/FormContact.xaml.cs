using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using thuchanh.Entity;
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
    public sealed partial class FormContact : Page
    {
       private ModelContact modelContact;
        public FormContact()
        {
            this.InitializeComponent();
           this.modelContact = new ModelContact();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact()
            {
                Name = name.Text,
                Phone = phone.Text,

            };

            modelContact.Insert(contact);
          
            name.Text = "";
            phone.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SearchContact));
        }
    }
}
