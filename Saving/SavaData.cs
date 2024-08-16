using System;

namespace CGL
{
    [Serializable]
    public class SavaData
    {
        // general
        public int Money = 0;
        public int ScoreRecord = 0;
        public int ColorSet = 0;

        // settings
        public TranslationData.Language language = TranslationData.Language.Ru;
    }
}