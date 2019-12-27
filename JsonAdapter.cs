using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileManager
{
    /// <summary>
    /// Class <c>JsonAdapter</c>
    /// Json文件操作
    /// </summary>
    class JsonAdapter
    {
        /// <summary>
        /// method <c>MapForm</c> 
        /// 获取省市区json数据
        /// </summary> 
        internal static void GetProvince(System.Windows.Forms.ComboBox comboBox, string json, string state, string admin)
        {
            try
            {
                JsonData jsond = JsonMapper.ToObject(json);
                IDictionary dict = jsond as IDictionary;
                comboBox.Items.Clear();
                foreach (string key in dict.Keys)
                {
                    if (admin.Equals("a"))
                    {
                        if (key != "c")
                        {
                            ComboxModel comboxModel = new ComboxModel();
                            comboxModel.Value = key;
                            comboxModel.Text = jsond[key].ToString();
                            comboxModel.Json = jsond[key].ToJson();
                            comboBox.Items.Add(comboxModel);
                        }
                    }
                    else if (key.Contains(state))
                    {
                        ComboxModel comboxModel = new ComboxModel();
                        comboxModel.Value = key;
                        comboxModel.Text = jsond[key][admin].ToString();
                        comboxModel.Json = jsond[key].ToJson();
                        comboBox.Items.Add(comboxModel);
                    }
                }
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }

            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
