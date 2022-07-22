using System;

public class AkDiffractionPathInfoArray : AkBaseArray<AkDiffractionPathInfo>
{
	protected override int StructureSize => default(int);

	public AkDiffractionPathInfoArray(int count)
	{
	}

	protected override AkDiffractionPathInfo CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkDiffractionPathInfo other)
	{
	}
}
