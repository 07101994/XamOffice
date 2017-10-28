using Syncfusion.SfDataGrid.XForms.UWP;
using System.IO;
using Windows.Storage;
using Windows.UI.Xaml.Navigation;

namespace XamOffice.UWP
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			this.InitializeComponent();

			SfDataGridRenderer.Init();
		}

		protected override async void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
			var args = e.Parameter as Windows.ApplicationModel.Activation.IActivatedEventArgs;
			if (args != null)
			{
				if (args.Kind == Windows.ApplicationModel.Activation.ActivationKind.File)
				{
					var fileArgs = args as Windows.ApplicationModel.Activation.FileActivatedEventArgs;
					string strFilePath = fileArgs.Files[0].Path;
					var file = (StorageFile)fileArgs.Files[0];
					Stream stream = await file.OpenStreamForReadAsync();
					LoadApplication(new XamOffice.Standard.App(new Standard.Dtos.DocumentDetails
					{
						Stream = stream,
						Type = Standard.Enums.DocumentType.Docx.ToString()
					}));
				}
			}
			else
			{
				LoadApplication(new XamOffice.Standard.App());
			}
		}
	}
}
