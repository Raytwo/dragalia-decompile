using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class AdventureBase : UIWindow
{
	[SerializeField]
	protected AdventureNote _note;

	[SerializeField]
	protected Image _imageBg;

	[SerializeField]
	protected Sprite[] _spriteBgs;

	protected List<AdventureNoteData.SheetData> _currentDatas;

	protected int _pageIndex;

	protected void SetupBg()
	{
	}

	protected bool UpdatePageSelect(float deltaTime)
	{
		return default(bool);
	}

	protected void MovePage(int add)
	{
	}
}
