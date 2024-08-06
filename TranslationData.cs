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
        new TranslationData_("t_newDay", "Новый день", "A new day");
        new TranslationData_("t_continueDay", "Продолжить день", "Continue the day");
        new TranslationData_("t_dist_m", "м", "m");
        new TranslationData_("t_pause", "Пауза", "Pause");
        new TranslationData_("t_dist_km", "км", "km");
        new TranslationData_("t_speed", "км/ч", "km/h");
        new TranslationData_("t_time_min", "м", "m");
        new TranslationData_("t_shop", "Магазин", "Shop");
        new TranslationData_("t_time_hour", "ч", "h");
        new TranslationData_("t_time_sec", "сек", "sec");
        new TranslationData_("t_fromWhere", "Откуда", "Where from");
        new TranslationData_("t_newOrder", "Новый заказ", "New order");
        new TranslationData_("t_endOrder", "Заказ завершен", "The order is completed");
        new TranslationData_("t_order", "Заказ", "Order");
        new TranslationData_("t_go", "Поехали", "Go");
        new TranslationData_("t_close", "Закрыть", "Close");
        new TranslationData_("t_pay", "Оплатить", "Pay");
        new TranslationData_("t_yesterday", "Вчера", "Yesterday");
        new TranslationData_("t_today", "Сегодня", "Today");
        new TranslationData_("t_day_result", "Результаты дня", "Results of the day");
        new TranslationData_("t_price", "Цена", "Price");
        new TranslationData_("t_price_total", "Итого", "Total");
        new TranslationData_("t_tips", "Чаевые", "Tips");
        new TranslationData_("t_toWhere", "Куда", "Where to");
        new TranslationData_("t_distT", "Дистанция", "Distance");
        new TranslationData_("t_fuelGone", "Топливо закончилось!", "The fuel has run out!");
        new TranslationData_("t_client_did_not_come", "Клиент который не явился", "The client who didn't show up");
        new TranslationData_("buton_ok", "Ок", "Ok");
        new TranslationData_("buton_collect_x2", "Получить 2X", "Collect 2X");
        new TranslationData_("buton_collect", "Получить", "Collect");
        new TranslationData_("buton_apply", "Принять", "Apply");
        new TranslationData_("buton_cancel", "Отменить", "Cancel");
        new TranslationData_("buton_towTruck", "Эвакуатор до заправки 500", "Tow truck before refueling 500");
        new TranslationData_("buton_fillUpTank", "Заправить бак", "Fill up the tank");
        new TranslationData_("buton_inMenu", "В меню", "In the menu");
        new TranslationData_("buton_saveProgress", "Сохранить прогресс дня", "Save the progress of the day");
        new TranslationData_("buton_restartDay", "Перезапустить день", "Restart the day");
        new TranslationData_("buton_endDay", "Завершить день", "End the day");
        new TranslationData_("buton_continue", "Продолжить игру", "Continue the game");

        #region Shop
        new TranslationData_("ts_buy", "Купить", "Buy");
        new TranslationData_("ts_Purchased", "Куплено", "Purchased");
        new TranslationData_("ts_getMoneyADS", "Получить 500 монет за просмотр рекламы", "Get 300 coins for watching ads");
        new TranslationData_("ts_radar", "Радар - \"антикамера\"", "Radar - \"anti-camera\"");
        new TranslationData_("ts_UpgradeСarToLevel", "Улучшить машину до уровня", "Upgrade the car to the level");
        new TranslationData_("ts_UpgradeСarTankToLevel", "Улучшить бензобак до уровня", "Upgrade the gas tank to the level of");

        #endregion

        #region Fines
        new TranslationData_("tf_fine", "Штраф", "Fine");
        new TranslationData_("tf_pay_fine50", "Оплатить 50%", "Pay 50%");
        new TranslationData_("tf_not_fine", "У вас нет неоплаченных штрафов", "You have no unpaid fines");
        new TranslationData_("tf_fines", "Штрафы", "Fines");
        new TranslationData_("tf_BotCar_t", "Столкновение с автомобилем", "Collision with a car");
        new TranslationData_("tf_BotCar_d", "Вам выписан штраф за аварию с участием автомобиля", "You have been issued a fine for an accident involving a car");
        new TranslationData_("tf_RoadSign_t", "Столкновение с дорожным объектом", "Collision with a road object");
        new TranslationData_("tf_RoadSign_d", "Вам выписан штраф за столкновение с дорожным объектам", "You have been issued a fine for collision with road objects");
        new TranslationData_("tf_CityObject_t", "Столкновение с городскими объектами", "Collision with urban objects");
        new TranslationData_("tf_CityObject_d", "Вам выписан штраф за столкновение с городскими объектами", "You have been issued a fine for collision with urban objects");
        new TranslationData_("tf_CityBuild_t", "Столкновение со зданием", "Collision with a building");
        new TranslationData_("tf_CityBuild_d", "Вам выписан штраф за столкновение со зданием", "You have been issued a fine for a collision with a building");
        new TranslationData_("tf_Speed_t", "Превышение скорости", "Speeding");
        new TranslationData_("tf_Speed_d-s", "Вам выписан штраф за незначительное  превышение скорости", "You have been issued a fine for minor speeding");
        new TranslationData_("tf_Speed_d-m", "Вам выписан штраф за превышение скорости", "You have been issued a speeding ticket");
        new TranslationData_("tf_Speed_d-b", "Вам выписан штраф за значительное превышение скорости", "You have been issued a fine for significant speeding");
        new TranslationData_("tf_Speed_d-bb", "Вам выписан штраф за огромное превышение скорости", "You have been issued a fine for a huge speeding");
        #endregion

        #region Road Point Title
        new TranslationData_("rp_t_0", "Фабрика на окраине", "Factory on the outskirts");
        new TranslationData_("rp_t_1", "Остановка у фабрики в городе", "Stop at the factory in the city");
        new TranslationData_("rp_t_2", "Стадион", "Stadium");
        new TranslationData_("rp_t_3", "Городская заправка", "City gas station");
        new TranslationData_("rp_t_4", "Фабрика в городе", "Factory in the city");
        new TranslationData_("rp_t_5", "Пиццерия", "Pizzeria");
        new TranslationData_("rp_t_6", "Микрорайон 1", "Microdistrict 1");
        new TranslationData_("rp_t_7", "Микрорайон 2", "Microdistrict 2");
        new TranslationData_("rp_t_8", "Микрорайон 3", "Microdistrict 3");
        new TranslationData_("rp_t_9", "Микрорайон 4", "Microdistrict 4");
        new TranslationData_("rp_t_10", "Супермаркет", "Supermarket");
        new TranslationData_("rp_t_11", "Микрорайон 5", "Microdistrict 5");
        new TranslationData_("rp_t_12", "Улица Парковая", "Park Street");
        new TranslationData_("rp_t_13", "Большой красный дом у фабрики", "The big red house near the factory");
        new TranslationData_("rp_t_14", "Пекарня на Парковой улице", "Bakery on Park Street");
        new TranslationData_("rp_t_15", "Парк на Парковой улице", "Park on Park Street");
        new TranslationData_("rp_t_16", "Остановка у чсного сектора 1", "Stop at the private sector 1");
        new TranslationData_("rp_t_17", "Часный сектор 1", "Private sector 1");
        new TranslationData_("rp_t_18", "Часный сектор 2", "Private sector 2");
        new TranslationData_("rp_t_19", "Между Паркавой улицей и часным сектором 2", "Between Park Street and the private sector 2");
        new TranslationData_("rp_t_20", "Кафе в тупике", "The cafe is at a dead end");
        new TranslationData_("rp_t_21", "Улица 1-я Луговая", "1st Lugovaya Street");
        new TranslationData_("rp_t_22", "Улица 2-я Луговая", "2st Lugovaya Street");
        new TranslationData_("rp_t_23", "Улица 3-я Луговая", "3st Lugovaya Street");
        new TranslationData_("rp_t_24", "Улица Романовская", "Romanovskaya Street");
        new TranslationData_("rp_t_25", "Улица Проездная", "Travel Street");
        new TranslationData_("rp_t_26", "Улица Карбышева", "Karbyshev Street");
        new TranslationData_("rp_t_27", "Улица Загорская", "Zagorskaya Street");
        new TranslationData_("rp_t_28", "Улица Едимновская", "Edimonovskaya Street");
        new TranslationData_("rp_t_29", "Улица Длинная", "The Street is Long");
        #endregion

        new TranslationData_("t_names_c",
            "Смирнов Михаил,Фёдоров Фёдор,Козлов Николай,Попов Александр,Семёнов Семён,Новиков Никита,Алексеев Алексей,Волков Владимир,Зайцев Захар,Сорокин Сергей,Тарасов Тимофей,Романов Роман,Морозов Михаил,Лебедев Лев,Цветков Василий,Марков Марк,Андреев Андрей,Никитин Никита,Белов Борис,Чернов Павел,Сафронов Сергей,Ильин Илья,Осипов Олег,Кузнецов Кирилл,Михайлов Михаил,Захаров Захар,Григорьев Григорий,Дмитриев Дмитрий,Павлов Павел,Степанов Степан,Николаев Николай,Егоров Егор,Филиппов Филипп,Ковалёв Кирилл,Моисеев Моисей,Щербаков Александр,Лавров Леонид,Максимов Максим,Тихонов Тимофей,Сидоров Сергей,Васильев Василий,Смирнов Михаил",
            "Smirnov Mikhail,Fedorov Fedor,Kozlov Nikolay,Popov Aleksandr,Semenov Semyon,Novikov Nikita,Alekseev Aleksey,Volkov Vladimir,Zaytsev Zakhar,Sorokin Sergey,Tarasov Timofey,Romanov Roman,Morozov Mikhail,Lebedev Lev,Tsvetkov Vasiliy,Markov Mark,Andreyev Andrey,Nikitin Nikita,Belov Boris,Chernov Pavel,Safronov Sergey,Ilyin Ilya,Osipov Oleg,Kuznetsov Kirill,Mikhaylov Mikhail,Zakharov Zakhar,Grigoryev Grigory,Dmitriyev Dmitriy,Pavlov Pavel,Stepanov Stepan,Nikolayev Nikolay,Yegorov Yegor,Filippov Filipp,Kovalev Kirill,Moiseyev Moisey,Shcherbakov Aleksandr,Lavrov Leonid,Maksimov Maksim,Tikhonov Timofey,Sidorov Sergey,Vasilyev Vasiliy,Smirnov Mikhail");

        new TranslationData_("t_advice_0", "Следите за уровнем топлива", "Keep an eye on the fuel level");
        new TranslationData_("t_advice_1", "Улучшайте машину и бензобак одновременно", "Upgrade your car and gas tank at the same time");
        new TranslationData_("t_advice_2", "Чем быстрее вы довезёте клиента, тем больше чаевые", "The faster you take the customer, the bigger the tip");
        new TranslationData_("t_advice_3", "Не нарушайте скоростной режим!", "Do not break the speed limit!");
        new TranslationData_("t_advice_4", "Купить радар чтобы видеть область видимости скоростной камеры.", "Buy a radar to see the field of view of a high-speed camera.");

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
