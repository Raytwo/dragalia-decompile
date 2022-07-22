using System;

public class AkExternalSourceInfoArray : AkBaseArray<AkExternalSourceInfo>
{
	protected override int StructureSize => default(int);

	public AkExternalSourceInfoArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	protected override AkExternalSourceInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkExternalSourceInfo other)
	{
	}
}
