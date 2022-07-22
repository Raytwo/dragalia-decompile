using UnityEngine;

namespace Dpr.UI;

public class UIWindowStateMachine : StateMachineBehaviour
{
	public static readonly int animParamConnectId;

	public static readonly int animParamStateId;

	public static readonly int animStateVoid;

	public static readonly int animStateOpened;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
