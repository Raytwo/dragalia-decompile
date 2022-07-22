using System;
using System.Collections.Generic;

namespace Dpr.Message;

public class FontAssetLoader
{
	private List<LoadFontAssetTask> loadTaskList;

	private int loadTaskCount;

	private bool bRunning;

	public bool RunningLoad => default(bool);

	public void OnAwake()
	{
	}

	public void OnFinalize()
	{
	}

	public bool HasLoadTaskByLanguageId(MessageEnumData.MsgLangId langId)
	{
		return default(bool);
	}

	public void RegistLoadFontAssetTask(MessageEnumData.MsgLangId langId, Action<LoadFontAssetTask> onCompleteLoad)
	{
	}

	private string GetFileNameByLanguageId(MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public void PerformLoad()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
