using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro;
using System.IO;
namespace Hansol_VisionBondingV2.Helper
{
    public class VisionOperator
    {
        private List<ToolBlock> _toolBlockList = new List<ToolBlock>();
        static public int ToolBlockAmount = 8;
        public class ToolBlock
        {
            public string Path { get; set; }
            public Cognex.VisionPro.ToolBlock.CogToolBlock Subject { get; set; }
            public object Clone()
            {
                return this.MemberwiseClone();
            }
        }
        #region VisionObjec
        private CogAcqFifoTool _cam3D;
        public CogAcqFifoTool Cam3D
        {
            get
            {
                return _cam3D;
            }

            set
            {
                _cam3D = value;
            }
        }
        /// <summary>
        /// Danh sach cac doi tuong chua toolblock
        /// </summary>
        public List<ToolBlock> ToolBlockList
        {
            get
            {
                return _toolBlockList;
            }

            set
            {
                _toolBlockList = value;
            }
        }
        public List<string> ToolNameList = new List<string>();
        #endregion
        public VisionOperator()
        {
            InitializeVision();
        }
        public bool InitializeVision()
        {
            try
            {
                ///Load ConfileCamera
                VisionHepler.LoadCamConfig(Cam3D);
                if (!Directory.Exists(VisionHepler.SampleFileFolderPath)) Directory.CreateDirectory(VisionHepler.SampleFileFolderPath);
                if (!Directory.Exists(VisionHepler.RunToolFolderPath)) Directory.CreateDirectory(VisionHepler.RunToolFolderPath);
                if (!Directory.Exists(VisionHepler.ImageStoreFolerPath)) Directory.CreateDirectory(VisionHepler.ImageStoreFolerPath);
                return true;
            }
            catch(Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }
    }
    public class VisionHepler
    {
        static public string VisionFolderPath = ".\\Vision";
        static public string SampleFileFolderPath = Path.Combine(VisionFolderPath, "SampleFile");
        static public string RunToolFolderPath = Path.Combine(VisionFolderPath, "RunToolFile");
        static public string ImageStoreFolerPath = Path.Combine(VisionFolderPath, "ImageStore");
        static public string CamConfigFilePath = Path.Combine(SampleFileFolderPath, "CAMConfig.vpp");
        /// <summary>
        /// Save Toolblock vao file
        /// </summary>
        /// <param name="toolname"></param>
        /// <param name="tool"></param>
        /// <returns></returns>
        static public bool SaveToolBlock(string toolname, Cognex.VisionPro.ToolBlock.CogToolBlock tool)
        {
            if (!SaveVppFile(Path.Combine(RunToolFolderPath, toolname), tool)) return false;
            return true;
        }
        /// <summary>
        /// Load Toolblock tu file vpp vao Toollist
        /// </summary>
        /// <param name="toollist"></param>
        /// <param name="toolnamelist"></param>
        /// <returns></returns>
        static public bool LoadToolBlock(List<VisionOperator.ToolBlock> toollist,List<string> toolnamelist)
        {
            try
            {
                if(toolnamelist == null) ProgramHelper.ThrowEx("ToolNameList is Null!");
                if(toolnamelist.Count != VisionOperator.ToolBlockAmount) ProgramHelper.ThrowEx("ToolNameList is invalid!");
                if (toollist == null) ProgramHelper.ThrowEx("ToolList is Null!");
                toollist.Clear();
                //Load toolblock
                string report = "";
                bool result = true;
                foreach(string path in toolnamelist)
                {
                    VisionOperator.ToolBlock _ = null;
                    try
                    {
                        Cognex.VisionPro.ToolBlock.CogToolBlock subject = LoadVppFile(Path.Combine(RunToolFolderPath,path)) as Cognex.VisionPro.ToolBlock.CogToolBlock;
                        if (subject == null) ProgramHelper.ThrowEx("");
                         _ = new VisionOperator.ToolBlock
                         {
                             Path = path,
                             Subject = subject
                        };
                        report += $"Load {path} -- OK\n";
                    }
                    catch
                    {
                        _ = new VisionOperator.ToolBlock()
                        {
                            Path = path
                        };
                        report += $"Load {path} -- NG\n";
                        result = false;
                    }
                    finally
                    {
                        toollist.Add(_);
                    }
                }
                System.Windows.Forms.MessageBox.Show(report);
                return result;
            }
            catch(Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }
        /// <summary>
        /// Tao danh sach ten toolblock
        /// </summary>
        /// <param name="modelname"></param>
        /// <param name="toolnamelist"></param>
        /// <returns></returns>
        static public bool GetToolNameList(string modelname,List<string> toolnamelist)
        {
            if (toolnamelist == null) return false;
            toolnamelist.Clear();
            for(int i = 0; i < 8; i++)
            {
                string _ = modelname + $"_Tool{i + 1}.vpp";
                toolnamelist.Add(_);
            }
            return true;
        }
        static public bool LoadCamConfig(CogAcqFifoTool cam)
        {
            try
            {
                //<----------------------------------------------------------->
                cam = LoadVppFile(CamConfigFilePath) as CogAcqFifoTool;
                if (cam == null) ProgramHelper.ThrowEx("Can not load ConfigFile!");
                return true;
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
        }
        static public object LoadVppFile(String filepath)
        {
            try
            {
                object result = CogSerializer.LoadObjectFromFile(filepath);
                return result;
            }
            catch(Exception t)
            {
                ProgramHelper.WriteLog(t);
                return null;
            }
        }
        static public bool SaveVppFile(String filepath,Cognex.VisionPro.ToolBlock.CogToolBlock _object)
        {
            try
            {
                CogSerializer.SaveObjectToFile(_object,filepath);
                return true;
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t,true,true);
                return false;
            }
        }
    }
}
