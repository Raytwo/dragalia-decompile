using System;
using System.Runtime.CompilerServices;

namespace Dpr.SequenceEditor;

[AttributeUsage(AttributeTargets.Field)]
public class ShortNameAttribute : Attribute
{
	public string ShortName
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

	public ShortNameAttribute(string shortName)
	{
	}
}
