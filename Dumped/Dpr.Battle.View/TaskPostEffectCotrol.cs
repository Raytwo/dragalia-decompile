using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public class TaskPostEffectCotrol : Task
{
	protected SequenceCameraObject _cameraObject;

	public TaskPostEffectCotrol(SequenceCameraObject cameraObject)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}

	protected virtual PfxParam OnUpdate(int frame, float raito, ref PfxParam pfxParam)
	{
		return default(PfxParam);
	}
}
