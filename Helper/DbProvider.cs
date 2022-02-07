﻿using System;
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
        //Event Database thay doi
        public delegate void ModelDbChangedDelegate();
        public event ModelDbChangedDelegate ModelDbChange;

        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null) instance = new Database();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

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

        static public bool AddModel(Model model)
        {
            if(model == null)
            {
                ProgramHelper.WriteLog("Master","Selected Model is Null!",true,true);
                return false;
            }
            if (DbHelper.AddModel(model))
            {
                ProgramHelper.WriteLog("Master", "Add new Model successfully!");
                System.Windows.Forms.MessageBox.Show("Add Model Successfully!");
                Instance.ModelDbChange();
                return true;
            }
            else
            {
                ProgramHelper.WriteLog("Master", "Add new Model Fail!");
                System.Windows.Forms.MessageBox.Show("Add Model Fail!");
                Instance.ModelDbChange();
                return false;
            }
            
        }

        static public bool GetModel(List<Model> modelist)
        {
            if (!DbHelper.GetModel(modelist))
            {
                if (Instance.ModelDbChange == null) return false;
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool EditModel(Model model)
        {
            try
            {
                if (model == null) ProgramHelper.ThrowEx("Model is Null!");
                System.Windows.Forms.DialogResult dlg =  System.Windows.Forms.MessageBox.Show($"Edit Model: {model.ModelName}","Warning!",System.Windows.Forms.MessageBoxButtons.YesNo);
                if (dlg != System.Windows.Forms.DialogResult.Yes) return false;
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
            if (DbHelper.EditModel(model))
            {
                instance.ModelDbChange();
                return true;
            }
            instance.ModelDbChange();
            return false;
        }

        static public bool DelModel(Model model)
        {
            try
            {
                if (model == null) ProgramHelper.ThrowEx("Model is Null!");
                System.Windows.Forms.DialogResult dlg = System.Windows.Forms.MessageBox.Show($"Delete Model: {model.ModelName}", "Warning!", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (dlg != System.Windows.Forms.DialogResult.Yes) return false;
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
            if (DbHelper.DeleteModel(model))
            {
                instance.ModelDbChange();
                return true;
            }
            instance.ModelDbChange();
            return false;
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
                    Database.Model buffermodel = col.FindOne(x=>x.ModelName == model.ModelName) as Database.Model;
                    if (buffermodel != null) ProgramHelper.ThrowEx("Model is Already Exits!");
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
        static public bool GetModel(List<Database.Model> modellist)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    modellist.Clear();
                    modellist.AddRange(col.FindAll().ToList());
                }
                if (modellist.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception t)
            {
                modellist.Clear();
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
        static public bool EditModel(Database.Model model)
        {
            try
            {
                if (model == null) ProgramHelper.ThrowEx("Selected Model is Null!");
                Database.Model editmodel;
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    editmodel = col.FindOne(x => x.ModelName == model.ModelName) as Database.Model;
                    if (editmodel == null)
                    {
                        ProgramHelper.ThrowEx("Model is not Exits");
                    }
                    model.Id = editmodel.Id;
                    if (!col.Update(model)) ProgramHelper.CreateEx("Edit Fail!");
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

        static public bool DeleteModel(Database.Model model)
        {
            try
            {
                using (LiteDatabase db = new LiteDatabase(Database.DbModel))
                {
                    var col = db.GetCollection<Database.Model>();
                    Database.Model deletemodel = col.FindOne(x => x.ModelName == model.ModelName) as Database.Model;
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
