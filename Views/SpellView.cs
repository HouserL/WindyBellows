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

namespace WindyBellows.Views;

public partial class SpellView : UserControl
{
    public Dictionary<int, string> SpellLevels;
    public SpellView()
    {
        InitializeComponent();
        SpellLevels = Enum.GetValues(typeof(SpellLevel))
               .Cast<SpellLevel>()
               .ToDictionary(t => (int)t, t => t.ToDescriptionString());
        cboSpellLevel.DataSource = SpellLevels.Values.ToList();
        cboSpellType.DataSource = Enum.GetValues(typeof(SpellType));
    }

    private void SpellView_Load(object sender, EventArgs e)
    {

    }
}
