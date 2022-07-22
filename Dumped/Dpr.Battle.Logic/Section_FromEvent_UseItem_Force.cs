using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_UseItem_Force : Section
{
	public enum UseEffectType
	{
		Normal,
		Force,
		Disable
	}

	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public ushort itemID;

		public bool isAteKinomi;

		public UseEffectType useEffectType;
	}

	public class Result
	{
		public bool isUsed;
	}

	public Section_FromEvent_UseItem_Force([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void displayItemEffect([In] ref ServerCommandPutter.UseItemCommandParam param, UseEffectType effectType, bool isUsed)
	{
	}

	private void afterItemEquip(BTL_POKEPARAM poke, ushort itemID)
	{
	}
}
