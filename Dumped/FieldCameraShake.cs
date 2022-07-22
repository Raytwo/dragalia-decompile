using System.Runtime.CompilerServices;
using Dpr;
using UnityEngine;

public class FieldCameraShake
{
	private FieldFloatMove Time;

	private Vector3 DefaultShakeOffset;

	private float Cycle;

	public Vector3 ShakeOffset
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Update(float deltaTime)
	{
	}

	public void Shake(Vector3 shakeOfs, float time, float cycle)
	{
	}
}
