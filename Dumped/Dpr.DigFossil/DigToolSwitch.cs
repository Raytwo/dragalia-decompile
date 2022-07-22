using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigToolSwitch : MonoBehaviour, IDigToolsSwitch
{
	private enum SpriteIndex
	{
		HummerOff,
		HummerOn,
		PickaxeOff,
		PickaxeOn
	}

	[SerializeField]
	private Image hummer;

	[SerializeField]
	private Image pickaxe;

	[SerializeField]
	private List<Sprite> sprites;

	[SerializeField]
	private RectTransform hummerRect;

	[SerializeField]
	private RectTransform pickaxeRect;

	[SerializeField]
	private DigAudioManager audioManager;

	private IDigCursor cursor;

	public bool IsPickaxe
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize(IDigCursor cursor)
	{
	}

	public void OnUpdate()
	{
	}

	private void SetTool(bool bIsPickaxe)
	{
	}

	private bool CheckInsideButton(Vector2 touchPos, RectTransform rect)
	{
		return default(bool);
	}
}
