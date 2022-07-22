using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class BackUpReport : ReportWindowBase
{
	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private BuckUpReportButton[] _buttons;

	private int _selectIndex;

	private UnityAction<bool> _closeCalback;

	public virtual void Open(UIWindowID prevWindowId, UnityAction<bool> closeCalback)
	{
	}

	protected override void Setup()
	{
	}

	public override IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	protected override void OnUpdate(float deltaTime)
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
}
