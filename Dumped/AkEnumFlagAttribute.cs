using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class AkEnumFlagAttribute : PropertyAttribute
{
	public Type Type;

	public AkEnumFlagAttribute(Type type)
	{
	}
}
