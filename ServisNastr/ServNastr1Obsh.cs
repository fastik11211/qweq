using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiemensProgram.Skins;
namespace SiemensProgram.ServisNastr
{
    public partial class ServNastr1Obsh : MainSkins
    {
        public ServNastr1Obsh()
        {
            InitializeComponent();
        }

        private void ServNastr1Obsh_Load(object sender, EventArgs e)
        {
            alBut.Visible = !true;
            button1.Visible = !true;
            button2.Visible = !true;
        }
    }
}
