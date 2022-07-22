using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using Dpr.Battle.View;
using Dpr.SequenceEditor;
using UnityEngine;

namespace Dpr.Sequence;

[Serializable]
public abstract class SequenceSystem : ISequenceCallback, IDisposable
{
	public const int DEFAULT_SEQUENCE_SYSTEM_STEP_CNT = 1;

	public const int MAX_COMMAND_NUM = 1024;

	public const float ONE_FRAME_TIME = 0.033333f;

	public static readonly Color PARTICLE_MULTIPLY_RESET_COLOR;

	public static readonly Vector3 BACKGROUND_DEFAULT_POSITION;

	public static readonly Vector3 BACKGROUND_DEFAULT_ROTATION;

	public static readonly Vector3 BACKGROUND_DEFAULT_SCALE;

	public const string WWISE_PLAY_VOICE_EV = "Play_PV_EV_{0:d3}_{1:d2}_{2}";

	public const string WWISE_PLAY_VOICE_BTL = "Play_PV_Btl_{0:d3}_{1:d2}_{2}";

	public const string WWISE_PLAY_VOICE_BTL_SWITCH = "Play_PV_Btl_{0:d3}_{1:d2}_00";

	protected BTLV_ENVIRONMENT_PARAM _environmentParam;

	protected Coroutine _seqFileLoadCoroutine;

	protected List<Coroutine> _preLoadCoroutines;

	protected Dictionary<string, AudioData> _cachedSoundBank;

	protected int _step;

	protected float _sequenceElapsedTime;

	protected float _sequenceInterpolationTime;

	public SequenceFile SequenceFile
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public int CurrentFrame
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public float CurrentTime => default(float);

	public int MaxFrame
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public float MaxTime => default(float);

	protected List<CommandParam> Commands
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected bool IsCommandSkip
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

	public bool IsPause
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsLoadedSequenceFile => default(bool);

	public bool IsPreLoaded => default(bool);

	public bool IsFinishSequence
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	protected bool IsInterpolationTime
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

	public SequenceSystem()
	{
	}

	public void Dispose()
	{
	}

	public virtual void UnInitialize()
	{
	}

	public abstract void LoadSequence(string path, bool isWaitCamera = false);

	public abstract void SetPause(bool value);

	public abstract void Stop();

	public void Update(float deltaTime, int step = 1)
	{
	}

	public void LateUpdate(float deltaTime)
	{
	}

	private bool IsUpdateValid()
	{
		return default(bool);
	}

	protected void CheckPreLoadCount()
	{
	}

	protected void StepFrame(float deltaTime)
	{
	}

	protected virtual void OnUpdate(float deltaTime, int step)
	{
	}

	protected virtual void OnLateUpdate(float deltaTime, int step)
	{
	}

	protected virtual void OnComplete()
	{
	}

	protected void SetSkipCommand(bool isSkip)
	{
	}

	public virtual void SkipFrame(int frame, bool isReset = true)
	{
	}

	public virtual void CommandCallback(SequenceFile file, CommandParam param, bool isSkip)
	{
	}

	public virtual void CommandCallbackLate(SequenceFile file, CommandParam param, bool isSkip)
	{
	}

	public void SetupEnvironmentParam()
	{
	}

	public BTLV_ENVIRONMENT_PARAM GetEnvironmentParam()
	{
		return default(BTLV_ENVIRONMENT_PARAM);
	}

	public List<CommandParam> FindCommands(CommandNo commandNo)
	{
		return null;
	}
}
