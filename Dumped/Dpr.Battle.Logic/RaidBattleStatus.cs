using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class RaidBattleStatus
{
	private byte m_allDeadCount;

	private ushort[] m_turnCountAfterAllDead;

	private bool m_isPlayBtlEffectKill;

	public void Initialize()
	{
	}

	public void CopyFrom([In] ref RaidBattleStatus src)
	{
	}

	public byte GetAllDeadCount()
	{
		return default(byte);
	}

	public void IncAllDeadCount()
	{
	}

	public bool IsAllDeadCountMax()
	{
		return default(bool);
	}

	public ushort GetTurnCountAfterAllDead(BTL_CLIENT_ID clientID)
	{
		return default(ushort);
	}

	public void IncTurnCountAfterAllDead(BTL_CLIENT_ID clientID)
	{
	}

	public void ResetTurnCountAfterAllDead(BTL_CLIENT_ID clientID)
	{
	}

	public void PlayBtlEffectKill()
	{
	}

	public bool IsPlayBtlEffectKill()
	{
		return default(bool);
	}
}
