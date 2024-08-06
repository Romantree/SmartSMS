using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views
{
    public partial class MessageView : UserControl
    {
        public MessageView()
        {
            InitializeComponent();
        }

        private void MessageView_Load(object sender, EventArgs e)
        {
            roundBorderPanel1.borderColor=Color.White;
        }
    }
}
