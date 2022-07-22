using System.Collections.Generic;
using UnityEngine;

namespace Dpr.UI;

public class BoxMultiNavigator : UINavigator
{
	[SerializeField]
	private List<UINavigator> _lefts;

	[SerializeField]
	private List<UINavigator> _rights;

	[SerializeField]
	private List<UINavigator> _tops;

	[SerializeField]
	private List<UINavigator> _bottoms;

	private List<List<UINavigator>> _multiNavigates;

	private bool isMultiInitialized;

	protected override void Awake()
	{
	}

	public void SetNavigate(NavigateType type, int index)
	{
	}

	public List<UINavigator> GetNavigates(NavigateType type)
	{
		return null;
	}

	public void SetNavigates(NavigateType type, List<UINavigator> naviList)
	{
	}
}
