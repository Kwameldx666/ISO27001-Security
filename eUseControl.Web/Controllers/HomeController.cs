﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller
    {
        // Метод для отображения формы ввода названия компании
        public ActionResult Index()
        {
            return View();
        }

        // Метод для сохранения названия компании и перехода к вопросам
        [HttpPost]
        public ActionResult SaveCompanyName(string companyName)
        {
            Session["CompanyName"] = companyName;


            // Перенаправляем пользователя на страницу с вопросами
            return RedirectToAction("Questionnaire", "Home");
        }

        // Метод для отображения страницы с вопросами
        public ActionResult Questionnaire()
        {
            // Получаем название компании из сессии
            string companyName = Convert.ToString(Session["CompanyName"]);
            ViewBag.CompanyName = companyName;

            List<string> questions = new List<string>
        {
            "Существует ли у вашей организации документированная политика информационной безопасности?",
            "Проходят ли сотрудники обязательное обучение по вопросам информационной безопасности?",
            "Используются ли у вас процедуры для классификации и маркировки информационных активов?",
            "Осуществляется ли регулярная оценка процессов управления информационной безопасностью на соответствие стандарту ISO 27001?",
            "Имеются ли у вас четко определенные роли и ответственности по вопросам информационной безопасности?",
            "Проводятся ли анализы угроз безопасности информационных активов с учетом внутренних и внешних угроз?",
            "Имеется ли у вас система мониторинга аномальной активности в сети и системах?",
            "Регулярно ли обновляются процедуры обеспечения безопасности для учета новых угроз?",
            "Используются ли средства шифрования для защиты хранимой и передаваемой конфиденциальной информации?",
            "Осуществляется ли регулярное тестирование уязвимостей систем и сетей?",
            "Проводится ли периодическая оценка рисков безопасности с участием заинтересованных сторон?",
            "Устанавливается ли приоритетность рисков в соответствии с их потенциальными последствиями?",
            "Используются ли количественные методы оценки риска для определения потенциальных убытков?",
            "Принимаются ли меры для уменьшения риска безопасности до приемлемого уровня?",
            "Используются ли многофакторная аутентификация или другие продвинутые методы идентификации пользователей?",
            "Проводится ли резервное копирование данных с учетом частоты и критичности информации?",
            "Осуществляется ли аудит информационной безопасности для проверки соответствия стандартам и политикам безопасности?",
            "Имеются ли у вас процедуры для своевременного реагирования на инциденты безопасности и восстановления после них?",
            "Существует ли у вашей организации официальное описание деятельности и структуры?",
            "Установлены ли у вас процессы и процедуры по управлению информационной безопасностью?",
            "Разделена ли организация на отделы или подразделения с определенными функциями и обязанностями?",
            "Происходит ли регулярная оценка информационных активов по категориям: информация, программное обеспечение, оборудование, сеть?",
            "Осуществляется ли управление доступом к информационным активам на основе ролей и привилегий?",
            "Идентифицированы ли основные угрозы безопасности информационных активов в вашей организации?",
            "Осуществляется ли мониторинг и обнаружение инцидентов информационной безопасности?",
            "Имеются ли у вас процедуры для реагирования на инциденты безопасности?",
            "Применяются ли технические средства (например, брандмауэры, антивирусное ПО) для защиты от угроз?",
            "Проводятся ли регулярные обновления программного обеспечения и систем для устранения уязвимостей?",
            "Оценивается ли риск безопасности информационных активов с использованием качественных методов (например, матрицы рисков)?",
            "Происходит ли расчет потенциальных финансовых потерь от инцидентов безопасности?",
            "Имеются ли у вас критерии для определения приемлемого уровня риска безопасности?",
            "Проводятся ли анализы уязвимостей и угроз для оценки риска?",
            "Применяются ли технические меры (например, шифрование) для защиты конфиденциальной информации?",
            "Используются ли политики и процедуры для управления паролями и аутентификацией?",
            "Осуществляется ли резервное копирование данных и систем?",
            "Происходит ли мониторинг сетевой активности для обнаружения несанкционированного доступа?",
            "Проводятся ли регулярные обучения и тренинги по вопросам информационной безопасности для сотрудников?"
        };
            ViewBag.Questions = questions;

            Session["Count"] = ViewBag.Questions.Count;
            return View();
        }

        [HttpPost]
        public ActionResult Analysis(FormCollection form)
        {
            // Получаем список ответов
            int count = Convert.ToInt32(Session["Count"]);
            List<string> answers = new List<string>();
            string companyName = Convert.ToString(Session["CompanyName"]);
            ViewBag.CompanyName = companyName;
            for (int i = 1; i <= count; i++)
            {
                string answerKey = "answer" + i;
                string answer = form[answerKey];
                answers.Add(answer);
            }
            List<string> questions = new List<string>
        {
            "Существует ли у вашей организации документированная политика информационной безопасности?",
            "Проходят ли сотрудники обязательное обучение по вопросам информационной безопасности?",
            "Используются ли у вас процедуры для классификации и маркировки информационных активов?",
            "Осуществляется ли регулярная оценка процессов управления информационной безопасностью на соответствие стандарту ISO 27001?",
            "Имеются ли у вас четко определенные роли и ответственности по вопросам информационной безопасности?",
            "Проводятся ли анализы угроз безопасности информационных активов с учетом внутренних и внешних угроз?",
            "Имеется ли у вас система мониторинга аномальной активности в сети и системах?",
            "Регулярно ли обновляются процедуры обеспечения безопасности для учета новых угроз?",
            "Используются ли средства шифрования для защиты хранимой и передаваемой конфиденциальной информации?",
            "Осуществляется ли регулярное тестирование уязвимостей систем и сетей?",
            "Проводится ли периодическая оценка рисков безопасности с участием заинтересованных сторон?",
            "Устанавливается ли приоритетность рисков в соответствии с их потенциальными последствиями?",
            "Используются ли количественные методы оценки риска для определения потенциальных убытков?",
            "Принимаются ли меры для уменьшения риска безопасности до приемлемого уровня?",
            "Используются ли многофакторная аутентификация или другие продвинутые методы идентификации пользователей?",
            "Проводится ли резервное копирование данных с учетом частоты и критичности информации?",
            "Осуществляется ли аудит информационной безопасности для проверки соответствия стандартам и политикам безопасности?",
            "Имеются ли у вас процедуры для своевременного реагирования на инциденты безопасности и восстановления после них?",
            "Существует ли у вашей организации официальное описание деятельности и структуры?",
            "Установлены ли у вас процессы и процедуры по управлению информационной безопасностью?",
            "Разделена ли организация на отделы или подразделения с определенными функциями и обязанностями?",
            "Происходит ли регулярная оценка информационных активов по категориям: информация, программное обеспечение, оборудование, сеть?",
            "Осуществляется ли управление доступом к информационным активам на основе ролей и привилегий?",
            "Идентифицированы ли основные угрозы безопасности информационных активов в вашей организации?",
            "Осуществляется ли мониторинг и обнаружение инцидентов информационной безопасности?",
            "Имеются ли у вас процедуры для реагирования на инциденты безопасности?",
            "Применяются ли технические средства (например, брандмауэры, антивирусное ПО) для защиты от угроз?",
            "Проводятся ли регулярные обновления программного обеспечения и систем для устранения уязвимостей?",
            "Оценивается ли риск безопасности информационных активов с использованием качественных методов (например, матрицы рисков)?",
            "Происходит ли расчет потенциальных финансовых потерь от инцидентов безопасности?",
            "Имеются ли у вас критерии для определения приемлемого уровня риска безопасности?",
            "Проводятся ли анализы уязвимостей и угроз для оценки риска?",
            "Применяются ли технические меры (например, шифрование) для защиты конфиденциальной информации?",
            "Используются ли политики и процедуры для управления паролями и аутентификацией?",
            "Осуществляется ли резервное копирование данных и систем?",
            "Происходит ли мониторинг сетевой активности для обнаружения несанкционированного доступа?",
            "Проводятся ли регулярные обучения и тренинги по вопросам информационной безопасности для сотрудников?"
        };
            ViewBag.Questions = questions;
            // Оценка риска на основе ответов
            RiskAssessment assessment = new RiskAssessment();
            var riskLevels = assessment.EvaluateRisk(answers);

            // Генерация рекомендаций по снижению риска
            RiskRecommendation recommendation = new RiskRecommendation();
            var recommendations = recommendation.GenerateRecommendations(riskLevels);

            // Подготовка данных для графика
            ViewBag.RiskLevels = riskLevels;
            ViewBag.Recommendations = recommendations;

            return View();
        }

        // Страница анализа рисков и рекомендаций
      
    }

    // Класс оценки риска
    public class RiskAssessment
    {
        public List<RiskLevel> EvaluateRisk(List<string> answers)
        {
            List<RiskLevel> riskLevels = new List<RiskLevel>();

            // Оценка риска на основе конкретных ответов
            for (int i = 0; i < answers.Count; i++)
            {
                string question = GetQuestionByIndex(i); // Получаем вопрос по индексу
                string answer = answers[i]; // Получаем ответ по индексу

                // Оценка риска на основе ответа
                string riskLevel = AssessRiskLevel(answer);

                riskLevels.Add(new RiskLevel { Question = question, Level = riskLevel , Answer  = answer , Number  = i});
            }

            return riskLevels;
        }

        private string GetQuestionByIndex(int index)
        {
            // Метод для получения вопроса по индексу
            List<string> questions = GetQuestions(); // Получаем список всех вопросов

            if (index >= 0 && index < questions.Count)
            {
                return questions[index];
            }

            return "Unknown Question";
        }

        private List<string> GetQuestions()
        {
            // Метод для получения списка всех вопросов
            return new List<string>
       {
            "Существует ли у вашей организации документированная политика информационной безопасности?",
            "Проходят ли сотрудники обязательное обучение по вопросам информационной безопасности?",
            "Используются ли у вас процедуры для классификации и маркировки информационных активов?",
            "Осуществляется ли регулярная оценка процессов управления информационной безопасностью на соответствие стандарту ISO 27001?",
            "Имеются ли у вас четко определенные роли и ответственности по вопросам информационной безопасности?",
            "Проводятся ли анализы угроз безопасности информационных активов с учетом внутренних и внешних угроз?",
            "Имеется ли у вас система мониторинга аномальной активности в сети и системах?",
            "Регулярно ли обновляются процедуры обеспечения безопасности для учета новых угроз?",
            "Используются ли средства шифрования для защиты хранимой и передаваемой конфиденциальной информации?",
            "Осуществляется ли регулярное тестирование уязвимостей систем и сетей?",
            "Проводится ли периодическая оценка рисков безопасности с участием заинтересованных сторон?",
            "Устанавливается ли приоритетность рисков в соответствии с их потенциальными последствиями?",
            "Используются ли количественные методы оценки риска для определения потенциальных убытков?",
            "Принимаются ли меры для уменьшения риска безопасности до приемлемого уровня?",
            "Используются ли многофакторная аутентификация или другие продвинутые методы идентификации пользователей?",
            "Проводится ли резервное копирование данных с учетом частоты и критичности информации?",
            "Осуществляется ли аудит информационной безопасности для проверки соответствия стандартам и политикам безопасности?",
            "Имеются ли у вас процедуры для своевременного реагирования на инциденты безопасности и восстановления после них?",
            "Существует ли у вашей организации официальное описание деятельности и структуры?",
            "Установлены ли у вас процессы и процедуры по управлению информационной безопасностью?",
            "Разделена ли организация на отделы или подразделения с определенными функциями и обязанностями?",
            "Происходит ли регулярная оценка информационных активов по категориям: информация, программное обеспечение, оборудование, сеть?",
            "Осуществляется ли управление доступом к информационным активам на основе ролей и привилегий?",
            "Идентифицированы ли основные угрозы безопасности информационных активов в вашей организации?",
            "Осуществляется ли мониторинг и обнаружение инцидентов информационной безопасности?",
            "Имеются ли у вас процедуры для реагирования на инциденты безопасности?",
            "Применяются ли технические средства (например, брандмауэры, антивирусное ПО) для защиты от угроз?",
            "Проводятся ли регулярные обновления программного обеспечения и систем для устранения уязвимостей?",
            "Оценивается ли риск безопасности информационных активов с использованием качественных методов (например, матрицы рисков)?",
            "Происходит ли расчет потенциальных финансовых потерь от инцидентов безопасности?",
            "Имеются ли у вас критерии для определения приемлемого уровня риска безопасности?",
            "Проводятся ли анализы уязвимостей и угроз для оценки риска?",
            "Применяются ли технические меры (например, шифрование) для защиты конфиденциальной информации?",
            "Используются ли политики и процедуры для управления паролями и аутентификацией?",
            "Осуществляется ли резервное копирование данных и систем?",
            "Происходит ли мониторинг сетевой активности для обнаружения несанкционированного доступа?",
            "Проводятся ли регулярные обучения и тренинги по вопросам информационной безопасности для сотрудников?"
        };
        }

        private string AssessRiskLevel(string answer)
        {
            // Логика оценки риска на основе ответа
            if (string.IsNullOrWhiteSpace(answer))
            {
                return "Unknown"; // Если ответ не указан или пустой, вернуть неопределенный уровень риска
            }

            // Пример простой логики оценки риска
            if (answer.ToLower().Contains("no"))
            {
                return "Высокий";
            }
            else
            {
                return "Низкий";
            }
           
        }
    }

    // Класс генерации рекомендаций
    public class RiskRecommendation
    {
        public List<string> GenerateRecommendations(List<RiskLevel> riskLevels)
        {
            List<string> recommendations = new List<string> {
                "Разработайте и внедрите документированную политику информационной безопасности, которая будет устанавливать стандарты и правила для защиты информации.\r\n\r\nПроходят ли сотрудники обязательное обучение по вопросам информационной ",
                "Организуйте регулярное обязательное обучение сотрудников по вопросам информационной безопасности для повышения осведомленности и усиления защиты.",
                "Внедрите процедуры классификации и маркировки информационных активов для правильного управления доступом и защиты конфиденциальной информации.",
                "Проводите регулярные оценки и аудиты в соответствии со стандартом ISO 27001 для обеспечения соответствия и повышения уровня безопасности.",
                "Определите и документируйте четкие роли и обязанности по вопросам информационной безопасности для эффективного управления рисками.",
                "Разработайте и реализуйте систему анализа угроз для регулярной оценки и управления угрозами информационной безопасности.",
                "Внедрите систему мониторинга для раннего обнаружения аномальной активности и потенциальных угроз.",
                "Обеспечьте регулярное обновление процедур безопасности для адаптации к изменяющимся угрозам и технологиям.",
                "Внедрите шифрование для защиты конфиденциальных данных в покое и в движении.",
                "Проводите регулярное тестирование уязвимостей для выявления и устранения уязвимых мест в инфраструктуре.",
                "Организуйте периодические оценки рисков с участием всех заинтересованных сторон для адекватного управления рисками.",
                "Определите и установите приоритеты рисков в зависимости от их потенциальных последствий для эффективного управления.",
                "Применяйте количественные методы оценки риска для определения потенциальных убытков и разработки адекватных мер по их предотвращению.",
                "Разработайте и реализуйте меры по уменьшению риска до приемлемого уровня с учетом специфики организации.",
                "Внедрите многофакторную аутентификацию или другие продвинутые методы идентификации пользователей для повышения безопасности доступа.",
                "Организуйте регулярное резервное копирование данных с учетом частоты и критичности информации для обеспечения готовности к восстановлению.",
                "Проводите регулярные аудиты информационной безопасности для проверки соответствия стандартам и политикам безопасности.",
                "Разработайте и внедрите процедуры реагирования на инциденты безопасности и восстановления после них для минимизации вреда от инцидентов.",
                "Разработайте и документируйте официальное описание деятельности и структуры организации для ясности и эффективного управления.",
                "Внедрите процессы и процедуры по управлению информационной безопасностью для систематического подхода к защите информации.",
                "Разделите организацию на отделы или подразделения с определенными функциями и обязанностями для ясного распределения ответственности по безопасности.",
                "Проводите регулярные оценки информационных активов по категориям для правильного управления рисками и защиты.",
                "Внедрите систему управления доступом на основе ролей и привилегий для обеспечения минимизации привилегий и защиты конфиденциальности.",
                "Идентифицируйте основные угрозы безопасности информационных активов и разработайте меры по их предотвращению и защите.",
                "Организуйте систему мониторинга и обнаружения инцидентов для оперативного реагирования на потенциальные угрозы.",
                "Разработайте и документируйте процедуры реагирования на инциденты безопасности для эффективного контроля ситуации.",
                "Используйте технические средства, такие как брандмауэры и антивирусное ПО, для обеспечения защиты от внешних угроз.",
                "Регулярно обновляйте программное обеспечение и системы для устранения известных уязвимостей и повышения безопасности.",
                "Оценивайте риск с использованием качественных методов, таких как матрица рисков, для более точной оценки потенциальных угроз.",
                "Проводите расчет потенциальных финансовых потерь от инцидентов безопасности для оценки реального воздействия угроз.",
                "Определите критерии для определения приемлемого уровня риска безопасности и адаптируйте стратегию защиты соответственно.",
                "Проводите регулярные анализы уязвимостей и угроз для более точной оценки и управления рисками безопасности.",
                "Применяйте технические меры, такие как шифрование, для защиты конфиденциальной информации от несанкционированного доступа.",
                "Установите строгие политики и процедуры для управления паролями и аутентификацией пользователей для повышения безопасности доступа.",
                "Регулярно осуществляйте резервное копирование данных и систем для обеспечения готовности к восстановлению после инцидентов.",
                "Организуйте мониторинг сетевой активности для обнаружения несанкционированных действий и угроз.",
                "Проводите регулярные обучения и тренинги по вопросам информационной безопасности для повышения осведомленности и правильного поведения сотрудников."

            };
            return recommendations;
        }
    }

    // Класс уровня риска для каждого вопроса
 

}