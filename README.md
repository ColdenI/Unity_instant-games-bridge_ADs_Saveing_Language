# 🎮 Unity Instant Games Bridge: Ads, Save & Localization

![Logo](https://getbridge.org/assets/images/bridge-logo.svg) <!-- Можно заменить на ваше изображение -->

> ⚡ Быстрое подключение рекламы, сохранений и локализации для WebGL-игр на Unity.  
> 🔌 Готовое решение для платформ: **Yandex, VK, OK, Telegram и других Instant Games**.

[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Unity Version](https://img.shields.io/badge/Unity-2021+-%23C94F2A?logo=unity)](https://unity.com/)
[![Platform](https://img.shields.io/badge/Platform-WebGL%20%7C%20Mobile%20%7C%20Desktop-lightgrey)](#)

🔗 **Официальная документация Bridge**: [getbridge.org/docs/unity/#connection](https://getbridge.org/docs/unity/#connection)  
📦 **Скачать последнюю версию ассета**: [GitHub Releases](https://github.com/instant-games-bridge/instant-games-bridge-unity/releases)

---

## 🚀 Что это?

**Unity Instant Games Bridge (Ads, Saving, Language)** — это универсальный ассет, созданный для **ускорения разработки простых игр на Unity**, особенно при публикации в **Instant Games** (Yandex, VK, OK и др.).

Он объединяет три критически важные функции:
- ✅ **Реклама и IAP** через мост `instant-games-bridge`
- ✅ **Универсальная система сохранений** (поддержка WebGL, Mobile, Desktop)
- ✅ **Гибкая система локализации** интерфейса на несколько языков

Идеально подходит для prototype-разработки, мини-игр и быстрых MVP!

---

## 💡 Особенности

| Функция | Поддержка |
|-------|----------|
| **Реклама** | Видео, баннеры, вознаграждённые ролики |
| **Платежи (IAP)** | Покупки внутриигровых предметов |
| **Платформы** | Yandex, VK, OK, Telegram, Web, Desktop, Mobile |
| **Сохранения** | PlayerPrefs (локальные), JSON (гибкие), синхронизация между сессиями |
| **Локализация** | JSON-файлы, переключение языков "на лету", поддержка кириллицы и UTF-8 |
| **Простота интеграции** | Drag-and-drop, примеры, готовые UI-компоненты |

---

## 🧩 Какие проблемы решает?

- ❌ Сложная и запутанная интеграция рекламы на разных платформах?
  → **Bridge делает это автоматически!**
- ❌ Сохранения не работают в WebGL или теряются после обновления?
  → **Надёжная система хранения данных.**
- ❌ Нужно быстро добавить поддержку русского, английского и других языков?
  → **Локализация за пару кликов.**

---

## 🔧 Установка

### 1. Добавьте ассет в проект

#### Вариант A: Через GitHub
```bash
git clone https://github.com/ColdenI/Unity_instant-games-bridge_ADs_Saveing_Language.git
```
Переместите содержимое папки Assets в свой Unity-проект.

Вариант B: Скачайте .unitypackage
→ Перейдите в Releases и загрузите последнюю версию .unitypackage.

Импортируйте в Unity:
Assets → Import Package → Custom Package

2. Настройте Bridge
Убедитесь, что вы подключили instant-games-bridge SDK .
Откройте BridgeManager в сцене.
Настройте рекламу и IAP через панель инспектора.
💡 Подробная инструкция: https://getbridge.org/docs/unity 

3. Используйте встроенную систему
📦 Сохранения
``` csharp
SaveSystem.Save("playerScore", 100);
int score = SaveSystem.Load<int>("playerScore");
```

Автоматическое обновление текста при смене языка

