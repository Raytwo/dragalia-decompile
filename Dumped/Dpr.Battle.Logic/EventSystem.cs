using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class EventSystem
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public PokeActionContainer pPokeActionContainer;

		public PokeChangeRequest pPokeChangeRequest;

		public SectionContainer pSectionContainer;

		public SectionSharedData pSectionSharedData;
	}

	private MainModule m_pMainModule;

	private BattleEnv m_pBattleEnv;

	private PokeActionContainer m_pPokeActionContainer;

	private PokeChangeRequest m_pPokeChangeRequest;

	private SectionContainer m_pSectionContainer;

	private SectionSharedData m_pSectionSharedData;

	private EventVarStack m_variableStack;

	private EventVarSetStack m_variableSetStack;

	private EventVarSet m_pCurrentEventVarSet;

	private uint m_eventLevel;

	public EventSystem([In] ref SetupParam param)
	{
	}

	public void Initialize()
	{
	}

	public EventFactorContainer GetFactorContainer()
	{
		return null;
	}

	public EventFactor AddFactor(EventFactorType factorType, ushort subID, EventPriority mainPri, uint subPri, byte dependID, EventFactor.EventHandlerTable[] handlerTable, byte handlerNum)
	{
		return null;
	}

	public void RemoveFactor(EventFactor pFactor)
	{
	}

	public void RemoveIsolateFactors()
	{
	}

	public void SleepFactors(ushort pokeID, EventFactorType factorType)
	{
	}

	public void WakeFactors(ushort pokeID, EventFactorType factorType)
	{
	}

	public void WakeAllFactors()
	{
	}

	public void CallEvent(EventID eventID)
	{
	}

	public void CallEvent_Force(EventID eventID)
	{
	}

	public void CallEvent_TargetType(EventID eventID, EventFactorType type)
	{
	}

	private void callEventCore(EventID eventID, EventFactorType targetFactorType, bool isSkipCheckEnable)
	{
	}

	private void notifyHandlers(EventID eventID, EventFactorType targetFactorType, bool isSkipCheckEnable)
	{
	}

	private EventFactor nofityHandler(EventID eventID, EventFactorType targetFactorType, bool isSkipCheckEnable, EventFactor factor)
	{
		return null;
	}

	private bool checkHandlerSkip(EventFactor factor, EventID eventID)
	{
		return default(bool);
	}

	private EventFactor getFirstFactor()
	{
		return null;
	}

	public void EVENTVAR_Push()
	{
	}

	public void EVENTVAR_Pop()
	{
	}

	public void EVENTVAR_CheckStackCleared()
	{
	}

	public void EVENTVAR_SetValue(EventVar.Label label, int value)
	{
	}

	public void EVENTVAR_SetConstValue(EventVar.Label label, int value)
	{
	}

	public void EVENTVAR_SetRewriteOnceValue(EventVar.Label label, int value)
	{
	}

	public void EVENTVAR_RecoveryRewriteOncePermission(EventVar.Label label)
	{
	}

	public void EVENTVAR_SetMulValue(EventVar.Label label, int value, int mulMin, int mulMax)
	{
	}

	public bool EVENTVAR_RewriteValue(EventVar.Label label, int value)
	{
		return default(bool);
	}

	public void EVENTVAR_MulValue(EventVar.Label label, int value)
	{
	}

	public int EVENTVAR_GetValue(EventVar.Label label)
	{
		return default(int);
	}

	public bool EVENTVAR_GetValueIfExist(EventVar.Label label, out int pValue)
	{
		return default(bool);
	}

	public void EVENTVAR_SetWorkAddress(EventVar.Label label, object p)
	{
	}

	public object EVENTVAR_GetWorkAddress(EventVar.Label label)
	{
		return null;
	}
}
