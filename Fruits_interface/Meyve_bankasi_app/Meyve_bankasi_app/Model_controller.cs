using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace Meyve_bankasi_app
{
    internal class Model_controller:Imodel_initiliazer
    {

        private string _imageFolder;
        private readonly MLContext mLContext;
        public Model_controller(string imageFolder)
        {
            _imageFolder = imageFolder;
        }

        public void predict()
        {
            IEnumerable<ImageNetData> images = ImageNetData.ReadFromFile(_imageFolder);
            IDataView imageDataView = mLContext.Data.LoadFromEnumerable(images);

            var modelScorer = new OnnxModelScorer(_imageFolder, "C:\\Users\\Ryko\\Desktop\\Tez_uygulama\\Fruits_model_training\\tmp_model\\Cherrymodel.onnx", mLContext);

            IEnumerable<float[]> probabilities = modelScorer.Score(imageDataView);

        }

    }

}
