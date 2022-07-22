using System;
using System.Runtime.InteropServices;
using Audio;
using UnityEngine;

namespace Dpr.UI;

public class ZukanMovingEffecter : MonoBehaviour
{
	[Serializable]
	protected class SensorParam
	{
		public float max;

		public float min;
	}

	[SerializeField]
	protected SensorParam _sensorParam;

	protected float _maxLength;

	protected Animator _animator;

	protected const int _maxLevel = 5;

	protected static readonly int animParamStateId;

	protected float[] _values;

	public void Awake()
	{
	}

	public void Setup()
	{
	}

	protected void UpdateEffecter(uint gameParamId, float accelValue, bool isInstance = false, [Optional] AudioInstance voiceInstance)
	{
	}
}
