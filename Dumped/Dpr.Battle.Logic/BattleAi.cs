using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class BattleAi
{
	public enum AiAction
	{
		AIACT_WAZA,
		AIACT_ITEM,
		AIACT_POKECHANGE,
		AIACT_ESCAPE,
		AIACT_WARUAGAKI,
		AIACT_NUM,
		AIACT_NULL
	}

	public class SetupParam
	{
		public MainModule mainModule;

		public BattleEnv pBattleEnv;

		public BattleSimulator pBattleSimulator;

		public ulong randSeed;

		public uint scriptNoBit;

		public byte myClientID;
	}

	public class StartParam
	{
		public byte pokeId;

		public bool[] selectableWazaFlags;

		public ushort itemId;

		public bool isGoingToStartG;
	}

	public class Result
	{
		public AiAction action;

		public byte wazaIndex;

		public BtlPokePos wazaTargetPos;

		public ushort itemId;

		public byte changePokeIndex;
	}

	private enum ActionValuation
	{
		ACTION_VALUATION_SCORE,
		ACTION_VALUATION_PROHIBIT,
		ACTION_VALUATION_FORCE
	}

	private class ActionData
	{
		public ActionValuation valuation;

		public int score;
	}

	private enum SeqUpdateActionSelect
	{
		SEQ_START,
		SEQ_ITEM_START,
		SEQ_ITEM_WAIT,
		SEQ_POKECHANGE_START,
		SEQ_POKECHANGE_WAIT,
		SEQ_WAZA_START,
		SEQ_WAZA_WAIT,
		SEQ_DECIDE_ACT,
		SEQ_DONE
	}

	private readonly MainModule m_mainModule;

	private readonly BattleEnv m_pBattleEnv;

	private BTL_CLIENT m_client;

	private BTL_POKEPARAM m_procPoke;

	private Random m_randGenerator;

	private AiScript m_script;

	private AiItemJudge m_itemJudge;

	private AiPokeChangeJudge m_pokeChangeJudge;

	private AiWazaJudge m_wazaJudge;

	private bool[] m_isWazaSelectable;

	private bool m_isGoingToStartG;

	private ushort m_judgeTargetItem;

	private byte m_pokeChangeTarget;

	private byte m_selectedWazaIndex;

	private BtlPokePos m_selectedTargetPos;

	private Result m_result;

	private uint m_turnCount;

	private uint m_seq;

	private bool m_isFinished;

	private ActionData[] m_actionData;

	private static readonly AiAction[] selectForcedActionByPriority_priorityTable;

	public BattleAi([In] ref SetupParam setupParam)
	{
	}

	public void ChangeScript(uint scriptNoBit)
	{
	}

	public uint GetScript()
	{
		return default(uint);
	}

	public bool IsActionSelectFinished()
	{
		return default(bool);
	}

	public Result GetResult()
	{
		return null;
	}

	public void StartActionSelect([In] ref StartParam startParam)
	{
	}

	public void UpdateActionSelect()
	{
	}

	private void setActionDataByWazaJudge([In] ref AiWazaJudge wazaJudge)
	{
	}

	private bool CheckSpecialAction(Result result)
	{
		return default(bool);
	}

	private bool IsItemUseEnable()
	{
		return default(bool);
	}

	private bool IsPokeChangeEnable()
	{
		return default(bool);
	}

	private bool IsEnemyExist()
	{
		return default(bool);
	}

	private bool IsWazaUseEnable()
	{
		return default(bool);
	}

	private ushort GetItemNoForWazaJudge()
	{
		return default(ushort);
	}

	private void UpdateJudge(AiJudge judge)
	{
	}

	private uint GetSelectableWazaCount()
	{
		return default(uint);
	}

	private void DecideAction()
	{
	}

	private AiAction GetBestAction()
	{
		return default(AiAction);
	}

	private AiAction GetForcedAction()
	{
		return default(AiAction);
	}

	private static AiAction selectForcedActionByPriority(AiAction[] candidates, uint numCandidates)
	{
		return default(AiAction);
	}

	private AiAction GetBestScoredAction()
	{
		return default(AiAction);
	}

	private uint storeBestScoredActions(AiAction[] dest, uint numDestArray)
	{
		return default(uint);
	}

	private AiAction SelectActionAtRandom(AiAction[] actionArray, uint actionNum)
	{
		return default(AiAction);
	}

	private void SetupActionParam(Result destParam, AiAction action)
	{
	}
}
