namespace Dpr.Battle.Logic;

public sealed class AiItemJudge : AiJudge
{
	private enum UpdateJudgeSeq
	{
		SEQ_SCRIPT_START,
		SEQ_SCRIPT_WAIT,
		SEQ_TO_NEXT_SCRIPT,
		SEQ_END
	}

	private readonly MainModule m_mainModule;

	private readonly BattleEnv m_pBattleEnv;

	private BTL_POKEPARAM m_poke;

	private Random m_randGenerator;

	private AiScript m_script;

	private AiScriptHandler m_scriptHandler;

	private AiScriptCommandHandler m_scriptCommandHandler;

	private ushort m_itemNo;

	private int m_score;

	private uint m_seq;

	private bool m_isFinished;

	public AiItemJudge(AiScript aiScript, MainModule mainModule, BattleEnv pBattleEnv, BattleSimulator pBattleSimulator, ulong randSeed, uint scriptBit, byte myClientID)
	{
	}

	public override void Dispose()
	{
	}

	public void StartJudge(BTL_POKEPARAM poke, ushort itemNo)
	{
	}

	public override void UpdateJudge()
	{
	}

	private void StartScript()
	{
	}

	private void RegisterScriptResult()
	{
	}

	public override bool IsJudgeFinished()
	{
		return default(bool);
	}

	public int GetScore()
	{
		return default(int);
	}
}
