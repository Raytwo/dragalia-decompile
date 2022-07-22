using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Dpr.Battle.View.ScriptableObjects;

[CreateAssetMenu]
public class BattleCameraSequenceData : ScriptableObject
{
	[Serializable]
	public class Sequence
	{
		public bool isFire
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

		public int Count
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Ease Ease
		{
			[CompilerGenerated]
			get
			{
				return default(Ease);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int StartCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int EndCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}

	[SerializeField]
	private List<Sequence> _sequenceList;
}
