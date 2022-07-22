using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class AiScriptCommandHandler
{
	public class CommandParam
	{
		public byte clientID;

		public BTL_POKEPARAM attackPoke;

		public BTL_POKEPARAM defensePoke;

		public byte currentWazaIndex;

		public WazaNo currentWazaNo;

		public ushort currentItemNo;

		public BTL_POKEPARAM currentBenchPoke;

		public bool isGWazaUseTurn;

		public void CopyFrom(CommandParam src)
		{
		}

		public void Clear()
		{
		}
	}

	private readonly MainModule m_mainModule;

	private readonly BattleEnv m_pBattleEnv;

	private BattleSimulator m_pBattleSimulator;

	private CommandParam m_commandParam;

	private WazaNo[][] m_usedWaza;

	private bool m_isEscapeSelected;

	private Random m_randGenerator;

	public AiScriptCommandHandler(MainModule mainModule, BattleSimulator pBattleSimulator, BattleEnv pBattleEnv, ulong randSeed)
	{
	}

	public void Dispose()
	{
	}

	public void SetCommandParam([In] ref CommandParam commandParam)
	{
	}

	public CommandParam GetCommandParam()
	{
		return null;
	}

	public Random GetRandGenerator()
	{
		return null;
	}

	public MainModule GetMainModule()
	{
		return null;
	}

	public BattleSimulator GetBattleSimulator()
	{
		return null;
	}

	public POKECON GetPokeCon()
	{
		return null;
	}

	public BattleEnv GetBattleEnv()
	{
		return null;
	}

	public BTL_POKEPARAM GetAttackPokeParam()
	{
		return null;
	}

	public BTL_POKEPARAM GetDefensePokeParam()
	{
		return null;
	}

	public BtlPokePos GetAttackPokePos()
	{
		return default(BtlPokePos);
	}

	public BtlPokePos GetDefensePokePos()
	{
		return default(BtlPokePos);
	}

	private BtlPokePos GetPokePos(BTL_POKEPARAM pokeParam)
	{
		return default(BtlPokePos);
	}

	public BTL_POKEPARAM GetBenchPokeParam()
	{
		return null;
	}

	public byte GetCurrentWazaIndex()
	{
		return default(byte);
	}

	public WazaNo GetCurrentWazaNo()
	{
		return default(WazaNo);
	}

	public ushort GetCurrentItemNo()
	{
		return default(ushort);
	}

	public BTL_POKEPARAM GetBpp(BtlPokePos pos)
	{
		return null;
	}

	public BTL_POKEPARAM GetBppByAISide(uint ai_side)
	{
		return null;
	}

	public byte AISideToClientID(uint ai_side)
	{
		return default(byte);
	}

	public BtlPokePos AISideToPokePos(uint ai_side)
	{
		return default(BtlPokePos);
	}

	public TokuseiNo CheckTokuseiByAISide(int ai_side)
	{
		return default(TokuseiNo);
	}

	public uint CalcMaxDamage(BTL_POKEPARAM atkPoke, BTL_POKEPARAM defPoke, bool loss_flag)
	{
		return default(uint);
	}

	public void StoreUsedWaza(BTL_POKEPARAM bpp)
	{
	}

	public bool CheckWazaStored(BTL_POKEPARAM bpp, WazaNo waza_no)
	{
		return default(bool);
	}

	public void ResetEscape()
	{
	}

	public void NotifyEscapeByAI()
	{
	}

	public bool IsEscapeSelected()
	{
		return default(bool);
	}
}
