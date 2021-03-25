using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysis1
{
    public static class Data
    {
        public static List<Problem> problems = new List<Problem>()
        {
            new Problem("Проблема нехватки общественного транспорта", "Описание отсутсвует", "Не задействовано", 
                new List<Alternative>() {
                    new Alternative("Альтерантива 1"),
                    new Alternative("Альтерантива 2"),
                    new Alternative("Альтерантива 3"),
                }, 
                new List<Expert>() {
                    new Expert("Воронкина Дарья", "Компетенция 1"),
                    new Expert("Кондратьев Игорь", "Компетенция 2"),
                }),
            new Problem("Проблема перераспределения выделенного бюджета", "Описание отсутсвует", "Не задействовано",
                new List<Alternative>() {
                    new Alternative("Альтерантива 1"),
                    new Alternative("Альтерантива 2"),
                    new Alternative("Альтерантива 3"),
                },
                new List<Expert>() {
                    new Expert("Воронкина Дарья", "Компетенция 1"),
                    new Expert("Кондратьев Игорь", "Компетенция 2"),
                    new Expert("Парышков Дмитрий", "Компетенция 3"),
                }),
        };
    }
}
