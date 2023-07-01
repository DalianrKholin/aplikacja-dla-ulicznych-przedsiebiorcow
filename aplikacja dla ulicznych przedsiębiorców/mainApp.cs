using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacja_dla_ulicznych_przedsiębiorców
{
    public partial class mainApp : Form
    {
        public mainApp()
        {
            enterApp login = new enterApp(this);
            login.ShowDialog();
            InitializeComponent();

        }
    }
}
