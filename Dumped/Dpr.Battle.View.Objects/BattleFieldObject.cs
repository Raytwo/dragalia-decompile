using UnityEngine;

namespace Dpr.Battle.View.Objects;

public class BattleFieldObject : BtlvBehaviour
{
	private enum HideObjectIndex
	{
		Player,
		Trainer
	}

	private enum AllHideObjectIndex
	{
		Tag,
		Single
	}

	[SerializeField]
	private GameObject[] _cellingObjects;

	[SerializeField]
	private GameObject[] _singleBattleHideObjects;

	[SerializeField]
	private GameObject[] _doubleBattleHideObjects;

	[SerializeField]
	private GameObject[] _tagBattleHideObject;

	private MirrorPlane[] mirrarPlanes;

	public GameObject[] CeilingObjects => null;

	public GameObject[] SingleBattleHideObjects => null;

	public GameObject[] DoubleBattleHideObjects => null;

	public GameObject[] TagBattleHideObjects => null;

	protected void Awake()
	{
	}

	public void SetMirrarCharacterLayerEnable(bool isEnable)
	{
	}

	public void SetSkirtHideObjectActive(bool isHidePlayer, bool isPlayerSingle, bool isHideTrainer, bool isTrainerSingle)
	{
	}

	private void SetPlayerSkirtHideObjectActive(bool isHidePlayer, bool isSingle)
	{
	}

	private void SetTrainerSkirtHideObjectActive(bool isHideTrainer, bool isSingle)
	{
	}

	private void SetAllTrainerSkirtHideObjectActive(bool isHide, bool isSingle)
	{
	}

	private void OnDestroy()
	{
	}
}
