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
        static public string DatabaseFolderPath = ".\\Database";
        static public string DbModel = Path.Combine(DatabaseFolderPath, "Model.db");

        public class Model
        {
            public int Id { get; set; }
            public string ModelName { get; set; }
            public CamParams camparams { get; set; }
        }
        public class CamParams
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
    public class DbHelper
    {
        static public bool CheckDbFolderExist(string dbfolderpath, bool CreateNew = false)
        {
            if (!Directory.Exists(dbfolderpath))
            {
                if (CreateNew)
                {
                    Directory.CreateDirectory(dbfolderpath);
                }
                return false;
            }
            return true;
        }
        /// <summary>
        /// Luu model moi vao database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        static public bool AddModel(Database.Model model)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    col.Insert(model);
                }
                return true;
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }
        /// <summary>
        /// Tra ve model tu Database
        /// </summary>
        /// <param name="ModelName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        static public bool GetModel(string ModelName, Database.Model model)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    model = col.Find(x => x.ModelName == ModelName) as Database.Model;
                }
                if (model == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception t)
            {
                model = null;
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }
        /// <summary>
        /// Chinh sua Model
        /// </summary>
        /// <param name="ModelName"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        static public bool EditModel(string ModelName, Database.Model model)
        {
            try
            {
                if (model == null) ProgramHelper.ThrowEx("Selected Model is Null!");
                Database.Model editmodel;
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    editmodel = col.Find(x => x.ModelName == ModelName) as Database.Model;
                    if (editmodel == null)
                    {
                        ProgramHelper.ThrowEx("Model is not Exits");
                    }
                    model.Id = editmodel.Id;
                    col.Update(model);
                    return true;
                }
            }
            catch (Exception t)
            {
                model = null;
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }

        static public bool DeleteModel(string ModelName)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    Database.Model deletemodel = col.Find(x => x.ModelName == ModelName) as Database.Model;
                    if (deletemodel == null)
                    {
                        ProgramHelper.ThrowEx("Model is not Exits");
                    }
                    col.Delete(deletemodel.Id);
                    return true;
                }
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }
    }
}
