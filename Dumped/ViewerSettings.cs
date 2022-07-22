using System;
using SmartPoint.Components;
using SmartPoint.Rendering;
using UnityEngine;

[Serializable]
public class ViewerSettings : PlayerPrefsProvider<ViewerSettings>
{
	[SerializeField]
	private float _cameraFov;

	[SerializeField]
	private float _focalLength;

	[SerializeField]
	private float _farDepth;

	[SerializeField]
	private float _blurry;

	[SerializeField]
	private Color _clearColor;

	[SerializeField]
	private bool _autoRotate;

	[SerializeField]
	private bool _effectEnable;

	[SerializeField]
	private bool _saveField;

	[SerializeField]
	private bool _appendOpenMode;

	[SerializeField]
	private string _fieldAssetBundleName;

	[SerializeField]
	private int _timeZone;

	[SerializeField]
	private bool _hideBoundingBox;

	[SerializeField]
	private bool _autoFit;

	[SerializeField]
	private bool _sequentialShooting;

	[SerializeField]
	private bool _avatarTakeover;

	[SerializeField]
	private int _trackColorVariation;

	[SerializeField]
	private bool _trackShadowAdjust;

	[SerializeField]
	private float _sensorScale;

	private Camera _camera;

	private DepthOfField _dof;

	private string _lastSelectionName;

	protected override string key => null;

	public static Camera camera
	{
		set
		{
		}
	}

	public static float fieldOfView
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static Transform cameraTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static float farDepth
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static bool sequentialShooting
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool avatarTakeover
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static int trackColorVariation
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static bool trackShadowAdjust
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static float clearColorR
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static float clearColorG
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static float clearColorB
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static float sensorScale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static bool autoRotate
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool effectEnable
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool saveField
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static int timeZone
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static bool appendOpenMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool hideBoundingBox
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool autoFit
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static string fieldAssetBundleName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string lastSelectionName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
