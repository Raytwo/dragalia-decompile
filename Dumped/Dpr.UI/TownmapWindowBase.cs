using System.Collections.Generic;
using UnityEngine.Events;

namespace Dpr.UI;

public class TownmapWindowBase : UIWindow
{
	protected override void OnOpen(UIWindowID prevWindowId)
	{
	}

	public virtual void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	protected bool IsPlayerFly()
	{
		return default(bool);
	}

	protected virtual bool IsFly(Townmap.Cell cell)
	{
		return default(bool);
	}

	protected void Fly(Townmap townmap)
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}
}
