using UnityEngine;

namespace Dpr.SecretBase;

public class FillterWindow : SelectWindow<FillterIcon, string>
{
	[SerializeField]
	private OptionsWindow subSelect;

	public OptionsWindow SubSelect => null;

	private void Start()
	{
	}
}
