using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.UI;

public class YunionMenu : UIWindow
{
	private enum OpenMenuType
	{
		SelectRoom,
		CommunityRoom,
		GlobalRoom
	}

	[SerializeField]
	private UIText _textTitle;

	[SerializeField]
	private GameObject _objNetMode;

	[SerializeField]
	private Cursor _cursorNetMode;

	[SerializeField]
	private GameObject _objEnterMode;

	[SerializeField]
	private MultiModelView _modelView;

	private OpenMenuType _currentMenu;

	private OpenMenuType _currentSelect;

	private bool _loadingModel;

	private const int CURSOR_POS = 295;

	private const string MODEL_PATH = "persons/field/fc2012_00";

	private const string MSG_FILE = "dlp_net_union_room";

	private const string MSG_LABEL_UNION = "DLP_net_union_room_111";

	private const string MSG_LABEL_COMMUNITY = "DLP_net_union_room_106";

	private const string MSG_LABEL_GLOBAL = "DLP_net_union_room_107";

	private const string SCRIPT_COMMUNITY = "ev_connect_union_ymenu";

	private const string SCRIPT_GLOBAL = "ev_connect_global_ymenu";

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(bool cancel)
	{
	}

	public IEnumerator OpCloseCancel()
	{
		return null;
	}

	public IEnumerator OpClose()
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void ChangeMenu(OpenMenuType type)
	{
	}

	private void SelectMenu()
	{
	}

	public void OpenKeyguide()
	{
	}

	public void CloseKeyGuide([Optional] Action onComplete)
	{
	}

	private void SetTitle()
	{
	}

	private void SetSelect(OpenMenuType type)
	{
	}

	private void SetCursor()
	{
	}

	private void LoadModel()
	{
	}

	private void UnloadModel()
	{
	}
}
