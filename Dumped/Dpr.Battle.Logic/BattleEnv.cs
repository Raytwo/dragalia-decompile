using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class BattleEnv
{
	public class SetupParam
	{
		public MainModule pMainModule;
	}

	private POKECON m_pokecon;

	private FieldStatus m_fieldStatus;

	private SideEffectManager m_sideEffectManager;

	private PosEffectManager m_posEffectManager;

	private EventFactorContainer m_eventFactorContainer;

	private PosPoke m_posPoke;

	private DeadRec m_deadRec;

	private WazaRec m_wazaRec;

	private AffCounter m_affCounter;

	private ActionRecorder m_actionRecorder;

	private ActionSerialNoManager m_actionSerialNoManager;

	private TimeLimit m_timeLimit;

	private GRightsManager m_gRightsManager;

	private GGauge[] m_gGauge;

	private RaidBattleStatus m_raidBattleStatus;

	private BattleFlags m_flags;

	private BattleCounter m_counter;

	private EscapeInfo m_escapeInfo;

	private WazaParam m_lastExecutedWaza;

	private TamaHiroiData m_tamaHiroiData;

	public BattleEnv([In] ref SetupParam param)
	{
	}

	public void Dispose()
	{
	}

	public void Initialize(MainModule mainModule)
	{
	}

	public void CopyFrom([In] ref BattleEnv src)
	{
	}

	public POKECON GetPokeCon()
	{
		return null;
	}

	public FieldStatus GetFieldStatus()
	{
		return null;
	}

	public SideEffectManager GetSideEffectManager()
	{
		return null;
	}

	public SideEffectStatus GetSideEffectStatus(BtlSide side, BtlSideEffect effect)
	{
		return null;
	}

	public PosEffectStatus GetPosEffectStatus(BtlPokePos pos, BtlPosEffect effect)
	{
		return null;
	}

	public EventFactorContainer GetEventFactorContainer()
	{
		return null;
	}

	public PosPoke GetPosPoke()
	{
		return null;
	}

	public DeadRec GetDeadRec()
	{
		return null;
	}

	public WazaRec GetWazaRec()
	{
		return null;
	}

	public AffCounter GetAffinityCounter()
	{
		return null;
	}

	public ActionRecorder GetActionRecorder()
	{
		return null;
	}

	public ActionSerialNoManager GetActionSerialNoManager()
	{
		return null;
	}

	public TimeLimit GetTimeLimit()
	{
		return null;
	}

	public GRightsManager GetGRightsManager()
	{
		return null;
	}

	public GGauge GetGGauge(BTL_CLIENT_ID clientID)
	{
		return null;
	}

	public RaidBattleStatus GetRaidBattleStatus()
	{
		return null;
	}

	public BattleFlags GetBattleFlags()
	{
		return null;
	}

	public BattleCounter GetBattleCounter()
	{
		return null;
	}

	public EscapeInfo GetEscapeInfo()
	{
		return null;
	}

	public WazaParam GetLastExecutedWaza()
	{
		return null;
	}

	public void SetLastExecutedWaza([In] ref WazaParam wazaParam)
	{
	}

	public void SetTamaHiroiData(ushort itemNo)
	{
	}

	public ushort GetTamaHiroiData()
	{
		return default(ushort);
	}
}
