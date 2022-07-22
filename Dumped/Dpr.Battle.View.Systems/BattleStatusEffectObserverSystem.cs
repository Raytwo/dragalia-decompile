using System;
using System.Runtime.CompilerServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using XLSXContent;

namespace Dpr.Battle.View.Systems;

public sealed class BattleStatusEffectObserverSystem : IDisposable
{
	private enum Sequence
	{
		WAIT,
		START_LOAD,
		WAIT_LOAD,
		WAIT_EFFECT,
		EMIT,
		WAIT_NEXT,
		NOSICK_WAIT,
		GO_NEXT
	}

	private const int DISP_TIME = 80;

	private const int WAIT_TIME = 10;

	private BattleViewSystem _viewSystem;

	private Sequence _sequence;

	private BtlvPos[] _orderArr;

	private int _nowOrder;

	private bool _isFinished;

	private int _cnt;

	private BtlvEffectInstance _iPtrParticle;

	private BtlvEffectInstance _iPtrSubParticle;

	private BattleDataTable.SheetBattleStatusEffectObserverData[] _observerDatas;

	private BOPokemon targetPokemon;

	public bool IsPlaying
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

	public bool IsUnInitialized
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

	public bool IsFinish => default(bool);

	public BattleStatusEffectObserverSystem(BattleViewSystem pViewSystem)
	{
	}

	public void Dispose()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void Finish()
	{
	}
}
