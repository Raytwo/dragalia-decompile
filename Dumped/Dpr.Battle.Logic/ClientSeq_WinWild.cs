using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class ClientSeq_WinWild
{
	public class SetupParam
	{
		public MainModule mainModule;

		public BTL_CLIENT client;

		public POKECON pokecon;

		public BattleViewBase viewSystem;
	}

	public enum Sequence
	{
		SEQ_MONEY_MESSAGE_START,
		SEQ_MONEY_MESSAGE_WAIT,
		SEQ_WIN_VS_NUSI_EFFECT_START,
		SEQ_WIN_VS_NUSI_EFFECT_WAIT,
		SEQ_WIN_VS_NUSI_MESSAGE_START,
		SEQ_WIN_VS_NUSI_MESSAGE_WAIT,
		SEQ_EXIT
	}

	private MainModule m_mainModule;

	private BTL_CLIENT m_client;

	private POKECON m_pokecon;

	private BattleViewBase m_viewSystem;

	private int m_seq;

	private bool m_isFinished;

	private BTLV_STRPARAM m_strParam;

	public void Setup([In] ref SetupParam setupParam)
	{
	}

	public void Start()
	{
	}

	public bool IsFinished()
	{
		return default(bool);
	}

	public void Update()
	{
	}

	private bool IsNusiWinEffectEnable()
	{
		return default(bool);
	}
}
