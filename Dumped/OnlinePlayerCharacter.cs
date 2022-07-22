using System;
using Dpr.FureaiHiroba;
using UnityEngine;

public class OnlinePlayerCharacter : MonoBehaviour
{
	private const int EMOTICON_ID_BATTLE = 15;

	private const int EMOTICON_ID_TRADE = 16;

	private const int EMOTICON_ID_RECODE = 17;

	private const int EMOTICON_ID_TRAINER = 21;

	private const int EMOTICON_ID_BALL_DECO = 18;

	private const int EMOTICON_ID_TALK = 9;

	private const int EMOTICON_ID_LIKES = 28;

	private const int EMOTICON_ID_CROSS = 20;

	private const int EMOTICON_ID_EXCLAMATION = 29;

	private const int EMOTICON_ID_PICKEL = 24;

	private const int EMOTICON_ID_TOGETHER = 27;

	private const int EMOTICON_ID_GET = 25;

	public OpcState opcState;

	public Balloon balloon;

	public Emoticon emoticon;

	public Action<int> _ShowWindow;

	public float talkDistance;

	public bool isMenuOpen;

	public AnimationPlayer _myAnimationPlayer;

	public int stationIndex;

	private float _IdleTransutuonTime;

	private bool _IsTransitionIdle;

	private int emoticonType;

	public bool isRecruiment;

	public bool isTransitionAfter;

	public bool isMyPlyaer;

	protected virtual void Start()
	{
	}

	protected virtual void MyUpdate(float deltaTime)
	{
	}

	public bool IsGetOpcState()
	{
		return default(bool);
	}

	public void ShowEmoticon(OpcState.OnlineState state)
	{
	}

	public void DeleteEmoticon()
	{
	}

	public void SetEmoticonHost()
	{
	}

	public void SetEmoticonNormal()
	{
	}

	public bool IsCanTalkState()
	{
		return default(bool);
	}

	public virtual void SetOpcOnlineState(OpcState.OnlineState state)
	{
	}

	public OpcState.OnlineState GetOpcOnlineState()
	{
		return default(OpcState.OnlineState);
	}

	public void SetMenuOpen(bool isOpen)
	{
	}

	public bool GetIsMenuOpen()
	{
		return default(bool);
	}

	public Balloon GetBallon()
	{
		return null;
	}

	public Emoticon GetEmoticon()
	{
		return null;
	}

	public void PlayerInputActiveEnabled()
	{
	}

	public void PlayerInputActiveDisabled()
	{
	}

	public void SetAnimationPlayer(AnimationPlayer animationPlayer)
	{
	}

	public AnimationPlayer GetAnimationPlayer()
	{
		return null;
	}

	public void SetIsTransutuonIdle(bool isTransitionIdle)
	{
	}

	private int GetEmoticonType(OpcState.OnlineState state)
	{
		return default(int);
	}

	protected virtual void OnDestroy()
	{
	}
}
