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
            new Problem("Проблема нехватки общественного транспорта", "Описание отсутсвует", Status.Редактирование, 
                new List<Alternative>() {
                    new Alternative("Альтерантива 1", 0),
                    new Alternative("Альтерантива 2", 1),
                }, 
                new List<Expert>() {
                    new Expert("aa", "Компетенция 1"),
                }),
            new Problem("Проблема перераспределения выделенного бюджета", "Описание отсутсвует", Status.Редактирование,
                new List<Alternative>() {
                    new Alternative("Альтерантива 1", 0),
                    new Alternative("Альтерантива 2", 1),
                    new Alternative("Альтерантива 3", 2),
                },
                new List<Expert>() {
                    new Expert("Воронкина Дарья", "Компетенция 1"),
                    new Expert("Кондратьев Игорь", "Компетенция 2"),
                    new Expert("Парышков Дмитрий", "Компетенция 3"),
                }),
        };
    }
}
