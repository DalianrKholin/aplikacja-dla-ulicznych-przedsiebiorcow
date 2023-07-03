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
    public partial class Form1 : VirtualForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        protected override void RejectButton_Click(object sender, EventArgs e)
        {
            base.RejectButton_Click(sender, e);
        }
        protected override void makeAcction()
        {
            base.makeAcction();
        }
        protected override void AcceptButton_Click(object sender, EventArgs e)
        {
            base.AcceptButton_Click(sender, e);
        }
    }
}
