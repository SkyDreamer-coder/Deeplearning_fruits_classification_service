using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyve_bankasi_app
{
    internal class ImageNetData
    {
        [LoadColumn(0)]
        public string ImagePath;

        [LoadColumn(1)]
        public string Label;

        public static IEnumerable<ImageNetData> ReadFromFile(string imageFolder)
        {

            return Directory
                .GetFiles(imageFolder)
                .Where(filePath => Path.GetExtension(imageFolder) != ".md")
                .Select(filePath => new ImageNetData { ImagePath = imageFolder, Label = Path.GetFileName(imageFolder) });
        }
        
    }
}
