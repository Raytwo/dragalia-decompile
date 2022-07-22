using Dpr.MsgWindow;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class PokemonStatusPanel : MonoBehaviour
{
	protected PokemonParam _pokemonParam;

	protected GameObject _aButtonGuide;

	public UIInputController input;

	public PokemonStatusWindow.Param statusParam;

	public UnityAction<bool> onChangeMemberSelectArrow;

	public UnityAction<bool, string, string> onChangeAbuttonGuide;

	public UnityAction onOpenBag;

	public UnityAction<bool> onOpenBagOfWazaMachine;

	public UnityAction onOpenPofinCase;

	public UnityAction<MsgWindowParam> onOpenMessageWindow;

	public UnityAction onForceClosed;

	public PokemonParam pokemonParam => null;

	private bool isFromBattle => default(bool);

	private bool isFromBoxOtherStatus => default(bool);

	private bool isFromBoxSelect => default(bool);

	private bool isFromZukanRegister => default(bool);

	private bool isFromFureai => default(bool);

	protected bool isLimitBag => default(bool);

	protected bool isLimitMarking => default(bool);

	protected bool isLimitWazaSwap => default(bool);

	protected bool isLimitWazaMachine => default(bool);

	protected bool isLimitPofin => default(bool);

	protected bool isLimitRibon => default(bool);

	public virtual void Clear()
	{
	}

	public virtual void Setup(PokemonParam pokemonParam)
	{
	}

	public virtual void Select(bool enabled)
	{
	}

	public virtual bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}
}
