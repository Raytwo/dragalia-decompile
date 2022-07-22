using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NexPlugin;

public class DataStorePermission
{
	internal DataStore.Permission permission;

	internal List<ulong> recipientIds;

	public DataStorePermission()
	{
	}

	public DataStorePermission(DataStore.Permission permission, [Optional] List<ulong> recipientIds)
	{
	}

	public void SetPermission(DataStore.Permission permission_)
	{
	}

	public DataStore.Permission GetPermission()
	{
		return default(DataStore.Permission);
	}

	public void SetRecipientIds(List<ulong> recipientIds_)
	{
	}

	public List<ulong> GetRecipientIds()
	{
		return null;
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
