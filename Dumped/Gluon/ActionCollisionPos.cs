using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ActionCollisionPos
	{
		NONE = 0,
		SELF = 1,
		SELF_C = 2,
		TARGET = 3,
		TARGET_C = 4,
		FRONT_R = 5,
		FRONT_CR = 6,
		FRONT_CHR = 7,
		SLOT_ATTACK = 8,
		SLOT_ARM_R = 9,
		SLOT_ARM_L = 10,
		SLOT_TAIL_B = 11,
		SLOT_HEAD = 13,
		SLOT_JAW = 14,
		SELF_GROUND = 0xF,
		TARGET_GROUND = 0x10,
		SLOT_HAND_R = 17,
		SLOT_HAND_L = 18,
		MARKER = 19,
		MARKER_U_RANDOM = 20,
		SLOT_WEAPON_R = 21,
		SLOT_WEAPON_L = 22,
		SPECIFY_ID = 23,
		AREA_ANCHOR = 24,
		TARGET_P = 25,
		RESERVE_02 = 26,
		RESERVE_03 = 27,
		RESERVE_04 = 28,
		RESERVE_05 = 29,
		RESERVE_06 = 30,
		RESERVE_07 = 0x1F,
		RESERVE_08 = 0x20,
		RESERVE_09 = 33,
		RESERVE_10 = 34
	}
}
