using UnityEngine;

namespace Dpr.Field.Walking;

public class MyWaitForSeconds : CustomYieldInstruction
{
	public bool IsCompleted;

	private float elapsedTime;

	private float targetTime;

	public override bool keepWaiting => default(bool);

	public MyWaitForSeconds(float targetTime)
	{
	}
}
