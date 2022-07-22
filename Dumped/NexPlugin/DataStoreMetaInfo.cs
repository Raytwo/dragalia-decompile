using System.Collections.Generic;

namespace NexPlugin;

public class DataStoreMetaInfo
{
	internal ulong dataId;

	internal ulong ownerId;

	internal uint size;

	internal string name;

	internal ushort dataType;

	internal ushort period;

	internal DataStorePermission accessPermission;

	internal DataStorePermission updatePermission;

	internal NpDateTime createdTime;

	internal NpDateTime updatedTime;

	internal DataStore.DataStatus status;

	internal uint referDataId;

	internal DataStore.DataFlag flag;

	internal NpDateTime expireTime;

	internal List<string> tags;

	internal List<DataStoreRatingInfo> ratingInfo;

	internal List<byte> metaBinary;

	public ulong GetDataId()
	{
		return default(ulong);
	}

	public ulong GetOwnerId()
	{
		return default(ulong);
	}

	public uint GetSize()
	{
		return default(uint);
	}

	public string GetName()
	{
		return null;
	}

	public ushort GetDataType()
	{
		return default(ushort);
	}

	public DataStorePermission GetAccessPermission()
	{
		return null;
	}

	public DataStorePermission GetUpdatePermission()
	{
		return null;
	}

	public NpDateTime GetCreatedTime()
	{
		return default(NpDateTime);
	}

	public NpDateTime GetUpdatedTime()
	{
		return default(NpDateTime);
	}

	public ushort GetPeriod()
	{
		return default(ushort);
	}

	public DataStore.DataStatus GetDataStatus()
	{
		return default(DataStore.DataStatus);
	}

	public uint GetReferDataId()
	{
		return default(uint);
	}

	public DataStore.DataFlag GetDataFlag()
	{
		return default(DataStore.DataFlag);
	}

	public NpDateTime GetExpireTime()
	{
		return default(NpDateTime);
	}

	public List<string> GetTags()
	{
		return null;
	}

	public List<DataStoreRatingInfo> GetRating()
	{
		return null;
	}

	public List<byte> GetMetaBinary()
	{
		return null;
	}

	public bool IsValid()
	{
		return default(bool);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
