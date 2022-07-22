using Dpr.Battle.View.Objects;

namespace Dpr.Contest;

public class WazaSequencePlayer
{
	private enum WazaSeqState
	{
		Wait,
		Start,
		Active,
		Playing,
		End
	}

	private SceneObjectManager objManager;

	private BOCamera mainCamera;

	private BOCamera wazaCamera;

	private ContestViewSystem wazaViewSystemPtr;

	private WazaSeqState seqState;

	private int userIndex;

	private bool hasRequestPlaySequence;

	public bool IsRunning => default(bool);

	public void SetupWazaSequence()
	{
	}

	public void ResetParam()
	{
	}

	private void ActivateWazaCamera()
	{
	}

	private void DeactivateWazaCamera()
	{
	}

	public void PlayWazaSequence(int userIndex)
	{
	}

	public void OnUpdate()
	{
	}

	private void UpdateStateActive()
	{
	}

	private void UpdateStatePlaying()
	{
	}

	public void OnLateUpdate()
	{
	}
}
