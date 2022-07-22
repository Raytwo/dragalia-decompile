using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Net.Data;

public class ServerVersions
{
	public const int ELEM_MAX = 4;

	public const int StationIndexInvalid = -1;

	private ServerVersionData[] m_element;

	private byte m_maxVersion;

	private byte m_serverClientID;

	public void Initialize()
	{
	}

	public void SetServerVersion(int clientID, [In] ref ServerVersionData data)
	{
	}

	public int GetRecievedBits()
	{
		return default(int);
	}

	public void DetermineServerVersion()
	{
	}

	public bool RemoveByStationIndex(int stationIndex)
	{
		return default(bool);
	}

	public bool ExistsByStationIndex(int stationIndex)
	{
		return default(bool);
	}

	public byte MaxVersion()
	{
		return default(byte);
	}

	public byte GetServerClientID()
	{
		return default(byte);
	}

	public void SetServerClientID(byte clientId)
	{
	}

	public bool IsDeterminedServer()
	{
		return default(bool);
	}

	public int GetStationIndex(BTL_CLIENT_ID clientID)
	{
		return default(int);
	}

	public BTL_CLIENT_ID GetClientID(int stationIndex)
	{
		return default(BTL_CLIENT_ID);
	}
}
