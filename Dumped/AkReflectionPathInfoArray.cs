using System;

public class AkReflectionPathInfoArray : AkBaseArray<AkReflectionPathInfo>
{
	protected override int StructureSize => default(int);

	public AkReflectionPathInfoArray(int count)
	{
	}

	protected override AkReflectionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkReflectionPathInfo other)
	{
	}
}
