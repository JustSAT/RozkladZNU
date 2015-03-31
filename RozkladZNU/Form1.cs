using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace RozkladZNU
{
    public partial class Form1 : Form
    {
        public Departments departmentObjects;
        public Groups groupObjects;

        private int selectedDepartmentId = -1;
        private int selectedGroupId = -1;


        public bool isDepartmentSync = false;
        public bool isGroupSync = false;


        string apiRequestLink = "http://rozkladznu.pp.ua/api/v1/department/?format=json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string result = GetRequestResult(apiRequestLink);
            
            departmentObjects = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Departments>(result);
            foreach (var item in departmentObjects.objects)
            {
                departmentsList.Items.Add(item.name);
            }
            isDepartmentSync = true;

            result = GetRequestResult("http://rozkladznu.pp.ua/api/v1/group/?format=json");
            groupObjects = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Groups>(result);
            isGroupSync = true;

        }




        public string GetRequestResult()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiRequestLink);
                request.Method = "GET";
                request.ContentType = "text/json";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string result;
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.ToString());
                return ex.ToString();
            }
        }
        public string GetRequestResult(string link)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Method = "GET";
                request.ContentType = "text/json";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string result;
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.ToString());
                return ex.ToString();
            }
        }
        public int GetDepIdByName(string name)
        {
            if (isDepartmentSync)
            {
                foreach (var item in departmentObjects.objects)
                {
                    if (item.name == name)
                    {
                        return item.id;
                    }
                }
                MessageBox.Show("Exception:" + " не знайшов ключ факультету в данних які мені доступні.");
            }
            return -1;
        }
        private void departmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDepartmentId = GetDepIdByName(departmentsList.SelectedItem.ToString());
        }

        private void stepsElement_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {

        }

        private void groupsTab_Enter(object sender, EventArgs e)
        {
            groupList.Items.Clear();
            foreach (var item in groupObjects.objects)
            {
                if (selectedDepartmentId != -1)
                {
                    if (item.department_id == selectedDepartmentId)
                    {
                        groupList.Items.Add(item.name);
                    }
                }
                else
                {
                    groupList.Items.Add(item.name);
                }
            }

        }
    }
}
