using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_CheckSpecialWazaAdditionalEffectOccur : Section
{
	public class Description
	{
		public byte atkPokeID;

		public byte defPokeID;

		public byte defaultPer;
	}

	public class Result
	{
		public bool isOccur;
	}

	public Section_FromEvent_CheckSpecialWazaAdditionalEffectOccur([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
