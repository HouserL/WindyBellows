using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindyBellows
{
    public partial class frmMonster : Form
    {
        public Monster Monster { get; set; }
        public frmMonster()
        {
            InitializeComponent();
        }

        private void FrmMonster_Load(object sender, EventArgs e)
        {
            if (Monster != null) { LoadMonster(); }
            else { NewMonster(); }
        }
        private void LoadMonster()
        {
            //txtName
            rtbName.Text = Monster.Name;
            rtbSize.Text = Monster.Size + ", " + Monster.Type + ' ' + Monster.Alignment;
            rtbAC.Text = Monster.AC;
            rtbHP.Text = Monster.AverageHP().ToString() + " (" + Monster.HitDie.ToString() + "d"
                + Monster.HitDieValue.ToString();
            //switch (Convert.ToInt32(Monster.Stats))
            //{
            //    case < 10: rtbHP.Text += ((Monster.Stats.CON / 2 - 5) * -1).ToString(); break;
            //    case 10 or 11: break;
            //    case > 11: rtbHP.Text += ((Monster.Stats.CON / 2) - 5).ToString(); break;
            //    default:
            //}
        }
        private void NewMonster()
        {
            rtbName.ReadOnly = false;
        }

        private void TxtName_Click(object sender, EventArgs e)
        {
            if (rtbName.ReadOnly != false)
            {
                //txtName.
            }
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hwnd);
        private void RtbReSize(object sender, ContentsResizedEventArgs e)
        {

            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
              e.NewRectangle.Width + margin,
            e.NewRectangle.Height + margin);
        }

        private void RtbGotFocus(object sender, EventArgs e)
        {
            RichTextBox rch = sender as RichTextBox;
            if (rch.ReadOnly != false)
            {
                HideCaret(rch.Handle);
            }
        }

    }
}
