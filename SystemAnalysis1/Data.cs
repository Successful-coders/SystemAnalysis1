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
                    new Expert("aa", 0),
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
                    new Expert("Воронкина Дарья", 0),
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
