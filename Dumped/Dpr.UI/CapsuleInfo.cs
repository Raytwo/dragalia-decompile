using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.BallDeco;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class CapsuleInfo
{
	private int capsuleId;

	public CapsuleData Data
	{
		[CompilerGenerated]
		get
		{
			return default(CapsuleData);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PokemonParam AttachPokemonParam
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PokemonParam PreviewPokemonParam
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool Is3DEditMode => default(bool);

	public bool IsAppliedTemplate => default(bool);

	public bool IsAffixedSeal => default(bool);

	public bool IsAffixSealMaxCount => default(bool);

	public CapsuleInfo(int id)
	{
	}

	public CapsuleInfo(CapsuleData data, [Optional] PokemonParam pokemonParam)
	{
	}

	public void RefreshData()
	{
	}

	public void AttachPokemon(PokemonParam pokemonParam)
	{
	}

	public void DetachPokemon()
	{
	}

	public void SwitchEditMode()
	{
	}

	public void Swap(CapsuleInfo capsuleInfo)
	{
	}

	public int GetCanCopySealCount()
	{
		return default(int);
	}

	public void CopyTo(CapsuleInfo capsuleInfo)
	{
	}

	public int AddAffixSeal(ushort sealId, Vector3 pos)
	{
		return default(int);
	}

	public void SetAffixSeal(int affixSealId, ushort sealId, Vector3 pos)
	{
	}

	public void RemoveAffixSeal(int affixSealId, bool isDoReturn = true)
	{
	}

	public void RemoveAllAffixSeals()
	{
	}

	public void SwapAffixSeal(int affixSealId, ushort sealId)
	{
	}

	public void SwapEachAffixSeal(int toAffixSealId, int fromAffixSealId)
	{
	}
}
