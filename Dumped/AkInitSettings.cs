using System;

public class AkInitSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint uMaxNumPaths
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uCommandQueueSize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public bool bEnableGameSyncPreparation
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public uint uContinuousPlaybackLookAhead
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uNumSamplesPerFrame
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uMonitorQueuePoolSize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public AkOutputSettings settingsMainOutput
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint uMaxHardwareTimeoutMs
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public bool bUseSoundBankMgrThread
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool bUseLEngineThread
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public string szPluginDLLPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkFloorPlane eFloorPlane
	{
		get
		{
			return default(AkFloorPlane);
		}
		set
		{
		}
	}

	public uint uBankReadBufferSize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public float fDebugOutOfRangeLimit
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool bDebugOutOfRangeCheckEnabled
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal AkInitSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkInitSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkInitSettings()
	{
	}

	public virtual void Dispose()
	{
	}
}
