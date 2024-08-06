using System;
using System.Collections.Generic;
using UnityEngine;

public static class TranslationData
{
    /// <summary>
    /// Init function, to call in Start or in Awake
    /// </summary>
    public static void Init()
    { 
        new TranslationData_("t_pause", "Ïàóçà", "Pause");
        new TranslationData_("t_shop", "Ìàãàçèí", "Shop");
        new TranslationData_("t_close", "Çàêðûòü", "Close");
        new TranslationData_("t_pay", "Îïëàòèòü", "Pay");
        new TranslationData_("t_price", "Öåíà", "Price");
        new TranslationData_("t_price_total", "Èòîãî", "Total");
        new TranslationData_("buton_ok", "Îê", "Ok");
        new TranslationData_("buton_collect_x2", "Ïîëó÷èòü 2X", "Collect 2X");
        new TranslationData_("buton_collect", "Ïîëó÷èòü", "Collect");
        new TranslationData_("buton_apply", "Ïðèíÿòü", "Apply");
        new TranslationData_("buton_cancel", "Îòìåíèòü", "Cancel");
        new TranslationData_("buton_inMenu", "Â ìåíþ", "In the menu");
        new TranslationData_("buton_continue", "Ïðîäîëæèòü èãðó", "Continue the game");

       
    }
    
    #region Logic
    public static void Init(TranslationData_.Language _language)
    {
        language = _language;
        Init();
    }
   
    public static List<TranslationData_> data = new List<TranslationData_>();
    public static int counter = -1;
    public static TranslationData_.Language language = TranslationData_.Language.Ru;

    private static string CheckData(string str, string key) => string.IsNullOrWhiteSpace(str) ? $"[no data - '{key}']" : str;

    public static string Get(int _index, TranslationData_.Language _l)
    {
        switch (_l)
        {
            case TranslationData_.Language.Ru: return CheckData(data[_index].Ru, data[_index].Key);
            case TranslationData_.Language.En: return CheckData(data[_index].En, data[_index].Key);
            default: return "{no language}";
        }
    }
    public static string Get(string _key, TranslationData_.Language _l)
    {
        foreach(TranslationData_ i in data) if(i.Key == _key) return Get(i.Index, _l);
        return $"[no key - '{_key}']";
    }
    public static string Get(string _key)
    {
        return Get(_key, language);
    }
    public static string Get(int _index)
    {
        return Get(_index, language);
    }

    #endregion
}

[Serializable]
public class TranslationData_
{
    public TranslationData_(out int _index, string _key, string ru, string en)
    {
        TranslationData.counter++;
        _index = TranslationData.counter;
        TranslationData.data.Add(new TranslationData_(_index, _key)
        {
            Ru = ru,
            En = en
        });
    }
    public TranslationData_(string _key, string ru, string en) : this(out int a, _key, ru, en) { }

    private TranslationData_(int _index, string _key) { index = _index; key = _key; }

    private int index;
    private string key;
    public int Index { get { return index; } }
    public string Key { get { return key; } }
    public string Ru;
    public string En;

    [Serializable]
    public enum Language
    {
        Ru,
        En
    }
}
