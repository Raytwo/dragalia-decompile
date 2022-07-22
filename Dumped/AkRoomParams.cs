using System;
using UnityEngine;

public class AkRoomParams : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public Vector3 Up
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 Front
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public uint ReverbAuxBus
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public float ReverbLevel
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float WallOcclusion
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float RoomGameObj_AuxSendLevelToSelf
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool RoomGameObj_KeepRegistered
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal AkRoomParams(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkRoomParams obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkRoomParams()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkRoomParams()
	{
	}
}
