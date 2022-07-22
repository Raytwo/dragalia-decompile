using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class PlayerStatusIcon : MonoBehaviour
{
	private UIText wazaNameText;

	private UIText playerNameText;

	private RectTransform iconContent;

	private RectTransform statusIconRect;

	private RectTransform pmIconRect;

	private Image pmIconImage;

	private Image wazaTypeIconImage;

	private Image wazaMaskObj;

	private Image tensionIconImage;

	private Vector3 startPos;

	public Transform GetTransform()
	{
		return null;
	}

	public Vector3 GetPmIconPos()
	{
		return default(Vector3);
	}

	public void Initialize(int index)
	{
	}

	private void SetComponents()
	{
	}

	public void ResetIcon()
	{
	}

	public void SetWazaName(string wazaName, Sprite wazaTypeIconSpr)
	{
	}

	public void SetMonsterIconSpr(Sprite iconSpr)
	{
	}

	public void SetPlayerName(string name)
	{
	}

	public void ShowTension(Sprite spr)
	{
	}

	public void ShowTension(Sprite spr, float duration, float jumpPower)
	{
	}

	public void HideTension()
	{
	}

	private void SetTensionImageActive(bool active)
	{
	}

	public void ShowWazaMask()
	{
	}

	public void HideWazaMask()
	{
	}

	public void StartContestSkill()
	{
	}
}
