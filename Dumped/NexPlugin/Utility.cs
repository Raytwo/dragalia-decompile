using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NexPlugin;

public static class Utility
{
	public delegate void AcquireNexUniqueIdCB(AsyncResult asyncResult, ulong nexUniqueId);

	public delegate void AcquireNexUniqueIdWithPasswordCB(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo);

	public delegate void GetAssociatedNexUniqueIdWithMyPrincipalIdCB(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo);

	public delegate void GetAssociatedNexUniqueIdWithMyPrincipalIdListCB(AsyncResult asyncResult, List<UniqueIdInfo> uniqueIdInfo);

	public delegate void GetIntegerSettingsCB(AsyncResult asyncResult, Dictionary<ushort, int> integerSettings);

	public static bool AcquireNexUniqueIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] AcquireNexUniqueIdCB callback)
	{
		return default(bool);
	}

	public static bool AcquireNexUniqueIdWithPasswordAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] AcquireNexUniqueIdWithPasswordCB callback)
	{
		return default(bool);
	}

	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, UniqueIdInfo uniqueIdInfo, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool AssociateNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, List<UniqueIdInfo> uniqueIdInfo, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] GetAssociatedNexUniqueIdWithMyPrincipalIdCB callback)
	{
		return default(bool);
	}

	public static bool GetAssociatedNexUniqueIdWithMyPrincipalIdAsync(out uint asyncId, IntPtr pNgsFacade, int timeOut = 0, [Optional] GetAssociatedNexUniqueIdWithMyPrincipalIdListCB callback)
	{
		return default(bool);
	}

	public static bool GetIntegerSettingsAsync(out uint asyncId, IntPtr pNgsFacade, uint integerSettingIndex, int timeOut = 0, [Optional] GetIntegerSettingsCB callback)
	{
		return default(bool);
	}

	public static extern bool IsValidNexUniqueId(ulong nexUniqueId);
}
