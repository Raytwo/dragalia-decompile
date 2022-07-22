using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Item;
using Pml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUIPokeBallList : BattleViewUICanvasBase, IResultable<ItemNo>
{
	public enum BallListState
	{
		Empty,
		One,
		Many
	}

	[SerializeField]
	private BUIButton _prevButton;

	[SerializeField]
	private BUIButton _nextButton;

	[SerializeField]
	private Image _ballIcon;

	[SerializeField]
	private Image _originalIcon;

	[SerializeField]
	private TextMeshProUGUI _ballNameText;

	[SerializeField]
	private TextMeshProUGUI _ballCountText;

	[SerializeField]
	private TextMeshProUGUI _descriptionText;

	[SerializeField]
	private BUIButton _useButton;

	private List<ItemInfo> _balls;

	private Dictionary<ItemNo, Sprite> _ballSprites;

	private Action _callBack;

	private int firstIndex;

	[SerializeField]
	private List<Sprite> _sprites;

	public ItemNo Result
	{
		[CompilerGenerated]
		get
		{
			return default(ItemNo);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool Initialize(List<ItemInfo> balls, Action callback)
	{
		return default(bool);
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnShow()
	{
	}

	public BallListState SetOpenBallInfo(bool enableCallback = true)
	{
		return default(BallListState);
	}

	public BallListState SetBallInfo(bool enableCallback = true)
	{
		return default(BallListState);
	}

	private void SetBallInfo(ItemNo ballItemNo, int count, Sprite icon)
	{
	}

	protected override void PreparaNext(bool isForward)
	{
	}

	public void SetInvalid()
	{
	}

	public void CleanUp()
	{
	}

	private void OnSubmit()
	{
	}

	private void OnCancel()
	{
	}
}
