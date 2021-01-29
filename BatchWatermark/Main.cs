using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XS.Core;
using XS.Core.FSO;

namespace BatchWatermark
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            XS.Core.Log.InfoLog.Info("系统已启动:"+DateTime.Now);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sImgMarkFullPath = txtSyPath.Text.Trim();
            dlgShowScanInfo = ShowScanInfo;
            sInPath = txtSourePath.Text;
            sOutPath = txtOutPath.Text.Trim();
            Imgquality = tbImgquality.Value;
            WatermarkPlace = tbWatermarkPlace.Value;
            Watermarktransparency = tbWatermarktransparency.Value;

            Thread st = new Thread(() =>
            {
                ScanFiles(sInPath);
                lbFindingInfo.Invoke(dlgShowScanInfo, "所有文件生成完毕！");
            });
            st.Start();


        }

        private void ShowScanInfo(string sInfo)
        {
            lbFindingInfo.Text = sInfo;
        }
        private delegate void DelegateShowInfo(string info);//用来在扫描过程中回调
        private DelegateShowInfo dlgShowScanInfo;
        private string[] aScanFileType= {".png",".jpg", ".jpeg" };
        private void ScanFiles(string filepath)
        {
            if (filepath.Trim().Length > 0)
            {

                string[] filecollect = null;
                try
                {
                    lbFindingInfo.Invoke(dlgShowScanInfo, string.Concat("正在计算列表:", filepath));
                    filecollect = Directory.GetFileSystemEntries(filepath);

                     
                }
                catch (Exception ex)
                {
                    XS.Core.Log.ErrorLog.ErrorFormat("在获取计算时发生错误:{0}", ex.ToString());
                    //MessageBox.Show("出错了！" + ex.Message);
                    //ex.ToString();
                }

                if (!Equals(filecollect, null))
                {
                    foreach (string file in filecollect)
                    {

                        //lbFindingInfo.Invoke(dlgShowScanInfo, file);

                        if (Directory.Exists(file))
                        {
                            ScanFiles(file);
                        }
                        else
                        {
                            try
                            {
                                foreach (string file_extend in aScanFileType)
                                {
                                    if (file.EndsWith(file_extend))
                                    {
                                        AddSignPic(file);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                XS.Core.Log.ErrorLog.ErrorFormat("生成水印图发生错误:{0}", ex.ToString());

                            }
                            

                        }
                    }
                }


            }
        }
        private string sInPath;
        private string sOutPath;
        private string sImgMarkFullPath;
        private int WatermarkPlace = 5;//图片水印位置 图片附件添加水印 0=不使用 1=左上 2=中上 3=右上 4=左中 ... 9=右下
        private int Imgquality =100;//加水印后的质量0~100,数字越大质量越高
        private int Watermarktransparency = 50; //水印图透明度0-10
        private void AddSignPic(string sFilePath)
        {
            //FileStream streamFile = new FileStream(strSaveFullPath, FileMode.Create, FileAccess.Write);
            string SavePath = string.Concat(sOutPath, sFilePath.Replace(sInPath, "")) ;

            XS.Core.FSO.FObject.ExistsDirectory(SavePath);

            Image img = Image.FromFile(sFilePath, true);
            //img.Save(strSaveFullPath.Replace(".", "test."));
            WaterImg.ImageWaterMarkPic(img, SavePath,
                sImgMarkFullPath,
                 WatermarkPlace,
                 Imgquality,
                Watermarktransparency);

            lbFindingInfo.Invoke(dlgShowScanInfo, string.Format("生成完毕:{0}", SavePath));
        }

        private void btnSelIn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog(); 
            fld.ShowDialog();
            txtSourePath.Text = fld.SelectedPath.Trim();
        }

        private void btnSelOut_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//c#实现的类，代码关键 
            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                txtSyPath.Text = openFileDialog.FileName;
            }
            
        }

        private void btnSelOutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();
            fld.ShowDialog();
            txtOutPath.Text = fld.SelectedPath.Trim();
        }
    }
}
