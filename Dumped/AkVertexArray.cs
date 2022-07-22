using System;

[Obsolete]
public class AkVertexArray : AkBaseArray<AkVertex>
{
	protected override int StructureSize => default(int);

	public AkVertexArray(int count)
	{
	}

	protected override AkVertex CreateNewReferenceFromIntPtr(IntPtr address)
	{
		return null;
	}

	protected override void CloneIntoReferenceFromIntPtr(IntPtr address, AkVertex other)
	{
	}
}
