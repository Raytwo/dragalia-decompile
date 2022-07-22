using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public class Section
{
	public class CommonParam
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public ServerCommandQueue pServerCmdQueue;

		public ServerCommandPutter pServerCmdPutter;

		public WazaCommandPutter pWazaCmdPutter;

		public EventSystem pEventSystem;

		public EventLauncher pEventLauncher;

		public SectionSharedData pSharedData;

		public PokeActionContainer pPokemonActionContainer;

		public PokeChangeRequest pPokeChangeRequest;

		public CaptureInfo pCaptureInfo;

		public SectionContainer pSectionContainer;
	}

	private MainModule m_pMainModule;

	private BattleEnv m_pBattleEnv;

	private ServerCommandQueue m_pServerCmdQueue;

	private ServerCommandPutter m_pServerCmdPutter;

	private WazaCommandPutter m_pWazaCmdPutter;

	private EventSystem m_pEventSystem;

	private EventLauncher m_pEventLauncher;

	private SectionSharedData m_pSharedData;

	private PokeActionContainer m_pPokemonActionContainer;

	private PokeChangeRequest m_pPokeChangeRequest;

	private CaptureInfo m_pCaptureInfo;

	private SectionContainer m_pSectionContainer;

	public Section([In] ref CommonParam param)
	{
	}

	protected MainModule GetMainModule()
	{
		return null;
	}

	protected BattleEnv GetBattleEnv()
	{
		return null;
	}

	protected ServerCommandQueue GetServerCommandQueue()
	{
		return null;
	}

	protected ServerCommandPutter GetServerCommandPutter()
	{
		return null;
	}

	protected WazaCommandPutter GetWazaCommandPutter()
	{
		return null;
	}

	protected EventSystem GetEventSystem()
	{
		return null;
	}

	protected EventLauncher GetEventLauncher()
	{
		return null;
	}

	protected SectionSharedData GetSharedData()
	{
		return null;
	}

	protected ActionSharedData GetActionSharedData()
	{
		return null;
	}

	protected PokeActionContainer GetPokemonActionContainer()
	{
		return null;
	}

	protected PokeChangeRequest GetPokeChangeRequest()
	{
		return null;
	}

	protected CaptureInfo GetCaptureInfo()
	{
		return null;
	}

	protected SectionContainer GetSectionContainer()
	{
		return null;
	}

	protected byte GetPokeID(BtlPokePos pos)
	{
		return default(byte);
	}

	protected BTL_POKEPARAM GetPokeParam(byte pokeID)
	{
		return null;
	}

	protected BTL_POKEPARAM GetPokeParam(BtlPokePos pos)
	{
		return null;
	}

	protected BTL_POKEPARAM GetPokeParam(byte clientID, byte posIdx)
	{
		return null;
	}

	protected BtlPokePos GetPokePos(BTL_POKEPARAM poke)
	{
		return default(BtlPokePos);
	}

	protected BtlPokePos GetPokePos(byte pokeID)
	{
		return default(BtlPokePos);
	}

	protected BtlSide GetPokeSide(BTL_POKEPARAM poke)
	{
		return default(BtlSide);
	}

	protected BtlSide GetPokeSide(byte pokeID)
	{
		return default(BtlSide);
	}

	protected BTL_PARTY GetPokeParty(byte clientID)
	{
		return null;
	}

	protected BtlRule GetRule()
	{
		return default(BtlRule);
	}

	protected BtlMultiMode GetMultiMode()
	{
		return default(BtlMultiMode);
	}

	protected BtlCompetitor GetCompetitor()
	{
		return default(BtlCompetitor);
	}

	protected bool CheckCommMode()
	{
		return default(bool);
	}

	protected bool CheckStatusFlag(BTL_STATUS_FLAG flag)
	{
		return default(bool);
	}

	protected bool CheckFriendPoke(BTL_POKEPARAM poke1, BTL_POKEPARAM poke2)
	{
		return default(bool);
	}

	protected bool CheckFriendPoke(byte pokeID1, byte pokeID2)
	{
		return default(bool);
	}

	protected bool CheckShowdown()
	{
		return default(bool);
	}

	protected bool CheckAllDeadSide(BtlSide checkSide)
	{
		return default(bool);
	}

	protected bool CheckSkipBattleAfterShowdown()
	{
		return default(bool);
	}

	protected bool CheckTurnEnd(InterruptCode interruptCode)
	{
		return default(bool);
	}

	protected bool CheckPlayersClient(BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	protected byte GetFriendship(BTL_POKEPARAM poke)
	{
		return default(byte);
	}

	protected bool CheckPlayersPoke(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	protected bool CheckPlayersPoke(byte pokeID)
	{
		return default(bool);
	}

	protected bool CheckPlayersFriendPoke(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	protected bool CheckPlayersFriendPoke(byte pokeID)
	{
		return default(bool);
	}

	protected bool CheckMustHit(BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	protected bool CheckInvalidWaza(WazaNo waza)
	{
		return default(bool);
	}

	protected bool CheckWazaEffectEnable()
	{
		return default(bool);
	}

	protected bool CheckSkyBattleFailWaza(WazaNo waza)
	{
		return default(bool);
	}

	protected WazaNo CheckEncoreWazaChange(PokeAction action)
	{
		return default(WazaNo);
	}

	protected ulong GetCounter(BattleCounter.UniqueCounter counterID)
	{
		return default(ulong);
	}

	protected ulong GetCounter(BattleCounter.ClientCounter counterID, BTL_CLIENT_ID clientID)
	{
		return default(ulong);
	}
}
