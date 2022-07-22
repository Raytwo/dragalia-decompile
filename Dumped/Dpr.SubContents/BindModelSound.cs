using System;
using Pml;
using UnityEngine;
using XLSXContent;

namespace Dpr.SubContents;

[Serializable]
public class BindModelSound
{
	public enum SoundType
	{
		BGM,
		VOICE,
		SE
	}

	public Transform parent;

	public SoundType soundType;

	public string SoundName;

	public MonsNo Debug_Voice;

	[NonSerialized]
	public PokemonInfo.SheetCatalog catalog;

	public bool WaitFinish;

	public uint GetID()
	{
		return default(uint);
	}

	public void Destroy()
	{
	}
}
