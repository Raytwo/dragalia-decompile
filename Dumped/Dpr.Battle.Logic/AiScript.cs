namespace Dpr.Battle.Logic;

public sealed class AiScript
{
	public class Result
	{
		public int score;

		public bool isPokeChangeEnable;
	}

	private static BtlAIBaseScript[] s_PawnBaeCache;

	private uint m_loadedScriptNo;

	private BtlAIBaseScript m_script;

	public bool StartLoadScript(BtlAiScriptNo scriptNo)
	{
		return default(bool);
	}

	private static BtlAIBaseScript CreateScriptBase(uint scriptNo)
	{
		return null;
	}

	public static void ReleaseAiScriptCache()
	{
	}

	public bool WaitLoadScript()
	{
		return default(bool);
	}

	public void SetExecParameter(AiScriptCommandHandler commandHandler)
	{
	}

	public bool Execute()
	{
		return default(bool);
	}

	public void GetResult(Result dest)
	{
	}

	public void UnLoadScript()
	{
	}
}
