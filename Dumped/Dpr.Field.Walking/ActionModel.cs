using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.SubContents;

namespace Dpr.Field.Walking;

public abstract class ActionModel : IHaveWeight
{
	public delegate bool Usable();

	public float priority;

	public float coolTime;

	public float downTime;

	public float elapsedTime;

	public int lotteryType;

	public const int Lottery_Normal = 0;

	public const int Lottery_Force = 1;

	public float lotteryWeight
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public event EventHandler<int> OnNeedEffect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Usable usables
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public virtual IEnumerator DoAction(AIModel model)
	{
		return null;
	}

	public ActionModel()
	{
	}

	public bool IsUsable()
	{
		return default(bool);
	}
}
