using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NexPlugin;

public class RankingCachedResult : RankingResult
{
	public enum LocalUpdateState
	{
		UPDATE_SUCCESS,
		UPDATE_FAILED,
		UPDATE_ERROR
	}

	internal uint maxLength;

	internal NpDateTime createdTime;

	internal NpDateTime expiredTime;

	public uint GetMaxLength()
	{
		return default(uint);
	}

	public NpDateTime GetCreatedTime()
	{
		return default(NpDateTime);
	}

	public NpDateTime GetExpiredTime()
	{
		return default(NpDateTime);
	}

	public LocalUpdateState LocalUpdate(RankingOrderParam orderParam, RankingScoreData scoreData, ulong pid, ulong nexUniqueId = 0uL, [Optional] NpDateTime utcCurrentTime, [Optional] List<byte> pCommonData)
	{
		return default(LocalUpdateState);
	}

	public new void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
