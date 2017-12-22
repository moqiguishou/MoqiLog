using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace moqi_log
{
    public partial class MoqiLog : Form
    {
        string strLog_path = "", strLog_add = "";
        public MoqiLog()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            get_LogPath();
            get_LogAdd();
            if (strLog_path.Equals("") || strLog_add.Equals("")) {
                return;
            }
            //-------------------------------------------------//
            try
            {
                FileStream fs = new FileStream(strLog_path, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                //sw.WriteLine("");
                sw.WriteLine(strLog_add);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (IOException _e)
            {
                text_Add.Text = _e.ToString();
            }
        }

        private void btn_ShowDetails_Click(object sender, EventArgs e)
        {
            if (strLog_path.Equals(""))
            {
                return;
            }
            //------------------------------------------------//
            FileStream fs = new FileStream(strLog_path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string line;
            string result_details = "";
            while ((line = sr.ReadLine()) != null) {
                result_details = result_details + line + "\r\n";
            }
            sr.Close();
            fs.Close();
            text_LogDetails.Text = result_details;
        }

        private void get_LogAdd()
        {
            strLog_add = text_Add.Text;
        }

        private void get_LogPath()
        {
            //if (text_LogPath.Text != "") {
            //    return text_LogPath.Text;
            //}
            //return "";
            strLog_path = text_LogPath.Text;
        }
    }
}
