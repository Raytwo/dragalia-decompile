using System;

namespace Dpr.SequenceEditor;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class GroupColorAttribute : Attribute
{
	public byte BgColR;

	public byte BgColG;

	public byte BgColB;

	public byte BgColA;

	public GroupColorAttribute(byte r, byte g, byte b, byte a = byte.MaxValue)
	{
	}
}
