# 🎮 Unity Instant Games Bridge – Ads, Saving & Language System

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)  
[![Unity Version](https://img.shields.io/badge/Unity-2021.3%2B-brightgreen)](https://unity.com/)  
[![Platform](https://img.shields.io/badge/Platform-WebGL%20%7C%20Mobile%20%7C%20Desktop-lightgrey)](#)  

> ⚡️ Готовый ассет для быстрой разработки простых Unity-проектов с поддержкой **рекламы**, **сохранений** и **многоязычности** на платформах мгновенных игр (Yandex, VK, OK и др.).

👉 Идеально подходит для **HTML5/WebGL-игр**, публикуемых на **инстант-платформах**.

🔗 [Документация Bridge](https://getbridge.org/docs/unity/#connection) | 
📥 [Скачать SDK](https://github.com/instant-games-bridge/instant-games-bridge-unity/releases)

---

## 🌟 Описание

**Unity Instant Games Bridge – Ads, Saving & Language System** — это универсальный и легковесный инструментарий, который позволяет быстро добавить в вашу Unity-игру:

✅ Поддержку рекламы и IAP через **Instant Games Bridge** (Yandex, VK, OK, Mail.ru и др.)  
✅ Универсальную систему **сохранения данных** (для WebGL, Android, iOS, Windows, macOS)  
✅ Простую и гибкую систему **многоязыкового интерфейса**

> 💡 Этот ассет создан для ускорения разработки мини-игр, хакатонов и прототипов, где важна скорость интеграции и кросс-платформенность.

---

## 🔧 Функционал

### 📢 Реклама и покупки (via Instant Games Bridge)
- Поддержка **видео-рекламы за награду**
- Показ **баннеров** (если доступно)
- Интеграция с **платформами**: Yandex Games, VK Play, OK Games и другие
- Работает в **WebGL** без дополнительных настроек

### 💾 Система сохранений (`SaveData.cs`, `SaveLogic.cs`)
- Автоматическое определение платформы:
  - **WebGL** → `LocalStorage`
  - **Мобильные/Десктоп** → `PlayerPrefs` или `JSON-файлы`
- Простой API:
  ```csharp
  SaveLogic.Save("coins", 100);
  int coins = SaveLogic.Load<int>("coins");
  ```
  Поддержка сложных объектов через сериализацию
🌍 Мультиязычность (TranslationData.cs, ADs.cs)
Лёгкая система локализации интерфейса
Язык определяется автоматически (или задаётся вручную)
Поддержка нескольких языков: RU, EN, и легко расширяется
Пример использования:
csharp


1
2
string text = TranslationData.Get("menu_start");
buttonText.text = text;
🔊 Дополнительно: AudioFon.cs
Простой контроллер фоновой музыки
Автоматическое воспроизведение и пауза при переключении сцены
Поддержка mute/ unmute
🚀 Быстрый старт
1. Установка
Склонируйте репозиторий:
bash


1
git clone https://github.com/ColdenI/Unity_instant-games-bridge_ADs_Saveing_Language.git
Перенесите папку Scripts/ в ваш Unity-проект (Assets/Scripts).
Подключите Instant Games Bridge SDK в свой проект.
Настройте index.html (для WebGL) согласно документации:
👉 https://getbridge.org/docs/unity/#connection
2. Примеры использования
▶️ Показать рекламу
csharp


1
2
3
ADs.Instance.ShowRewardedAd(() => {
    Debug.Log("Реклама просматрена! Выдайте награду.");
});
💾 Сохранить данные
csharp


1
2
SaveLogic.Save("level", 5);
SaveLogic.Save("sound_on", true);
🔁 Загрузить данные
csharp


1
2
int level = SaveLogic.Load<int>("level", 1); // значение по умолчанию — 1
bool soundOn = SaveLogic.Load<bool>("sound_on", true);
🌐 Изменить язык
csharp


1
2
TranslationData.SetLanguage(Language.EN);
UpdateUI(); // Обновите тексты в интерфейсе
📂 Структура кода
ADs.cs
Управление рекламой (Bridge SDK)
SaveData.cs
Контейнер для хранения данных (PlayerPrefs / JSON)
SaveLogic.cs
Логика сохранения/загрузки с проверкой платформы
TranslationData.cs
Хранение переводов и выбор языка
AudioFon.cs
Простой аудио-контроллер для фоновой музыки

🖼️ Скриншоты (пример)
Пример интерфейса

Интерфейс с кнопками: "Просмотреть рекламу", "Сменить язык", "Сохранить прогресс"

(Замените placeholder.png на реальный скриншот в вашем репозитории) 

🤝 Как использовать в своих проектах?
Этот ассет можно:

Использовать в личных и коммерческих проектах
Модифицировать под свои нужды
Расширять (например, добавлять новые языки или типы сохранений)
📜 Лицензия
Проект распространяется под лицензией MIT.
Вы можете свободно использовать, изменять и делиться им.

Подробности: LICENSE

🔗 Полезные ссылки
📚 Документация Instant Games Bridge
💾 Скачать SDK Bridge для Unity
🐞 Сообщить о баге или предложить улучшение
📬 Автор
Разработчик: ColdenI
Email: andreiakulin2005044@gmail.com
GitHub: @ColdenI
