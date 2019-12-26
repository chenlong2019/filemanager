using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileManager
{
    /// <summary>Class <c>JsonAdapter</c> Json文件操作</summary>
    class JsonAdapter
    {
        /// <summary>method <c>MapForm</c> 获取省市区json数据</summary> 
        internal static JsonData GetProvince(System.Windows.Forms.ComboBox list_cb_province)
        {
            try
            {
                JsonData jsond = JsonMapper.ToObject(File.ReadAllText("Resources/provicecityarea.json"));
               
                for (int i = 0; i < jsond.Count; i++)
                {
                    JsonData msg = jsond[i];
                    Console.WriteLine(msg.ToJson());
                    string province = msg["p"].ToString();
                    list_cb_province.Items.Add(province);
                    if (list_cb_province.Items.Count != 0)
                    {
                        list_cb_province.SelectedIndex = 0;
                    }
                    Console.WriteLine(province);
                }
                    return jsond;
            }
            catch
            {
                return "";
            }
        }

        internal static void GetCity(string province)
        {
            throw new NotImplementedException();
        }
    }
}
