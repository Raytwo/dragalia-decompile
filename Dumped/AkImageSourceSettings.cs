using System;
using UnityEngine;

public class AkImageSourceSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkImageSourceParams params_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AkImageSourceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkImageSourceSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkImageSourceSettings()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkImageSourceSettings()
	{
	}

	public AkImageSourceSettings(Vector3 in_sourcePosition, float in_fDistanceScalingFactor, float in_fLevel)
	{
	}

	public void SetOneTexture(uint in_texture)
	{
	}

	public void SetName(string in_pName)
	{
	}
}
