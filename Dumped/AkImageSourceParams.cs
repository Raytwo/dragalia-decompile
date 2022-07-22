using System;
using UnityEngine;

public class AkImageSourceParams : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public Vector3 sourcePosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float fDistanceScalingFactor
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float fLevel
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float fDiffraction
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public byte uDiffractionEmitterSide
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte uDiffractionListenerSide
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	internal AkImageSourceParams(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkImageSourceParams obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkImageSourceParams()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkImageSourceParams()
	{
	}

	public AkImageSourceParams(Vector3 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
	{
	}
}
