using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class BoxSearchDescription : MonoBehaviour
{
	[SerializeField]
	private UIText _mainDescription;

	[SerializeField]
	private UIText[] _subDescriptions;

	[SerializeField]
	private GameObject _mainObject;

	[SerializeField]
	private GameObject _subObject;

	private float _openPosX;

	private float _closePosX;

	private int? _searchType;

	private int _subIndex;

	public BoxWindow.SEARCH_DATA SearchData
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

	public void Initialize()
	{
	}

	public void Open(BoxWindow.SEARCH_DATA searchData, int index = 0)
	{
	}

	public void Close()
	{
	}

	public void Apply(BoxWindow.SEARCH_DATA searchData, int index = -1, int subIndex = -1)
	{
	}
}
