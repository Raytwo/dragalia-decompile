using System.Collections;
using UnityEngine;

namespace Dpr.Field.Walking;

public class SanpoPairActionCommon : ActionModel
{
	private delegate Coroutine deleCor();

	private int masterAnim;

	private int slaveAnim;

	private bool isCanSameTime;

	public SanpoPairActionCommon(int masterAnim, int slaveAnim, bool isCanSameTime = false)
	{
	}

	private IEnumerator WaitFrame(int count)
	{
		return null;
	}

	public override IEnumerator DoAction(AIModel m)
	{
		return null;
	}
}
