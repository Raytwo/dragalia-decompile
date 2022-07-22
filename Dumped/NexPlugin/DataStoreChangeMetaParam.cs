using System.Collections.Generic;

namespace NexPlugin;

public class DataStoreChangeMetaParam
{
	internal ulong dataId;

	internal DataStore.ModificationFlag modifiesFlag;

	internal string name;

	internal DataStorePermission accessPermission;

	internal DataStorePermission updatePermission;

	internal ushort period;

	internal ushort dataType;

	internal List<string> tags;

	internal List<byte> metaBinary;

	internal DataStorePersistenceTarget persistenceTarget;

	internal DataStore.DataStatus status;

	internal ulong updatePassword;

	internal DataStoreChangeMetaCompareParam compareParam;

	public void SetDataId(ulong dataId_)
	{
	}

	public ulong GetDataId()
	{
		return default(ulong);
	}

	public void SetModificationFlag(DataStore.ModificationFlag modificationFlag)
	{
	}

	public DataStore.ModificationFlag GetModificationFlag()
	{
		return default(DataStore.ModificationFlag);
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

	public void SetUpdatePassword(ulong updatePassword_)
	{
	}

	public ulong GetUpdatePassword()
	{
		return default(ulong);
	}

	public void SetDataType(ushort dataType_)
	{
	}

	private ushort GetDataType()
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

	public void SetChangeMetaCompareParam(DataStoreChangeMetaCompareParam compareParam_)
	{
	}

	public DataStoreChangeMetaCompareParam GetChangeMetaCompareParam()
	{
		return null;
	}

	public void SetPersistenceTarget(DataStorePersistenceTarget persistenceTarget_)
	{
	}

	public DataStorePersistenceTarget GetPersistenceTarget()
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
