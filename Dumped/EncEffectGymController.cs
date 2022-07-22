using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class EncEffectGymController : MonoBehaviour
{
	[SerializeField]
	private Image _playerImage;

	[SerializeField]
	private Image _enemyImage;

	private Animation _anime;

	[SerializeField]
	private Canvas _canvas;

	private void OnEnable()
	{
	}

	public void SetImage(Sprite player, Sprite enemy1, [Optional] Sprite enemy2)
	{
	}

	public void Play()
	{
	}

	private void AnimeEnd()
	{
	}

	public void Release()
	{
	}
}
