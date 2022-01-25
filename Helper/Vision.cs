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
