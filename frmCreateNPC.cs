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


    public partial class frmCreateNPC : Form
    {
        public int _STR
        {
            get
            {
                return Convert.ToInt32(txtSTR.Text);
            }
            set
            {
                txtSTR.Text = value.ToString();
            }
        }
        public int stat;
        public frmCreateNPC()
        {
            InitializeComponent();
        }

        private void btnCreateNPC_Click(object sender, EventArgs e)
        {
            try
            {
                // Add new NPCs to list with inserted values need to make sure if text boxs void
                // that it throws error.
                NPC _NPC = new NPC();
                BaseStats _stats = new BaseStats
                {
                    STR = Convert.ToByte(txtSTR.Text.ToString()),
                    CON = Convert.ToByte(txtCON.Text.ToString()),
                    DEX = Convert.ToByte(txtDEX.Text.ToString()),
                    WIS = Convert.ToByte(txtWIS.Text.ToString()),
                    INT = Convert.ToByte(txtINT.Text.ToString()),
                    CHR = Convert.ToByte(txtCHR.Text.ToString()),
                };

                _NPC.Old_AC = Convert.ToInt32(txtAC.Text.ToString());
                _NPC.Level = Convert.ToInt32(txtLevel.Text.ToString());
                _NPC.Old_Preception = Convert.ToInt32(txtPassive.Text.ToString());
                _NPC.Name = txtName.Text.ToString();
                _NPC.Occupation = txtOccupation.Text.ToString();
                _NPC.Race = txtRace.Text.ToString();
                _NPC.HP = Convert.ToInt32(txtHP.Text.ToString());
                _NPC.Stats = _stats;

                for (int i = 0; i < frmMain._comp.NPCs.Count; i++)
                {
                    //see if NPCs already exists and remove or update it.
                    if (_NPC.Name.Equals(frmMain._comp.NPCs[i].Name))
                    {
                        DialogResult dialogResult = MessageBox.Show("NPCs with this Name already exist would you like to " +
                            "overwrite current NPCs?", "NPCs Creator", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            frmMain._comp.NPCs.Remove(frmMain._comp.NPCs[i]);

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                frmMain._comp.NPCs.Add(_NPC);
                frmMain._comp.NPCs.Sort((x, y) => string.Compare(x.Name, y.Name));
                frmMain.SaveNPCBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnRandomStats_Click(object sender, EventArgs e)
        {

            txtSTR.Text = RandomStatRoll().ToString();
            txtDEX.Text = RandomStatRoll().ToString();
            txtCON.Text = RandomStatRoll().ToString();
            txtINT.Text = RandomStatRoll().ToString();
            txtWIS.Text = RandomStatRoll().ToString();
            txtCHR.Text = RandomStatRoll().ToString();
        }

        private void btnRandomRace_Click(object sender, EventArgs e)
        {
            txtRace.Text = Table.RunTable(frmMain._comp.Tables, frmMain._comp.Tables[Properties.Settings.Default.tblRace]);
        }

        private int RandomStatRoll()
        {   
            int d1 = Table.RandomNumberSeeded(6);
            int d2 = Table.RandomNumberSeeded(6);
            int d3 = Table.RandomNumberSeeded(6);
            int d4 = Table.RandomNumberSeeded(6);
            return Convert.ToByte(d1 + d2 + d3 + d4 - Math.Min(d1, Math.Min(d2, Math.Min(d3, d4))));// Create a better method for this?
        }

        private void CreateNPC_Load(object sender, EventArgs e)
        {
            // need to just set this up in main and call from there
            // need to youse app coinfigs to set tables and create a settings file for what tables to run.
            //_table = SerializableObjectBase.FromFile<TableBase>(@"C:\Program Files (x86)\Compendium\Tables.xml");
        }

        private void btnToNPCLayout_Click(object sender, EventArgs e)
        {
            //frmNPCLayout form = new frmNPCLayout();
            try
            {
                // Add new player to list with inserted values need to make sure if text boxs void
                // that it throws error temp right now for creating basic stats for a player for client.
                Player _Player = new Player();
                BaseStats _stats = new BaseStats
                {
                    STR = Convert.ToByte(txtSTR.Text.ToString()),
                    CON = Convert.ToByte(txtCON.Text.ToString()),
                    DEX = Convert.ToByte(txtDEX.Text.ToString()),
                    WIS = Convert.ToByte(txtWIS.Text.ToString()),
                    INT = Convert.ToByte(txtINT.Text.ToString()),
                    CHR = Convert.ToByte(txtCHR.Text.ToString()),
                };

                _Player.Old_AC = Convert.ToByte(txtAC.Text.ToString());
                _Player.Level = Convert.ToByte(txtLevel.Text.ToString());
                _Player.Old_Preception = Convert.ToInt32(txtPassive.Text.ToString());
                _Player.Name = txtName.Text.ToString();
                //_Player.Occupation = txtOccupation.Text.ToString();
                //_Player.Race = txtRace.Text.ToString();
                _Player.HP = Convert.ToByte(txtHP.Text.ToString());
                _Player.Stats = _stats;

                for (int i = 0; i < frmMain._comp.Players.Count; i++)
                {
                    //see if NPCs already exists and remove or update it.
                    if (_Player.Name.Equals(frmMain._comp.Players[i].Name))
                    {
                        DialogResult dialogResult = MessageBox.Show("Player with this Name already exist would you like to " +
                            "overwrite current Player?", "NPCs Creator", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            frmMain._comp.Players.Remove(frmMain._comp.Players[i]);

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                frmMain._comp.Players.Add(_Player);
                frmMain._comp.Players.Sort((x, y) => string.Compare(x.Name, y.Name));
                frmMain.SavePlayerBase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            int input = Properties.Settings.Default.tblRace;
            ShowInputDialog(ref input, "Race Table Choice");
            Properties.Settings.Default.tblRace = input;
            Properties.Settings.Default.Save();

        }
        private static DialogResult ShowInputDialog(ref int input, string _Title)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = _Title;

            System.Windows.Forms.ComboBox combobox = new ComboBox();
            for (int i = 0; i < frmMain._comp.Tables.Count ; i++)
            {
                combobox.Items.Add(frmMain._comp.Tables[i].Name);
            }
            combobox.Size = new System.Drawing.Size(size.Width - 10, 23);
            combobox.Location = new System.Drawing.Point(5, 5);
            combobox.SelectedIndex = input;
            inputBox.Controls.Add(combobox);
            


            //System.Windows.Forms.TextBox textBox = new TextBox();
            //textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            //textBox.Location = new System.Drawing.Point(5, 5);
            //textBox.Text = input;
            //inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = combobox.SelectedIndex;
            return result;
        }
    }
}
