using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public partial class ListRowResultPanel : Component
    {
        public ListRowResultPanel()
        {
            InitializeComponent();
        }

        public ListRowResultPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
