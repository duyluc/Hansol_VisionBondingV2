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
                         _ = new VisionOperator.ToolBlock
                        {
                            Path = path,
                            Subject = LoadVppFile(path) as Cognex.VisionPro.ToolBlock.CogToolBlock
                        };
                        report += $"Load {path} -- OK\n";
                    }
                    catch
                    {
                         _ = new VisionOperator.ToolBlock();
                        report += $"Load {path} -- NG\n";
                        result = false;
                    }
                    finally
                    {
                        toollist.Add(_);
                    }
                }
                return result;
            }
            catch(Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
                return false;
            }
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
    }
}
