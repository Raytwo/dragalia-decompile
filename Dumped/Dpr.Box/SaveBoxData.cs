using System;
using System.Runtime.InteropServices;

namespace Dpr.Box;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 1610)]
public struct SaveBoxData
{
	[Serializable]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	public struct _STR17
	{
		public string str;
	}

	[Serializable]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	public struct _STR11
	{
		public string str;
	}

	public _STR17[] trayName;

	public _STR11[] teamName;

	public ushort[] teamPos;

	public byte teamLock;

	public byte trayMax;

	public byte currentTray;

	public bool isOpened;

	public byte[] wallPaper;

	public ushort statusPut;

	public void Clear()
	{
	}
}
