using UnityEngine;

namespace Dpr.UI;

public class GiftMenuItem : MonoBehaviour
{
	[SerializeField]
	public GiftMainMenuWindow.MenuType ItemMenuType;

	[SerializeField]
	public GameObject buttonEffectObject;

	public void Select()
	{
	}

	public void Unselect()
	{
	}
}
