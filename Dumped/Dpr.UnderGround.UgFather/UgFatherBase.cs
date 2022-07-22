using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UnderGround.UgFather;

public class UgFatherBase : MonoBehaviour
{
	public delegate void OnEventEnd();

	protected OnEventEnd onEventEndCallback;

	public FieldCharacterEntity FieldCharacterEntity
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize(FieldCharacterEntity entity, OnEventEnd eventEndCallback)
	{
	}

	public virtual void OnTalkEvent()
	{
	}

	public virtual void OnUpdate(float deltaTime)
	{
	}

	private void LookAtPlayer()
	{
	}
}
