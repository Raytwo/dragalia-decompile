using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using nn.hid;

namespace Dpr.DigFossil;

public class DigVibration : MonoBehaviour
{
	[SerializeField]
	private Text timeText;

	[SerializeField]
	private Text lowAmpText;

	[SerializeField]
	private Text highAmpText;

	[SerializeField]
	private Text lowFreqText;

	[SerializeField]
	private Text highFreqText;

	private const int vibrationDeviceCountMax = 2;

	private int vibrationDeviceCount;

	private Coroutine vibHandler;

	private readonly VibrationDeviceHandle[] vibrationDeviceHandles;

	private readonly VibrationDeviceInfo[] vibrationDeviceInfos;

	private VibrationValue vibrationHighValue;

	private VibrationValue vibrationLowValue;

	private VibrationValue vibrationStopValue;

	private NpadId currentNpadId;

	private NpadStyle currentNpadStyle;

	private VibrationValue vibrationValue;

	private void Start()
	{
	}

	public void Picaxe()
	{
	}

	public void Hummer()
	{
	}

	public void HardStone()
	{
	}

	public void CollapsePhase1(float time)
	{
	}

	public void CollapsePhase2(float time)
	{
	}

	private void SendValue(VibrationValue value, float period)
	{
	}

	private IEnumerator StartVibration(VibrationValue value, float period)
	{
		return null;
	}

	private void GetVibrationDevice(NpadId id, NpadStyle style)
	{
	}
}
