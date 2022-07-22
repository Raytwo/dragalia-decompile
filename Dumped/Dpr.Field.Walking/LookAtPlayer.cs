using System.Collections;

namespace Dpr.Field.Walking;

public class LookAtPlayer : ActionModel
{
	private float duration;

	private float speed;

	public LookAtPlayer(float duration, float speed = 5f)
	{
	}

	public override IEnumerator DoAction(AIModel model)
	{
		return null;
	}
}
