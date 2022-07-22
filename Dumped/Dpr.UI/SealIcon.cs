using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealIcon : MonoBehaviour
{
	[SerializeField]
	protected Image iconImage;

	[SerializeField]
	private Image typeIconImage;

	public void Set(SealInfo sealInfo)
	{
	}

	public void Set(int sealId)
	{
	}

	public void Clear()
	{
	}

	public void SetEnable(bool isEnable)
	{
	}
}
