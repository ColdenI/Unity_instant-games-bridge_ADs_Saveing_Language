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
        new TranslationData_("t_newDay", "����� ����", "A new day");
        new TranslationData_("t_continueDay", "���������� ����", "Continue the day");
        new TranslationData_("t_dist_m", "�", "m");
        new TranslationData_("t_pause", "�����", "Pause");
        new TranslationData_("t_dist_km", "��", "km");
        new TranslationData_("t_speed", "��/�", "km/h");
        new TranslationData_("t_time_min", "�", "m");
        new TranslationData_("t_shop", "�������", "Shop");
        new TranslationData_("t_time_hour", "�", "h");
        new TranslationData_("t_time_sec", "���", "sec");
        new TranslationData_("t_fromWhere", "������", "Where from");
        new TranslationData_("t_newOrder", "����� �����", "New order");
        new TranslationData_("t_endOrder", "����� ��������", "The order is completed");
        new TranslationData_("t_order", "�����", "Order");
        new TranslationData_("t_go", "�������", "Go");
        new TranslationData_("t_close", "�������", "Close");
        new TranslationData_("t_pay", "��������", "Pay");
        new TranslationData_("t_yesterday", "�����", "Yesterday");
        new TranslationData_("t_today", "�������", "Today");
        new TranslationData_("t_day_result", "���������� ���", "Results of the day");
        new TranslationData_("t_price", "����", "Price");
        new TranslationData_("t_price_total", "�����", "Total");
        new TranslationData_("t_tips", "������", "Tips");
        new TranslationData_("t_toWhere", "����", "Where to");
        new TranslationData_("t_distT", "���������", "Distance");
        new TranslationData_("t_fuelGone", "������� �����������!", "The fuel has run out!");
        new TranslationData_("t_client_did_not_come", "������ ������� �� ������", "The client who didn't show up");
        new TranslationData_("buton_ok", "��", "Ok");
        new TranslationData_("buton_collect_x2", "�������� 2X", "Collect 2X");
        new TranslationData_("buton_collect", "��������", "Collect");
        new TranslationData_("buton_apply", "�������", "Apply");
        new TranslationData_("buton_cancel", "��������", "Cancel");
        new TranslationData_("buton_towTruck", "��������� �� �������� 500", "Tow truck before refueling 500");
        new TranslationData_("buton_fillUpTank", "��������� ���", "Fill up the tank");
        new TranslationData_("buton_inMenu", "� ����", "In the menu");
        new TranslationData_("buton_saveProgress", "��������� �������� ���", "Save the progress of the day");
        new TranslationData_("buton_restartDay", "������������� ����", "Restart the day");
        new TranslationData_("buton_endDay", "��������� ����", "End the day");
        new TranslationData_("buton_continue", "���������� ����", "Continue the game");

        #region Shop
        new TranslationData_("ts_buy", "������", "Buy");
        new TranslationData_("ts_Purchased", "�������", "Purchased");
        new TranslationData_("ts_getMoneyADS", "�������� 500 ����� �� �������� �������", "Get 300 coins for watching ads");
        new TranslationData_("ts_radar", "����� - \"����������\"", "Radar - \"anti-camera\"");
        new TranslationData_("ts_Upgrade�arToLevel", "�������� ������ �� ������", "Upgrade the car to the level");
        new TranslationData_("ts_Upgrade�arTankToLevel", "�������� �������� �� ������", "Upgrade the gas tank to the level of");

        #endregion

        #region Fines
        new TranslationData_("tf_fine", "�����", "Fine");
        new TranslationData_("tf_pay_fine50", "�������� 50%", "Pay 50%");
        new TranslationData_("tf_not_fine", "� ��� ��� ������������ �������", "You have no unpaid fines");
        new TranslationData_("tf_fines", "������", "Fines");
        new TranslationData_("tf_BotCar_t", "������������ � �����������", "Collision with a car");
        new TranslationData_("tf_BotCar_d", "��� ������� ����� �� ������ � �������� ����������", "You have been issued a fine for an accident involving a car");
        new TranslationData_("tf_RoadSign_t", "������������ � �������� ��������", "Collision with a road object");
        new TranslationData_("tf_RoadSign_d", "��� ������� ����� �� ������������ � �������� ��������", "You have been issued a fine for collision with road objects");
        new TranslationData_("tf_CityObject_t", "������������ � ���������� ���������", "Collision with urban objects");
        new TranslationData_("tf_CityObject_d", "��� ������� ����� �� ������������ � ���������� ���������", "You have been issued a fine for collision with urban objects");
        new TranslationData_("tf_CityBuild_t", "������������ �� �������", "Collision with a building");
        new TranslationData_("tf_CityBuild_d", "��� ������� ����� �� ������������ �� �������", "You have been issued a fine for a collision with a building");
        new TranslationData_("tf_Speed_t", "���������� ��������", "Speeding");
        new TranslationData_("tf_Speed_d-s", "��� ������� ����� �� ��������������  ���������� ��������", "You have been issued a fine for minor speeding");
        new TranslationData_("tf_Speed_d-m", "��� ������� ����� �� ���������� ��������", "You have been issued a speeding ticket");
        new TranslationData_("tf_Speed_d-b", "��� ������� ����� �� ������������ ���������� ��������", "You have been issued a fine for significant speeding");
        new TranslationData_("tf_Speed_d-bb", "��� ������� ����� �� �������� ���������� ��������", "You have been issued a fine for a huge speeding");
        #endregion

        #region Road Point Title
        new TranslationData_("rp_t_0", "������� �� �������", "Factory on the outskirts");
        new TranslationData_("rp_t_1", "��������� � ������� � ������", "Stop at the factory in the city");
        new TranslationData_("rp_t_2", "�������", "Stadium");
        new TranslationData_("rp_t_3", "��������� ��������", "City gas station");
        new TranslationData_("rp_t_4", "������� � ������", "Factory in the city");
        new TranslationData_("rp_t_5", "��������", "Pizzeria");
        new TranslationData_("rp_t_6", "���������� 1", "Microdistrict 1");
        new TranslationData_("rp_t_7", "���������� 2", "Microdistrict 2");
        new TranslationData_("rp_t_8", "���������� 3", "Microdistrict 3");
        new TranslationData_("rp_t_9", "���������� 4", "Microdistrict 4");
        new TranslationData_("rp_t_10", "�����������", "Supermarket");
        new TranslationData_("rp_t_11", "���������� 5", "Microdistrict 5");
        new TranslationData_("rp_t_12", "����� ��������", "Park Street");
        new TranslationData_("rp_t_13", "������� ������� ��� � �������", "The big red house near the factory");
        new TranslationData_("rp_t_14", "������� �� �������� �����", "Bakery on Park Street");
        new TranslationData_("rp_t_15", "���� �� �������� �����", "Park on Park Street");
        new TranslationData_("rp_t_16", "��������� � ������ ������� 1", "Stop at the private sector 1");
        new TranslationData_("rp_t_17", "������ ������ 1", "Private sector 1");
        new TranslationData_("rp_t_18", "������ ������ 2", "Private sector 2");
        new TranslationData_("rp_t_19", "����� �������� ������ � ������ �������� 2", "Between Park Street and the private sector 2");
        new TranslationData_("rp_t_20", "���� � ������", "The cafe is at a dead end");
        new TranslationData_("rp_t_21", "����� 1-� �������", "1st Lugovaya Street");
        new TranslationData_("rp_t_22", "����� 2-� �������", "2st Lugovaya Street");
        new TranslationData_("rp_t_23", "����� 3-� �������", "3st Lugovaya Street");
        new TranslationData_("rp_t_24", "����� �����������", "Romanovskaya Street");
        new TranslationData_("rp_t_25", "����� ���������", "Travel Street");
        new TranslationData_("rp_t_26", "����� ���������", "Karbyshev Street");
        new TranslationData_("rp_t_27", "����� ���������", "Zagorskaya Street");
        new TranslationData_("rp_t_28", "����� �����������", "Edimonovskaya Street");
        new TranslationData_("rp_t_29", "����� �������", "The Street is Long");
        #endregion

        new TranslationData_("t_names_c",
            "������� ������,Ը����� Ը���,������ �������,����� ���������,������ ����,������� ������,�������� �������,������ ��������,������ �����,������� ������,������� �������,������� �����,������� ������,������� ���,������� �������,������ ����,������� ������,������� ������,����� �����,������ �����,�������� ������,����� ����,������ ����,�������� ������,�������� ������,������� �����,��������� ��������,�������� �������,������ �����,�������� ������,�������� �������,������ ����,�������� ������,������ ������,������� ������,�������� ���������,������ ������,�������� ������,������� �������,������� ������,�������� �������,������� ������",
            "Smirnov Mikhail,Fedorov Fedor,Kozlov Nikolay,Popov Aleksandr,Semenov Semyon,Novikov Nikita,Alekseev Aleksey,Volkov Vladimir,Zaytsev Zakhar,Sorokin Sergey,Tarasov Timofey,Romanov Roman,Morozov Mikhail,Lebedev Lev,Tsvetkov Vasiliy,Markov Mark,Andreyev Andrey,Nikitin Nikita,Belov Boris,Chernov Pavel,Safronov Sergey,Ilyin Ilya,Osipov Oleg,Kuznetsov Kirill,Mikhaylov Mikhail,Zakharov Zakhar,Grigoryev Grigory,Dmitriyev Dmitriy,Pavlov Pavel,Stepanov Stepan,Nikolayev Nikolay,Yegorov Yegor,Filippov Filipp,Kovalev Kirill,Moiseyev Moisey,Shcherbakov Aleksandr,Lavrov Leonid,Maksimov Maksim,Tikhonov Timofey,Sidorov Sergey,Vasilyev Vasiliy,Smirnov Mikhail");

        new TranslationData_("t_advice_0", "������� �� ������� �������", "Keep an eye on the fuel level");
        new TranslationData_("t_advice_1", "��������� ������ � �������� ������������", "Upgrade your car and gas tank at the same time");
        new TranslationData_("t_advice_2", "��� ������� �� ������� �������, ��� ������ ������", "The faster you take the customer, the bigger the tip");
        new TranslationData_("t_advice_3", "�� ��������� ���������� �����!", "Do not break the speed limit!");
        new TranslationData_("t_advice_4", "������ ����� ����� ������ ������� ��������� ���������� ������.", "Buy a radar to see the field of view of a high-speed camera.");

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
