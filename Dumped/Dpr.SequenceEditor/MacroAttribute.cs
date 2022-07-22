using System;
using System.Runtime.CompilerServices;

namespace Dpr.SequenceEditor;

[AttributeUsage(AttributeTargets.Class)]
public sealed class MacroAttribute : Attribute
{
	public CommandNo CommandNo
	{
		[CompilerGenerated]
		get
		{
			return default(CommandNo);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Color
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string Type
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string PreFunc
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public MacroAttribute(CommandNo command)
	{
	}

	public MacroAttribute(CommandNo command, string color, string type, string preFunc)
	{
	}
}
