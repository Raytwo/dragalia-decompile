using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class WazaEffectParams
{
	public WazaNo effectWazaID;

	public BtlPokePos attackerPos;

	public BtlPokePos targetPos;

	public byte effectIndex;

	public byte pluralHitIndex;

	public bool isGShockOccur;

	public bool fEnable;

	public bool fDone;

	public ushort commandQueuePos;

	public bool isSyncDamageEffect;

	public byte subEff_pokeCnt;

	public byte subEff_pokeID_1;

	public byte subEff_pokeID_2;

	public byte subEff_pokeID_3;

	public byte subEff_pokeID_4;

	public byte subEff_pokeID_5;

	public void CopyFrom(WazaEffectParams src)
	{
	}

	public void Clear()
	{
	}

	public void Setup(BTL_POKEPARAM attacker, PokeSet targets, [In] ref PosPoke posPoke)
	{
	}

	public void ChangeAttackerPos(BtlPokePos atkPos)
	{
	}

	public void ChangeEffectWazaID(WazaNo waza)
	{
	}

	public WazaNo GetEffectWazaID()
	{
		return default(WazaNo);
	}

	public void SetEnable()
	{
	}

	public void SetEnableDummy()
	{
	}

	public bool IsEnable()
	{
		return default(bool);
	}

	public bool IsDone()
	{
		return default(bool);
	}

	public void SetEffectIndex(byte index)
	{
	}

	public void AddSubEffectPoke(byte pokeID)
	{
	}

	public void ClearSubEffectParams()
	{
	}

	public bool IsSubEffectParamsValid()
	{
		return default(bool);
	}

	public bool IsGShockOccur()
	{
		return default(bool);
	}

	public void SetGShockOccur()
	{
	}

	public void SetSyncDamageEffectEnable()
	{
	}
}
