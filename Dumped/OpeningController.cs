using System;
using System.Collections;
using Dpr.Demo;
using Dpr.UI;
using SmartPoint.AssetAssistant;
using UnityEngine;

public class OpeningController : MonoBehaviour
{
	private SelectPlayerVisualItem _selectPlayerVisualItem;

	public Action OnFinishedCallBack;

	private AssetRequestOperation demoRequestOperation;

	private GameObject demoInstance;

	private DemoSceneManager demoSceneManager;

	private Demo_Hakase demoModel;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OpenSelectLanguage()
	{
	}

	public void OpenSelectPlayerVisual()
	{
	}

	private void OpenKeyboardByPlayerName()
	{
	}

	private (bool, string) OnInputCheck(string resultText, SoftwareKeyboard.ErrorState errorState)
	{
		return default((bool, string));
	}

	public void OpenKeyboardByRivalName()
	{
	}

	private void OnFinished()
	{
	}
}
