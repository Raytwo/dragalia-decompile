using SmartPoint.AssetAssistant;
using UnityEngine;

public class TairyouHasseiPokeManager
{
	private const int GRID_SIZE = 12;

	private const int POKE_MAX = 8;

	private const float DIS = 4f;

	private TairyouHasseiPoke[] _objects;

	private AssetRequestOperation _operation;

	private float _defaultScale;

	private byte _loadingState;

	private GameObject _parent;

	private ZoneID _targetZone;

	public static bool ForceStop;

	private static TairyouHasseiPokeManager instance;

	public bool ZoneChange(bool walk)
	{
		return default(bool);
	}

	public void Update(float time)
	{
	}

	private void Loading()
	{
	}

	private void ObjectStart(int i, FieldPokemonEntity entity)
	{
	}

	private void ObjectEnd(int i)
	{
	}

	private void ObjectReset(int i)
	{
	}

	private bool CheckDisappearOrder(int objectIndex)
	{
		return default(bool);
	}

	private void ObjectUpdate(int i, float time)
	{
	}

	public bool StopUpdate(int i, float time)
	{
		return default(bool);
	}

	private bool CheckAttribute(ref Vector2Int outgrid, out EffectFieldID effet)
	{
		return default(bool);
	}

	private bool ZoneCheck(ref Vector2Int grid)
	{
		return default(bool);
	}

	public static void ForceStopObject()
	{
	}
}
