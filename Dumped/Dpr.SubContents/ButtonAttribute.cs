using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.SubContents;

[AttributeUsage(AttributeTargets.Field)]
public sealed class ButtonAttribute : PropertyAttribute
{
	public string Function
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

	public string Name
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

	public object[] Parameters
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

	public ButtonAttribute(string function, string name, object[] parameters)
	{
	}
}
