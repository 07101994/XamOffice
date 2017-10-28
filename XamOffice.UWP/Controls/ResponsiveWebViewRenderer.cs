using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamOffice.UWP.Controls;

[assembly: ExportRenderer(typeof(WebView), typeof(ResponsiveWebViewRenderer))]
namespace XamOffice.UWP.Controls
{
	public class ResponsiveWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (Control != null)
			{
				Control.Settings.IsJavaScriptEnabled = true;
				
			}
		}
	}
}
