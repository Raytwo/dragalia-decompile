namespace Dpr.DigFossil;

public interface IDigCameraShaker
{
	bool IsEnable { get; set; }

	void DoShake(float strength, float period);
}
