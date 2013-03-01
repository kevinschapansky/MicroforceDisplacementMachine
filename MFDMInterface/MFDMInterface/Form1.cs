using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFDMInterface
{
    public partial class Form1 : Form
    {
        private StageController MovementController;
        public Form1()
        {
            InitializeComponent();
            MovementController = new StageController();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
