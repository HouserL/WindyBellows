using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class Guild
{
    public string Name { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("Player")]
    public List<string> Players { get; set; }
    [System.Xml.Serialization.XmlElementAttribute("NPC")]
    public List<string> NPCs { get; set; }
}