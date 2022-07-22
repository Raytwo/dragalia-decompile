using System;
using UnityEngine;

public class AkMIDIPostArray
{
	private readonly int m_Count;

	private readonly int SIZE_OF;

	private IntPtr m_Buffer;

	public AkMIDIPost this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkMIDIPostArray(int size)
	{
	}

	~AkMIDIPostArray()
	{
	}

	public void PostOnEvent(uint in_eventID, GameObject gameObject)
	{
	}

	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count)
	{
	}

	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	public int Count()
	{
		return default(int);
	}

	private IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
