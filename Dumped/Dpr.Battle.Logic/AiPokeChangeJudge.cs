namespace Dpr.Battle.Logic;

public sealed class AiPokeChangeJudge : AiJudge
{
	public class JudgeResult
	{
		public bool isPokeChangeEnable;

		public int score;

		public int inPokePartyIndex;
	}

	private class JudgePokeData
	{
		public byte inPartyIndex;

		public bool isChangeEnable;

		public int score;
	}

	public enum SeqUpdateJudge
	{
		SEQ_INIT,
		SEQ_SCRIPT_START,
		SEQ_SCRIPT_WAIT,
		SEQ_SCRIPT_END,
		SEQ_TO_NEXT_POKE,
		SEQ_TO_NEXT_SCRIPT,
		SEQ_END
	}

	private readonly MainModule m_mainModule;

	private BTL_CLIENT m_client;

	private readonly BattleEnv m_pBattleEnv;

	private BTL_POKEPARAM m_targetFrontPoke;

	private Random m_randGenerator;

	private AiScript m_script;

	private AiScriptHandler m_scriptHandler;

	private AiScriptCommandHandler m_scriptCommandHandler;

	private uint m_seq;

	private bool m_isFinished;

	private byte m_judgePokeCount;

	private byte m_judgePokeIndex;

	private JudgePokeData[] m_judgePokeData;

	private JudgeResult m_result;

	public AiPokeChangeJudge(AiScript aiScript, MainModule mainModule, BattleEnv pBattleEnv, BattleSimulator pBattleSimulator, ulong randSeed, uint scriptBit, byte myClientID)
	{
	}

	public override void Dispose()
	{
	}

	public void StartJudge(BTL_POKEPARAM targetFrontPoke)
	{
	}

	public override void UpdateJudge()
	{
	}

	private void InitJudgePokeData()
	{
	}

	private void StartScript()
	{
	}

	private BTL_POKEPARAM GetCurrentJudgePokeParam()
	{
		return null;
	}

	private void RegisterScriptResult()
	{
	}

	private void SetupJudgeResult()
	{
	}

	private int GetBestScoredJudgePokeIndex()
	{
		return default(int);
	}

	public override bool IsJudgeFinished()
	{
		return default(bool);
	}

	public JudgeResult GetJudgeResult()
	{
		return null;
	}
}
