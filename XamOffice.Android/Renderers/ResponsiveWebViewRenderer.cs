using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XamOffice.Droid.Renderers;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(WebView), typeof(ResponsiveWebViewRenderer))]
namespace XamOffice.Droid.Renderers
{
	public class ResponsiveWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (Control != null)
			{
				Control.Settings.BuiltInZoomControls = true;
				Control.Settings.DisplayZoomControls = false;

				Control.Settings.LoadWithOverviewMode = true;
				Control.Settings.UseWideViewPort = true;
			}
		}
	}
}