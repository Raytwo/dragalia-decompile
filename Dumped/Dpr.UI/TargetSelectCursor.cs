using System.Collections.Generic;
using Dpr.Battle.Logic;
using Pml.WazaData;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class TargetSelectCursor : Cursor
{
	[SerializeField]
	private FrameList[] _TargetFrames;

	private List<Image[]> _showFrames;

	private List<Image[]> _hideFrames;

	public void SetCursorFrame(BtlvPos attackerPos, WazaTarget targetType)
	{
	}

	private void SetFrameParts(List<Image[]> frames, bool isShow)
	{
	}
}
