using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using System.IO;
using Newtonsoft.Json;

namespace SystemAnalysis1
{
    public static class Data
    {
        private const string SAVING_PATH = "problems.json";


        public static List<Problem> problems = new List<Problem>()
        {
           
            new Problem("Проблема перераспределения выделенного бюджета", "Описание отсутсвует", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("Альтерантива 1", 0),
                    new Alternative("Альтерантива 2", 1),
                    new Alternative("Альтерантива 3", 2),
                },
                new List<Expert>() {
                    new Expert("aa", 1),
                }),

             new Problem("Проблема организации дальнейшего бесперебойного предоставления услуг населению банком",
                    "В результате успешной деятельности банка и востребования его услуг руководство стоит перед проблемой организации дальнейшего бесперебойного предоставления услуг населению, расширения, привлечения новых клиентов.", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("открытие дополнительного филиала в городе", 0),
                    new Alternative("приобретение нового здания большего размера и расширение банка", 1),
                    new Alternative("введение круглосуточного режима работы", 2),
                    new Alternative("сокращение численности кадров", 3),
                    new Alternative("усиление рекламы в СМИ", 4),
                    new Alternative("проведение реорганизации и оптимизации структуры банка", 5),
                    new Alternative("проведение независимого аудита работы банка", 6),
                    new Alternative("усовершенствование системы обслуживания пластиковых карт", 7),
                },
                new List<Expert>() {
                    new Expert("Воронкина Дарья", 1),
                }),

              new Problem("Проблема распределения средств на развитие здравохранения",
                    "Из федерального бюджета выделены средства на развитие системы здравоохранения города. Необходимо провести оценку наиболее эффективного вложения средств.", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("строительство специализированного медицинского центра", 0),
                    new Alternative("покупка дорогостоящего современного оборудования", 1),
                    new Alternative("строительство наркологического центра", 2),
                    new Alternative("увеличение парка машин скорой помощи", 3),
                },
                new List<Expert>() {
                    new Expert("Министрова Ольга", 8),
                    new Expert("Иванов Иван", 6),
                    new Expert("Павлов Виктор", 7),
                }),

              new Problem("Анализ результатов экономической деятельности корпорации",
                    "Анализ результатов экономической деятельности корпорации показал неспособность функционирования одного из предприятий корпорации на рынке. Решение поручено принять ведущим специалистам корпорации.", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("ликвидация предприятия", 0),
                    new Alternative("продажа", 1),
                    new Alternative("объявление банкротом", 2),
                    new Alternative("проведение санации", 3),
                },
                new List<Expert>() {
                    new Expert("Министрова Ольга", 8),
                    new Expert("Иванов Иван", 6),
                    new Expert("Павлов Виктор", 7),
                }),

                new Problem("Развитие экономики и укрепление финансовой стабильности в области",
                    "На сессии областного правительства были сформулированы некоторые предложения, направленные на развитие экономики, укрепление финансовой стабильности в области. Группа экспертов созвана для выбора наиболее важного курса проведения реформ", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("стимулирование динамичного экономического роста", 0),
                    new Alternative("реструктуризация в сельском хозяйстве", 1),
                    new Alternative("формирование эффективной финансовой системы", 2),
                    new Alternative("интеграция в мировые экономические системы", 3),
                    new Alternative("развитие всех форм собственности", 4),
                },
                new List<Expert>() {
                    new Expert("Министрова Ольга", 8),
                    new Expert("Иванов Иван", 6),
                    new Expert("Павлов Виктор", 7),
                }),
        };

        public static void Save()
        {
            string json = JsonConvert.SerializeObject(problems, Formatting.Indented);
            File.WriteAllText(SAVING_PATH, json);
        }
        public static void Load()
        {
            if (File.Exists(SAVING_PATH))
            {
                string json = File.ReadAllText(SAVING_PATH);
                problems = JsonConvert.DeserializeObject<List<Problem>>(json);
            }
        }
    }
}
