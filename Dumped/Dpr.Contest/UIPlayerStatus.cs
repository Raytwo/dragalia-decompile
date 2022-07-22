using System;
using System.Collections;
using System.Collections.Generic;
using Dpr.SubContents;
using Effect;
using UnityEngine;

namespace Dpr.Contest;

public class UIPlayerStatus : MonoBehaviour
{
	[SerializeField]
	private Sprite[] tensionSprArray;

	[SerializeField]
	private GameObject[] statusIconObjArray;

	private Dictionary<int, Sprite> tensionSprTable;

	private List<Coroutine> runningCoroutineList;

	private EffectInstance[] skillBgFxArray;

	private PlayerStatusIcon[] statusIconArray;

	private EffectEmitter fxEmitter;

	private WaitForSeconds waitWazaStartFx;

	private float duration;

	private float jumpPower;

	public void Initialize(float waitWazaStartTime)
	{
	}

	private void SetTentionSprTable()
	{
	}

	public bool IsReady()
	{
		return default(bool);
	}

	public void Setup(float duration, float jumpPower)
	{
	}

	private void LoadFx()
	{
	}

	public void SetPlayerDataUI(AContestPlayerData data, Sprite wazaTypeIconSpr, Sprite iconSpr)
	{
	}

	public void OnFinalize()
	{
	}

	public void ResetParam()
	{
	}

	public void Stop()
	{
	}

	public Vector3 GetIconPos(int index)
	{
		return default(Vector3);
	}

	public void SetTensionID(int index, TensionID tensionID)
	{
	}

	public void SetTensionID(int index, TensionID tensionID, bool isUp)
	{
	}

	public void LaunchContestWaza(int playerIndex)
	{
	}

	private IEnumerator IE_LaunchContestWaza(int playerIndex, Action onComplete)
	{
		return null;
	}

	public void OnFinishedSkillEffect(int playerIndex)
	{
	}

	public void ShowWazaMaskByIndex(int playerIndex)
	{
	}
}
