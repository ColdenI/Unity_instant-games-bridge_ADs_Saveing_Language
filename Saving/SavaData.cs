using System;
using UnityEngine;

[Serializable]
public class SavaData
{
    // general
    public int Money = 0;
    public float Rating = 1f;
    public bool isUnfinishedDay = false;  
    public int pb_carPower = 0;
    public bool pb_showCameraSpeedArea = false;
    public bool pb_showCameraSpeedArea_isOn = false;
    public int pb_carTank = 0;

    // day
    public int MoneyDay = 0;
    public float RatingDay = 0;
    public Fine[] fines = new Fine[0];
    public float car_fuel = 250f;

    // settings
    public TranslationData_.Language language = TranslationData_.Language.Ru;
}
