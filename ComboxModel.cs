using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    /// <summary>
    ///  Class 
    ///  <c>ComboxModel</c> 
    ///  Combobox item类
    /// </summary>
    class ComboxModel
    {
        private string text;
        private string value;
        private string json;

        public string Text { get => text; set => text = value; }
        public string Value { get => value; set => this.value = value; }
        public string Json { get => json; set => json = value; }

        public override string ToString()
        {
            return Text;
        }
    }
}
