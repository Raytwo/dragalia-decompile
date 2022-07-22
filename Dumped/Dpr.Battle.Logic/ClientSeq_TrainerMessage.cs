using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class ClientSeq_TrainerMessage
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public BattleViewBase pViewSystem;

		public TrainerMessageManager pMessageManager;
	}

	private MainModule m_pMainModule;

	private BattleViewBase m_pViewSystem;

	private TrainerMessageManager m_pMessageManager;

	private int m_seq;

	private bool m_isFinished;

	private byte m_clientId;

	private TrainerMessageID m_messageId;

	public void Setup([In] ref SetupParam setupParam)
	{
	}

	public void Start(byte clientId, TrainerMessageID messageId)
	{
	}

	public void Update()
	{
	}

	private void StartView()
	{
	}

	private bool WaitView()
	{
		return default(bool);
	}

	public bool IsFinished()
	{
		return default(bool);
	}
}
