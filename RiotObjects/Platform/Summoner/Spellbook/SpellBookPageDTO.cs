using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Summoner.Spellbook
{

public class SpellBookPageDTO : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.summoner.spellbook.SpellBookPageDTO";

public SpellBookPageDTO(Callback callback)
{
this.callback = callback;
}

public SpellBookPageDTO(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(SpellBookPageDTO result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("pageId")]
public double PageId { get; set; }

[InternalName("name")]
public string Name { get; set; }

[InternalName("current")]
public bool Current { get; set; }

[InternalName("slotEntries")]
public List<SlotEntry> SlotEntries { get; set; }

[InternalName("createDate")]
public DateTime CreateDate { get; set; }

[InternalName("summonerId")]
public double SummonerId { get; set; }

}
}
