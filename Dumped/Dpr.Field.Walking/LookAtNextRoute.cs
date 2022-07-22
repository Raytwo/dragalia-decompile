using System.Collections;

namespace Dpr.Field.Walking;

public class LookAtNextRoute : ActionModel
{
	private float speed;

	private float duration;

	public LookAtNextRoute(float speed, float duration)
	{
	}

	public override IEnumerator DoAction(AIModel model)
	{
		return null;
	}
}
