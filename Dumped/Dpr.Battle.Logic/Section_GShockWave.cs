using System.Runtime.InteropServices;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_GShockWave : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM defender;

		public ActionDesc actionDesc;

		public WazaParam wazaParam;
	}

	public class Result
	{
		public bool isEffected;
	}

	public Section_GShockWave([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool applyEffect(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Weather(GShockEffectParam pEffectParam, BtlWeather weather)
	{
		return default(bool);
	}

	public bool effect_Ground(GShockEffectParam pEffectParam, byte ground)
	{
		return default(bool);
	}

	private bool effect_Rank(GShockEffectParam pEffectParam, ExPokePos.ExPosType area, WazaRankEffect effect, int volume)
	{
		return default(bool);
	}

	private bool addRank(GShockEffectParam pEffectParam, BTL_POKEPARAM pTarget, WazaRankEffect effect, int volume)
	{
		return default(bool);
	}

	private bool effect_Sick_DokuMahiNemuri(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Sick_DokuMahi(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	public bool addPokeSickAtRandom(GShockEffectParam pEffectParam, Sick[] pSickTable, byte sickTableSize)
	{
		return default(bool);
	}

	private bool effect_Sick_Doku(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Sick_Mahi(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Sick_Konran(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Sick_MeroMero(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool addSick_AllEnemies(GShockEffectParam pEffectParam, WazaSick sick, BTL_SICKCONTOBJ pSickCont)
	{
		return default(bool);
	}

	private bool addSick(GShockEffectParam pEffectParam, BTL_POKEPARAM pTarget, WazaSick sick, BTL_SICKCONTOBJ pSickCont, StrParam pMessage)
	{
		return default(bool);
	}

	private bool effect_AuroraVeil(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_StealthRock(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_StealthRock_Hagane(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Side_Honoo(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Side_Iwa(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool addSideEffect(BTL_POKEPARAM pAttacker, BtlSide side, BtlSideEffect effect, [In] ref BTL_SICKCONT cont, byte successEffectNo, [In] ref StrParam successMessage)
	{
		return default(bool);
	}

	private bool effect_Juryoku(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_NekoNiKoban(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_NekoNiKoban_AddBonusMoney(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Toosenbou(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Akubi(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Ichamon(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Syuukaku(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_Syuukaku_Target(BTL_POKEPARAM pTarget)
	{
		return default(bool);
	}

	private bool effect_Sunazigoku(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_HonooNoUzu(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_KiriBarai(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_CureSick(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_RecoverHP(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_DecrementPP(GShockEffectParam pEffectParam)
	{
		return default(bool);
	}

	private bool effect_DecrementPP_Target(GShockEffectParam pEffectParam, BTL_POKEPARAM pTarget)
	{
		return default(bool);
	}
}
