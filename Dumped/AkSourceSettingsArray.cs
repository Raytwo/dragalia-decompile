using System;

public class AkSourceSettingsArray : AkBaseArray<AkSourceSettings>
{
	protected override int StructureSize => default(int);

	public AkSourceSettingsArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override AkSourceSettings CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkSourceSettings other)
	{
	}
}
