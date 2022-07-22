using DG.Tweening;
using Pml;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.BallDeco;

public static class BallDecoWork
{
	public const int CapsuleInitialCount = 12;

	public const int CapsuleMaxCount = 99;

	public const int AffixSealMaxCount = 20;

	public const int SealSaveSize = 200;

	public const int SealMaxCount = 99;

	public const int Capsule2DCalcCenterThetaAngle = 90;

	public const int Capsule2DCalcCenterFrontPhiAngle = 0;

	public const int Capsule2DCalcCenterBackPhiAngle = -180;

	public const string BallLightEffectAssetBundlePathFormat = "effect/prefab/seal/ef_s_seal_eb{0:D3}";

	public static readonly int Capsule2DCalcFrontRadius;

	public static readonly int Capsule2DCalcBackRadius;

	public static readonly int Capsule2DCalcFrontSplitAngle;

	public static readonly int Capsule2DCalcBackSplitAngle;

	public static readonly float EffectMoveValue;

	public static readonly Ease EffectMoveEasingType;

	public static SaveBallDecoData m_ballDecoData => default(SaveBallDecoData);

	public static int GetCapsuleCount()
	{
		return default(int);
	}

	public static void AddCapsuleCount(int count)
	{
	}

	public static bool Get3DEditMode(int capsuleId)
	{
		return default(bool);
	}

	public static void Set3DEditMode(int capsuleId, bool is3DEditMode)
	{
	}

	public static void SetAppliedTemplate(int capsuleId, bool isAppliedTemplate)
	{
	}

	public static int GetAttachCapsuleId(uint pokemonId, uint personalRnd)
	{
		return default(int);
	}

	public static void SetAttachCapsule(int capsuleId, uint pokemonId, uint personalRnd)
	{
	}

	public static void SwapCapsuleData(int capsuleId1, int capsuleId2)
	{
	}

	public static int GetCanCopySealCount(int capsuleId)
	{
		return default(int);
	}

	public static int GetCanCopySealCount(CapsuleData capsuleData)
	{
		return default(int);
	}

	public static bool CopyCapsuleData(int fromCapsuleId, int toCapsuleId)
	{
		return default(bool);
	}

	public static bool CopyCapsuleData(CapsuleData capsuleData, int toCapsuleId)
	{
		return default(bool);
	}

	public static int GetAffixSealCount(int capsuleId)
	{
		return default(int);
	}

	public static AffixSealData GetAffixSealData(int capsuleId, int affixSealId)
	{
		return default(AffixSealData);
	}

	public static void SetAffixSealData(int capsuleId, int affixSealId, ushort sealId, Vector3 pos)
	{
	}

	public static void SetAffixSealData(int capsuleId, AffixSealData[] affixSealDatas, byte affixSealCount)
	{
	}

	public static bool AddAffixSealData(int capsuleId, ushort sealId, Vector3 pos)
	{
		return default(bool);
	}

	public static void RemoveAffixSealData(int capsuleId, int affixSealId)
	{
	}

	public static bool GetSealIsGet(int id)
	{
		return default(bool);
	}

	public static int GetSealCount(int id)
	{
		return default(int);
	}

	public static int GetSealTotalCount(int id)
	{
		return default(int);
	}

	public static int GetCanAddSealCount(int id)
	{
		return default(int);
	}

	public static void AddSealCount(int id, int count)
	{
	}

	public static void SubSealCount(int id, int count, bool isAffixSeal)
	{
	}

	public static void ReturnSealCount(int id, int count)
	{
	}

	public static CapsuleData GetCapsuleData(int capsuleId)
	{
		return default(CapsuleData);
	}

	public static Vector3 Convert2DPosition(int x, int y, bool isFront)
	{
		return default(Vector3);
	}

	public static float GetEffectPositionOffset(Size size)
	{
		return default(float);
	}

	public static string GetBallLightEffectAssetBundleName(BallId ballId)
	{
		return null;
	}

	public static bool GetFixedEffectData(SealID sealID, out Vector3 pos, out Vector3 rot, out Vector3 scaleRate)
	{
		return default(bool);
	}
}
