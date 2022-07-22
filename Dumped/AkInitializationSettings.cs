using System;

public class AkInitializationSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkStreamMgrSettings streamMgrSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkDeviceSettings deviceSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkInitSettings initSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkPlatformInitSettings platformSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkMusicSettings musicSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool useAsyncOpen
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal AkInitializationSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkInitializationSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkInitializationSettings()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkInitializationSettings()
	{
	}
}
