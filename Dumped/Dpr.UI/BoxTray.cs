using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxTray : BoxInfinityScrollItem
{
	public class BoxTrayParam : BaseParam
	{
		public UnityAction<BoxTray, int> setupAction;
	}

	[SerializeField]
	private UIText _title;

	[SerializeField]
	private Image _boxTitleImage;

	[SerializeField]
	private Image _boxBgImage;

	[SerializeField]
	private RectTransform _contents;

	public const int cellColumn = 6;

	private BoxTrayParam _param;

	private List<BoxTrayItem> _items;

	public Image BoxTitleImage => null;

	public Image BoxBgImage => null;

	public BoxTrayParam Param => null;

	public List<BoxTrayItem> Items => null;

	private void Awake()
	{
	}

	public override void Setup(BaseParam baseParam)
	{
	}

	public void SetTitle()
	{
	}

	public void Apply()
	{
	}

	public UINavigator GetNavigator(int posX, int posY)
	{
		return null;
	}
}
