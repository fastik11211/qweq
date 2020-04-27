using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiemensProgram.ServisNastr
{
    public partial class ServNastr19Dzm2 : ServNastr18Dzm1
    {
        public ServNastr19Dzm2()
        {
            InitializeComponent();
        }

        private void ServNastr19Dzm2_Load(object sender, EventArgs e)
        {
            label6.Visible = !true;
            textBox4.Visible = !true;
        }
    }
}
