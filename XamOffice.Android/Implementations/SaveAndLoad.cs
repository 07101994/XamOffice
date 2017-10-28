using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamOffice.Standard.Abstractions;
using XamOffice.Droid.Implementations;

[assembly: Xamarin.Forms.Dependency(typeof(SaveAndLoad))]
namespace XamOffice.Droid.Implementations
{
	public class SaveAndLoad : ISaveAndLoad
	{
		public Task<Stream> GetLocalFileInputStreamAsync(string fileName)
		{
			string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			FileStream fileStream = new FileStream(Path.Combine(folderPath, fileName), FileMode.Open);
			return Task<Stream>.Factory.StartNew(() => fileStream);
		}

		public Task<Stream> GetLocalFileOutputStreamAsync(string fileName)
		{
			string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			FileStream fileStream = new FileStream(Path.Combine(folderPath, fileName), FileMode.Create, FileAccess.ReadWrite, FileShare.None);
			return Task<Stream>.Factory.StartNew(() => fileStream);
		}
	}
}