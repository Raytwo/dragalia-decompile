using System.Collections;
using System.Collections.Generic;
using Audio;
using DPData;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class HallOfFameWindow : UIWindow
{
	private class HallOfFameParam
	{
		public int number;

		public DENDOU_RECORD record;

		public RE_DENDOU_RECORD rename_record;

		public DENDOU_SAVE_ADD_POKE_MEMBER add_record;

		public List<HallOfFameItem> items;
	}

	public class Param
	{
		public int dummy;
	}

	[SerializeField]
	private Image[] _arrows;

	[SerializeField]
	private UIText _number;

	[SerializeField]
	private UIText _date;

	[SerializeField]
	private RectTransform contentRoot;

	[SerializeField]
	private Image _cursor;

	private List<HallOfFameParam> _params;

	private int _paramIndex;

	private int _selectIndex;

	private const int _delayFrameNum = 4;

	private int _delayFrameCount;

	private const int _columnMax = 3;

	private int _infoType;

	private AudioInstance _voiceInstance;

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

	private void UpdateItems()
	{
	}

	private void SetupItems()
	{
	}

	private void SetItemInfos(int infoType)
	{
	}

	private void SetupTitle()
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

	private bool UpdateSelectParam()
	{
		return default(bool);
	}

	private bool SetParamIndex(int selectIndex, int move, bool isInitialize = false)
	{
		return default(bool);
	}

	private void PlayAnimArrow(int move)
	{
	}

	private bool UpdateSelect()
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}

	private void PlayVoice(UIDatabase.SheetPokemonVoice voiceData)
	{
	}

	private HallOfFameItem GetItem(int selectIndex)
	{
		return null;
	}
}
