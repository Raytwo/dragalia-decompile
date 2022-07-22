using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using XLSXContent;

namespace Dpr.SecretBase;

public class PlacementData
{
	private class SetMotionMono : MonoBehaviour
	{
		private float timer;

		private float height;

		private readonly float g;

		private float v0;

		private int bound;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}

	private class NGMotionMono : MonoBehaviour
	{
		private readonly float length;

		private int count;

		private Vector3 basePos;

		private bool isPlaying;

		public void Play()
		{
		}

		public void Stop()
		{
		}

		private void Update()
		{
		}

		private void PlayUpdate()
		{
		}
	}

	public StatueItemData data;

	public FieldCursor cursor;

	private Transform statueModel;

	private Transform pedestalModel;

	private StatueEffectData statue;

	public Pedestal.SheetInfo pedestal;

	private NGMotionMono ngMotionPlayer;

	public bool isLoading
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

	public Vector3 Position => default(Vector3);

	public PlacementData(PlacementData prev, RectInt rect, FieldCursor origin, Transform root)
	{
	}

	public PlacementData(GameObject model, StatueItemData value, StatueEffectData statue, Pedestal.SheetInfo pedestal, RectInt rect, FieldCursor origin, bool bIsCursorCopy, [Optional] Transform root)
	{
	}

	public PlacementData(StatueModelLoader modelLoader, StatueItemData value, StatueEffectData statue, Pedestal.SheetInfo pedestal, RectInt rect, FieldCursor origin, bool bIsCursorCopy, [Optional] Transform root)
	{
	}

	public void SetParent(FieldCursor parent)
	{
	}

	public void SetPedestal(Pedestal.SheetInfo pedestal)
	{
	}

	public void UpdateGraphic(bool pickup = false)
	{
	}

	public void Destroy(bool bCursor)
	{
	}

	public void SetActive(bool value)
	{
	}

	public void SetDisplayCursor(bool isView)
	{
	}

	public bool IsRotation()
	{
		return default(bool);
	}

	public void PlayNGMotion()
	{
	}

	public void StopNGMotion()
	{
	}
}
