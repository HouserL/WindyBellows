using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindyBellows
{
    public partial class frmMain : Form
    {
        public static Compendium _comp;
        public OldCompendium _oldComp;
        //public static TableBase _table;
        //public static PlayerBase _play;
        //public static Compendium _comp;
        //public static MonsterBase _mons;
        //public static NPCBase _NPC;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmPlayerView_Load(object sender, EventArgs e)
        {
            if (!File.Exists("./Compendium.xml"))
            {
                File.Create("./Compendium.xml");
                _comp = new Compendium();
                _comp.Monsters = new List<Monster>();
                _comp.Players = new List<Player>();
                _comp.Tables = new List<Table>();
                _comp.NPCs = new List<NPC>();
            }
            else
            {
                _comp = SerializableObjectBase.FromFile<Compendium>(@"./Compendium.xml");
            }
            for (int i = 0; i < _comp.Monsters.Count; i++)
            {
                comboBox1.Items.Add(_comp.Monsters[i].Name);
            }
            
        }
        private void btnCreateNPC_Click(object sender, EventArgs e)
        {
            frmCreateNPC form = new frmCreateNPC();
            form.Show();
            form._STR = 6;
        }
        private void savePlayerBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SavePlayerBase();
        }
        public static void SavePlayerBase()
        {
            _comp.WriteToFile("./Compendium.xml");
        }
        public static void SaveNPCBase()
        {
            //_NPC.WriteToFile(@"C:\Program Files (x86)\Compendium\NPCs.xml");
        }
        private void ConvertMonsters()
        {
            //Hate this block 
            //Convert old compendium array of items to catorigized values       
            try
            {
                int _monsterIndex = -1;
                bool _monsterExists = false;
                for (int i = 0; i < _oldComp.MonsterTypes.Count; i++)
                {
                    //switch (_oldComp.MonsterTypes[0].ItemsElementName[i].ToString())
                    //{
                    //    case "Name": break;
                    //    default: break;
                    //} // Convert lower code to this code
                    //if(i == 3007)
                    //{
                    //use to find errors inside of code
                    //}
                    Monster _monster = new Monster();
                    for (int j = 0; j < _oldComp.MonsterTypes[i].Items.Length; j++)
                    {
                        if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "name")
                        {
                            _monster.Name = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "size")
                        {
                            _monster.Size = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "type")
                        {
                            _monster.Type = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "Alignment")
                        {
                            _monster.Alignment = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "ac")
                        {
                            _monster.AC = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "speed")
                        {
                            _monster.Speed = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "str")
                        {
                            BaseStats _stats = new BaseStats();
                            _stats.STR = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                            j++;
                            _stats.DEX = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                            j++;
                            _stats.CON = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                            j++;
                            _stats.INT = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                            j++;
                            _stats.WIS = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                            j++;
                            _stats.CHR = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                            _monster.Stats = _stats;
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "cr")
                        {
                            _monster.CR = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "trait")
                        {
                            CompendiumBaseItem _oldBase = _oldComp.MonsterTypes[i].Items[j] as CompendiumBaseItem;
                            BaseItem _baseitem = new BaseItem();
                            _baseitem.Name = _oldBase.Name.ToString();
                            _baseitem.Description = _oldBase.Text.ToString();
                            if (_monster.Trait == null)
                            {
                                _monster.Trait = new List<BaseItem>(); // make sure list have been made for items
                            }
                            _monster.Trait.Add(_baseitem);
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "action")
                        {
                            CompendiumBaseItem _oldBase = _oldComp.MonsterTypes[i].Items[j] as CompendiumBaseItem;
                            BaseItem _baseitem = new BaseItem();
                            if (_oldBase.Name == null)
                            {
                                // fixes issues with old file splitting items
                                string input = _oldBase.Text.ToString();
                                int k = input.IndexOf('.');
                                string word = input.Substring(0, k);
                                _baseitem.Name = word;
                                word = input.Substring(k + 2);
                                _baseitem.Description = word;
                            }
                            else
                            {
                                _baseitem.Name = _oldBase.Name.ToString();
                                _baseitem.Description = _oldBase.Text.ToString();
                            }
                            if (_monster.Action == null)
                            {
                                _monster.Action = new List<BaseItem>();
                            }
                            _monster.Action.Add(_baseitem);
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "reaction")
                        {
                            CompendiumBaseItem _oldBase = _oldComp.MonsterTypes[i].Items[j] as CompendiumBaseItem;
                            BaseItem _baseitem = new BaseItem();
                            _baseitem.Name = _oldBase.Name.ToString();
                            _baseitem.Description = _oldBase.Text.ToString();
                            if (_monster.Reaction == null)
                            {
                                _monster.Reaction = new List<BaseItem>();
                            }
                            _monster.Reaction.Add(_baseitem);
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "legendary")
                        {
                            CompendiumBaseItem _oldBase = _oldComp.MonsterTypes[i].Items[j] as CompendiumBaseItem;
                            BaseItem _baseitem = new BaseItem();
                            if (_oldBase.Name == null)
                            {
                                _baseitem.Name = "Legendary";
                            }
                            else
                            {
                                _baseitem.Name = _oldBase.Name.ToString();
                            }
                            if (_oldBase.Text == null)
                            {
                                j++;
                                _oldBase = _oldComp.MonsterTypes[i].Items[j] as CompendiumBaseItem;
                            }
                            _baseitem.Description = _oldBase.Text.ToString();
                            if (_monster.Legendary == null)
                            {
                                _monster.Legendary = new List<BaseItem>();
                            }
                            _monster.Legendary.Add(_baseitem);
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "save")
                        {
                            _monster.OldSave += _oldComp.MonsterTypes[i].Items[j].ToString() + ", ";

                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "skill")
                        {
                            _monster.OldSkill += _oldComp.MonsterTypes[i].Items[j].ToString() + ", ";
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "hp")
                        {
                            //Get 2 int values inside of string so we can et and set HP either on averages or randomnly
                            // instead of using a string to just show the values of everything from average to die values.
                            string input = _oldComp.MonsterTypes[i].Items[j].ToString();
                            int k = input.IndexOf('(');
                            int l = input.IndexOf('d');
                            int m = input.IndexOf('+');
                            string word = input.Substring(k + 1, l - k - 1);
                            _monster.HitDie = Convert.ToInt32(word);
                            if (m == -1)
                            {
                                m = input.IndexOf("-");
                                if (m == -1)
                                {
                                    m = input.IndexOf(")");
                                    string word2 = input.Substring(l + 1, m - l - 1);
                                    _monster.HitDieValue = Convert.ToByte(word2);
                                }
                                else
                                {
                                    string word2 = input.Substring(l + 1, m - l - 1);
                                    _monster.HitDieValue = Convert.ToByte(word2);
                                }
                            }
                            else
                            {
                                string word2 = input.Substring(l + 1, m - l - 1);
                                _monster.HitDieValue = Convert.ToByte(word2);
                            }
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "senses")
                        {
                            _monster.senses = _oldComp.MonsterTypes[i].Items[j].ToString(); 
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "passive")
                        {
                            _monster.passive = Convert.ToByte(_oldComp.MonsterTypes[i].Items[j]);
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "alignment")
                        {
                            _monster.alignment = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "languages")
                        {
                            _monster.languages = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "description")
                        {
                            _monster.description = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "environment")
                        {
                            _monster.enivroment = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "immune")
                        {
                            _monster.immuneold = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "resist")
                        {
                            _monster.resist = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "slots")
                        {
                            _monster.slots = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else if (_oldComp.MonsterTypes[i].ItemsElementName[j].ToString() == "conditionImmune")
                        {
                            _monster.condition = _oldComp.MonsterTypes[i].Items[j].ToString();
                        }
                        else
                        {
                            // Use to get any missing values and see what the value name is to 
                            //be able to add it for later use.
                            string _newWord = _oldComp.MonsterTypes[i].ItemsElementName[j].ToString();
                            ShowInputDialog(ref _newWord, i.ToString());
                            _monster.Size = _newWord;
                        }
                    }
                    //Implment this later in a diffrent area for nulls found in new monsters.
                    //if(_monster.Size == null)
                    //{
                    //    string _newWord = "Size";
                    //    ShowInputDialog( ref _newWord, _monster.Name.ToString());
                    //    _monster.Size = _newWord;
                    //}
                    if(_comp.Monsters == null)
                    {
                        _comp.Monsters = new List<Monster>();
                    }
                    for (int j = 0; j < _comp.Monsters.Count; j++)
                    {
                        if (_comp.Monsters[j].Name.Contains(_monster.Name))
                        {
                            _monsterExists = true;
                            _monsterIndex = j;
                            break;
                        }
                    }
                    if(_monsterExists == true)
                    {
                        _comp.Monsters.RemoveAt(_monsterIndex);
                        _comp.Monsters.Insert(_monsterIndex, _monster);
                    }
                    else
                    {
                        _comp.Monsters.Add(_monster);
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("All Done!");
            //_comp.WriteToFile(@"./Compendium.xml");
        }

        private static DialogResult ShowInputDialog(ref string input, string _Title)
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = _Title;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

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
            input = textBox.Text;
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConvertMonsters();
        }
        private void btnPlayerView_Click(object sender, EventArgs e)
        {
            frmPlayerView form = new frmPlayerView();
            form.Show();
            //List<Monster> _saveMonster = _mons.Monsters as List<Monster>;
            //_saveMonster = _mons.Monsters;
            //MonsterBase monsterBase = new MonsterBase();
            //monsterBase.Monsters = _saveMonster;
            //monsterBase.WriteToFile(@"C:\Users\Drebi\source\repos\WindyBellows\BaseXML\Monsters.xml");
            //_saveMonster[0].WriteToFile(@"C:\Users\Drebi\source\repos\WindyBellows\BaseXML\Monsters.xml");
        }
        private void btnTableEditor_Click(object sender, EventArgs e)
        {
            frmTableEditor form = new frmTableEditor();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = _comp.Monsters[comboBox1.SelectedIndex].RandomHP().ToString();
        }

        private void btnMonster_Click(object sender, EventArgs e)
        {
            frmMonster form = new frmMonster();
            form._monster = _comp.Monsters[0];
            form.Show();
        }
    }
}