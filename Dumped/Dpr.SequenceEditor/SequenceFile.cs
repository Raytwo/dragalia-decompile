using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.SequenceEditor;

[CreateAssetMenu]
public sealed class SequenceFile : ScriptableObject
{
	[SerializeField]
	private List<Group> _groupData;

	private List<CommandParam> _cachedCommandParams;

	public List<Group> GroupData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int MaxFrame => default(int);

	public bool HasChainAttack
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static Macro Cast(Macro macro)
	{
		return null;
	}

	public List<CommandParam> GetCommandParams()
	{
		return null;
	}
}
