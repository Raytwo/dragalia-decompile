using UnityEngine;

public class BicycleJump
{
	public enum Seq
	{
		Start,
		Jump,
		EndFollow,
		End
	}

	private Vector3 _startPos;

	private Vector3 _endPos;

	private Vector3 _diffPos;

	private Vector3 _jumpVector;

	private bool _gear;

	private Seq _seqNo;

	private bool _left;

	private float _workX;

	private float _jumpSpeed;

	private float _jumpHeight;

	private float _jumpZusaCnt;

	private const float JumpHeight_g3 = 0.8f;

	private const float JumpHeight_g4 = 1f;

	private const float JumpSpeed_g3 = 6f;

	private const float JumpSpeed_g4 = 10f;

	private const float JumpZusaTime = 0.1f;

	public void SetUp(Vector3 startpos, Vector3 endpos, bool gear)
	{
	}

	public Vector3 Update(float deltatime, out Seq end, ref Vector3 worldpos)
	{
		return default(Vector3);
	}

	private Vector3 JumpAction(float deltatime, ref Vector3 worldpos)
	{
		return default(Vector3);
	}

	private Vector3 SlowGear(float deltatime, out Seq end, ref Vector3 worldpos)
	{
		return default(Vector3);
	}

	private Vector3 FastGear(float deltatime, out Seq end, ref Vector3 worldpos)
	{
		return default(Vector3);
	}
}
