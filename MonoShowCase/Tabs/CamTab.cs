using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Media;
using Android.Graphics;

namespace MonoShowCase.Tabs
{
    public class CamTab : Fragment
    {
        #region Fields
        private ImageView imageView;
        private Toast unsupportedToast;
        private Xamarin.Media.MediaPicker picker;
        #endregion

        public override View OnCreateView(LayoutInflater inflater,
       ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(
                Resource.Layout.Activity_cam_fragment, container, false);

            imageView = view.FindViewById<ImageView>(Resource.Id.camOutput);

            var button = view.FindViewById<Button>(Resource.Id.camButton);
            button.Click += TakePicture;
            picker = new MediaPicker(container.Context);

            return view;
        }


        private void TakePicture(object sender, EventArgs e)
        {
            
            if (!picker.IsCameraAvailable || !picker.PhotosSupported)
            {
                //ShowUnsupported();
                return;
            }

            picker.TakePhotoAsync(new StoreCameraMediaOptions
            {
                Name = "test.jpg",
                Directory = "MediaPickerSample"
            })
            .ContinueWith(t =>
            {
                if (t.IsCanceled)
                    return;


                

                this.Activity.RunOnUiThread(() =>
                {
                    var picture = BitmapFactory.DecodeFile(t.Result.Path);
                    
                    //
                    // Display the bitmap
                    //
                    imageView.SetImageBitmap(picture);

                    // Cleanup any resources held by the MediaFile instance
                    t.Result.Dispose();
                });
            });

        }

        //private void ShowUnsupported()
        //{
        //    if (this.unsupportedToast != null)
        //    {
        //        this.unsupportedToast.Cancel();
        //        this.unsupportedToast.Dispose();
        //    }

        //    this.unsupportedToast = Toast.MakeText(this, "Your device does not support this feature", ToastLength.Long);
        //    this.unsupportedToast.Show();
        //}
    }
}