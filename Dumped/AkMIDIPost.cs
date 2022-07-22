using System;
using UnityEngine;

public class AkMIDIPost : AkMIDIEvent
{
	private IntPtr swigCPtr;

	public uint uOffset
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkMIDIPost(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMIDIPost obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkMIDIPost()
	{
	}

	public override void Dispose()
	{
	}

	public AKRESULT PostOnEvent(uint in_eventID, GameObject in_gameObjectID, uint in_uNumPosts)
	{
		return default(AKRESULT);
	}

	public void Clone(AkMIDIPost other)
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}

	public AkMIDIPost()
	{
	}
}
