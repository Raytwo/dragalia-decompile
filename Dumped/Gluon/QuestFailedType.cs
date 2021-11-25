using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum QuestFailedType
	{
		NONE = 0,
		TIME_ELAPSED = 3,
		TIME_ELAPSED_ENEMY_ATTACK = 6,
		EVENT_DEFENSE = 7,
		PLAYER_DOWN = 8,
		NONE_FAILURE = 9
	}
}
