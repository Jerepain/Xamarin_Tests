using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Xamarin_Tests;
using Xamarin_Tests.Droid;

[assembly: ExportRenderer(typeof(FontAwesomeLabel), typeof(FontAwesomeLabelRenderer))]
namespace Xamarin_Tests.Droid
{
    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var label = Control;
            Typeface font;
            try
            {
                font = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/fontawesome-webfont.ttf");
                label.Typeface = font;
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("TTF file not found. Make sure the Android project contains it at '/Assets/Fonts/fontawesome-webfont.ttf'.");
            }

        }
    }
}