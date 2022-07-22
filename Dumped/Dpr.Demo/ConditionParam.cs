using Pml.PokePara;

namespace Dpr.Demo;

public class ConditionParam
{
	public byte[] PrevCondition;

	public byte[] NowCondition;

	public byte[] AddCondition;

	public Taste taste;

	public TasteJudge tasteJudge;

	public bool IsConditionUp(Condition condition)
	{
		return default(bool);
	}

	public bool IsConditionMax(Condition condition)
	{
		return default(bool);
	}
}
