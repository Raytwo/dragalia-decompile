using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class ClientSeq_Capture
{
	public class SetupParam
	{
		public MainModule mainModule;

		public BTL_CLIENT client;

		public POKECON pokecon;

		public BattleViewBase viewSystem;
	}

	private enum Sequence
	{
		SEQ_EXIT
	}

	private MainModule m_mainModule;

	private BTL_CLIENT m_client;

	private POKECON m_pokecon;

	private BattleViewBase m_viewSystem;

	private int m_seq;

	private bool m_isFinished;

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
}
