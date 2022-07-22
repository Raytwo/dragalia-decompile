using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class EventFactorContainer
{
	private const uint FACTOR_PER_POKE = 12u;

	private const uint FACTOR_MAX_FOR_POKE = 72u;

	private const uint FACTOR_MAX_FOR_SIDEEFF = 44u;

	private const uint FACTOR_MAX_FOR_POSEFF = 30u;

	private const uint FACTOR_MAX_FOR_FIELD = 10u;

	private const uint FACTOR_MAX_ALLOWANCE = 16u;

	private const uint FACTOR_REGISTER_MAX = 172u;

	private EventFactor[] m_factors;

	private EventFactor m_pRunningFactor;

	private EventFactor m_pStoredFactor;

	private const uint SUBPRI_BIT_WIDTH = 24u;

	private const uint SUBPRI_MAX = 16777215u;

	private static uint calcFactorPriority(EventPriority mainPri, uint subPri)
	{
		return default(uint);
	}

	private static bool isDependPokeFactorType(EventFactorType factorType)
	{
		return default(bool);
	}

	private void createFactors()
	{
	}

	private void storeAllFactors()
	{
	}

	public void CopyFrom([In] ref EventFactorContainer src)
	{
	}

	private EventFactor getFactor(ushort instanceID)
	{
		return null;
	}

	public void Clear()
	{
	}

	public EventFactor AddFactor(EventFactorType factorType, ushort subID, EventPriority mainPri, uint subPri, byte dependID, EventFactor.EventHandlerTable[] handlerTable, byte handlerNum, ushort eventLevel)
	{
		return null;
	}

	public void RemoveFactor(EventFactor pFactor)
	{
	}

	public EventFactor GetFirstFactor()
	{
		return null;
	}

	public EventFactor SeekFactor(EventFactorType factorType)
	{
		return null;
	}

	public EventFactor SeekFactor(EventFactorType factorType, byte dependID)
	{
		return null;
	}

	public EventFactor GetNextFactor(EventFactor pFactor, bool isSkipDependIDCheck = false)
	{
		return null;
	}

	private void storeFactor(EventFactor pFactor)
	{
	}

	private void storeAllRunningFactor()
	{
	}

	private EventFactor pickStoredFactor(int instanceID = -1)
	{
		return null;
	}

	private void addRunningFactor(EventFactor pNewFactor)
	{
	}

	public bool SwapFactorsSideEffect(BtlSide side1, BtlSide side2, BtlSideEffect effect)
	{
		return default(bool);
	}
}
