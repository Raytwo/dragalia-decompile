using System;
using Dpr.Battle.Logic;
using Dpr.SequenceEditor;
using Dpr.Trainer;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public sealed class BOTrainer : BattleViewCharacter
{
	private const string SEQUENCE_BALL_NODE_NAME = "loc_ob_ball";

	public static readonly Tuple<string, int>[] CONVERT_ANIMATON_NAME_TO_SEQUENCE_ID;

	public static readonly Tuple<string, JointName>[] CONVERT_ATTACH_JOINT_TO_JOINT_NAME;

	private TRAINER_DATA _trainerData;

	private BattleCharacterEntity _battlePlayerEntity;

	public bool IsPlayer => default(bool);

	public BattleCharacterEntity Entity => null;

	public void Initialize(BtlvPos vPos, TRAINER_DATA data)
	{
	}

	public byte GetClientId()
	{
		return default(byte);
	}

	public HandDominance GetDominansHand()
	{
		return default(HandDominance);
	}

	public HandDominance GetBallHoldHand()
	{
		return default(HandDominance);
	}

	public Transform GetNodeJoint(JointName jointName)
	{
		return null;
	}

	public Transform GetNodeJoint(SEQ_DEF_NODE_MODEL joint)
	{
		return null;
	}

	private bool IsHandNode(JointName nodeName)
	{
		return default(bool);
	}

	[Obsolete]
	public override void AttachObject(GameObject obj, string nodeName, bool isFollowPos, bool isFollowRot, bool isFollowScl, bool isFollowAnimScl, bool isFollowLocalScl)
	{
	}

	public void AttachObject(ObjectEntity obj, JointName nodeName, bool ignoreDominantHand, bool enableDominantHoldBallHand, bool isFollowPos, bool isFollowRot, bool isFollowScl, bool isFollowAnimScl, bool isFollowLocalScl)
	{
	}

	public void DetachObject(ObjectEntity obj)
	{
	}

	[Obsolete]
	public override void ChangeAnimState(string parameterName, bool isReset = false)
	{
	}

	public void ChangeAnimState(SEQ_DEF_TRAINER_MOTION motion, float duration = 0.15f, float startTime = 0f, bool isLoop = false)
	{
	}

	public void ChangeAnimStateThrowBall(float duration, SEQ_DEF_TRAINER_MOTION_THROW_BALL ballThrowType)
	{
	}

	protected override void UpdateAnimSpeed()
	{
	}

	protected override void UpdateVisible()
	{
	}

	public override void SetRenderActive(bool isActive)
	{
	}

	public override void SetVisibleShadow(bool value)
	{
	}
}
