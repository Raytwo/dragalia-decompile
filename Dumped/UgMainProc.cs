using System.Collections;
using System.Collections.Generic;
using Dpr.Field.Walking;
using Pml.PokePara;
using Ug;
using UnityEngine;
using XLSXContent;

public class UgMainProc
{
	private class SimbolMons
	{
		public PokemonParam pokeParam;

		public PokemonInfo.SheetCatalog catalog;

		public Vector3 defaultPos;

		public bool Active;

		public bool isLoaded;

		public Ug.MoveType moveType;

		public GameObject gameObject;

		public Transform transform;

		public FieldPokemonEntity entity;

		public void Destroy()
		{
		}
	}

	private List<SimbolMons> _ugMons;

	public static UgWalkingAIManager walkingManager;

	public static bool isEntering;

	private List<AIUgModel> ugAIs;

	private float NoHitTime;

	public void Init()
	{
	}

	private void OnSceneInit()
	{
	}

	public void EncountMonsLot(int randmark)
	{
	}

	public void CreatePoke(PokemonParam param, Vector3 pos)
	{
	}

	public IEnumerator CreateObject()
	{
		return null;
	}

	private void OnZoneChange()
	{
	}

	public void SaveSimbols()
	{
	}

	public void LoadSimbols()
	{
	}

	public bool update(float time)
	{
		return default(bool);
	}

	private bool IsPlayerHit(Vector3 pos, SimbolMons mons)
	{
		return default(bool);
	}

	public void Destroy()
	{
	}
}
