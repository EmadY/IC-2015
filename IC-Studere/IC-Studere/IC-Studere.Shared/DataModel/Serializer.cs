using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace IC_Studere.DataModel
{
    public class Serializer
    {
        private const string JSONFILENAME = "DummyData.json";
        private static List<Course> Courses;

        private async Task readJsonAsync()
        {
            string content = String.Empty;
            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);
            using (StreamReader reader = new StreamReader(myStream))
        {
    content = await reader.ReadToEndAsync();

      }
        }
    }
}
