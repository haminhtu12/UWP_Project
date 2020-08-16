using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1904EHelloUWP.demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class _1 : Page
    {
        public _1()
        {
            this.InitializeComponent();
        }

        private async void button()
        {
            //FileSavePicker savePicker = new FileSavePicker();
            //savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            //savePicker.FileTypeChoices.Add("plain Text", new List<string>() { ".txt" });
            //savePicker.SuggestedFileName = "New Document";
            //StorageFile file = await savePicker.PickSaveFileAsync();
            //await FileIO.WriteTextAsync(file, "hello file");

            StorageFolder curentFolder = Windows.Storage.ApplicationData.Current.TemporaryFolder;
            StorageFile file = await curentFolder.CreateFileAsync("hello.txt", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, "hello file");
            Debug.WriteLine("write file success");
        }
       
    }
}
