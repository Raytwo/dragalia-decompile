namespace Dpr.Battle.Logic;

public sealed class PokeIDRec
{
	private const int CAPACITY_PER_CLIENT = 6;

	private byte[][] m_registeredID;

	public void Dispose()
	{
	}

	public void Clear()
	{
	}

	public void Register(byte pokeID)
	{
	}

	public bool IsRegistered(byte pokeID)
	{
		return default(bool);
	}

	public bool IsRegisteredRecent(byte pokeID, byte checkCount)
	{
		return default(bool);
	}

	private void removeID(byte clientID, byte pokeID)
	{
	}

	private void addID(byte clientID, byte pokeID)
	{
	}

	private int findIndex(byte clientID, byte pokeID)
	{
		return default(int);
	}
}
