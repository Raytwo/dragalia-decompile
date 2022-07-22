using System.Collections;
using DG.Tweening;
using Dpr.Battle.View.Objects;
using Dpr.Message;
using Dpr.UI;
using UnityEngine;
using XLSXContent;

namespace Dpr.Contest;

public class ResultPersonalPerformance : MonoBehaviour
{
	private enum State
	{
		WaitStart,
		Keywait,
		Finish
	}

	private class CameraAnimation
	{
		private Camera mainCamera;

		private Transform cameraTransform;

		private Vector3 endPosValue;

		private Vector3 endAngleValue;

		private float duration;

		public CameraAnimation(Camera targetCamera, float duration, Vector3 endPosValue, Vector3 endAngleValue)
		{
		}

		public void DOPlayForward()
		{
		}
	}

	private const float WAIT_DURATION = 1f;

	private SceneObjectManager objManagerPtr;

	private UIPersonalBoard uiBoard;

	private MessageMsgFile uiMsgFile;

	private CameraAnimation cameraAnim;

	private DOTweenAnimation moveFrameTween;

	private Keyguide keyguide;

	private ContestInput input;

	private ContestConfigDatas.SheetResultMotion motionData;

	private BOPokemon userPokemon;

	private WaitForSeconds waitDelayMoveFrame;

	private WaitForSeconds waitCameraAnim;

	private State currentState;

	private string playVoiceEventName;

	private bool isPlayVoice;

	private bool bIsUserWin;

	private bool bRunning;

	public void Initialize()
	{
	}

	public void ResetParam()
	{
	}

	public void OnFinalize()
	{
	}

	public void Setup(ResultDataModel resultDataModel)
	{
	}

	private void SettingCameraTweenParam(ContestConfigDatas.SheetResultCameraTween cameraParam)
	{
	}

	private string GetBestTimingCntStr(int count)
	{
		return null;
	}

	private string GetGreatTimingCntStr(int count)
	{
		return null;
	}

	private string GetNiceTimingCntStr(int count)
	{
		return null;
	}

	private string GetMissTimingCntStr(int count)
	{
		return null;
	}

	private string PerseCntText(int count, string labelName)
	{
		return null;
	}

	public void StartAnimation()
	{
	}

	private IEnumerator IE_StartAnimation()
	{
		return null;
	}

	private void PlayVoice()
	{
	}

	private void ChangeUserPokeAnimation(BattlePokemonEntity.AnimationState motionState)
	{
	}

	private BattlePokemonEntity.AnimationState GetMotionStateByScoreRanking()
	{
		return default(BattlePokemonEntity.AnimationState);
	}

	private void OpenKeyguid()
	{
	}

	private void CloseKeyguid()
	{
	}

	private void ChangeState(State nextState)
	{
	}

	public bool OnUpdate()
	{
		return default(bool);
	}

	private void UpdateKeywait()
	{
	}

	private void UpdatePokeMotion()
	{
	}
}
