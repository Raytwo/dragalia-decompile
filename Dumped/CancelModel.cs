public struct CancelModel
{
	public enum CancelReason
	{
		SelectCancel,
		Down
	}

	public CancelReason reason;

	public int fromStationIndex;
}
