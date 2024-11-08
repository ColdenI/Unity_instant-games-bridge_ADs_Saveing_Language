using UnityEngine;

namespace CGL
{
    public static class SaveLogic
    {
        [Header("Settings")]
        public static SavaData SaveData = new SavaData();

        public delegate void onLoad(SavaData savaData);
        public static event onLoad OnLoad;


        #region Load
        public static void Load()
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
    public static void Load_WebGL()
    {
        InstantGamesBridge.Bridge.storage.Get("data", OnStorageGetCompleted);
    }

    private static void OnStorageGetCompleted(bool success, string data)
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
        public static void Load_Android()
        {
            SavaData savaData = new SavaData();
            string json = PlayerPrefs.GetString("data", "none");
            if (json == "none") OnLoad?.Invoke(savaData);
            else
            {
                savaData = JsonUtility.FromJson<SavaData>(json);
                SaveData = savaData;
                OnLoad?.Invoke(savaData);
            }
        }
#endif
        #endregion
        #endregion

        #region Save
        public static void Save() => Save(SaveData);

        public static void Save(SavaData _saveData)
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
    public static void Save_WebGL(SavaData _saveData)
    {
        InstantGamesBridge.Bridge.storage.Set("data", JsonUtility.ToJson(_saveData), OnStorageSetCompleted);
    }

    private static void OnStorageSetCompleted(bool success)
    {
        Debug.Log($"OnStorageSetCompleted, success: {success}");
    }
#endif
        #endregion

        #region Save Android
#if PLATFORM_ANDROID
        public static void Save_Android(SavaData _saveData)
        {
            PlayerPrefs.SetString("data", JsonUtility.ToJson(_saveData));
            PlayerPrefs.Save();
        }
#endif
        #endregion
        #endregion

        #region Reset
        public static void Reset()
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
    public static void Reset_WebGL()
    {
        InstantGamesBridge.Bridge.storage.Delete("data", OnStorageDeleteCompleted);
    }

    private static void OnStorageDeleteCompleted(bool obj)
    {
        Save(new SavaData());
    }
#endif
        #endregion

        #region Reset Android
#if PLATFORM_ANDROID
        public static void Reset_Android()
        {
            PlayerPrefs.SetString("data", JsonUtility.ToJson(new SavaData()));
            PlayerPrefs.Save();
        }
#endif
        #endregion
        #endregion
    }
}