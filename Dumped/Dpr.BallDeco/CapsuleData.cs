using System;
using System.Runtime.InteropServices;

namespace Dpr.BallDeco;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 172)]
public struct CapsuleData
{
	public uint AttachPokemonId;

	public uint AttachPersonalRnd;

	public bool Is3DEditMode;

	public bool IsAppliedTemplate;

	public byte AffixSealCount;

	public AffixSealData[] AffixSealDatas;

	public void Clear()
	{
	}

	public void CopyFrom([In] ref CapsuleData src)
	{
	}
}
