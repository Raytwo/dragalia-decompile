using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_FieldEffect_Remove : Section
{
	public class Description
	{
		public EffectType effect;

		public BTL_POKEPARAM pDependPoke;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_FieldEffect_Remove([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool removeFieldEffect(EffectType effect, BTL_POKEPARAM pDependPoke)
	{
		return default(bool);
	}
}
