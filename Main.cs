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
using WindyBellows.Views;
using WindyBellows.Models;
using WindyBellows.Logic;

namespace WindyBellows;

public partial class Main : Form
{
    private string _control;
    private TablesView _tablesView;
    private CreatePlayerView _createPlayer;
    private PlayerView _playerView;
    private SpellView _spellView;
#pragma warning disable CA2211 // Non-constant fields should not be visible
    public static Compendium _comp;
#pragma warning restore CA2211 // Non-constant fields should not be visible
    public OldCompendium _oldComp;
    //public static TableBase _table;
    //public static PlayerBase _play;
    //public static Compendium _comp;
    //public static MonsterBase _mons;
    //public static NPCBase _NPC;
    public Main()
    {
        InitializeComponent();
        _tablesView = new TablesView();
        _createPlayer = new CreatePlayerView();
        _playerView = new PlayerView();
        _spellView = new SpellView();

    }
    private void FrmPlayerView_Load(object sender, EventArgs e)
    {
        if (!File.Exists("./Compendium.xml"))
        {
            _comp = new();
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
        //_comp.Players[0].Skills
    }
    private void BtnCreateNPC_Click(object sender, EventArgs e)
    {
        //CreateNPC form = new();
        //form.Show();

        if (this.Controls.Contains(_createPlayer) == true) return;

        _createPlayer.CreateControl();
        Controls.Add(_createPlayer);
        _createPlayer.Location = new System.Drawing.Point(146, 31);
        this.Size = new System.Drawing.Size(960, 746);
        _createPlayer.Show();
        _control = "_createPlayer";

    }
    private void SavePlayerBaseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveCompendium();
    }
    public static void SaveCompendium()
    {
        if (File.Exists("./Compendium.xml"))
        {
            _comp.WriteToStream(File.Create("./Compendium.xml"),SerializableObjectBase.SerializableObjectType.Xml);
            return;
        }
        _comp.WriteToFile("./Compendium.xml");
    }



   

    private static DialogResult ShowInputDialog(ref string input, string _Title)
    {
        System.Drawing.Size size = new(300, 70);
        Form inputBox = new();

        inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        inputBox.ClientSize = size;
        inputBox.Text = _Title;

        System.Windows.Forms.TextBox textBox = new();
        textBox.Size = new(size.Width - 10, 23);
        textBox.Location = new Point(5, 5);
        textBox.Text = input;
        inputBox.Controls.Add(textBox);

        Button okButton = new();
        okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        okButton.Name = "okButton";
        okButton.Size = new System.Drawing.Size(75, 23);
        okButton.Text = "&OK";
        okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
        inputBox.Controls.Add(okButton);

        Button cancelButton = new();
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
    private void Button1_Click(object sender, EventArgs e)
    {
        Converter converter = new Converter();
        converter._comp = _comp;
        converter.ConvertMonsters();
    }
    private void BtnPartyView_Click(object sender, EventArgs e)
    {
        //Controls.Remove(_tablesView);
        frmPlayerView form = new();
        form.Show();
        //List<Monster> _saveMonster = _mons.Monsters as List<Monster>;
        //_saveMonster = _mons.Monsters;
        //MonsterBase monsterBase = new MonsterBase();
        //monsterBase.Monsters = _saveMonster;
        //monsterBase.WriteToFile(@"C:\Users\Drebi\source\repos\WindyBellows\BaseXML\Monsters.xml");
        //_saveMonster[0].WriteToFile(@"C:\Users\Drebi\source\repos\WindyBellows\BaseXML\Monsters.xml");
    }
    private void BtnTableEditor_Click(object sender, EventArgs e)
    {
        if (this.Controls.Contains(_tablesView) == true) return;
        RemoveControls();  
        _tablesView.CreateControl();
        Controls.Add(_tablesView);
        _tablesView.Location = new System.Drawing.Point(146, 31);
        _tablesView.Tables = _comp.Tables;
        _tablesView.LoadData();
        this.Size = new System.Drawing.Size(960, 746);
        _tablesView.Show();
        _control = "_tablesView";
        
    }

    private void Button2_Click(object sender, EventArgs e)
    {
        switch (_control)
        {
            case "_tablesView": _comp.Tables = _tablesView.Tables; break;
            case "_createPlayer": _comp.Players = _createPlayer.NewPlayer(_comp.Players) ; break;

            default: break;
        }
        //_comp.Tables = this._tablesView.Tables;
    }

    private void BtnMonster_Click(object sender, EventArgs e)
    {
    }

    private void RemoveControls()
    {
        switch (_control)
        {
            case "_tablesView": this.Controls.Remove(_tablesView); break;
            default:
                break;
        }
    }
    
    public static void RemovePlayer(int player)
    {
        _comp.Players.Remove(_comp.Players[player]);
        return;
    }

    private void BtnPlayerView_Click(object sender, EventArgs e)
    {
        if (this.Controls.Contains(_playerView) == true) return;
        RemoveControls();
        _control = "_playerView";
        _playerView.CreateControl();
        Controls.Add(_playerView);
        _playerView.Location = new Point(146, 31);
        this.Size = new Size(960, 746);
        _playerView.Show();


    }

    private void btnSpellView_Click(object sender, EventArgs e)
    {
        if (this.Controls.Contains(_spellView) == true) return;
        RemoveControls();
        _control = "_playerView";
        _spellView.CreateControl();
        Controls.Add(_spellView);
        _spellView.Location = new Point(146, 31);
        this.Size = new Size(960, 746);
        _spellView.Show();

    }
}
