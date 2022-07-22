using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class Cursor : MonoBehaviour
{
	[SerializeField]
	private Image[] _frameImages;

	[SerializeField]
	private Sprite[] _frameSprites;

	public static readonly int animStateIn;

	public static readonly int animStateOut;

	public static readonly int animStateDecide;

	public static readonly int animStateWait;

	public static readonly int animStateNull;

	protected Animator _animator;

	protected Coroutine _opPlay;

	public Animator animator => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetActive(bool enabled)
	{
	}

	public bool IsActived()
	{
		return default(bool);
	}

	public bool Play(int animState, int layer = 0, float startTime = 0f)
	{
		return default(bool);
	}

	private IEnumerator OpPlay(int animState, int layer, float startTime)
	{
		return null;
	}

	public void SetFrameSprite(int index)
	{
	}
}
