using System;

public class AkAcousticSurface : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint textureID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public float occlusion
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public string strName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AkAcousticSurface(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkAcousticSurface obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkAcousticSurface()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkAcousticSurface()
	{
	}

	public void Clear()
	{
	}

	public void DeleteName()
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}

	public void Clone(AkAcousticSurface other)
	{
	}
}
