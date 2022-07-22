using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 32)]
public struct UgCountRecord
{
	public short DigFossilPlayCount;

	public short NumStatueBroadcastOnTV;

	public int NumTimesSecretBaseBroadcastOnTVWereLiked;

	public int SomeoneSecretBaseLikeCount;

	public int NumSuccessfulLightStoneSearches;

	public long reserved_long01;

	public long reserved_long02;

	public void IncrementDigFossilPlayCount()
	{
	}
}
