using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Platform.Catalog.Runes
{

public class RuneType : RiotGamesObject
{
public override string TypeName
{
get
{
return this.type;
}
}

private string type = "com.riotgames.platform.catalog.runes.RuneType";

public RuneType(Callback callback)
{
this.callback = callback;
}

public RuneType(TypedObject result)
{
base.SetFields(this, result);
}

public delegate void Callback(RuneType result);

private Callback callback;

public override void DoCallback(TypedObject result)
{
base.SetFields(this, result);
callback(this);
}

[InternalName("runeTypeId")]
public int RuneTypeId { get; set; }

[InternalName("name")]
public string Name { get; set; }

}
}
