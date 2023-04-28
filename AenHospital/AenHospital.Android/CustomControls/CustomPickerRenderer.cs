using AenHospital.CustomControls;
using AenHospital.Droid.CustomControls;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]


namespace AenHospital.Droid.CustomControls
{
    [Obsolete]
    public class CustomPickerRenderer : PickerRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {

                var viewData = (CustomPicker)Element;

                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(30f);
                gradientDrawable.SetStroke(4, viewData.BorderColor.ToAndroid());
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);

                Control.SetPadding(30,30,30,30);
                Control.SetBackground(gradientDrawable);

               
            }

            
        }

     

    }
}