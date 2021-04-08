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
            new Problem("Проблема нехватки общественного транспорта", "Описание отсутсвует", Status.Редактирование, 
                new List<Alternative>() {
                    new Alternative("Альтерантива 1", 0),
                    new Alternative("Альтерантива 2", 1),
                }, 
                new List<Expert>() {
                    new Expert("aa", 5),
                }),
            new Problem("Проблема перераспределения выделенного бюджета", "Описание отсутсвует", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("Альтерантива 1", 0),
                    new Alternative("Альтерантива 2", 1),
                    new Alternative("Альтерантива 3", 2),
                },
                new List<Expert>() {
                    new Expert("aa", 5),
                    new Expert("Воронкина Дарья", 5),
                    new Expert("Кондратьев Игорь", 5),
                    new Expert("Парышков Дмитрий", 5),
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
