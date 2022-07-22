namespace Dpr.Battle.Logic;

public static class PokemonPosition
{
	public const byte BTL_POS_NUM = 5;

	public const byte BTL_EXIST_POS_MAX = 6;

	public const byte BTL_POS_DOUBLE_NUM = 4;

	public const byte BTL_POS_RAID_NUM = 5;

	public const byte BTL_POS_RAID_NUM_PLAYERS = 4;

	public const byte BTL_POS_RAID_NUM_BOSS = 1;

	private static readonly BTL_CLIENT_ID[] GetPosCoverClientId_Single_POS_COVER_CLIENT_SINGLE;

	private static readonly BTL_CLIENT_ID[] GetPosCoverClientId_Double_POS_COVER_CLIENT_DOUBLE;

	private static readonly BTL_CLIENT_ID[] GetPosCoverClientId_Double_POS_COVER_CLIENT_DOUBLE_MULTI;

	private static readonly BTL_CLIENT_ID[] GetPosCoverClientId_Double_POS_COVER_CLIENT_DOUBLE_AI_TAG;

	private static readonly BTL_CLIENT_ID[] GetPosCoverClientId_Double_POS_COVER_CLIENT_DOUBLE_PA_A;

	private static readonly BTL_CLIENT_ID[] GetPosCoverClientId_Double_POS_COVER_CLIENT_DOUBLE_PA_A2;

	private static readonly BtlSide[] GetClientSide_Single_SIDE_TABLE;

	private static readonly BtlSide[] GetClientSide_Double_SIDE_TABLE;

	public static uint GetClientCoverPosNum(BtlRule rule, BtlMultiMode multiMode, BTL_CLIENT_ID clientId)
	{
		return default(uint);
	}

	public static BTL_CLIENT_ID GetPosCoverClientId(BtlRule rule, BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(BTL_CLIENT_ID);
	}

	private static BTL_CLIENT_ID GetPosCoverClientId_Single(BtlPokePos pos)
	{
		return default(BTL_CLIENT_ID);
	}

	private static BTL_CLIENT_ID GetPosCoverClientId_Double(BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(BTL_CLIENT_ID);
	}

	private static BTL_CLIENT_ID GetPosCoverClientId_Raid(BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(BTL_CLIENT_ID);
	}

	public static bool IsPokePosExist(BtlRule rule, BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(bool);
	}

	public static BtlPokePos GetValidPosMax(BtlRule rule)
	{
		return default(BtlPokePos);
	}

	public static BtlPokePos GetOpponentPokePos(BtlRule rule, BtlMultiMode multiMode, BtlPokePos myBasePos, byte opponentPosIndex)
	{
		return default(BtlPokePos);
	}

	public static byte GetClientNum(BtlRule rule, BtlMultiMode multiMode, BtlSide side)
	{
		return default(byte);
	}

	public static uint GetFrontPosNum(BtlRule rule, BtlMultiMode multiMode, BtlSide side)
	{
		return default(uint);
	}

	public static BtlPokePos GetSidePos(BtlRule rule, BtlSide side, byte posIndex)
	{
		return default(BtlPokePos);
	}

	public static BtlPokePos GetSidePos_Raid(BtlSide side, byte posIndex)
	{
		return default(BtlPokePos);
	}

	public static BtlSide PosToSide(BtlRule rule, BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(BtlSide);
	}

	public static bool IsPlayerSide(BtlSide playerSide, BtlSide checkSide)
	{
		return default(bool);
	}

	public static BtlSide GetOpponentSide(BtlRule rule, BtlSide side)
	{
		return default(BtlSide);
	}

	public static bool IsSideExist(BtlRule rule, BtlSide side)
	{
		return default(bool);
	}

	public static byte GetSideNum(BtlRule rule)
	{
		return default(byte);
	}

	public static void ExpandSide(BtlSide[] expandSide, ref byte expandSideNum, BtlRule rule, BtlSide targetSide)
	{
	}

	public static void AddSideIfExist(BtlSide[] destArray, ref byte count, BtlRule rule, BtlSide side)
	{
	}

	public static bool IsUnitSide(BtlSide side)
	{
		return default(bool);
	}

	public static bool IsMultiSide(BtlSide side)
	{
		return default(bool);
	}

	public static BtlSide GetClientSide(BtlRule rule, BTL_CLIENT_ID clientId)
	{
		return default(BtlSide);
	}

	private static BtlSide GetClientSide_Single(BTL_CLIENT_ID clientId)
	{
		return default(BtlSide);
	}

	private static BtlSide GetClientSide_Double(BTL_CLIENT_ID clientId)
	{
		return default(BtlSide);
	}

	private static BtlSide GetClientSide_Raid(BTL_CLIENT_ID clientId)
	{
		return default(BtlSide);
	}

	public static byte PosToSidePosIndex(BtlRule rule, BtlPokePos pos)
	{
		return default(byte);
	}

	private static byte PosToSidePosIndex_Raid(BtlPokePos pos)
	{
		return default(byte);
	}

	public static BtlPokePos GetFriendPokePos(BtlRule rule, BtlMultiMode multiMode, BtlPokePos myBasePos, byte sidePosIndex)
	{
		return default(BtlPokePos);
	}

	public static bool IsFriendPokePos(BtlRule rule, BtlMultiMode multiMode, BtlPokePos pos1, BtlPokePos pos2)
	{
		return default(bool);
	}

	public static BtlPokePos GetFacedPokePos(BtlRule rule, BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(BtlPokePos);
	}

	private static BtlPokePos GetFacedPokePos_Double(BtlMultiMode multiMode, BtlPokePos pos)
	{
		return default(BtlPokePos);
	}
}
