using System;

public class AkObjectInfoArray : AkBaseArray<AkObjectInfo>
{
	protected override int StructureSize => default(int);

	public AkObjectInfoArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override AkObjectInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObjectInfo other)
	{
	}
}
