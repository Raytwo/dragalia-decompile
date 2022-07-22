using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class EventFactor
{
	public class EventHandlerArgs
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public PokeActionContainer pPokeActionContainer;

		public PokeChangeRequest pPokeChangeRequest;

		public SectionContainer pSectionContainer;

		public SectionSharedData pSectionSharedData;

		public EventSystem pEventSystem;

		public EventVarSet pEventVar;

		public EventFactor pMyFactor;
	}

	public delegate void EventHandler([In] ref EventHandlerArgs args, byte dependID);

	public class EventHandlerTable
	{
		public EventID eventID;

		public EventHandler eventHandler;

		public EventHandlerTable(EventID eventID, EventHandler eventHandler)
		{
		}
	}

	public class SkipCheckHandlerArgs
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public EventFactor pMyFactor;

		public EventID eventID;

		public EventFactorType factorType;

		public ushort subID;

		public byte dependID;
	}

	public delegate bool SkipCheckHandler([In] ref SkipCheckHandlerArgs args);

	private class Data
	{
		public EventHandlerTable[] handlerTable;

		public SkipCheckHandler skipCheckHandler;

		public EventFactorType factorType;

		public uint priority;

		public ushort subID;

		public byte dependID;

		public byte pokeID;

		public uint eventLevel;

		public uint numHandlers;

		public bool callingFlag;

		public bool recallEnableFlag;

		public bool rmReserveFlag;

		public bool sleepFlag;

		public bool tmpItemFlag;

		public bool existFlag;

		public int[] work;

		public void Clear()
		{
		}

		public void ClearWork()
		{
		}

		public void CopyFrom(Data src)
		{
		}
	}

	public const uint EVENT_HANDLER_WORK_ELEMS = 7u;

	private ushort m_instanceID;

	private EventFactor m_prevFactor;

	private EventFactor m_nextFactor;

	private Data m_data;

	public EventFactor(ushort factorID)
	{
	}

	public void CopyFrom([In] ref EventFactor src)
	{
	}

	public void Clear()
	{
	}

	public ushort GetInstanceID()
	{
		return default(ushort);
	}

	public void ClearWork()
	{
	}

	public int[] GetWork()
	{
		return null;
	}

	public int GetWorkValue(byte workIdx)
	{
		return default(int);
	}

	public void SetWorkValue(byte workIdx, int value)
	{
	}

	public void SetTmpItemFlag()
	{
	}

	public void SetRecallEnable()
	{
	}

	public void ResetRecallEnable()
	{
	}

	public byte GetPokeID()
	{
		return default(byte);
	}

	public void AttachSkipCheckHandler(SkipCheckHandler handler)
	{
	}

	public void DetachSkipCheckHandler()
	{
	}

	public SkipCheckHandler GetSkipCheckHandler()
	{
		return null;
	}

	public void ConvertForIsolate()
	{
	}

	public bool IsIsolateMode()
	{
		return default(bool);
	}

	public bool Sleep()
	{
		return default(bool);
	}

	public bool Wake()
	{
		return default(bool);
	}

	public void Link(EventFactor next)
	{
	}

	public void Unlink()
	{
	}

	public EventFactor GetNext()
	{
		return null;
	}

	public EventFactor GetPrev()
	{
		return null;
	}

	public ushort GetEventLevel()
	{
		return default(ushort);
	}

	public void SetEventLevel(ushort value)
	{
	}

	public EventFactorType GetFactorType()
	{
		return default(EventFactorType);
	}

	public uint GetPriority()
	{
		return default(uint);
	}

	public byte GetDependID()
	{
		return default(byte);
	}

	public ushort GetSubID()
	{
		return default(ushort);
	}

	public bool GetExistFlag()
	{
		return default(bool);
	}

	public bool GetRemoveReserveFlag()
	{
		return default(bool);
	}

	public bool GetCallingFlag()
	{
		return default(bool);
	}

	public bool GetRecallEnableFlag()
	{
		return default(bool);
	}

	public bool GetSleepFlag()
	{
		return default(bool);
	}

	public bool GetTempItemFlag()
	{
		return default(bool);
	}

	public EventHandlerTable[] GetHandlerTable()
	{
		return null;
	}

	public byte GetHandlerNum()
	{
		return default(byte);
	}

	public void SetFactorType(EventFactorType type)
	{
	}

	public void SetPriority(uint value)
	{
	}

	public void SetSubID(ushort value)
	{
	}

	public void SetDependID(byte value)
	{
	}

	public void SetPokeID(byte pokeID)
	{
	}

	public void SetExistFlag(bool value)
	{
	}

	public void SetRemoveReserverFlag(bool value)
	{
	}

	public void SetCallingFlag(bool value)
	{
	}

	public void SetHandlerTable(EventHandlerTable[] handlerTable, byte handlerNum)
	{
	}
}
