using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindyBellows
{
    public partial class UCBasicPlayerView : UserControl
    {
        public UCBasicPlayerView()
        {
            InitializeComponent();
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Name.ToString());
            UCDisposing();
            this.Dispose();
        }
        private void UCDisposing()
        {
            
        }

        private void lblAC_Click(object sender, EventArgs e)
        {

        }

        private void UCBasicPlayerView_Load(object sender, EventArgs e)
        {

        }
    }
}
