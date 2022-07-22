using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SetPower : Section
{
	public class Description
	{
		public byte pokeID;

		public ushort attack;

		public ushort defence;

		public ushort spAttack;

		public ushort spDefence;

		public ushort agility;

		public bool isAttackEnable;

		public bool isDefenceEnable;

		public bool isSpAttackEnable;

		public bool isSpDefenceEnable;

		public bool isAgilityEnable;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_SetPower([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
