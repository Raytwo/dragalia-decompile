using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CommonAction
	{
		NONE = 0,
		STATE_STAY = 1,
		STATE_DEAD = 2,
		STATE_VICTORY = 3,
		STATE_MOVE = 4,
		STATE_TURN = 5,
		STATE_PARALYSIS = 8,
		STATE_FREEZE = 9,
		STATE_SWOON = 10,
		STATE_SLEEP = 11,
		STATE_ENEMY_POS_ADJUST = 12,
		COMMON_MOVE_BEHIND = 0xF,
		COMMON_BLASTUP = 0x10,
		COMMON_BLASTDOWN = 17,
		STATE_CARRY = 36,
		STATE_THROW = 37,
		STATE_CARRIED = 38,
		STATE_TORPEDO = 39
	}
}
