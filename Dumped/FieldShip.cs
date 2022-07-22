using System.Runtime.CompilerServices;
using Dpr;
using Effect;
using UnityEngine;

public class FieldShip
{
	private enum MapType
	{
		None,
		Normal,
		Sea
	}

	public enum MovePhase
	{
		None,
		AdjustCamera,
		MoveShip
	}

	public enum MoveSeaPhase
	{
		None,
		AppearShip,
		WaitShip,
		AccShip,
		Finish
	}

	private FieldEventEntity Ship;

	private FieldFloatMove ShipSpeed;

	private Vector3 MoveVector;

	private FieldFloatMove CameraOffsetRate;

	private Vector3 CameraOffsetA;

	private Vector3 CameraOffsetB;

	private FieldFloatMove ShipOffset;

	private GameObject CameraAttachObject;

	private GameObject BlurEffectRotate;

	private GameObject BlurEffectParent;

	private EffectInstance BlurEffect;

	private EffectInstance ShipEffect;

	private bool IsAttachPlayer;

	private MapType Type;

	public MovePhase Phase
	{
		[CompilerGenerated]
		get
		{
			return default(MovePhase);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public MoveSeaPhase SeaPhase
	{
		[CompilerGenerated]
		get
		{
			return default(MoveSeaPhase);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Terminate()
	{
	}

	public void FindAndSetShip(string name)
	{
	}

	public void PlayIdle()
	{
	}

	private void PlayShipEffect(EffectFieldID id)
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void StartShip(DIR dir)
	{
	}

	public void NormalUpdate(float deltaTime)
	{
	}

	public void StartShipSeaMap(DIR dir)
	{
	}

	public void SeaUpdate(float deltaTime)
	{
	}
}
