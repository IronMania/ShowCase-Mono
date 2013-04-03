using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace MonoWp7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void HelloWorldButtonClick(object sender, RoutedEventArgs e)
        {
            outputField.Text = String.Format("Hallo {0}!", inputField.Text);
        }

        private void TakePictureButtonClick(object sender, RoutedEventArgs e)
        {
            //cameraCaptureTask.Show();
        }

        //private void GeoLocationButtonClick(object sender, RoutedEventArgs e)
        //{
        //    if (watcher.Status == GeoPositionStatus.NoData)
        //    {
        //        watcher.Start();
        //    }
        //    else
        //    {
        //        watcher.Stop();
        //        startLocationButton.Content = "StartLocationService";
        //    }

        //}

        //private void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        //{
        //    switch (e.Status)
        //    {
        //        case GeoPositionStatus.Disabled:
        //            // The Location Service is disabled or unsupported.
        //            // Check to see whether the user has disabled the Location Service.
        //            if (watcher.Permission == GeoPositionPermission.Denied)
        //            {
        //                // The user has disabled the Location Service on their device.
        //                statusTextBlock.Text = "you have this application access to location.";
        //            }
        //            else
        //            {
        //                statusTextBlock.Text = "location is not functioning on this device";
        //            }
        //            break;

        //        case GeoPositionStatus.Initializing:
        //            // The Location Service is initializing.
        //            // Disable the Start Location button.
        //            startLocationButton.IsEnabled = false;
        //            break;

        //        case GeoPositionStatus.NoData:
        //            // The Location Service is working, but it cannot get location data.
        //            // Alert the user and enable the Stop Location button.
        //            statusTextBlock.Text = "location data is not available.";
        //            startLocationButton.Content = "StopLocationService";
        //            startLocationButton.IsEnabled = true;
        //            break;

        //        case GeoPositionStatus.Ready:
        //            // The Location Service is working and is receiving location data.
        //            // Show the current position and enable the Stop Location button.
        //            statusTextBlock.Text = "location data is available.";
        //            startLocationButton.Content = "StopLocationService";
        //            startLocationButton.IsEnabled = true;
        //            break;
        //    }
        //}
        //private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        //{
        //    latitudeTextBlock.Text = "Latitude: " + e.Position.Location.Latitude.ToString("0.000");
        //    longitudeTextBlock.Text = "Longitude: " + e.Position.Location.Longitude.ToString("0.000");
        //}

        //private void cameraCaptureTask_Completed(object sender, PhotoResult e)
        //{
        //    if (e.TaskResult == TaskResult.OK)
        //    {
        //        MessageBox.Show(e.ChosenPhoto.Length.ToString());

        //        //Code to display the photo on the page in an image control named myImage.
        //        System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
        //        bmp.SetSource(e.ChosenPhoto);
        //        myImage.Source = bmp;
        //    }

        //}


    }
}