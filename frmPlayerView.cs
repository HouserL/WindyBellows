using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindyBellows.Models;

namespace WindyBellows
{
    public partial class frmPlayerView : Form
    {
        public int indexController;
        public int x;
        public int y;
        public int UserCount;
        public List<string> listUCControls; 
        public frmPlayerView()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChange(object sender, EventArgs e)
        {

        }

        private void FrmPlayerView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Main._comp.Players.Count; i++)
            {
                toolStripComboBox1.Items.Add(Main._comp.Players[i].Name);
            }
            for (int i = 0; i < Main._comp.NPCs.Count; i++)
            {
                toolStripComboBox2.Items.Add(Main._comp.NPCs[i].Name);
            }
            for (int i = 0; i < Main._comp.Guilds.Count; i++)
            {
                toolStripComboBox3.Items.Add(Main._comp.Guilds[i].Name);
            }
            x = 0;
            y = 28;
            UserCount = 0;
        }

        private void NewUser(Player _player)
        {
            UCBasicPlayerView ucPlayerView = new();
            Controls.Add(ucPlayerView);
            if (UserCount < 5)
            {
  
                ucPlayerView.Location = new Point(12 + x, 12 + y);
                //UC1.Click += new System.EventHandler(this.UC_Click);
                x = ucPlayerView.Right;
                UserCount += 1;
            }
            else
            {
                x = 0;
                y += 262;
                UserCount = 1;

                ucPlayerView.Location = new Point(12 + x, 12 + y);
                //UC1.Click += new System.EventHandler(this.UC_Click);
                x = ucPlayerView.Right;
            }
            LoadUCdata(_player, ucPlayerView);
        }
        private void NewUser(NPC _NPC)
        {
            UCBasicPlayerView ucPlayerView = new();
            Controls.Add(ucPlayerView);
            indexController = this.Controls.Count - 1;
            ucPlayerView.Name = "ucPlayerView" + indexController;
            if (UserCount < 5)
            {               
                ucPlayerView.Location = new Point(12 + x, 12 + y);
                //UC1.Click += new System.EventHandler(this.UC_Click);
                x = ucPlayerView.Right;
                UserCount += 1;
            }
            else
            {
                x = 0;
                y += 262;
                UserCount = 1;

                ucPlayerView.Location = new Point(12 + x, 12 + y);
                //UC1.Click += new System.EventHandler(this.UC_Click);
                x = ucPlayerView.Right;
            }
            Console.WriteLine(this.Controls[indexController].Name.ToString());
            LoadUCdata(_NPC, ucPlayerView);
        }
        private void AddPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == -1)
            {
                return;
            }
            NewUser(Main._comp.Players[toolStripComboBox1.SelectedIndex]);
        }
        private static void LoadUCdata(Player _player, UCBasicPlayerView _UC)
        {
            _UC.lblName.Text = _player.Name.ToString();
            _UC.lblLevel.Text = _player.Level.ToString();
            _UC.lblSTR.Text = _player.STR.ToString() + " (" + (_player.STR / 2 - 5).ToString() + ")";
            _UC.lblDEX.Text = _player.DEX.ToString() + " (" + (_player.DEX / 2 - 5).ToString() + ")";
            _UC.lblCON.Text = _player.CON.ToString() + " (" + (_player.CON / 2 - 5).ToString() + ")";
            _UC.blbWIS.Text = _player.WIS.ToString() + " (" + (_player.WIS / 2 - 5).ToString() + ")";
            _UC.lblINT.Text = _player.INT.ToString() + " (" + (_player.INT / 2 - 5).ToString() + ")";
            _UC.lblCHR.Text = _player.CHR.ToString() + " (" + (_player.CHR / 2 - 5).ToString() + ")";
            _UC.lblAC.Text = _player.Old_AC.ToString();
            _UC.lblPP.Text = ""; // removed passive so fix this
            _UC.lblHP.Text = _player.HP.ToString();
        }
        private static void LoadUCdata(NPC _NPC, UCBasicPlayerView _UC)
        {
            _UC.lblName.Text = _NPC.Name.ToString();
            _UC.lblLevel.Text = _NPC.Level.ToString();
            _UC.lblSTR.Text = _NPC.STR.ToString() + " (" + (_NPC.STR / 2 - 5).ToString() + ")";
            _UC.lblDEX.Text = _NPC.DEX.ToString() + " (" + (_NPC.DEX / 2 - 5).ToString() + ")";
            _UC.lblCON.Text = _NPC.CON.ToString() + " (" + (_NPC.CON / 2 - 5).ToString() + ")";
            _UC.blbWIS.Text = _NPC.WIS.ToString() + " (" + (_NPC.WIS / 2 - 5).ToString() + ")";
            _UC.lblINT.Text = _NPC.INT.ToString() + " (" + (_NPC.INT / 2 - 5).ToString() + ")";
            _UC.lblCHR.Text = _NPC.CHR.ToString() + " (" + (_NPC.CHR / 2 - 5).ToString() + ")";
            _UC.lblAC.Text = _NPC.Old_AC.ToString();
            _UC.lblPP.Text = _NPC.Old_Preception.ToString();
            _UC.lblHP.Text = _NPC.HP.ToString();
        }

        private void AddNPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedIndex == -1)
            {
                return;
            }
            NewUser(Main._comp.NPCs[toolStripComboBox2.SelectedIndex]);
        }

        private void LoadGuildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox3.SelectedIndex == -1)
            {
                return;
            }
            for (int i = 0; i < Main._comp.Players.Count; i++)
            {
                if (Main._comp.Guilds[toolStripComboBox3.SelectedIndex].Players.Contains(Main._comp.Players[i].Name))
                {
                    NewUser(Main._comp.Players[i]);
                }
            }
            for (int i = 0; i < Main._comp.NPCs.Count; i++)
            {
                if (Main._comp.Guilds[toolStripComboBox3.SelectedIndex].NPCs.Contains(Main._comp.NPCs[i].Name))
                {
                    NewUser(Main._comp.NPCs[i]);
                }
            }

        }
    }

}
