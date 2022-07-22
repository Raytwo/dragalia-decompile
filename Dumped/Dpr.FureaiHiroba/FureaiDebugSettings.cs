using Pml.PokePara;
using UnityEngine;

namespace Dpr.FureaiHiroba;

public class FureaiDebugSettings : MonoBehaviour
{
	public int Button01;

	public static float _Time_ActionInterval;

	[SerializeField]
	private float Time_ActionInterval;

	public static bool _StopOnly;

	[SerializeField]
	private bool StopOnly;

	public static bool _KyoroOnly;

	[SerializeField]
	private bool KyoroOnly;

	public int Button03;

	public static bool _WaitKyoroOnly;

	[SerializeField]
	private bool WaitKyoroOnly;

	public static bool _UroUroOnly;

	[SerializeField]
	private bool UroUroOnly;

	public static bool _RunOnly;

	[SerializeField]
	private bool RunOnly;

	public static bool _SleepOnly;

	[SerializeField]
	private bool SleepOnly;

	public int Button02;

	public static bool _Enable;

	[SerializeField]
	private bool Enable;

	public static uint _Nakayoshi;

	[SerializeField]
	private uint Nakayoshi;

	public static Seikaku _Seikaku;

	[SerializeField]
	private Seikaku Seikaku;

	public static string _TalkText;

	[SerializeField]
	private string TalkText;

	private void OnValidate()
	{
	}

	private void AAA()
	{
	}
}
