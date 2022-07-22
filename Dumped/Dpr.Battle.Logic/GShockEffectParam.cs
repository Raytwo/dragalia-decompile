using System.Runtime.InteropServices;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public class GShockEffectParam
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public ActionDesc pActionDesc;

		public WazaParam pWazaParam;

		public BTL_POKEPARAM pAttaker;

		public BTL_POKEPARAM pDefender;

		public GShock.Effect gShockEffect;
	}

	private class PosData
	{
		public bool isEffected;

		public byte targetPokeID;

		public ushort effectNo;

		public int effectVolume;

		public Sick curedPokeSick;
	}

	private struct IsNeedSummarizeTableElem
	{
		public GShock.Effect effect;

		public bool needSummarize_ByBossAttack;

		public bool needSummarize_ByPlayerAttack;

		public IsNeedSummarizeTableElem(GShock.Effect effect, bool needSummarize_ByBossAttack, bool needSummarize_ByPlayerAttack)
		{
		}
	}

	private readonly MainModule m_pMainModule;

	private readonly BattleEnv m_pBattleEnv;

	private BTL_POKEPARAM m_pAttaker;

	private BTL_POKEPARAM m_pDefender;

	private readonly ActionDesc m_pActionDesc;

	private readonly WazaParam m_pWazaParam;

	private GShock.Effect m_gShockEffect;

	private PosData[] m_posData;

	private static readonly IsNeedSummarizeTableElem[] IsNeedSummarizeTable;

	public GShockEffectParam([In] ref SetupParam param)
	{
	}

	public bool IsNeedSummarize()
	{
		return default(bool);
	}

	public ActionDesc GetActionDesc()
	{
		return null;
	}

	public WazaParam GetWazaParam()
	{
		return null;
	}

	public BTL_POKEPARAM GetAttacker()
	{
		return null;
	}

	public BTL_POKEPARAM GetDefender()
	{
		return null;
	}

	public GShock.Effect GetGShockEffect()
	{
		return default(GShock.Effect);
	}

	public ushort GetEffectNo(BtlPokePos pos)
	{
		return default(ushort);
	}

	public int GetEffectVolume(BtlPokePos pos)
	{
		return default(int);
	}

	public int GetEffectVolume(byte pokeID)
	{
		return default(int);
	}

	public Sick GetCuredPokeSick(BtlPokePos pos)
	{
		return default(Sick);
	}

	public byte GetTargetPokeID(BtlPokePos pos)
	{
		return default(byte);
	}

	public bool IsEffected(BtlPokePos pos)
	{
		return default(bool);
	}

	public bool IsEffectedAny()
	{
		return default(bool);
	}

	public void SetEffected(BtlPokePos pos, ushort effectNo)
	{
	}

	public void SetEffected_Rank(BtlPokePos pos, int volume)
	{
	}

	public void SetEffected_Sick(BtlPokePos pos, WazaSick sick)
	{
	}

	public void SetEffected_CureSick(BtlPokePos pos, Sick sick)
	{
	}
}
