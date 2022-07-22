using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 2956)]
public struct TV_DATA
{
	public TV_RECORD UseRecord;

	public TV_RECORD MyRecord;

	public TV_TOPIC UseTopic;

	public TV_TOPIC MyTopic;

	public INTERVIEWER_DATA InterviewerData;

	public int TvWatchCount;
}
