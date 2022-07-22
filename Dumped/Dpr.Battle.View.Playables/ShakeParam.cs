using System;
using UnityEngine;

namespace Dpr.Battle.View.Playables;

[Serializable]
public struct ShakeParam
{
	public Vector3 Strength;

	public int Vibrato;

	public float Randomness;

	public bool FadeOut;

	public static ShakeParam Factory(bool isShakeParam = false)
	{
		return default(ShakeParam);
	}
}
