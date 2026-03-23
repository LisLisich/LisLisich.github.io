using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace task4
{
    /// <summary>
    /// Класс для обработки статистики вирусных атак
    /// </summary>
    public class VirusStatistics
    {
        private List<VirusAttack> attacks;
        private string reportTitle;

        public VirusStatistics()
        {
            attacks = new List<VirusAttack>();
            reportTitle = "Отчёт по вирусным атакам за месяц";
        }

        /// <summary>
        /// Добавить запись
        /// </summary>
        public void Add(VirusAttack attack)
        {
            attacks.Add(attack);
        }

        /// <summary>
        /// Удалить запись по индексу
        /// </summary>
        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < attacks.Count)
            {
                attacks.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Очистить все данные
        /// </summary>
        public void Clear()
        {
            attacks.Clear();
        }

        /// <summary>
        /// Количество записей
        /// </summary>
        public int Count
        {
            get { return attacks.Count; }
        }

        /// <summary>
        /// Общее количество атак
        /// </summary>
        public int TotalAttacks
        {
            get
            {
                int sum = 0;
                foreach (var a in attacks)
                    sum += a.AttackCount;
                return sum;
            }
        }

        /// <summary>
        /// Заголовок отчёта
        /// </summary>
        public string ReportTitle
        {
            get { return reportTitle; }
            set { reportTitle = value; }
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        public VirusAttack this[int i]
        {
            get
            {
                if (i >= 0 && i < attacks.Count)
                    return attacks[i];
                return null;
            }
        }

        /// <summary>
        /// Получить массивы для диаграммы
        /// </summary>
        public (string[], int[]) GetDataArrays()
        {
            string[] names = new string[attacks.Count];
            int[] counts = new int[attacks.Count];
            for (int i = 0; i < attacks.Count; i++)
            {
                names[i] = attacks[i].VirusName;
                counts[i] = attacks[i].AttackCount;
            }
            return (names, counts);
        }

        /// <summary>
        /// Сохранить в файл
        /// </summary>
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(reportTitle);
                writer.WriteLine(attacks.Count);
                foreach (var a in attacks)
                {
                    writer.WriteLine($"{a.VirusName};{a.AttackCount}");
                }
            }
        }

        /// <summary>
        /// Загрузить из файла
        /// </summary>
        public void LoadFromFile(string fileName)
        {
            attacks.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                reportTitle = reader.ReadLine();
                int count = int.Parse(reader.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(';');
                    attacks.Add(new VirusAttack(parts[0], int.Parse(parts[1])));
                }
            }
        }

        /// <summary>
        /// Построить столбчатую диаграмму
        /// </summary>
        public void DrawChart(Chart chart)
        {
            chart.Series.Clear();
            chart.Titles.Clear();

            // Форматирование
            chart.BackColor = Color.WhiteSmoke;
            chart.BackSecondaryColor = Color.White;
            chart.BackGradientStyle = GradientStyle.DiagonalRight;
            chart.BorderlineColor = Color.Gray;
            chart.BorderlineDashStyle = ChartDashStyle.Solid;

            // Область диаграммы
            chart.ChartAreas[0].BackColor = Color.White;
            chart.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart.ChartAreas[0].Area3DStyle.Inclination = 15;
            chart.ChartAreas[0].Area3DStyle.Rotation = 10;

            // Заголовок
            chart.Titles.Add(reportTitle);
            chart.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);

            // Серия
            Series series = new Series("VirusSeries")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue,
                IsValueShownAsLabel = true,
            };

            var (xValues, yValues) = GetDataArrays();
            series.Points.DataBindXY(xValues, yValues);

            // Цвета столбцов по значению
            for (int i = 0; i < series.Points.Count; i++)
            {
                if (yValues[i] < 50)
                    series.Points[i].Color = Color.Green;
                else if (yValues[i] < 150)
                    series.Points[i].Color = Color.Orange;
                else
                    series.Points[i].Color = Color.Red;
            }

            chart.Series.Add(series);

            // Оси
            chart.ChartAreas[0].AxisX.Title = "Тип вируса";
            chart.ChartAreas[0].AxisY.Title = "Количество атак";
            chart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
        }
    }
}
