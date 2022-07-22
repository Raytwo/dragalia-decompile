using System.Collections;
using UnityEngine;
using nn.hid;

namespace Dpr.SecretBase;

public class StatueVibration : MonoBehaviour
{
	private const int vibrationDeviceCountMax = 2;

	private int vibrationDeviceCount;

	private VibrationDeviceHandle[] vibrationDeviceHandles;

	private VibrationDeviceInfo[] vibrationDeviceInfos;

	private VibrationValue vibrationHighValue;

	private VibrationValue vibrationLowValue;

	private VibrationValue vibrationStopValue;

	private NpadId npadId;

	private NpadStyle npadStyle;

	private NpadState npadState;

	private Coroutine vibHandler;

	private VibrationValue vibrationValue;

	private void Start()
	{
	}

	public void Execute(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh, float period)
	{
	}

	private void SendValue(VibrationValue value, float period)
	{
	}

	private IEnumerator StartVibration(VibrationValue value, float period)
	{
		return null;
	}

	private void UpdateState()
	{
	}

	private void GetVibrationDevice(NpadId id, NpadStyle style)
	{
	}
}
