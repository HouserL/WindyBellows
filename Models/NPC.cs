using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindyBellows.Models;

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public class NPC
{

    public string Name { get; set; }
    public string Race { get; set; }
    public byte STR { get; set; }
    public byte DEX { get; set; }
    public byte CON { get; set; }
    public byte INT { get; set; }
    public byte WIS { get; set; }
    public byte CHR { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public string Occupation { get; set; }
    public string Personality { get; set; }
    public string SocialClass { get; set; }
    public string Talents { get; set; }
    public string Ideals { get; set; }
    public string Age { get; set; }
    public string Goals { get; set; }
    public string Alignment { get; set; }
    public string Reason { get; set; }
    public string Likes { get; set; }
    public string Dislikes { get; set; }
    public string Apperance { get; set; }
    public string Fear { get; set; }
    public string Mannerisms { get; set; }
    public string Interaction { get; set; }
    public string Alignment_Ideal { get; set; }
    public int Old_AC { get; set; }
    public int Old_Preception { get; set; }
    public string Flaws { get; set; }
    public string Class { get; set; }
}
