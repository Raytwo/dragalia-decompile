using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.UI;

namespace SmartPoint.Components;

public class Fader : SingletonMonoBehaviour<Fader>
{
	public enum FadeMode
	{
		Color,
		Cutout,
		Cross
	}

	public const int SORTING_ORDER = 16384;

	private Canvas _canvas;

	private RawImage _filterImage;

	private float _fillPower;

	private Color _fillColor;

	private float _speed;

	private Texture2D _renderTexture;

	private bool _valid;

	[SerializeField]
	private float _duration;

	[SerializeField]
	private FadeMode _mode;

	private Material _defaultMaterial;

	private Material _cutoutMaterial;

	public static bool valid
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static FadeMode fadeMode
	{
		get
		{
			return default(FadeMode);
		}
		set
		{
		}
	}

	public static float duration
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static Color fillColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Texture filterTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool isBusy => default(bool);

	public static float fadeInProgress => default(float);

	public static float fadeOutProgress => default(float);

	public static float fillPower => default(float);

	protected override bool Awake()
	{
		return default(bool);
	}

	public void OnDisable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateMaterial()
	{
	}

	public static void FadeIn()
	{
	}

	public static void FadeIn(float duration)
	{
	}

	public static void FadeOut()
	{
	}

	public static void FadeOut(float duration)
	{
	}

	private IEnumerator CaptureScreen()
	{
		return null;
	}
}
