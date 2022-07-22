using System.Collections.Generic;

namespace NexPlugin;

public class DataStoreSearchResult
{
	internal List<DataStoreMetaInfo> result;

	internal uint totalCount;

	internal DataStore.SearchResultTotalCountType totalCountType;

	public uint GetTotalCount()
	{
		return default(uint);
	}

	public List<DataStoreMetaInfo> GetResult()
	{
		return null;
	}

	public DataStore.SearchResultTotalCountType GetTotalCountType()
	{
		return default(DataStore.SearchResultTotalCountType);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
