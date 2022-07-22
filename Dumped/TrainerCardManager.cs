using UnityEngine;

public class TrainerCardManager : MonoBehaviour
{
	public struct TrainerCard
	{
		public uint id;

		public int monry;

		public int count;

		public ushort hour;

		public ushort minute;
	}

	[SerializeField]
	private int a;

	[SerializeField]
	private TrainerCard myData;

	private void Start()
	{
	}

	public void AddTrainerCardData()
	{
	}

	public void CatchTrainerCardData(TrainerCard data)
	{
	}
}
