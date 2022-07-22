using System;
using UnityEngine;
using nn.hid;

namespace Dpr;

public static class SixAxisSensorManager
{
	[Flags]
	public enum SixAxisSensorAttribute
	{
		IsConnected = 1,
		IsInterpolated = 2
	}

	public enum NpadId
	{
		No1 = 0,
		No2 = 1,
		No3 = 2,
		No4 = 3,
		No5 = 4,
		No6 = 5,
		No7 = 6,
		No8 = 7,
		Handheld = 32,
		Invalid = 64
	}

	[Flags]
	public enum NpadStyle
	{
		None = 0,
		FullKey = 1,
		Handheld = 2,
		JoyDual = 4,
		JoyLeft = 8,
		JoyRight = 0x10,
		Invalid = 0x20
	}

	public class SensorState
	{
		public const float AccelerometerMax = 7f;

		public const float AngularVelocityMax = 5f;

		public long deltaTimeNanoSeconds;

		public long samplingNumber;

		public Vector3 acceleration;

		public Vector3 angularVelocity;

		public Vector3 angle;

		public SixAxisSensorAttribute attributes;

		public Quaternion quaternion;

		public Vector3 gravity;

		public Vector3 userAcceleration;

		public SixAxisSensorState native;

		public void Update()
		{
		}
	}

	private const int HandleMax = 2;

	private static nn.hid.NpadId _currentNpadId;

	private static nn.hid.NpadStyle _currentNpadStyle;

	private static int _handlesCount;

	private static SixAxisSensorHandle[] _handles;

	private static SensorState[] _states;

	private static bool _isInitialized;

	private static bool _enableSensor;

	public static int handleCount => default(int);

	public static void Initialize()
	{
	}

	private static void OnSettingValueChanged(ConfigID configId, int value)
	{
	}

	public static void Terminate()
	{
	}

	public static SensorState GetSensorState(int index)
	{
		return null;
	}

	private static void OnUpdate(float deltaTime)
	{
	}

	private static void UpdateInternal(float deltaTime)
	{
	}

	private static bool UpdatePadState()
	{
		return default(bool);
	}

	private static void GetSixAxisSensor(nn.hid.NpadId id, nn.hid.NpadStyle style)
	{
	}
}
