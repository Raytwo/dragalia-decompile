using UnityEngine;

public class FieldFader : MonoBehaviour
{
	public enum FieldFadeType
	{
		NONE,
		DUNGEON,
		BUILDING,
		AREA_UP,
		AREA_DOWN,
		AREA_LEFT,
		AREA_RIGHT
	}

	[SerializeField]
	private GameObject _dungeonFade;

	[SerializeField]
	private GameObject _buildingFade;

	[SerializeField]
	private GameObject _areaFade;

	private bool _isFadeOut;

	private bool _isPlaying;

	private float _time;

	private float _progressTime;

	private Animator _animator;

	public bool IsBusy => default(bool);

	public void OnUpdate(float deltaTime)
	{
	}

	public void FadeOut(FieldFadeType type, float time = 0.5f)
	{
	}

	public void FadeIn(FieldFadeType type, float time = 0.5f)
	{
	}

	private void PlayAnimation(FieldFadeType type, float time)
	{
	}

	private void SetActiveFade(FieldFadeType type)
	{
	}
}
