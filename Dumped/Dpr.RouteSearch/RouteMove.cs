using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.RouteSearch;

public class RouteMove
{
	private Vector3[] Route;

	private int CurrentRouteIndex;

	public bool IsBusy
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float MoveSpeed
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void StartRoute(Vector3[] route)
	{
	}

	public void SetRoute(Vector3[] route)
	{
	}

	public void StartMove()
	{
	}

	public void StopMove()
	{
	}

	public void Update(float deltaTime, [In] ref Vector3 inputPos, out Vector3 outputPos)
	{
	}
}
