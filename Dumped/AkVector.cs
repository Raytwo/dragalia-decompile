using System;
using UnityEngine;

[Obsolete]
public class AkVector
{
	private Vector3 Vector;

	public float X
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Y
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Z
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public void Zero()
	{
	}

	public static implicit operator Vector3(AkVector vector)
	{
		return default(Vector3);
	}
}
