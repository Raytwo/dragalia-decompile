using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CharacterStates
	{
		Idle,
		Attack,
		Skill,
		Avoid,
		Guard,
		GuardCancelAttack,
		Damaged,
		BlastUp,
		BlastDown,
		BlastSp,
		Freeze,
		Paralysis,
		Swoon,
		Sleep,
		Dead,
		Break,
		Event,
		EventMove,
		Transform,
		Charge,
		Recovery,
		Fall,
		Leave,
		ReserverIn,
		Suppression,
		Carry,
		Carried,
		Throw,
		Torpedo,
		Bind,
		PartsDestroy,
		ShapeShift,
		Revive,
		GuardCancel,
		UniqueTransform,
		SkillCasting,
		Boundary,
		AlloutAssault
	}
}
