using System.Collections.Generic;

namespace NexPlugin;

public class DataStorePreparePostParam
{
	internal uint size;

	internal string name;

	internal ushort dataType;

	internal ushort period;

	internal DataStorePermission accessPermission;

	internal DataStorePermission updatePermission;

	internal DataStore.DataFlag flag;

	internal List<string> tags;

	internal Dictionary<sbyte, DataStoreRatingInitParam> ratingInitParams;

	internal List<byte> meta;

	internal DataStorePersistenceInitParam persistenceInitParam;

	public void SetSize(uint size_)
	{
	}

	public uint GetSize()
	{
		return default(uint);
	}

	public void SetName(string name_)
	{
	}

	public string GetName()
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

	public void SetDataFlag(DataStore.DataFlag flag_)
	{
	}

	public DataStore.DataFlag GetDataFlag()
	{
		return default(DataStore.DataFlag);
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

	public void SetRatingSetting(Dictionary<sbyte, DataStoreRatingInitParam> ratingInitParam)
	{
	}

	public void ClearRatingSetting()
	{
	}

	public bool AddRatingSetting(sbyte slot, DataStoreRatingInitParam ratingInitParam)
	{
		return default(bool);
	}

	public Dictionary<sbyte, DataStoreRatingInitParam> GetRatingSetting()
	{
		return null;
	}

	public void SetMetaBinary(List<byte> meta_)
	{
	}

	public List<byte> GetMetaBinary()
	{
		return null;
	}

	public void SetPersistenceInitParam(DataStorePersistenceInitParam persistenceInitParam_)
	{
	}

	public DataStorePersistenceInitParam GetPersistenceInitParam()
	{
		return null;
	}

	public void Reset()
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
