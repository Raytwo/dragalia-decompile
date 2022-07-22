using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

public class AkMemBankLoader : MonoBehaviour
{
	private const int WaitMs = 50;

	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16L;

	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15L;

	public string bankName;

	public bool isLocalizedBank;

	private string m_bankPath;

	[HideInInspector]
	public uint ms_bankID;

	private IntPtr ms_pInMemoryBankPtr;

	private GCHandle ms_pinnedArray;

	private UnityWebRequest ms_www;

	private void Start()
	{
	}

	public void LoadNonLocalizedBank(string in_bankFilename)
	{
	}

	public void LoadLocalizedBank(string in_bankFilename)
	{
	}

	private uint AllocateAlignedBuffer(byte[] data)
	{
		return default(uint);
	}

	private IEnumerator LoadFile()
	{
		return null;
	}

	private void DoLoadBank(string in_bankPath)
	{
	}

	private void OnDestroy()
	{
	}
}
