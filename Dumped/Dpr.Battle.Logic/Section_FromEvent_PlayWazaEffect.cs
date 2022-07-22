using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_PlayWazaEffect : Section
{
	public class Description
	{
		public BtlPokePos atkPos;

		public BtlPokePos defPos;

		public WazaNo waza;

		public byte wazaType;

		public BtlvWazaEffect_TurnType turnType;

		public byte pluralHitIndex;

		public bool isSyncEffect;
	}

	public class Result
	{
	}

	public Section_FromEvent_PlayWazaEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
