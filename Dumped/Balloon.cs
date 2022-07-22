using DG.Tweening;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Balloon
{
	public int Index;

	public float Time;

	public int type;

	public Transform Target;

	public RectTransform ParentRectTra;

	public GameObject parent;

	public RectTransform MyRectTra;

	public GameObject gameObject;

	public Image BlnImg;

	public Image MarkImg;

	public Image HostImgLeft;

	public Image HostImgRight;

	private UnionHostEmoticonController hostController;

	private int spriteIndex;

	private int spriteIndexMaxCount;

	public SpriteAtlas ballonAtlas;

	public float changeSpriteFlameCount;

	private int updateFrame;

	private static readonly string[] IconName;

	private static readonly string[] FukidashiName;

	private readonly string[] UNION_HOST_ICON_NAME;

	private Sprite[] CacheUnionHostIconNotice;

	private Color fukidasiImgColorWhite;

	private Color fukidasiImgColorYellow;

	private static readonly Vector3[] path;

	public void PlayAnimation(int type, SpriteAtlas atlas)
	{
	}

	public Tweener Fade(float alpha, float duration)
	{
		return null;
	}

	private Sprite GetMultipleSprite(SpriteAtlas atlas, int index)
	{
		return null;
	}

	private void SetFukidashiImg(SpriteAtlas atlas, int balloonType)
	{
	}

	public void SetFukidasiImgColorWhite()
	{
	}

	public void SetFukidasiImgColorYellow()
	{
	}

	public void StopHostEmoAnimation()
	{
	}

	public void SetSpriteIndexMaxCount(int count)
	{
	}

	public void AddSpriteIndex()
	{
	}

	public void SetHostImgIcon(SpriteAtlas atlas)
	{
	}

	public Tween Exclamation()
	{
		return null;
	}

	public Tween ExclamationDouble()
	{
		return null;
	}

	public Tween Heart()
	{
		return null;
	}

	public Tween MusicalNote()
	{
		return null;
	}

	public Tween MusicalNoteDouble()
	{
		return null;
	}

	public Tween Notice()
	{
		return null;
	}

	public Tween Panic()
	{
		return null;
	}

	public Tween Question()
	{
		return null;
	}

	public Tween Sad()
	{
		return null;
	}

	public Tween Silent(SpriteAtlas atlas)
	{
		return null;
	}

	public Tween Sleepy(SpriteAtlas atlas)
	{
		return null;
	}

	public Tween Sparkle(SpriteAtlas atlas)
	{
		return null;
	}

	public Tween Stress(SpriteAtlas atlas)
	{
		return null;
	}

	public Tween Kutibue(SpriteAtlas atlas)
	{
		return null;
	}
}
