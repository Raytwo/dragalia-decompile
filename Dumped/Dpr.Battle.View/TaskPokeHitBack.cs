using Dpr.Battle.View.Objects;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskPokeHitBack : Task
{
	private enum Sequence
	{
		BACK,
		RETURN,
		FINISH
	}

	public enum Mode
	{
		All,
		BackOnly
	}

	private BattleViewCharacter _iPtrPoke;

	private Sequence _current;

	private Vector3 _startPos;

	private Vector3 _hitbackPos;

	private new float _elapsedTime;

	public TaskPokeHitBack(BattleViewCharacter target, int cnt = 0, int maxCnt = 3)
	{
	}

	protected override void OnDispose()
	{
	}

	public override void Update(float deltaTime, float currentSeqeunceTime, int step)
	{
	}
}
