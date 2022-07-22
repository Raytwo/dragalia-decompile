using System;
using System.Runtime.CompilerServices;

namespace Dpr.SequenceEditor;

[AttributeUsage(AttributeTargets.Field)]
public class GroupOptionAttribute : Attribute
{
	public Type GrpOptEnum
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

	public GroupOptionAttribute(Type enumType)
	{
	}
}
