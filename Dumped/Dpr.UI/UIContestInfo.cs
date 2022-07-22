using System;
using System.Collections;
using Dpr.Contest;
using UnityEngine;

namespace Dpr.UI;

public class UIContestInfo : UIWindow
{
	[Serializable]
	public struct InfoItem
	{
		public UIText categoryNameText;

		public UIText rankNameText;
	}

	private class CategoryIndex
	{
		public const int Style = 0;

		public const int Beautiful = 1;

		public const int Cute = 2;

		public const int Clever = 3;

		public const int Strong = 4;

		public const int Fur = 5;
	}

	[SerializeField]
	private InfoItem[] infoItemArray;

	[SerializeField]
	private GameObject furRootObj;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void Setup()
	{
	}

	private RankID FindMaxClearRankNormalContest(CategoryID category)
	{
		return default(RankID);
	}

	private RankID FindMaxClearRankInSercretContest()
	{
		return default(RankID);
	}

	private void SetNameParam(int index, CategoryID category, RankID rankID)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateInput()
	{
	}

	private void CloseWindow()
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}
}
