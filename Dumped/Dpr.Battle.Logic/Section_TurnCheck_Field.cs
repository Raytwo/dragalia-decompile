using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnCheck_Field : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	public Section_TurnCheck_Field([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool incTurnCount(EffectType effect)
	{
		return default(bool);
	}

	private void removeEffect(EffectType effect)
	{
	}
}
