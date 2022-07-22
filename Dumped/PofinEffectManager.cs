using System.Collections;
using Effect;
using UnityEngine;

public class PofinEffectManager
{
	private EffectData kogeEff;

	private EffectData koboshiEff;

	private EffectData smokeEff;

	private EffectData kinomiInEff;

	private Transform kogeEffTra;

	private Transform smokeEffTra;

	private Transform koboreEffTra;

	private EffectInstance kogeInstance;

	private int kogeCount;

	private const int kogeMaxCount = 7;

	public PofinEffectManager(Transform koge, Transform kobore, Transform smoke)
	{
	}

	public void KogeEffect()
	{
	}

	public void SmokeEffect()
	{
	}

	public void KoboreEffect(Transform pofinKiji)
	{
	}

	public void KinomiInEffect(Transform pofinKiji)
	{
	}

	public IEnumerator LoadEffect()
	{
		return null;
	}

	public void UpdateEffScale()
	{
	}

	public void Release()
	{
	}
}
