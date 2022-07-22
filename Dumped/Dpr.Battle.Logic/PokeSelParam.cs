namespace Dpr.Battle.Logic;

public sealed class PokeSelParam
{
	private BTL_CLIENT_ID m_clientID;

	private BTL_PARTY m_party;

	private byte m_numSelect;

	private bool m_bDisabledPutPosSequence;

	private byte[] m_prohibit;

	public BTL_PARTY GetParty()
	{
		return null;
	}

	public void Init(BTL_CLIENT_ID clientID, BTL_PARTY party, byte numSelect)
	{
	}

	public void SetProhibitFighting(byte numCover)
	{
	}

	public void SetProhibit(PokeselReason reason, byte idx)
	{
	}

	public BTL_CLIENT_ID GetClientID()
	{
		return default(BTL_CLIENT_ID);
	}

	public byte GetNumSelect()
	{
		return default(byte);
	}

	public void DisablePutPosSequence()
	{
	}

	public bool IsDisabledPutPosSequence()
	{
		return default(bool);
	}
}
