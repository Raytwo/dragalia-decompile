using System;
using UnityEngine;

[Obsolete]
public class AkVertex
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

	public static implicit operator Vector3(AkVertex vector)
	{
		return default(Vector3);
	}

	public AkVertex()
	{
	}

	public AkVertex(float x, float y, float z)
	{
	}

	public void Clear()
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}

	public void Clone(AkVertex other)
	{
	}
}
