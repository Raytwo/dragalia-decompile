using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class NexInitParam
{
	private const int KILOBYTE = 1024;

	private const int MIN_TIMEOUT = 1000;

	private const int MAX_TIMEOUT = 60000;

	private const int DEF_TIMEOUT = 30000;

	private const int MIN_MEMORY = 300;

	private const int MAX_MEMORY = 10240;

	private const int MIN_RESERVEMEMORY = 40;

	[SerializeField]
	private string gameServerId;

	[SerializeField]
	private string accessKey;

	[SerializeField]
	private int timeOut;

	[SerializeField]
	private uint pluginMemSize;

	[SerializeField]
	private NexPlugin.Common.ThreadMode threadMode;

	[SerializeField]
	private Common.CALL_DISPATCH callDispatch;

	[SerializeField]
	private uint dispatchTimeOut;

	[SerializeField]
	private NexPlugin.Common.DispachFlag dispatchFlag;

	[SerializeField]
	private bool autoLogin;

	[SerializeField]
	private bool autoLogout;

	[SerializeField]
	private int coreNo;

	public Common.NEX_INIT_PARAM GetNexInitParam()
	{
		return default(Common.NEX_INIT_PARAM);
	}
}
