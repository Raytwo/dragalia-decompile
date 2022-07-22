using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;

public class AfterImage : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	private Camera _camera;

	private RenderTexture _renderTexture;

	private static readonly int BlendWeightID;

	private static readonly int AngleID;

	private static readonly int ReciprocalScaleID;

	private Material materialInstance;

	[SerializeField]
	private float angle;

	[SerializeField]
	private float scale;

	private bool copyOnce;

	public float Angle
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Scale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public RenderTexture renderTexture => null;

	public void OnViewportChange(int width, int height)
	{
	}

	private void Cleanup()
	{
	}

	private void OnEnable()
	{
	}

	private void OnRenderImage(RenderTexture input, RenderTexture output)
	{
	}

	private void OnDisable()
	{
	}
}
