using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigResultItem : MonoBehaviour, IDigResultItem
{
	[SerializeField]
	private Image image;

	private Tween tweenHandler;

	public int LabelID
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

	public int UgItemId
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

	public void Initialize(Sprite sprite, DigMasterDataManager.DepositItemData data)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	[SpecialName]
	GameObject IDigResultItem.get_gameObject()
	{
		return null;
	}
}
