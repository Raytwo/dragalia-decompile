using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class Capsule2DGridCell : MonoBehaviour
{
	[SerializeField]
	private SealIcon sealIcon;

	[SerializeField]
	private Image cellImage;

	[SerializeField]
	private RectTransform gridRectTransform;

	private Vector3 sealPosition;

	private Color clearColor;

	private Color affixedSealColor;

	public Vector2 GridPosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int AffixSealId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int SealId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsSetSeal
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

	public void Initialize(int x, int y)
	{
	}

	public void Setup(bool isFront, Color clear, Color affixed)
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public void SetAffixSeal(int affixSealId, int sealId)
	{
	}

	public void ClearAffixSeal()
	{
	}

	public void ShowAffixSeal()
	{
	}

	public void HideAffixSeal()
	{
	}

	public Vector3 GetSealPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	private void SetClearColor()
	{
	}

	private void SetAffixedSealColor()
	{
	}
}
