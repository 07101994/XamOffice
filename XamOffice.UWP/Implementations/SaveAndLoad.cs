using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;
using XamOffice.Standard.Abstractions;
using XamOffice.UWP.Implementations;

[assembly: Dependency(typeof(SaveAndLoad))]
namespace XamOffice.UWP.Implementations
{
	public class SaveAndLoad : ISaveAndLoad
	{
		public async Task<Stream> GetLocalFileInputStreamAsync(string fileName)
		{
			StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
			StorageFile sampleFile = await storageFolder.GetFileAsync(fileName);
			return await sampleFile.OpenStreamForReadAsync();
		}

		public async Task<Stream> GetLocalFileOutputStreamAsync(string fileName)
		{
			StorageFolder localFolder = ApplicationData.Current.LocalFolder;
			StorageFile saveFile = await localFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
			return await saveFile.OpenStreamForWriteAsync();
		}
	}
}
