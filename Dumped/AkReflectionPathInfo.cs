using System;
using UnityEngine;

public class AkReflectionPathInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public Vector3 imageSource
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public uint numPathPoints
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint numReflections
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public float level
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool isOccluded
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal AkReflectionPathInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkReflectionPathInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkReflectionPathInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}

	public Vector3 GetPathPoint(uint idx)
	{
		return default(Vector3);
	}

	public AkAcousticSurface GetAcousticSurface(uint idx)
	{
		return null;
	}

	public float GetDiffraction(uint idx)
	{
		return default(float);
	}

	public void Clone(AkReflectionPathInfo other)
	{
	}

	public AkReflectionPathInfo()
	{
	}
}
