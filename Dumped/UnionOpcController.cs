using Dpr.NetworkUtils;

public class UnionOpcController : OpcController
{
	private new bool isTransitionAfter;

	private bool isMultiMatchWait;

	public void Awake()
	{
	}

	protected override void MyUpdate(float deltaTime)
	{
	}

	public override void SetNetData(INetData netData)
	{
	}

	public void SetIsTransitionAfter(bool isTransition)
	{
	}

	public bool GetTransitionAfter()
	{
		return default(bool);
	}

	public void SetIsMultiMatchWait(bool flag)
	{
	}

	public bool GetIsMultiMatchWait()
	{
		return default(bool);
	}
}
