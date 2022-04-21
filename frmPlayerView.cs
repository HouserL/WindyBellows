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
            for (int i = 0; i < FrmMain._comp.Players.Count; i++)
            {
                toolStripComboBox1.Items.Add(FrmMain._comp.Players[i].Name);
            }
            for (int i = 0; i < FrmMain._comp.NPCs.Count; i++)
            {
                toolStripComboBox2.Items.Add(FrmMain._comp.NPCs[i].Name);
            }
            for (int i = 0; i < FrmMain._comp.Guilds.Count; i++)
            {
                toolStripComboBox3.Items.Add(FrmMain._comp.Guilds[i].Name);
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
            NewUser(FrmMain._comp.Players[toolStripComboBox1.SelectedIndex]);
        }
        private static void LoadUCdata(Player _player, UCBasicPlayerView _UC)
        {
            _UC.lblName.Text = _player.Name.ToString();
            _UC.lblLevel.Text = _player.Level.ToString();
            _UC.lblSTR.Text = _player.Stats.STR.ToString() + " (" + (_player.Stats.STR / 2 - 5).ToString() + ")";
            _UC.lblDEX.Text = _player.Stats.DEX.ToString() + " (" + (_player.Stats.DEX / 2 - 5).ToString() + ")";
            _UC.lblCON.Text = _player.Stats.CON.ToString() + " (" + (_player.Stats.CON / 2 - 5).ToString() + ")";
            _UC.blbWIS.Text = _player.Stats.WIS.ToString() + " (" + (_player.Stats.WIS / 2 - 5).ToString() + ")";
            _UC.lblINT.Text = _player.Stats.INT.ToString() + " (" + (_player.Stats.INT / 2 - 5).ToString() + ")";
            _UC.lblCHR.Text = _player.Stats.CHR.ToString() + " (" + (_player.Stats.CHR / 2 - 5).ToString() + ")";
            _UC.lblAC.Text = _player.Old_AC.ToString();
            _UC.lblPP.Text = _player.Preception.ToString();
            _UC.lblHP.Text = _player.HP.ToString();
        }
        private static void LoadUCdata(NPC _NPC, UCBasicPlayerView _UC)
        {
            _UC.lblName.Text = _NPC.Name.ToString();
            _UC.lblLevel.Text = _NPC.Level.ToString();
            _UC.lblSTR.Text = _NPC.Stats.STR.ToString() + " (" + (_NPC.Stats.STR / 2 - 5).ToString() + ")";
            _UC.lblDEX.Text = _NPC.Stats.DEX.ToString() + " (" + (_NPC.Stats.DEX / 2 - 5).ToString() + ")";
            _UC.lblCON.Text = _NPC.Stats.CON.ToString() + " (" + (_NPC.Stats.CON / 2 - 5).ToString() + ")";
            _UC.blbWIS.Text = _NPC.Stats.WIS.ToString() + " (" + (_NPC.Stats.WIS / 2 - 5).ToString() + ")";
            _UC.lblINT.Text = _NPC.Stats.INT.ToString() + " (" + (_NPC.Stats.INT / 2 - 5).ToString() + ")";
            _UC.lblCHR.Text = _NPC.Stats.CHR.ToString() + " (" + (_NPC.Stats.CHR / 2 - 5).ToString() + ")";
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
            NewUser(FrmMain._comp.NPCs[toolStripComboBox2.SelectedIndex]);
        }

        private void LoadGuildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox3.SelectedIndex == -1)
            {
                return;
            }
            for (int i = 0; i < FrmMain._comp.Players.Count; i++)
            {
                if (FrmMain._comp.Guilds[toolStripComboBox3.SelectedIndex].Players.Contains(FrmMain._comp.Players[i].Name))
                {
                    NewUser(FrmMain._comp.Players[i]);
                }
            }
            for (int i = 0; i < FrmMain._comp.NPCs.Count; i++)
            {
                if (FrmMain._comp.Guilds[toolStripComboBox3.SelectedIndex].NPCs.Contains(FrmMain._comp.NPCs[i].Name))
                {
                    NewUser(FrmMain._comp.NPCs[i]);
                }
            }

        }
    }

}
