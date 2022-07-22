using System.Collections;
using System.Collections.Generic;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class TrainingWindow : UIWindow
{
	private enum ItemType
	{
		HP,
		ATK,
		DEF,
		SPATK,
		SPDEF,
		AGI,
		START
	}

	public class Param
	{
		public PokemonParam pokemonParam;

		public ItemNo itemNo;
	}

	[SerializeField]
	private UIText _itemName;

	[SerializeField]
	private UIText _itemRemainNum;

	[SerializeField]
	private UIText _itemNum;

	[SerializeField]
	private RectTransform _contentRoot;

	private List<TrainingItemBase> _items;

	private int _itemCount;

	private int _itemRemainCount;

	private int _selectIndex;

	private bool _isDoneTraining;

	private Param _param;

	public bool isDoneTraining => default(bool);

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

	private void SetRemainItemNum(int remainCount)
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

	private void CheckItem(TrainingItemBase itemBase)
	{
	}

	private void EnableStart(bool enabled)
	{
	}

	private void StartTraining()
	{
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}
}
