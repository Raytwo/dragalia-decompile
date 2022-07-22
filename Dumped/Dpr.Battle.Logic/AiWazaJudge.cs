using Pml;

namespace Dpr.Battle.Logic;

public sealed class AiWazaJudge : AiJudge
{
	public enum ScoreStatus
	{
		STATUS_NORMAL,
		STATUS_DISABLE,
		STATUS_DISCOURAGE
	}

	private enum SeqSubProc_Core
	{
		AISTEP_START,
		AISTEP_INIT,
		AISTEP_SWITCH_SCRIPT,
		AISTEP_CHECK_RUNNABLE_SCRIPT,
		AISTEP_SCRIPT_START,
		AISTEP_SETUP_WAZA,
		AISTEP_SCRIPT_WAIT,
		AISTEP_SWITCH_WAZA,
		AISTEP_SWITCH_TARGET,
		AISTEP_DONE
	}

	private class ScoreData
	{
		public int score;

		public byte wazaIdx;

		public BtlPokePos targetPos;
	}

	public MainModule m_mainModule;

	public BattleEnv m_pBattleEnv;

	public BTL_POKEPARAM m_atkPoke;

	public BTL_POKEPARAM m_defPoke;

	public Random m_randGenerator;

	public AiScript m_script;

	public AiScriptHandler m_scriptHandler;

	public AiScriptCommandHandler m_scriptCommandHandler;

	public byte m_pokeID;

	public byte m_atkClientID;

	public BtlPokePos m_atkPos;

	public BtlPokePos m_defPos;

	public byte m_currentWazaPos;

	public WazaNo m_currentWazaNo;

	public ushort m_itemId;

	public bool m_isGoingToStartG;

	public uint m_AIStep;

	public int[][] m_wazaScore;

	public ScoreStatus[][] m_wazaScoreStatus;

	public bool[] m_usableWazaFlags;

	public bool[] m_bTokuseiAppeared;

	public int m_selectWazaScore;

	public byte m_selectWazaPos;

	public BtlPokePos m_selectTargetPos;

	public byte m_currentTargetIdx;

	public bool m_bTargetSideFriend;

	public bool m_bEscape;

	public bool m_bDecided;

	public bool m_bFinished;

	public AiWazaJudge(AiScript aiScript, MainModule mainModule, BattleEnv pBattleEnv, BattleSimulator pBattleSimulator, ulong randSeed, uint ai_bit, byte myClientID)
	{
	}

	public override void Dispose()
	{
	}

	public void SetJudgeParam(bool[] usableWazaFlags, BtlPokePos pos, byte pokeID, ushort itemId, bool isGoingToStartG)
	{
	}

	public void StartJudge()
	{
	}

	public override bool IsJudgeFinished()
	{
		return default(bool);
	}

	public override void UpdateJudge()
	{
	}

	private void subProc_Core()
	{
	}

	private bool incrementTargetIndex()
	{
		return default(bool);
	}

	private BtlPokePos updateTargetPos(bool bFriendSide, byte targetIdx)
	{
		return default(BtlPokePos);
	}

	private bool isTargettingCoveragePos(WazaNo waza_no, BtlPokePos targetPos)
	{
		return default(bool);
	}

	private BtlPokePos correctTargetPos(BtlPokePos targetPos, byte wazaIdx)
	{
		return default(BtlPokePos);
	}

	private BtlPokePos searchBestScorePos(byte wazaIdx, BtlPokePos atkPos, BtlSide side)
	{
		return default(BtlPokePos);
	}

	private BTL_POKEPARAM decideTargetPoke(BtlPokePos target_pos)
	{
		return null;
	}

	private void wazaScore_Reset()
	{
	}

	private int wazaScore_Add(byte wazaIdx, BtlPokePos targetPos, int score)
	{
		return default(int);
	}

	private void wazaScore_SetScoreless(byte wazaIdx, BtlPokePos targetPos)
	{
	}

	private bool wazaScore_IsScoreless(byte wazaIdx, BtlPokePos targetPos)
	{
		return default(bool);
	}

	private void wazaScore_DecideBest()
	{
	}

	private void wazaScore_DecideRaidBoss()
	{
	}

	private WazaNo getAttackerWazaNo(byte wazaIdx)
	{
		return default(WazaNo);
	}

	public bool IsEnemyEscape()
	{
		return default(bool);
	}

	public bool IsWazaSelected()
	{
		return default(bool);
	}

	public int GetSelectedWazaScore()
	{
		return default(int);
	}

	public void GetSelectedWaza(ref byte wazaIdx, ref BtlPokePos targetPos)
	{
	}
}
