using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

public class KeyguideItem : MonoBehaviour
{
	public class Param
	{
		public KeyguideID keyguideId;
	}

	[SerializeField]
	private Image _button;

	[SerializeField]
	private UIText _text;

	public void Setup(Param param)
	{
	}
}
