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
        public Monster _monster { get; set; }
        public frmMonster()
        {
            InitializeComponent();
        }

        private void frmMonster_Load(object sender, EventArgs e)
        {
            if (_monster != null) { LoadMonster(); }
            else { NewMonster(); }
        }
        private void LoadMonster()
        {
            //txtName
            rtbName.Text = _monster.Name;
            rtbSize.Text = _monster.Size + ", " + _monster.Type + ' ' + _monster.alignment;
            rtbAC.Text = _monster.AC;
            rtbHP.Text = _monster.AverageHP().ToString() + " (" + _monster.HitDie.ToString() + "d"
                + _monster.HitDieValue.ToString();
            switch (Convert.ToInt32(_monster.Stats))
            {
                case < 10:  rtbHP.Text += ((_monster.Stats.CON / 2 - 5)* -1).ToString(); break; 
                case 10 or 11:  break; 
                case > 11: rtbHP.Text += (_monster.Stats.CON / 2 - 5).ToString(); break;
                default:
            }
        }
        private void NewMonster()
        {
            rtbName.ReadOnly = false;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if(rtbName.ReadOnly != false)
            {
                //txtName.
            }
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hwnd);
        private void rtbReSize(object sender, ContentsResizedEventArgs e)
        {

            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
              e.NewRectangle.Width + margin,
            e.NewRectangle.Height + margin);
        }

        private void rtbGotFocus(object sender, EventArgs e)
        {
            
            RichTextBox rch = sender as RichTextBox;
            if(rch.ReadOnly != false)
            {
                HideCaret(rch.Handle);
            }
        }

    }
}
