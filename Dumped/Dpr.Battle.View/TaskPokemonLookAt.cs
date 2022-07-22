using Dpr.Battle.View.Objects;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskPokemonLookAt : Task
{
	private BattleViewCharacter _iPtrPoke;

	private bool _isWaitFinish;

	protected override bool IsFinishCondition => default(bool);

	public TaskPokemonLookAt(BattleViewCharacter pPoke, Vector3 pos, int lifeTime)
	{
	}

	protected override void OnDispose()
	{
	}

	public override void Update(float deltaTime, float currentSeqeunceTime, int step)
	{
	}
}
