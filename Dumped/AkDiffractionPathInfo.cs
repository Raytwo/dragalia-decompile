using System;
using UnityEngine;

public class AkDiffractionPathInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public const uint kMaxNodes = 8u;

	public AkTransform virtualPos
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint nodeCount
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public float diffraction
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float totLength
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float obstructionValue
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	internal AkDiffractionPathInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkDiffractionPathInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkDiffractionPathInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}

	public Vector3 GetNodes(uint idx)
	{
		return default(Vector3);
	}

	public float GetAngles(uint idx)
	{
		return default(float);
	}

	public ulong GetPortals(uint idx)
	{
		return default(ulong);
	}

	public ulong GetRooms(uint idx)
	{
		return default(ulong);
	}

	public void Clone(AkDiffractionPathInfo other)
	{
	}

	public AkDiffractionPathInfo()
	{
	}
}
