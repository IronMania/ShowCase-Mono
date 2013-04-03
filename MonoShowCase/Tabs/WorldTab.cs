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

namespace MonoShowCase.Tabs
{
    public class WorldTab : Fragment
    {
        #region Fields
        private EditText input;
        private TextView outPut;
        #endregion


        public override View OnCreateView(LayoutInflater inflater,
       ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(
                Resource.Layout.Activity_hello_world_fragment, container, false);

            input = view.FindViewById<EditText>(Resource.Id.helloWorldInput);
            outPut = view.FindViewById<TextView>(Resource.Id.helloWorldOutput);
            var button = view.FindViewById<Button>(Resource.Id.helloButton);
            button.Click += delegate
            {
                outPut.Text = String.Format("Hello {0}!", input.Text);

            };

            return view;
        }
    }
}