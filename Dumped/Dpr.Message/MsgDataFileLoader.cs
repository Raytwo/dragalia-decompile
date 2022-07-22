using System;

namespace Dpr.Message;

public class MsgDataFileLoader
{
	private Action<LoadAssetBundleTask> OnCompleteLoadAssetAction;

	private Action<LoadMsbtFileTask> OnCompleteLoadMsbtAction;

	private bool bIsLoading;

	public bool IsLoading => default(bool);

	public void Initialize(Action<LoadAssetBundleTask> onCompleteLoadAssetAct, Action<LoadMsbtFileTask> onCompleteLoadMsbtAct)
	{
	}

	public void Dispose()
	{
	}

	public void RegistLoadCommonAssetBundleTask(string asssetBundleName)
	{
	}

	public void RegistLoadAssetBundleTask(string asssetBundleName)
	{
	}

	public void RequestLoadAssetBundle(Action onFinishedLoadRequest)
	{
	}
}
