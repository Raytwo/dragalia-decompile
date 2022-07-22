using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

namespace Dpr.UI;

public class CharacterModelView : ModelViewBase
{
	public class Param
	{
		public enum ModelType
		{
			Field,
			Battle,
			Num
		}

		public UIModelViewController.ModelViewType type;

		public CharacterDressData.SheetData characterDressData;

		public ModelType modelType;

		public Canvas canvas;

		public float offsetZ;

		public bool isAutoUpdateTexture;

		public int GetModelId()
		{
			return default(int);
		}

		public bool IsMaleDress()
		{
			return default(bool);
		}
	}

	[SerializeField]
	private Transform _transModel;

	[SerializeField]
	private float _fov;

	[SerializeField]
	private float _rotateSpeed;

	private int _saveModelViewCacheNum;

	public const string clipName_stand_b = "stand_b";

	public const string clipName_pose_b = "pose_b";

	public const string clipName_pose_loop_b = "pose_loop_b";

	private Param _param;

	private string _clipName;

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public void Setup(Param param, [Optional] UnityAction<Param> onSetup)
	{
	}

	public static string GetAssetBundleName(Param param)
	{
		return null;
	}

	public bool OnUpdate(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	public void PlayAnimation(string clipName, bool looped = false)
	{
	}

	protected override void UpdateAnimation(float deltaTime)
	{
	}
}
