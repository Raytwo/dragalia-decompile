using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Battle.View.Systems;

public sealed class BattleGroundEffectSystem
{
	private class BattleGroundData
	{
		public string mainEffectFileName;

		public string cameraEffectFileName;

		public Vector3 mainScale;

		public Vector3 cameraScale;
	}

	private BattleViewSystem _pViewSystem;

	private BtlGround _currentGroundType;

	private BtlvEffectInstance _iPtrGroundEffectMain;

	private BtlvEffectInstance _iPtrGroundEffectCamera;

	private BattleGroundData _groundDatas;

	private Vector3 _cameraEffectOffset;

	private Coroutine _changeGroundCol;

	private Action<BtlGround, BtlGround> _onChanged;

	public BattleGroundEffectSystem(BattleViewSystem pViewSystem)
	{
	}

	public void Request(BtlGround ground, Vector3 offset, [Optional] Action<BtlGround, BtlGround> onChanged)
	{
	}

	private IEnumerator ChangeBattleGround(BtlGround ground)
	{
		return null;
	}

	private IEnumerator PlayGroundEffect()
	{
		return null;
	}

	private bool CheckAlreadyChanged()
	{
		return default(bool);
	}

	private void Stop()
	{
	}

	private void LoadData(BtlGround groundType)
	{
	}

	public string[] GetFileNames(BtlGround groundType)
	{
		return null;
	}

	private IEnumerator LoadEffect(string file, Action<BtlvEffectInstance> setter, SEQ_DEF_EFF_DRAWTYPE drawType = SEQ_DEF_EFF_DRAWTYPE.SEQ_DEF_EFF_DRAWTYPE_NORAML)
	{
		return null;
	}

	public void SetGroundVisibility(bool visible)
	{
	}
}
