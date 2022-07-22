using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class ActionRecorder
{
	public enum ActionID : byte
	{
		FAILED_MASTER,
		FAILED_HIT_PERCENTAGE,
		FAILED_TOKUSEI,
		FAILED_TYPE,
		FAILED_GUARD_WAZA,
		NUM
	}

	private class PokeData
	{
		public uint actionFlag;
	}

	private class TurnData
	{
		public PokeData[] pokeData;

		public void CopyFrom(TurnData src)
		{
		}
	}

	public const uint RECORD_TURN_NUM = 2u;

	private TurnData[] m_turnData;

	public void CopyFrom([In] ref ActionRecorder src)
	{
	}

	public void Clear()
	{
	}

	private void ClearTurnData(TurnData turnData)
	{
	}

	public void StartTurn()
	{
	}

	public bool CheckAction(byte pokeId, byte backTurnCount, ActionID actionId)
	{
		return default(bool);
	}

	public void SetAction(byte pokeId, ActionID actionId)
	{
	}
}
