using System;
using UnityEngine;

public class AkAuxSendArray : IDisposable
{
	private const int MAX_COUNT = 4;

	private readonly int SIZE_OF_AKAUXSENDVALUE;

	private IntPtr m_Buffer;

	private int m_Count;

	public AkAuxSendValue this[int index] => null;

	public bool isFull => default(bool);

	public void Dispose()
	{
	}

	~AkAuxSendArray()
	{
	}

	public void Reset()
	{
	}

	public bool Add(GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue)
	{
		return default(bool);
	}

	public bool Add(uint in_AuxBusID, float in_fValue)
	{
		return default(bool);
	}

	public bool Contains(GameObject in_listenerGameObj, uint in_AuxBusID)
	{
		return default(bool);
	}

	public bool Contains(uint in_AuxBusID)
	{
		return default(bool);
	}

	public AKRESULT SetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	public AKRESULT GetValues(GameObject gameObject)
	{
		return default(AKRESULT);
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
