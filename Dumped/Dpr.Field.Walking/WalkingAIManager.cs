using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Field.Walking;

public class WalkingAIManager
{
	private List<WalkingCharacterController> walkingCharacters;

	public bool isAllStop;

	[SerializeField]
	private FieldObjectEntity testEntity;

	public int Button01;

	public int Button02;

	public WalkingCharacterController ToWalkingCharacter(FieldObjectEntity entity)
	{
		return null;
	}

	public virtual void Destroy(bool isDestroyGameObject = false)
	{
	}

	public void StopAll(bool isStop)
	{
	}

	private WalkingCharacterModel CreateFieldWalkModel(FieldObjectEntity entity)
	{
		return null;
	}

	private WalkingCharacterController CommonSetUp(FieldObjectEntity entity)
	{
		return null;
	}

	protected virtual WalkingCharacterController AddController(GameObject go)
	{
		return null;
	}

	public void SubWalkingCharacter(FieldObjectEntity entity, bool isDestroy = false)
	{
	}

	public void TestAdd()
	{
	}

	public void TestSub()
	{
	}

	public static List<Vector2Int> GetNearEmptyPosition(Vector2Int grid, bool ignoreNaname = false, bool isFureai = false)
	{
		return null;
	}
}
