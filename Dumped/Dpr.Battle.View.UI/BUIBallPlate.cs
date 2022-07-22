using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Systems;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public class BUIBallPlate : BattleViewUICanvasBase
{
	[SerializeField]
	private Image[] _pokeBallList;

	private float[] _baseXPositions;

	private bool _isPlayerside;

	private bool[] _isEnableSE;

	private const float BALL_PLATE_WAIT = 2.2f;

	private const float BALL_DELAY = 0.1f;

	private const float BALL_OFFSET = 720f;

	public bool IsInitialized
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

	public override void Startup()
	{
	}

	public void Initialize(BattleViewSystem.BattleViewSide side, Sprite[] ballTypeSprites)
	{
	}

	private int GetBallType(BTL_PARTY party, int num)
	{
		return default(int);
	}

	public void Play()
	{
	}

	protected override void OnShow()
	{
	}

	protected override void OnHide()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}
}
