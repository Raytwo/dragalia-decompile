using System.Runtime.CompilerServices;
using XLSXContent;

namespace Dpr.FureaiHiroba;

public sealed class PokeWalkingActionModel : PokeFureaiActionModel
{
	public enum PokeAction
	{
		Kyoro,
		Stop,
		Look,
		ToWalking,
		_None
	}

	private float coolTime;

	public bool isNoneActionMember;

	public bool isNoneStrayMember;

	public int StopThreshold
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int KyoroThreshold
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PokeWalkingActionModel(PokeWalkingActionNakayoshi.SheetSheet1 nakayoshi, PokeWalkingActionSeikaku.SheetSheet1 seikaku)
	{
	}

	public PokeAction LotteryAction(float deltaTime)
	{
		return default(PokeAction);
	}

	public PokeAction LotteryPokeAction()
	{
		return default(PokeAction);
	}
}
