using System;
using UnityEngine;

public class AkAuxSendValue : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public ulong listenerID
	{
		get
		{
			return default(ulong);
		}
		set
		{
		}
	}

	public uint auxBusID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public float fControlValue
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkAuxSendValue obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkAuxSendValue()
	{
	}

	public virtual void Dispose()
	{
	}

	public void Set(GameObject listener, uint id, float value)
	{
	}

	public bool IsSame(GameObject listener, uint id)
	{
		return default(bool);
	}

	public static int GetSizeOf()
	{
		return default(int);
	}
}
