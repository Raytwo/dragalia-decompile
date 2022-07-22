using System;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.Message;

public class LoadFontAssetTask
{
	public bool bRunning;

	public MessageEnumData.MsgLangId langId;

	public string fileName;

	public AssetRequestOperation operation;

	public Action<LoadFontAssetTask> onCompleteLoadAct;

	public bool IsDone => default(bool);

	public UnityEngine.Object Asset => null;

	public void OnFinishedLoad()
	{
	}

	public void Dispose()
	{
	}
}
