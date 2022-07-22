using Dpr.MsgWindow;
using UnityEngine;

namespace Dpr.UI;

public class PokemonWindowBase : UIWindow
{
	public class BaseParam
	{
		public int selectIndex;
	}

	[SerializeField]
	protected PokemonParty _party;

	[SerializeField]
	protected RectTransform _messageWindowRoot;

	public override void OnCreate()
	{
	}

	public void SetContextMenuPositionParams(ContextMenuWindow.Param param, RectTransform transPartyItem, int selectIndex, float posZ)
	{
	}

	protected override void OpenMessageWindow(MsgWindowParam messageParam)
	{
	}
}
