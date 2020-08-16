using MyService.Entity;
using MyService.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1904EHelloUWP.Entity;
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

namespace T1904EHelloUWP.Screen
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateSong : Page
    {
        public CreateSong()
        {
            this.InitializeComponent();
        }

        private async void Do_Save(object sender, RoutedEventArgs e)
        {
            SongService _songService = new SongService();
            var newSong = new Song
            {
             name = Name.Text,
             description = Description.Text,
             singer = Singer.Text,
             author = Author.Text,
             thumbnail = Thumbnail.Text,
             link = Link.Text
        };
           
            MyService.Entity.Song createdSong = await _songService.CreateSong(newSong);



        }

        private void Do_ReSet(object sender, RoutedEventArgs e)
        {

        }
    }
}
