using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Catalog.Champion
{

public class ChampionSkinDTO : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.catalog.champion.ChampionSkinDTO";

public ChampionSkinDTO(Callback callback)
{
this.callback = callback;
}

public ChampionSkinDTO(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(ChampionSkinDTO result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("lastSelected")]
public bool LastSelected { get; set; }

[InternalName("stillObtainable")]
public bool StillObtainable { get; set; }

[InternalName("purchaseDate")]
public double PurchaseDate { get; set; }

[InternalName("winCountRemaining")]
public int WinCountRemaining { get; set; }

[InternalName("endDate")]
public double EndDate { get; set; }

[InternalName("championId")]
public int ChampionId { get; set; }

[InternalName("freeToPlayReward")]
public bool FreeToPlayReward { get; set; }

[InternalName("skinId")]
public int SkinId { get; set; }

[InternalName("owned")]
public bool Owned { get; set; }

}
}
