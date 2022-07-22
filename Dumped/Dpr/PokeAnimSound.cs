using System;
using System.Runtime.CompilerServices;

namespace Dpr;

[Serializable]
public class PokeAnimSound
{
	[Serializable]
	public class AnimEventData
	{
		public int[] Frame;

		public uint[] EventSymbol;
	}

	public const uint SND_SWITCH_GROUP = 3000483895u;

	public const uint SND_SWITCH_STATE = 1893047300u;

	public AnimEventData[] AnimEvent;

	private AnimationPlayer _animationPlayer;

	private int _oldClipIndex;

	private int _oldEventIndex;

	public bool Enable
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Init(AnimationPlayer animationPlayer)
	{
	}

	public void Update()
	{
	}

	private int getAnimEventIndex(int clipIndex, float time)
	{
		return default(int);
	}
}
