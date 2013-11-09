using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using Windows.Web.Http;
using Windows.Web.Http.Headers;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private HttpClient httpClient;

        public MainPage()
        {
            this.InitializeComponent();

            httpClient = new HttpClient();

            var headers = httpClient.DefaultRequestHeaders;
            var downloaded = getData();



        }

        private async Task<string> getData() {
 
            string content = await httpClient.GetStringAsync(
                new Uri("http://en.wikipedia.org/w/api.php?format=json&action=query&titles=Avicii&prop=revisions&rvprop=content"));
            
            return content;
        }

        async private void ReadDataFromWiki()
        {
            var client = new HttpClient();
            

        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
