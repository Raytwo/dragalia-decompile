using UnityEngine;

public class JumpCalculator
{
	private float _duration;

	private float _gravity;

	private Vector3 _velocity;

	private Vector3 _startingPoint;

	private float _timeSinceStartup;

	public void Startup(Transform transform, float moveDistance = 2f, float relativeHeight = 0.75f, float relativeLower = -0.5f, float duration = 0.5f)
	{
	}

	public Vector3 Process(float deltaTime, out bool isFinished)
	{
		return default(Vector3);
	}
}
