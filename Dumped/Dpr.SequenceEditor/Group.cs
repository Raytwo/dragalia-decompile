using System;
using System.Collections.Generic;

namespace Dpr.SequenceEditor;

[Serializable]
public sealed class Group
{
	public static Group Default;

	public string Name;

	public int GrpNo;

	public int IsOpen;

	public int GrpDebug;

	public byte BgColR;

	public byte BgColG;

	public byte BgColB;

	[Obsolete]
	public byte ColR;

	[Obsolete]
	public byte ColG;

	[Obsolete]
	public byte ColB;

	[Obsolete]
	public string GrpOption;

	public List<GroupOption> GroupOption;

	public List<Command> Commands;
}
