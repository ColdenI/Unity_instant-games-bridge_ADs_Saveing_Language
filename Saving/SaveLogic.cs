using InstantGamesBridge;
using System;
using UnityEngine;

public class SaveLogic : MonoBehaviour
{
    [Header("Settings")]
    public SavaData SaveData = new SavaData();

    public delegate void onLoad(SavaData savaData);
    public event onLoad OnLoad;


    #region Load
    public void Load()
    {
#if PLATFORM_WEBGL
        Load_WebGL();
#endif
#if PLATFORM_ANDROID
        Load_Android();
#endif
    }

    #region Load WebGL
#if PLATFORM_WEBGL
    public void Load_WebGL()
    {
        Bridge.storage.Get("data", OnStorageGetCompleted);
    }

    private void OnStorageGetCompleted(bool success, string data)
    {
        SaveData = new SavaData();

        // Загрузка произошла успешно
        if (success)
        {
            if (data != null)
            {
                SaveData = JsonUtility.FromJson<SavaData>(data);
            }
        }
        OnLoad?.Invoke(SaveData);

    }
#endif
    #endregion

    #region Load Android
#if PLATFORM_ANDROID
    public void Load_Android()
    {
        SavaData savaData = new SavaData();
        string json = PlayerPrefs.GetString("data", "none");
        if (json == "none") OnLoad?.Invoke(savaData);
        else
        {
            savaData = JsonUtility.FromJson<SavaData>(json);
            OnLoad?.Invoke(savaData);
        }
    }
#endif
    #endregion
    #endregion

    #region Save
    public void Save(SavaData _saveData)
    {
        #if PLATFORM_WEBGL
        Save_WebGL(_saveData);
        #endif
        #if PLATFORM_ANDROID
        Save_Android(_saveData);
        #endif
    }

    #region Save WebGL
#if PLATFORM_WEBGL
    public void Save_WebGL(SavaData _saveData)
    {
        Bridge.storage.Set("data", JsonUtility.ToJson(_saveData), OnStorageSetCompleted);
    }

    private void OnStorageSetCompleted(bool success)
    {
        Debug.Log($"OnStorageSetCompleted, success: {success}");
    }
#endif
    #endregion

    #region Save Android
#if PLATFORM_ANDROID
    public void Save_Android(SavaData _saveData)
    {
        PlayerPrefs.SetString("data", JsonUtility.ToJson(_saveData));
        PlayerPrefs.Save();
    }
#endif
    #endregion
    #endregion

    #region Reset
    public void Reset()
    {
#if PLATFORM_WEBGL
        Reset_WebGL();
#endif
#if PLATFORM_ANDROID
        Reset_Android();
#endif
    }

    #region Reset WebGL
#if PLATFORM_WEBGL
    public void Reset_WebGL()
    {
        Bridge.storage.Delete("data", OnStorageDeleteCompleted);
    }

    private void OnStorageDeleteCompleted(bool obj)
    {
        Save(new SavaData());
    }
#endif
    #endregion

    #region Reset Android
#if PLATFORM_ANDROID
    public void Reset_Android()
    {
        PlayerPrefs.SetString("data", JsonUtility.ToJson(new SavaData()));
        PlayerPrefs.Save();
    }
#endif
    #endregion
    #endregion
}
