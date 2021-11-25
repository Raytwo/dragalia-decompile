using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ExHunterEventItemType
	{
		NONE = 0,
		SUMMON_POINT_01 = 10101,
		EX_HUNTER_POINT_01 = 10201,
		EX_HUNTER_POINT_02 = 10202,
		EX_HUNTER_POINT_03 = 10203,
		ADVENT_ITEM_01 = 10301,
		ADVENT_ITEM_02 = 10302,
		ULTIMATE_ITEM_01 = 10401,
		EXCHANGE_ITEM_01 = 10501,
		EXCHANGE_ITEM_02 = 10502
	}
}
