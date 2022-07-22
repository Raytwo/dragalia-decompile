namespace Dpr.Field.Walking;

public class NpcCollitionModel : WalkingCollisionModelBase
{
	public NpcCollitionModel(WalkData walkData)
	{
	}

	public override void CollisionUpdate(float deltaTime)
	{
	}

	public override bool ObjectCollisionUpdate(float deltaTime, bool isIgnoreJump = false)
	{
		return default(bool);
	}

	public override void LateUpdate(float deltaTime)
	{
	}
}
