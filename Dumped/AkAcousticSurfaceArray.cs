using System;

public class AkAcousticSurfaceArray : AkBaseArray<AkAcousticSurface>
{
	protected override int StructureSize => default(int);

	public AkAcousticSurfaceArray(int count)
	{
	}

	protected override void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected override AkAcousticSurface CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkAcousticSurface other)
	{
	}
}
