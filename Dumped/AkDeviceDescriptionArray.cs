using System;

public class AkDeviceDescriptionArray : AkBaseArray<AkDeviceDescription>
{
	protected override int StructureSize => default(int);

	public AkDeviceDescriptionArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override AkDeviceDescription CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDeviceDescription other)
	{
	}
}
