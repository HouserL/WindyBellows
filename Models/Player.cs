using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public class Player : SerializableObjectBase
{
    public byte STR { get; set; }
    public byte DEX { get; set; }
    public byte CON { get; set; }
    public byte INT { get; set; }
    public byte WIS { get; set; }
    public byte CHR { get; set; }
    public string Name { get; set; }
    public byte Level { get; set; }
    public byte HP { get; set; }
    public byte AC { get; set; }
    public byte Old_AC { get; set; }
    public int Old_Preception { get; set; }
    public List<Prof> Prof { get; set; } = new();
    [System.Xml.Serialization.XmlElementAttribute("Trait")]
    public List<BaseItem> Trait { get; set; } = new();
    [System.Xml.Serialization.XmlElementAttribute("Spells")]
    public List<Spell> AllSpells { get; set; } = new();
    [System.Xml.Serialization.XmlElementAttribute("PreppedSpells")]
    public List<Spell> PreppedSpells { get; set; } = new();

}
