using Dpr.FureaiHiroba;

namespace Dpr.Field.Walking;

public abstract class SanpoStateBase : AIStateBase
{
	private static readonly int[] RankToEmoticonNo;

	protected new AIFureaiModel model => null;

	protected PokeSanpoModel sanpoModel => null;

	protected WalkData walkModel => null;

	public SanpoStateBase(AIFureaiModel model)
	{
	}

	protected bool CheckAddWalking()
	{
		return default(bool);
	}

	protected bool LookPlayer()
	{
		return default(bool);
	}

	protected override void StateUpdate()
	{
	}
}
