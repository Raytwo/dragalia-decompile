using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Systems;
using Dpr.SequenceEditor;
using Dpr.Trainer;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.View;

public static class Extensions
{
	private static ComparerMotionReplaceData _comparerCatalog;

	public static void SetRotation(this Transform self, Axis axis, float value)
	{
	}

	public static void SetOrigin(this Transform self, [Optional] Transform parent)
	{
	}

	public static void SetTwist(this Transform self, float twist, bool isLocal = false)
	{
	}

	public static void InverseScale(this Transform self, bool isYInverse = false)
	{
	}

	public static Tweener DOVector(this Vector3 self, Vector3 endValue, float duration)
	{
		return null;
	}

	public static BattleDefaultPlacementData.SheetDefaultCharaPlacementData GetTrainerPlacementData(this BattleDefaultPlacementData self, BtlRule rule, BtlvPos vPos, Size pokeSize, SEQ_DEF_DEFAULT_PLACEMENT placement, out Vector3 pos, out int rotY)
	{
		return null;
	}

	public static BattleDefaultPlacementData.SheetDefaultCharaPlacementData GetPokemonPlacement(this BattleDefaultPlacementData self, BtlRule rule, BtlvPos vPos, Size size, SEQ_DEF_DEFAULT_PLACEMENT placement, out Vector3 pos, out int rotY)
	{
		return null;
	}

	public static BattleDefaultPlacementData.SheetDefaultCameraPlacementData GetDefaultCameraPlacementData(this BattleDefaultPlacementData self, BtlRule rule, Size pokePlayer, Size pokeEnemy)
	{
		return null;
	}

	public static BattleWaitCameraData.SheetWaitCameraData GetWaitCameraData(this BattleWaitCameraData self, int index)
	{
		return null;
	}

	public static BattleWaitCameraData.SheetWaitCameraData[] GetWaitCameraDatas(this BattleWaitCameraData self, MainModule.BtlDetailRule rule)
	{
		return null;
	}

	public static BattleWaitCameraData.SheetWaitCameraData[] GetTutorialWaitCameraDatas(this BattleWaitCameraData self)
	{
		return null;
	}

	public static BattleWaitCameraData.SheetWaitCameraData[] GetDemoCaptureWaitCameraDatas(this BattleWaitCameraData self)
	{
		return null;
	}

	public static MaskPattern GetMaskPattern(this BattleWaitCameraData.SheetWaitCameraData self)
	{
		return default(MaskPattern);
	}

	public static BattleDataTable.SheetSetupIntroPlaySequenceData GetSetupIntroPlaySequenceData(this BattleDataTable self, BattleSetupIntroID id)
	{
		return null;
	}

	public static BattleDataTable.SheetBattleWazaMsgFrameData FindMsgFrameData(this BattleDataTable self, string hashKey)
	{
		return null;
	}

	public static BattleDataTable.SheetBattleMiscEffectData FindMiscEffectData(this BattleDataTable self, BtlEff eff)
	{
		return null;
	}

	public static BattleDataTable.SheetBattleConstant GetBattleConstant(this BattleDataTable self, BattleConstantKey key)
	{
		return null;
	}

	public static int GetBattleConstantInt(this BattleDataTable self, BattleConstantKey key)
	{
		return default(int);
	}

	public static float GetBattleConstantFloat(this BattleDataTable self, BattleConstantKey key)
	{
		return default(float);
	}

	public static string GetBattleConstantString(this BattleDataTable self, BattleConstantKey key)
	{
		return null;
	}

	public static BattleDataTable.SheetMotionTimingData GetMotionTimingData(this BattleDataTable self, MonsNo monsNo, int formNo, Sex sex)
	{
		return null;
	}

	public static BattleDataTable.SheetMotionReplaceData GetMotionReplaceData(this BattleDataTable self, int uniqueId)
	{
		return null;
	}

	public static BattleDataTable.SheetPokemonEntryMotionData GetPokemonEntryMotionData(this BattleDataTable self, int index)
	{
		return null;
	}

	public static BattleDataTable.SheetAgeEyeBlink GetAgeEyeBlinkData(this BattleDataTable self, TrainerAge age)
	{
		return null;
	}

	public static BattleDataTable.SheetDisableBlinkPokemon GetDisableBlinkPokemon(this BattleDataTable self, MonsNo no)
	{
		return null;
	}

	public static BattleDataTable.SheetPokemonMotionBlendTime GetPokemonMotionBlendTime(this BattleDataTable self, MonsNo no)
	{
		return null;
	}

	public static BattleDataTable.SheetInterpolationSequence GetInterpolationSequence(this BattleDataTable self, string seqName)
	{
		return null;
	}

	public static BattleViewSystem.BattleViewSide GetBattleSide(this BtlvPos pos)
	{
		return default(BattleViewSystem.BattleViewSide);
	}

	public static Ease GetEase(this EaseFunc self)
	{
		return default(Ease);
	}

	public static BtlEff GetWheatherEffect(this BtlWeather self)
	{
		return default(BtlEff);
	}

	public static BtlEff GetGroundEffect(this BtlGround self)
	{
		return default(BtlEff);
	}

	public static BtlvPos GetBtlvPos(this WaitCameraTarget self)
	{
		return default(BtlvPos);
	}

	public static JointName GetJointName(this WaitCameraNode self)
	{
		return default(JointName);
	}

	public static BattlePokemonEntity.AnimationState GetAnimationState(this SEQ_DEF_ATK_MOT self)
	{
		return default(BattlePokemonEntity.AnimationState);
	}

	public static BattleCharacterEntity.AnimationState ToTrainerAnimationState(this SEQ_DEF_TRAINER_MOTION self)
	{
		return default(BattleCharacterEntity.AnimationState);
	}

	public static SEQ_DEF_TRAINER_MOTION ToDefTrainerMotion(this BattleCharacterEntity.AnimationState self)
	{
		return default(SEQ_DEF_TRAINER_MOTION);
	}

	public static void Reserve<T>(this List<T> self, int capacity)
	{
	}

	public static T At<T>(this IList<T> self, int index)
	{
		return (T)null;
	}

	public static void PushBack<T>(this IList<T> self, T item)
	{
	}

	public static void EmplaceBack<T>(this IList<T> self, T item)
	{
	}

	public static T Front<T>(this IList<T> self)
	{
		return (T)null;
	}

	public static T Back<T>(this IList<T> self)
	{
		return (T)null;
	}
}
