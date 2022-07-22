using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class TownmapPlayerIcon : TownmapIcon
{
	[SerializeField]
	private Image _image;

	protected override void Awake()
	{
	}

	private Sprite GetSpritePlayerIcon()
	{
		return null;
	}
}
