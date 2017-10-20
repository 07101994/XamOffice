
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using System;
using System.Threading.Tasks;
using XamOffice.Standard;

namespace XamOffice.Droid
{
	[Activity(Label = "XamOffice", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
			TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;
			AndroidEnvironment.UnhandledExceptionRaiser += AndroidEnvironmentOnUnhandledException;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			try
			{
				LoadApplication(new App());
			}
			catch (Exception exception)
			{
				
			}
		}

		private void AndroidEnvironmentOnUnhandledException(object sender, RaiseThrowableEventArgs e)
		{
			e.Handled = true;
			throw new NotImplementedException();
		}

		private void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
		{
			throw new NotImplementedException();
		}

		private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			throw new NotImplementedException();
		}

	}
}

