using System;
using System.Collections.Generic;

namespace Dpr.Contest;

public class DanceOtherUser : DanceNPC
{
	private bool bIsGamerActive;

	public bool IsGamerActive => default(bool);

	public DanceOtherUser(ContestPlayerEntity entity, CollectNotesDataModel collectNotesData, List<NotesDataModel> notesDataList, Action<ADancePlayer> onLockSkill)
	{
	}

	protected override void UpdateAction()
	{
	}

	public void SwitchUserToNPC(float elapsedTime)
	{
	}

	protected override void OnChangeMultiMode(bool isHost)
	{
	}
}
