using System;
using System.Collections.Generic;

namespace Dpr.SequenceEditor;

[Serializable]
public sealed class CommandParam
{
	public Group Group;

	public bool IsAlreadyCalled;

	public int StartFrame;

	public int EndFrame;

	public int GroupNo;

	public CommandNo CommandNo;

	public Macro Macro;

	public List<GroupOption> GroupOption;

	public float StartTime => default(float);

	public float EndTime => default(float);

	public CommandParam()
	{
	}

	public CommandParam(CommandParam other)
	{
	}

	public GroupOption GetGroupOption(GRP_OPT option)
	{
		return null;
	}

	public int GetOptionValue(GRP_OPT option)
	{
		return default(int);
	}

	public bool TryGetOptionValue(GRP_OPT option, out int value)
	{
		return default(bool);
	}
}
