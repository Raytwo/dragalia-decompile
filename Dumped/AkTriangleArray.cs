using System;

public class AkTriangleArray : AkBaseArray<AkTriangle>
{
	protected override int StructureSize => default(int);

	public AkTriangleArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override AkTriangle CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkTriangle other)
	{
	}
}
