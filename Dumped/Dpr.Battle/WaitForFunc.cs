using System;
using UnityEngine;

namespace Dpr.Battle;

public class WaitForFunc : CustomYieldInstruction
{
	private Func<bool> _onComplete;

	public override bool keepWaiting => default(bool);

	public WaitForFunc(Func<bool> onComplete)
	{
	}
}
