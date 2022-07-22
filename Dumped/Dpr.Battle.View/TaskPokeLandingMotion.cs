using System.Collections.Generic;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using Dpr.SequenceEditor;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.View;

public sealed class TaskPokeLandingMotion : Task
{
	private enum Sequence
	{
		SEQ_SETUP,
		SEQ_LAND_A,
		SEQ_LAND_B,
		SEQ_LAND_C,
		SEQ_LAND,
		SEQ_FINISH
	}

	private static readonly Dictionary<PokeEffWeight, string> LANDING_SWITCH_NAME;

	private Sequence _seq;

	private ISequenceViewSystem _iPtrBtlvSystem;

	private BtlvPos _vPos;

	private BOPokemon _iPtrPoke;

	private float _introHeight;

	private float _centerOfsY;

	private Vector3 _defualtPokePos;

	private int _rotY;

	private BtlvSound _btlvSound;

	private TaskVectorControl _iPtrTaskTransPos;

	private TaskVectorControl _iPtrTaskTransScl;

	private BattleDataTable _battleDataTable;

	private PokeEffWeight _pokeEffWeight;

	private string _effectFileName;

	private bool _isContest;

	public TaskPokeLandingMotion(ISequenceViewSystem pBtlvSystem, BtlvPos vPos, BattleViewCharacter pPoke, float introHeight, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	protected override void OnDispose()
	{
	}

	public override void Update(float deltaTime, float currentSeqeunceTime, int step)
	{
	}
}
