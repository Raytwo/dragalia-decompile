using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1024)]
public struct MT_DATA
{
	public const int BUFFER_SIZE = 1024;

	private byte[] buffer;

	public void Clear()
	{
	}
}
