using System.Collections.Generic;

namespace NexPlugin;

public class DataStoreChangeMetaCompareParam
{
	internal DataStore.ComparisonFlag comparisonFlag;

	internal string name;

	internal DataStorePermission accessPermission;

	internal DataStorePermission updatePermission;

	internal ushort dataType;

	internal ushort period;

	internal List<string> tags;

	internal List<byte> metaBinary;

	internal DataStore.DataStatus status;

	public DataStoreChangeMetaCompareParam()
	{
	}

	public DataStoreChangeMetaCompareParam(DataStore.ComparisonFlag comparisonFlag, DataStoreMetaInfo metaInfo)
	{
	}

	public void Set(DataStore.ComparisonFlag comparisonFlag_, DataStoreMetaInfo metaInfo_)
	{
	}

	public void SetComparisonFlag(DataStore.ComparisonFlag comparisonFlag_)
	{
	}

	public DataStore.ComparisonFlag GetComparisonFlag()
	{
		return default(DataStore.ComparisonFlag);
	}

	public void SetName(string name_)
	{
	}

	public string GetName()
	{
		return null;
	}

	public void SetAccessPermission(DataStorePermission permission_)
	{
	}

	public DataStorePermission GetAccessPermission()
	{
		return null;
	}

	public void SetUpdatePermission(DataStorePermission updatePermission_)
	{
	}

	public DataStorePermission GetUpdatePermission()
	{
		return null;
	}

	public void SetPeriod(ushort period_)
	{
	}

	public ushort GetPeriod()
	{
		return default(ushort);
	}

	public void SetTags(List<string> tags_)
	{
	}

	public List<string> GetTags()
	{
		return null;
	}

	public void SetMetaBinary(List<byte> meta)
	{
	}

	public List<byte> GetMetaBinary()
	{
		return null;
	}

	public void SetDataType(ushort dataType_)
	{
	}

	public ushort GetDataType()
	{
		return default(ushort);
	}

	public void SetDataStatus(DataStore.DataStatus status_)
	{
	}

	public DataStore.DataStatus GetDataStatus()
	{
		return default(DataStore.DataStatus);
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
