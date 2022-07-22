using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class BattleTowerRecordWindow : UIWindow
{
	[Serializable]
	private class RecordParam
	{
		public RectTransform root;

		public RectTransform bgRoot;

		public RectTransform titleRoot;

		public UIText rank;

		public UIText consecutiveWinsTitle;

		public UIText consecutiveWins;

		public UIText maxConsecutiveWins;
	}

	public class Param
	{
		public enum RecordType
		{
			Single,
			Double,
			MasterSingle,
			MasterDouble
		}

		public RecordType recordType;

		public int rank;

		public int consecutiveWins;

		public int maxConsecutiveWins;

		public bool isSuspended;
	}

	[SerializeField]
	private RecordParam[] _recordParams;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupKeyguide()
	{
	}

	private void EnableRecordParam(RecordParam recordParam, bool enabled)
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
