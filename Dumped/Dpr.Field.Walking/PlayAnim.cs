using System.Collections;

namespace Dpr.Field.Walking;

public class PlayAnim : ActionModel
{
	private int anim;

	private float duration;

	private float startTime;

	public PlayAnim(int anim, float duration = 0.2f, float startTime = 0f)
	{
	}

	public override IEnumerator DoAction(AIModel model)
	{
		return null;
	}
}
