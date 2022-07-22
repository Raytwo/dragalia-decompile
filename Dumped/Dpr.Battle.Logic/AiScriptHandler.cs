namespace Dpr.Battle.Logic;

public sealed class AiScriptHandler
{
	public class ScriptStartParam
	{
		public AiScript script;

		public BtlAiScriptNo scriptNo;

		public AiScriptCommandHandler commandHandler;

		public AiScriptCommandHandler.CommandParam commandParam;
	}

	public enum SeqWaitScript
	{
		SEQ_LOAD_START,
		SEQ_LOAD_WAIT,
		SEQ_EXEC_START,
		SEQ_EXEC_WAIT,
		SEQ_END
	}

	private AiScript m_script;

	private BtlAiScriptNo m_scriptNo;

	private AiScriptCommandHandler m_commandHandler;

	private AiScriptCommandHandler.CommandParam m_commandParam;

	private uint m_seq;

	private AiScript.Result m_result;

	public void StartScript(ScriptStartParam startParam)
	{
	}

	public bool WaitScript()
	{
		return default(bool);
	}

	public AiScript.Result GetScriptResult()
	{
		return null;
	}
}
