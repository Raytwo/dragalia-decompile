using System.Runtime.CompilerServices;
using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Movie;

public class StaffrollRow : MonoBehaviour
{
	[SerializeField]
	private UIText[] _uiTexts;

	[SerializeField]
	private RectTransform _root;

	[SerializeField]
	private Image _image;

	private const string messageFile = "dlp_staff_list";

	private const int TextFontIndex = 8;

	private const int HeadingFontIndex = 9;

	public int Type
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float StartTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float EndTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void SetText(string[] texts, float size, bool heading, int materialIndex, float offset)
	{
	}

	public void SetSprite(Sprite sprite, Vector2 size)
	{
	}

	public void SetSpriteAlpha(float alpha)
	{
	}
}
