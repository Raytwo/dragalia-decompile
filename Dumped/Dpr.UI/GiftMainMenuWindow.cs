using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class GiftMainMenuWindow : GiftSubWindow
{
	public enum MenuType
	{
		None = -1,
		ReceiveInternet,
		ReceiveSerialCode,
		ShowHistory
	}

	[SerializeField]
	private Cursor cursor;

	[SerializeField]
	private GiftMenuItem[] menuItems;

	private IndexSelector indexSelector;

	public MenuType SelectedMenuType
	{
		[CompilerGenerated]
		get
		{
			return default(MenuType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected override void OnInitialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public override void Show()
	{
	}
}
