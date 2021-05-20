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
           
                new Problem("Градостроительная проблема в Новосибирске",
                    "Новосибирск находится на первом месте рейтинга самых грязных городов России по версии популярного урбаниста Ильи Варламова. Проблема пыли, грязи, отсутствие общественных пространств и неграмотной застройки очень остро стоит в городе. Каждый год коммунальные услуги не готовы к очевидной зиме, что превращает зимний Новосибирск в еще более некомфортный город для проживания. Помимо этого, на данный момент Новосибирск - город для машин, так как пешеходу передвигаться по городу гораздо сложнее, нежели автомобилю. Транспортная сеть не развита, отсутствуют пешеходные улицы, город в основном состоит и широкополосных дорог и развязок, нежели из скверов, парков и аллей.", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("Уменьшение количества полос автомобильных дорог в приоритет озеленению.", 0),
                    new Alternative("Реконструкция старых зданий, восстановление их исторического вида.", 1),
                    new Alternative("Запрет на высокоэтажное строительство.", 2),
                    new Alternative("Льготы на количество автомобилей в городе.", 3),
                    new Alternative("Создание общественных пространств.", 4),
                    new Alternative("Развитие трамвайной сети и закупка новых трамваев.", 5),
                    new Alternative("Жесткий дизайн код на вывески и рекламу в Новосибирске.", 6),
                    new Alternative("Снос билбордов.", 7),
                },
                new List<Expert>() {
                    new Expert("Максим Кац", 10),
                    new Expert("Зайков Юрий", 4),
                    new Expert("Воронкин Константин", 2),
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
