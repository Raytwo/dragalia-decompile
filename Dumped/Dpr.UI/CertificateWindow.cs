using System.Collections;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class CertificateWindow : UIWindow
{
	public class Param
	{
		public enum CertificateType
		{
			Zukan,
			ZenkokuZukan,
			Akashi
		}

		public CertificateType type;

		public PokemonParam pokemonParam;
	}

	[SerializeField]
	private UIText _text0;

	[SerializeField]
	private UIText _text1;

	[SerializeField]
	private Image _imageBg;

	[SerializeField]
	private Image _imagePokemon;

	[SerializeField]
	private Sprite[] _spriteBgs;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupKeyguide()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
