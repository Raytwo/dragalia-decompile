using System;

public class AkObstructionOcclusionValuesArray : AkBaseArray<AkObstructionOcclusionValues>
{
	protected override int StructureSize => default(int);

	public AkObstructionOcclusionValuesArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override AkObstructionOcclusionValues CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkObstructionOcclusionValues other)
	{
	}
}
