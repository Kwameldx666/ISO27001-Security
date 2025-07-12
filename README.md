# 🔐 ISO 27001 Security Compliance Assessment System

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5-orange.svg)](https://www.asp.net/mvc)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![Security](https://img.shields.io/badge/security-ISO%2027001-red.svg)](https://www.iso.org/isoiec-27001-information-security.html)

## 📋 Описание проекта / Project Description

**eUseControl** - это веб-приложение для оценки соответствия организации стандарту ISO 27001 в области информационной безопасности. Система предоставляет комплексную оценку рисков и рекомендации по улучшению системы управления информационной безопасностью.

**eUseControl** is a web application for assessing an organization's compliance with the ISO 27001 information security standard. The system provides comprehensive risk assessment and recommendations for improving information security management systems.

## ✨ Основные возможности / Key Features

### 🔍 Комплексная оценка
- **37 детализированных вопросов** по всем аспектам ISO 27001
- **Автоматическая оценка рисков** на основе ответов
- **Персонализированные рекомендации** для каждой области

### 📊 Анализ и отчетность
- **Визуализация уровней риска** по категориям
- **Детальные рекомендации** по улучшению
- **Индивидуальные отчеты** для каждой организации

### 🛠 Технические возможности
- **Интуитивный веб-интерфейс**
- **Сохранение данных сессии**
- **Адаптивный дизайн**

## 🏗 Архитектура проекта / Project Architecture

```
📦 ISO27001-Security
├── 🌐 eUseControl.Web/          # Веб-приложение ASP.NET MVC
│   ├── 🎮 Controllers/          # Контроллеры MVC
│   ├── 📱 Models/              # Модели данных
│   ├── 🎨 Views/               # Представления Razor
│   ├── 📚 Scripts/             # JavaScript библиотеки
│   └── 🎯 Content/             # CSS стили и ресурсы
├── 🏢 eUseControl.Domain/       # Доменный слой
│   ├── 👥 Entities/            # Сущности предметной области
│   └── 📋 Enums/               # Перечисления
└── 📄 eUseControl.sln          # Файл решения Visual Studio
```

## 🚀 Быстрый старт / Quick Start

### Системные требования / System Requirements

- **Visual Studio 2019** или новее
- **.NET Framework 4.8**
- **IIS Express** (включен в Visual Studio)
- **Web browser** с поддержкой JavaScript

### 📦 Установка / Installation

1. **Клонирование репозитория / Clone the repository:**
```bash
git clone https://github.com/Kwameldx666/ISO27001-Security.git
cd ISO27001-Security
```

2. **Открытие в Visual Studio / Open in Visual Studio:**
```bash
# Откройте файл eUseControl.sln в Visual Studio
# Open eUseControl.sln file in Visual Studio
```

3. **Восстановление пакетов / Restore packages:**
```bash
# В Visual Studio: Tools → NuGet Package Manager → Restore
# In Visual Studio: Tools → NuGet Package Manager → Restore
```

4. **Запуск приложения / Run the application:**
```bash
# Нажмите F5 или кнопку "Start" в Visual Studio
# Press F5 or "Start" button in Visual Studio
```

## 📚 Руководство пользователя / User Guide

### 🏢 Шаг 1: Информация о компании
1. Введите название вашей организации
2. Нажмите кнопку "Продолжить"

### ❓ Шаг 2: Прохождение опроса
1. Ответьте на 37 вопросов честно и точно
2. Выберите наиболее подходящий ответ для каждого вопроса
3. Вопросы охватывают все ключевые области ISO 27001:
   - 📋 Политики информационной безопасности
   - 👨‍💼 Управление персоналом
   - 🔒 Контроль доступа
   - 🛡 Техническая защита
   - 📊 Управление рисками
   - 🔍 Мониторинг и аудит

### 📈 Шаг 3: Анализ результатов
1. Получите автоматическую оценку рисков
2. Изучите персонализированные рекомендации
3. Планируйте улучшения на основе анализа

## 🔧 Технические детали / Technical Details

### 🛠 Используемые технологии / Technologies Used

- **Backend:** ASP.NET MVC 5, C#
- **Frontend:** HTML5, CSS3, JavaScript, Bootstrap
- **UI Components:** jQuery, DataTables, Toastr
- **Session Management:** ASP.NET Session State
- **Build System:** MSBuild
- **IDE:** Visual Studio

### 📊 Алгоритм оценки рисков / Risk Assessment Algorithm

Система использует простой, но эффективный алгоритм:
- **"No" ответы** → Высокий риск 🔴
- **"Yes" ответы** → Низкий риск 🟢
- **Пустые ответы** → Неопределенный статус ⚪

### 🎯 Области оценки / Assessment Areas

1. **Организационные меры** (18 вопросов)
2. **Технические меры** (10 вопросов)  
3. **Физические меры** (5 вопросов)
4. **Правовые аспекты** (4 вопроса)

## 🤝 Содействие проекту / Contributing

Мы приветствуем вклад в развитие проекта! / We welcome contributions to the project!

### 📝 Как принять участие / How to Contribute

1. **Fork** репозиторий
2. Создайте **feature branch** (`git checkout -b feature/AmazingFeature`)
3. **Commit** изменения (`git commit -m 'Add some AmazingFeature'`)
4. **Push** в branch (`git push origin feature/AmazingFeature`)
5. Откройте **Pull Request**

### 🐛 Сообщение об ошибках / Bug Reports

Используйте [GitHub Issues](https://github.com/Kwameldx666/ISO27001-Security/issues) для сообщения об ошибках.

## 📜 Лицензия / License

Этот проект распространяется под лицензией MIT. Подробности см. в файле [LICENSE](LICENSE).

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## 📞 Контакты / Contact

- **GitHub:** [@Kwameldx666](https://github.com/Kwameldx666)
- **Project Link:** [https://github.com/Kwameldx666/ISO27001-Security](https://github.com/Kwameldx666/ISO27001-Security)

## 🙏 Благодарности / Acknowledgments

- [ISO/IEC 27001](https://www.iso.org/isoiec-27001-information-security.html) стандарт информационной безопасности
- [ASP.NET MVC](https://docs.microsoft.com/en-us/aspnet/mvc/) фреймворк
- [Bootstrap](https://getbootstrap.com/) для адаптивного дизайна
- Сообщество специалистов по информационной безопасности

---

<div align="center">

**⭐ Если проект оказался полезным, поставьте звезду! / If this project helped you, please give it a star! ⭐**

[![Made with ❤️](https://img.shields.io/badge/Made%20with-❤️-red.svg)](https://github.com/Kwameldx666/ISO27001-Security)

</div>