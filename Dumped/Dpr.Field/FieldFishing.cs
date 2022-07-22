using AttributeData;
using Audio;
using Effect;
using UnityEngine;

namespace Dpr.Field;

public class FieldFishing
{
	private enum Seq
	{
		Start,
		StartAnimeWait,
		StartAnimeEnd,
		Update,
		HitInput,
		End,
		FaileAnimeWait,
		SuccessAnimeWait,
		HitEndAnimeWait
	}

	public enum ResultState
	{
		Update,
		Sucsess,
		NoneEnc,
		MissInput,
		Cancel
	}

	public struct Result
	{
		public bool isFishing;

		public EncountResult encResult;

		public ResultState state;

		public int attriCode;

		public MapAttributeEx attriEx;
	}

	private enum EffectID
	{
		EF_F_FISHING_THROW_01,
		EF_F_FISHING_WAIT_01,
		EF_F_FISHING_HIT_01,
		EF_F_FISHING_CATCH_01,
		EF_F_FISHING_CATCH_02,
		END
	}

	private enum AudioID
	{
		s_fi021,
		s_fi021_2,
		s_fi021_3,
		s_fi022,
		s_fi023,
		s_fi024,
		s_fi025,
		s_fi026,
		end
	}

	private Seq _seqNo;

	private Result _returnResult;

	private Vector2Int _grid;

	private float _inputTime;

	private float _inputLimit;

	private FishingRod _rodType;

	private Balloon _ballon;

	private Vector3 _effectPosition;

	private bool _isRideBicycle;

	private EffectInstance[] _eff_Instance;

	private AudioInstance[] _se_audio_instance;

	private bool _throw_se;

	private float _hit_random_time;

	private float _hit_wait_time;

	private float FAIL_TIME;

	private bool _is_feint;

	private float _feint_down;

	private float _feint_time;

	public void Clear()
	{
	}

	private float DATA_TuriageFrameTbl(FishingRod rodType)
	{
		return default(float);
	}

	public bool StartFishing(FishingRod rodType)
	{
		return default(bool);
	}

	private bool IsWaterGrid(ref Vector3 forward)
	{
		return default(bool);
	}

	public Result Update(float time)
	{
		return default(Result);
	}

	private void RideBicycle()
	{
	}

	public static int RodVaridation(FishingRod rod)
	{
		return default(int);
	}
}
