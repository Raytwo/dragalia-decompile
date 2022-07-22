using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUIActionSelectButton : BUIButtonBase<BUIActionSelectButton>
{
	private Dictionary<BUIActionList.ActionButtonType, string> _buttonMsgLabels;

	[SerializeField]
	private Image _lightFrame;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private BUIActionList.ActionButtonType _buttonType;

	public BUIActionList.ActionButtonType ButtonType => default(BUIActionList.ActionButtonType);

	public bool Initialize(BUIActionList.ActionButtonType type, int index, bool isEnable)
	{
		return default(bool);
	}

	private Sprite GetBagSprite(bool isDemoCapture)
	{
		return null;
	}

	protected override void OnChangeState(StateType type)
	{
	}
}
