using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class SectionSharedData
{
	public class SetupParam
	{
	}

	public enum TurnFlag : ulong
	{
		ESCAPE_MESSAGE_DISPLAYED,
		TURN_START_PROCESS_DONE,
		BEFORE_FIRST_FIGHT_PROCESS_DONE,
		RAID_BOSS_EXTRA_ACTION_ADD,
		GWALL_BREAK_EFFECT_DISPLAYED,
		NUM
	}

	private ActionSharedDataStack m_actionSharedDataStack;

	private InterruptAccessor m_interruptAccessor;

	private PartyAllDeadRecorder m_partyAllDeadRecorder;

	private PokemonBattleInRegister m_pokemonBattleInRegister;

	private ushort[] m_itemChangeCounter;

	private byte m_turnCheckStep;

	private ulong m_turnFlag;

	public SectionSharedData([In] ref SetupParam param)
	{
	}

	public void Initialize()
	{
	}

	public ActionSharedDataStack GetActionSharedDataStack()
	{
		return null;
	}

	public InterruptAccessor GetInterruptAccessor()
	{
		return null;
	}

	public PartyAllDeadRecorder GetPartyAllDeadRecorder()
	{
		return null;
	}

	public PokemonBattleInRegister GetPokemonBattleInRegister()
	{
		return null;
	}

	public byte GetTurnCheckStep()
	{
		return default(byte);
	}

	public void IncTurnCheckStep()
	{
	}

	public void ResetTurnCheckStep()
	{
	}

	public ushort GetItemChangeCount(byte pokeID)
	{
		return default(ushort);
	}

	public void IncItemChangeCount(byte pokeID)
	{
	}

	public void ClearItemChangeCount()
	{
	}

	public bool GetTurnFlag(TurnFlag flag)
	{
		return default(bool);
	}

	public void SetTurnFlag(TurnFlag flag)
	{
	}

	public void ResetTurnFlag(TurnFlag flag)
	{
	}

	public void ClearTurnFlag()
	{
	}
}
