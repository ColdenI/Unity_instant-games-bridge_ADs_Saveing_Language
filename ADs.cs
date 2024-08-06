using UnityEngine;

public class ADs : MonoBehaviour
{
    private void Start()
    {
#if PLATFORM_WEBGL
        RewardedInit_WEBGL();
#endif

#if PLATFORM_ANDROID
                RewardedInit_ANDROID();
#endif
    }

    private void OnDestroy()
    {
#if PLATFORM_WEBGL
        RewardedDeInit_WEBGL();
#endif

#if PLATFORM_ANDROID
                RewardedDeInit_ANDROID();
#endif
    }

    public bool isPause = true;
    public bool isAudioOff = true;
    public bool isPrintDebugMessage = true;
    private float _st_AudioVolume = 1f;
    private float _st_TimeScale = 1f;

    private void PauseAndOffAudio(bool val)
    {
        if (!isPause && !isAudioOff) return;

        if (val)
        {
            _st_AudioVolume = AudioListener.volume;
            _st_TimeScale = Time.timeScale;
        }
        if(isAudioOff) AudioListener.volume = val ? 0 : _st_AudioVolume;
        if(isPause) Time.timeScale = val ? 0 : _st_TimeScale;

        if (isPrintDebugMessage) Debug.Log("The sound and time state has been changed to:: " + (val ? 0 : 1).ToString());
    }

    #region Rewarded
    private int RewardedIndex = -1;
    private bool isRewarded = false;
    public delegate void onRewardedStateChanged(RewardedState state);
    public delegate void onRewardedStateChanged_type();
    public delegate void onRewardedReward(int rewardedIndex);
    public event onRewardedStateChanged OnRewardedStateChanged;
    public event onRewardedStateChanged_type OnRewardedState_Loading;
    public event onRewardedStateChanged_type OnRewardedState_Opened;
    public event onRewardedStateChanged_type OnRewardedState_Closed;
    public event onRewardedStateChanged_type OnRewardedState_Rewarded;
    public event onRewardedReward OnRewardedState_RewardedAndClose;
    public event onRewardedStateChanged_type OnRewardedState_Failed;

    public enum RewardedState
    {
        Loading, Opened, Closed, Rewarded, Failed
    }

    public void Show_Rewarded(int rewardedIndex = -1)
    {
#if PLATFORM_WEBGL
        Show_Rewarded_WEBGL(rewardedIndex);
#endif

#if PLATFORM_ANDROID
Show_Rewarded_ANDROID();
#endif
    }

    #region WEBGL
#if PLATFORM_WEBGL
    private void RewardedInit_WEBGL()
    {
        InstantGamesBridge.Bridge.advertisement.rewardedStateChanged += OnRewardedStateChanged_WEBGL;
    }
    private void RewardedDeInit_WEBGL()
    {
        InstantGamesBridge.Bridge.advertisement.rewardedStateChanged -= OnRewardedStateChanged_WEBGL;
    }

    private void Show_Rewarded_WEBGL(int rewardedIndex)
    {
        RewardedIndex = rewardedIndex;
        InstantGamesBridge.Bridge.advertisement.ShowRewarded();
    }

    private void OnRewardedStateChanged_WEBGL(InstantGamesBridge.Modules.Advertisement.RewardedState state)
    {
        RewardedState state_ = RewardedState.Failed;
        if (state == InstantGamesBridge.Modules.Advertisement.RewardedState.Loading)
        {
            state_ = RewardedState.Loading;
            OnRewardedState_Loading?.Invoke();
        }
        if (state == InstantGamesBridge.Modules.Advertisement.RewardedState.Opened)
        {
            state_ = RewardedState.Opened;
            isRewarded = false;
            OnRewardedState_Opened?.Invoke();
            PauseAndOffAudio(true);
        }
        if (state == InstantGamesBridge.Modules.Advertisement.RewardedState.Closed)
        {
            state_ = RewardedState.Closed;           
            OnRewardedState_Closed?.Invoke();
            if (isRewarded && RewardedIndex != -1) OnRewardedState_RewardedAndClose?.Invoke(RewardedIndex);
            RewardedIndex = -1;
            PauseAndOffAudio(false);
        }
        if (state == InstantGamesBridge.Modules.Advertisement.RewardedState.Rewarded)
        {
            state_ = RewardedState.Rewarded;
            OnRewardedState_Rewarded?.Invoke();
            isRewarded = true;
        }
        if (state == InstantGamesBridge.Modules.Advertisement.RewardedState.Failed)
        {
            state_ = RewardedState.Failed;
            OnRewardedState_Failed?.Invoke();
            PauseAndOffAudio(false);
        }
        if(isPrintDebugMessage) Debug.Log("The rewarded status has been changed to: " + state_.ToString());
        OnRewardedStateChanged?.Invoke(state_);
    }
#endif
    #endregion

    #region ANDROID
#if PLATFORM_ANDROID
    private void RewardedInit_ANDROID()
    {
        
    }

    private void Show_Rewarded_ANDROID()
    {

    }

    private void RewardedDeInit_ANDROID()
    {

    }

#endif
    #endregion

    #endregion

    #region interstitial advertising
    public void Show_InterstitialAdvertising()
    {
#if PLATFORM_WEBGL
        Show_InterstitialAdvertising_WEBGL();
#endif
#if PLATFORM_ANDROID
            Show_InterstitialAdvertising_ANDROID();
#endif
    }

#if PLATFORM_WEBGL
    private void Show_InterstitialAdvertising_WEBGL()
    {
        InstantGamesBridge.Bridge.advertisement.ShowInterstitial();
    }
#endif
#if PLATFORM_ANDROID
    private void Show_InterstitialAdvertising_ANDROID()
    {
        
    }
#endif
    #endregion
}
