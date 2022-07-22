using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class BattleDriver
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;
	}

	private MainModule m_pMainModule;

	private BattleEnv m_pBattleEnv;

	private ServerCommandQueue m_serverCmdQueue;

	private ServerCommandGenerator m_serverCmdGenerator;

	private ServerCommandPutter m_serverCmdPutter;

	private WazaCommandPutter m_wazaCmdPutter;

	private ServerCommandExecutor m_serverCmdExecutor;

	private EventSystem m_eventSystem;

	private EventLauncher m_eventLauncher;

	private PokeActionContainer m_pokeActionContainer;

	private SectionSharedData m_sectionSharedData;

	private SectionContainer m_sectionContainer;

	private PokeChangeRequest m_pokeChangeRequest;

	private CaptureInfo m_captureInfo;

	public BattleDriver([In] ref SetupParam setupParam)
	{
	}

	public void Dispose()
	{
	}

	private void createSectionSharedData()
	{
	}

	private void createEventSystem()
	{
	}

	private void createEventLauncher()
	{
	}

	private void createServerCommandExecutor()
	{
	}

	private void createServerCommandPutter()
	{
	}

	private void createWazaMessagePutter()
	{
	}

	private void createSections()
	{
	}

	private void createServerCommandGenerator()
	{
	}

	public void Initialize()
	{
	}

	public ServerCommandQueue GetServerCommandQueue()
	{
		return null;
	}

	public ServerCommandGenerator GetServerCommandGenerator()
	{
		return null;
	}

	public ServerCommandPutter GetServerCommandPutter()
	{
		return null;
	}

	public WazaCommandPutter GetWazaCommandPutter()
	{
		return null;
	}

	public ServerCommandExecutor GetServerCommandExecutor()
	{
		return null;
	}

	public EventSystem GetEventSystem()
	{
		return null;
	}

	public EventLauncher GetEventLauncher()
	{
		return null;
	}

	public PokeActionContainer GetPokeActionContainer()
	{
		return null;
	}

	public SectionSharedData GetSectionSharedData()
	{
		return null;
	}

	public SectionContainer GetSectionContainer()
	{
		return null;
	}

	public PokeChangeRequest GetPokeChangeRequest()
	{
		return null;
	}

	public CaptureInfo GetCaptureInfo()
	{
		return null;
	}
}
