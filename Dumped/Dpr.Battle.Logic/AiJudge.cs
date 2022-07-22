namespace Dpr.Battle.Logic;

public abstract class AiJudge
{
	public const int SCORE_FLAT = 100;

	public const int SCORE_DISCOURAGE = 0;

	private BtlAiScriptNo m_minScriptNo;

	private BtlAiScriptNo m_maxScriptNo;

	private BtlAiScriptNo m_currentScriptNo;

	private uint m_targetScriptBit;

	private byte m_myClientID;

	public abstract void UpdateJudge();

	public abstract bool IsJudgeFinished();

	public AiJudge(byte myClientID, BtlAiScriptNo minScriptNo, BtlAiScriptNo maxScriptNo, uint targetScriptBit)
	{
	}

	public virtual void Dispose()
	{
	}

	protected byte GetMyClientID()
	{
		return default(byte);
	}

	public void ChangeAiBit(uint targetScriptBit)
	{
	}

	public uint GetAiBit()
	{
		return default(uint);
	}

	protected BtlAiScriptNo GetCurrentScriptNo()
	{
		return default(BtlAiScriptNo);
	}

	protected void ResetScriptNo()
	{
	}

	protected void UpdateScriptNo()
	{
	}

	private BtlAiScriptNo GetNextScriptNo(BtlAiScriptNo minScriptNo, BtlAiScriptNo maxScriptNo)
	{
		return default(BtlAiScriptNo);
	}

	protected bool IsAllScriptFinished()
	{
		return default(bool);
	}
}
