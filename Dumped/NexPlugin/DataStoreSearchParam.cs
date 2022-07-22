using System.Collections.Generic;

namespace NexPlugin;

public class DataStoreSearchParam
{
	internal DataStore.SearchType searchTarget;

	internal List<ulong> ownerIds;

	internal DataStore.SearchTarget ownerType;

	internal List<ulong> destinationIds;

	internal List<ushort> dataTypes;

	internal NpDateTime createdAfter;

	internal NpDateTime createdBefore;

	internal NpDateTime updatedAfter;

	internal NpDateTime updatedBefore;

	internal DataStore.SearchSortColumn resultOrderColumn;

	internal DataStore.SearchSortOrder resultOrder;

	internal ResultRange resultRange;

	internal DataStore.ResultFlag resultOption;

	internal List<string> tags;

	internal uint minimalRatingFrequency;

	internal bool totalCountEnabled;

	internal bool useCache;

	public void SetSearchType(DataStore.SearchType searchType)
	{
	}

	public DataStore.SearchType GetSearchType()
	{
		return default(DataStore.SearchType);
	}

	public void SetOwnerIds(List<ulong> ownerIds_)
	{
	}

	public List<ulong> GetOwnerIds()
	{
		return null;
	}

	public void SetOwnerType(DataStore.SearchTarget ownerType_)
	{
	}

	public DataStore.SearchTarget GetOwnerType()
	{
		return default(DataStore.SearchTarget);
	}

	public void SetDestinationIds(List<ulong> destinationIds_)
	{
	}

	public List<ulong> GetDestinationIds()
	{
		return null;
	}

	public void SetDataType(ushort dataType_)
	{
	}

	public void SetDataType(List<ushort> dataTypes_)
	{
	}

	public ushort GetDataType()
	{
		return default(ushort);
	}

	public void GetDataType(ref List<ushort> dataTypes_)
	{
	}

	public void SetCreatedAfter(NpDateTime createdAfter_)
	{
	}

	public NpDateTime GetCreatedAfter()
	{
		return default(NpDateTime);
	}

	public void SetCreatedBefore(NpDateTime createdBefore_)
	{
	}

	public NpDateTime GetCreatedBefore()
	{
		return default(NpDateTime);
	}

	public void SetUpdatedAfter(NpDateTime updatedAfter_)
	{
	}

	public NpDateTime GetUpdatedAfter()
	{
		return default(NpDateTime);
	}

	public void SetUpdatedBefore(NpDateTime updatedBefore_)
	{
	}

	public NpDateTime GetUpdatedBefore()
	{
		return default(NpDateTime);
	}

	public void SetSearchSortOrderColumn(DataStore.SearchSortColumn resultOrderColumn_)
	{
	}

	public DataStore.SearchSortColumn GetSearchSortOrderColumn()
	{
		return default(DataStore.SearchSortColumn);
	}

	public void SetSearchSortOrder(DataStore.SearchSortOrder resultOrder_)
	{
	}

	public DataStore.SearchSortOrder GetSearchSortOrder()
	{
		return default(DataStore.SearchSortOrder);
	}

	public void SetResultRange(ResultRange resultRange_)
	{
	}

	public ResultRange GetResultRange()
	{
		return null;
	}

	public void SetResultOption(DataStore.ResultFlag resultOption_)
	{
	}

	public DataStore.ResultFlag GetResultOption()
	{
		return default(DataStore.ResultFlag);
	}

	public void SetTags(List<string> tags_)
	{
	}

	public List<string> GetTags()
	{
		return null;
	}

	public void SetMinimalRatingFrequency(uint minimalRatingFrequency_)
	{
	}

	public uint GetMinimalRatingFrequency()
	{
		return default(uint);
	}

	public void SetUseCache(bool useCache_)
	{
	}

	public bool GetUseCache()
	{
		return default(bool);
	}

	public void SetTotalCountEnabled(bool totalCountEnabled_)
	{
	}

	public bool GetTotalCountEnabled()
	{
		return default(bool);
	}

	private void Reset()
	{
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
