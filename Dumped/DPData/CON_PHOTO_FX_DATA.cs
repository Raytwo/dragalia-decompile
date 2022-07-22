using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 44)]
public struct CON_PHOTO_FX_DATA
{
	public int groupNo;

	public float particlePlayTime;

	public float fxPositionX;

	public float fxPositionY;

	public float fxPositionZ;

	public float fxRotX;

	public float fxRotY;

	public float fxRotZ;

	public float fxScaleX;

	public float fxScaleY;

	public float fxScaleZ;
}
