using System;

public class AkExternalSourceInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint iExternalSrcCookie
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint idCodec
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public string szFile
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IntPtr pInMemory
	{
		get
		{
			return default(IntPtr);
		}
		set
		{
		}
	}

	public uint uiMemorySize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint idFile
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkExternalSourceInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkExternalSourceInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkExternalSourceInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkExternalSourceInfo()
	{
	}

	public AkExternalSourceInfo(IntPtr in_pInMemory, uint in_uiMemorySize, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	public AkExternalSourceInfo(string in_pszFileName, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	public AkExternalSourceInfo(uint in_idFile, uint in_iExternalSrcCookie, uint in_idCodec)
	{
	}

	public void Clear()
	{
	}

	public void Clone(AkExternalSourceInfo other)
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}
}
