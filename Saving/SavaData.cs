using System;

namespace CGL
{
    [Serializable]
    public class SavaData
    {
        // general
        public int Money = 0;
        public int Level = 0;
        public bool isUseMusic = true;
        public bool isUseAllSound = true;
        public float sensa = 1f;

        // settings
        public TranslationData.Language language = TranslationData.Language.Ru;
    }
}