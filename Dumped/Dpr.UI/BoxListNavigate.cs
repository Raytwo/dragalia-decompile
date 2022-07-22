using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxListNavigate : MonoBehaviour
{
	[SerializeField]
	private int _arrayWidth;

	[SerializeField]
	private int _arrayHeight;

	[SerializeField]
	private GridLayoutGroup _layout;

	[SerializeField]
	private UINavigator _leftTop;

	[SerializeField]
	private UINavigator _rightTop;

	[SerializeField]
	private UINavigator _leftBottom;

	[SerializeField]
	private UINavigator _rightBottom;

	public List<UINavigator> NavigatorList
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GridLayoutGroup LayoutGroup => null;

	public int Width => default(int);

	public int Height => default(int);

	public void Initialize(int trayNum, BoxMultiNavigator functionLeft, BoxMultiNavigator functionRight)
	{
	}

	private IEnumerator SetFunctionNavigates(UINavigator.NavigateType setType, BoxMultiNavigator functionLeft, BoxMultiNavigator functionRight)
	{
		return null;
	}
}
