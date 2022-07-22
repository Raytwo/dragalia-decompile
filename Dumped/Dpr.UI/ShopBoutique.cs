using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class ShopBoutique : ShopBase
{
	[Serializable]
	protected class ModelParam
	{
		public float offsetZ;
	}

	public enum BoutiqueType
	{
		Buy,
		Change
	}

	[SerializeField]
	protected UIText _charge;

	[SerializeField]
	protected CharacterModelView _modelView;

	[SerializeField]
	protected ModelParam[] _modelParams;

	protected List<ShopBoutiqueItemItem.Param> _itemParams;

	protected ShopBoutiqueItemItem _selectShopItem;

	protected CharacterModelView.Param.ModelType _modelType;

	protected BoutiqueType _boutiqueType;

	protected int _selectIndex;

	protected bool _isPlayerInputActive;

	protected const float _delayTime = 0.5f;

	protected float _loadModelDelayTime;

	public override void OnCreate()
	{
	}

	public void Open()
	{
	}

	public virtual IEnumerator OpOpen()
	{
		return null;
	}

	protected virtual void SetupScrollViewItemParams()
	{
	}

	protected static bool IsMaleDress(int DressNo)
	{
		return default(bool);
	}

	protected void SetupCharge()
	{
	}

	protected void OnRequiredItemData(IUIButton button)
	{
	}

	protected void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	protected void SetupModelView([Optional] UnityAction onComplate)
	{
	}

	protected void UpdateModelView(float delayTime)
	{
	}

	protected void SetupKeyguide()
	{
	}

	protected void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	protected void OnUpdate(float deltaTime)
	{
	}

	protected virtual void OnCancel()
	{
	}

	protected virtual void OnDecidedSelectItem()
	{
	}

	protected int GetCharge()
	{
		return default(int);
	}

	protected void SubCharge(int subCharge)
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}

	protected void ChangeDress()
	{
	}
}
