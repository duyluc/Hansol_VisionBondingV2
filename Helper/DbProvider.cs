using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LiteDB;

namespace Hansol_VisionBondingV2.Helper
{
    public class Database
    {

    }
    public class DbHelper
    {
        static public string DatabaseFolderPath = ".\\Database";
        static public string DbModel = Path.Combine(DatabaseFolderPath,"Model.db");

        class Model
        {
            public int Id { get; set; }
            public string ModelName { get; set; }
        }
        class CamParams
        {
            public enum CameraType
            {
                AreaScan,
                LineScan,
            }
            public int Id { get; set; }
            public string CameraName { get; set; }
            public string CameraSerial { get; set; }
            public CameraType Camtype { get; set; }
            public int Exposure { get; set; }
            public int OriginX { get; set; } = 0;
            public int OriginY { get; set; } = 0;
            public int ImageWidth { get; set; } = 2048;
            public int ImageHeight { get; set; }
            public int LazerPower { get; set; } = 100;
            public int Brightness { get; set; } = 20;
        }
    }
}
