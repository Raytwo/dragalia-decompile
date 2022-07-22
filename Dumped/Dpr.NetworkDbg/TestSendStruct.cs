using System;
using System.Runtime.InteropServices;

namespace Dpr.NetworkDbg;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct TestSendStruct
{
	public int a;

	public float b;

	public ushort c;

	public byte d;

	public bool e;
}
