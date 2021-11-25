using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum SummonType
	{
		NONE,
		TUTORIAL,
		NORMAL,
		DEFINITE_SSR,
		CHARA_SSR,
		PLATINUM,
		DRAGON_SSR,
		TUTORIAL_REDOABLE,
		CAMPAIGN_SSR,
		CHARA_SSR_UPDATE,
		DRAGON_SSR_UPDATE,
		EXCLUDE
	}
}
