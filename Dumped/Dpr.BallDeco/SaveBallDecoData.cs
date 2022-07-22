using System;
using System.Runtime.InteropServices;

namespace Dpr.BallDeco;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 17032)]
public struct SaveBallDecoData
{
	public byte CapsuleCount;

	public CapsuleData[] CapsuleDatas;

	public void Clear()
	{
	}
}
