using Dpr;
using UnityEngine;

public class TelescopeNagisa
{
	private enum ScopePhase
	{
		None,
		Start,
		Open,
		Wait,
		PreClose,
		Close
	}

	private ScopePhase Phase;

	private Vector2Int EventPos;

	private FieldFloatMove Time;

	public bool IsBusy => default(bool);

	public void Start(Vector2Int eventPos)
	{
	}

	public void Update(float deltaTime)
	{
	}
}
