using UnityEngine;

namespace Dpr.Field.Walking;

public class WalkingCharacterView : MonoBehaviour
{
	public enum AnimType
	{
		Wait,
		Walk,
		Run
	}

	public float PokeScale;

	private float toRunSpeed;

	public int anim;

	public Transform EffTransform;

	public bool isWaitMotionMove;

	protected AnimationPlayer animPlayer;

	private int PrevAnimID;

	public bool IsStopUpdate;

	public bool isKwWait;

	private float AnimDuration;

	public float t;

	public float defaultDuration;

	public static readonly int[] WaitAnimIDs;

	public static readonly int[] WaittoWalkIDs;

	public static readonly int[] WaittoRunIDs;

	public static readonly int[] WalktoRunIDs;

	public static readonly int[] WalktoWaitIDs;

	public static readonly int[] RuntoWalkIDs;

	public static readonly int[] RuntoWaitIDs;

	private void Awake()
	{
	}

	public void ChangeUpdateWhenOffScreen(FieldPokemonEntity entity)
	{
	}

	private void OnDestroy()
	{
	}

	public void SetAnimPlayer(AnimationPlayer player)
	{
	}

	public AnimationPlayer GetAnimPlayer()
	{
		return null;
	}

	public void CreateEffectPosition(Vector3 pos)
	{
	}

	public void AutoSelectAnimation(WalkingCharacterModel model)
	{
	}

	public bool CheckSleepState(WalkingCharacterModel model)
	{
		return default(bool);
	}

	public void AnimPlay(int index, float duration = 0f, float startTime = 0f)
	{
	}

	public CorSystem AnimPlayForce(int index, CorSystem corSys, WalkingCharacterModel model, float duration = 0f, float startTime = 0f)
	{
		return null;
	}

	private float GetWaitDuration(int NextAnimID)
	{
		return default(float);
	}

	private int GetWaitToWait(int hokanAnim, int nextAnim)
	{
		return default(int);
	}

	public int GetWaitAnim(int prevWait, int nextWait)
	{
		return default(int);
	}

	public int GetNeutralWaitAnim()
	{
		return default(int);
	}

	public bool isHokanAnimation(int AnimID)
	{
		return default(bool);
	}

	private bool isWaitAnim(int AnimID)
	{
		return default(bool);
	}

	private bool isRunAnim(int AnimID)
	{
		return default(bool);
	}

	private bool isWalkAnim(int AnimID)
	{
		return default(bool);
	}

	public bool isNeedWait()
	{
		return default(bool);
	}

	public void CheckForceLoop(int animIndex)
	{
	}

	public int GetAnimIndex(AnimType animType)
	{
		return default(int);
	}

	public void OnValidate()
	{
	}
}
