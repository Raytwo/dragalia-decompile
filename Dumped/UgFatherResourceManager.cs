using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.UnderGround.UgFather;
using UnityEngine;

public class UgFatherResourceManager
{
	public const string DataAssetName = "ugfdata";

	private static GameObject ugFatherManagerPrefab;

	private static bool _isDataLoadRequest;

	private static bool _isDataLoadEnd;

	private static Action _onPostLoaded;

	public static UgFatherManager UgFather
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool IsDataLoadEnd => default(bool);

	public static void UnLoad()
	{
	}

	public static void DataLoadRequest(Action callback)
	{
	}

	private static IEnumerator DataLoad()
	{
		return null;
	}

	public static IEnumerator CreateAsset()
	{
		return null;
	}
}
