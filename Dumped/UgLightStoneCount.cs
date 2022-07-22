using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UgLightStoneCount : MonoBehaviour
{
	[SerializeField]
	private List<Sprite> numResource;

	[SerializeField]
	private int digit;

	[SerializeField]
	private Image numeratorLeft;

	[SerializeField]
	private Image numeratorCenter;

	[SerializeField]
	private Image numeratorRight;

	[SerializeField]
	private Image denominatoLeft;

	[SerializeField]
	private Image denominatoCenter;

	[SerializeField]
	private Image denominatoRight;

	private Image[] numeratorImages;

	private Image[] denominatoImages;

	private int max;

	public void Initialize()
	{
	}

	public void SetDenominato(int num)
	{
	}

	public void SetNumerator(int num)
	{
	}

	private int DigitNum(int num)
	{
		return default(int);
	}

	private int[] Split(int num)
	{
		return null;
	}
}
