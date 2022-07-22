using UnityEngine;

public class FieldEmbankmentEntity : FieldEventEntity
{
	public enum EmbankmentType
	{
		NONE,
		GROUND,
		SNOW,
		SAND,
		KUSA
	}

	[SerializeField]
	private EmbankmentType embankmentType;

	private FieldCharacterEntity character;

	private bool isCharacterOut;

	private bool isPlayingAnimeOut;

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	public void UpdateEmbankment()
	{
	}

	public void CharacterOut(bool encount)
	{
	}

	private void SetCharacterActive(bool isActive)
	{
	}
}
