using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SelectOpeningBase : UIWindow
{
	[SerializeField]
	protected Image _imageBg;

	[SerializeField]
	protected Image _imageBgBody;

	[SerializeField]
	protected Sprite[] _spriteBgs;

	protected void SetupBgs()
	{
	}
}
