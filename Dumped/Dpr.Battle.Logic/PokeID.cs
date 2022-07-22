namespace Dpr.Battle.Logic;

public static class PokeID
{
	public const byte NUM = 30;

	public const byte INVALID = 31;

	private static readonly byte[] ClientBasePokeID;

	public static byte GetClientBasePokeId(BTL_CLIENT_ID clientID)
	{
		return default(byte);
	}

	public static bool IsClientsPokeID(BTL_CLIENT_ID clientID, byte pokeID)
	{
		return default(bool);
	}

	public static byte GetClientPokeId(BTL_CLIENT_ID clientID, byte pokeIndex)
	{
		return default(byte);
	}

	public static byte PokeIdToStartMemberIndex(byte pokeID)
	{
		return default(byte);
	}

	public static BTL_CLIENT_ID PokeIdToClientId(byte pokeID)
	{
		return default(BTL_CLIENT_ID);
	}

	public static byte PokeIdToShortId(byte pokeID)
	{
		return default(byte);
	}

	public static byte ShortIdToPokeId(BTL_CLIENT_ID clientID, byte shortID)
	{
		return default(byte);
	}
}
