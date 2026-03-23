using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        private VirusStatistics statistics;
        private BindingSource bindingSource;
        public Form1()
        {
            InitializeComponent();
            statistics = new VirusStatistics();
            InitializeDataGridView();
            UpdateTotalLabel();
            statusLabel.Text = "Готов к работе";
            statistics.Add(new VirusAttack("Trojan.Win32", 12));
            statistics.Add(new VirusAttack("Worm.Net", 20));
            statistics.Add(new VirusAttack("Ransomware", 5));
            RefreshData();  // Обновить таблицу
        }
        public class VirusAttackDisplay
        {
            public string VirusName { get; set; }
            public int AttackCount { get; set; }
        }
        /// <summary>
        /// Инициализация DataGridView
        /// </summary>
        private void InitializeDataGridView()
        {
            dgvData.Columns.Clear();
            dgvData.AutoGenerateColumns = false;

            // Колонка "Название вируса"
            DataGridViewTextBoxColumn colVirusName = new DataGridViewTextBoxColumn();
            colVirusName.Name = "colVirusName";
            colVirusName.HeaderText = "Название вируса";
            colVirusName.DataPropertyName = "VirusName";  // ← ВАЖНО!
            colVirusName.Width = 300;
            dgvData.Columns.Add(colVirusName);

            // Колонка "Количество атак"
            DataGridViewTextBoxColumn colAttackCount = new DataGridViewTextBoxColumn();
            colAttackCount.Name = "colAttackCount";
            colAttackCount.HeaderText = "Количество атак";
            colAttackCount.DataPropertyName = "AttackCount";  // ← ВАЖНО!
            colAttackCount.Width = 150;
            dgvData.Columns.Add(colAttackCount);

            // Остальные настройки
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSource = new BindingSource();
            dgvData.DataSource = bindingSource;
        }

        /// <summary>
        /// Обновить отображение данных
        /// </summary>
        private void RefreshData()
        {
            // Создаем список для отображения в таблице
            var displayList = new List<VirusAttackDisplay>();

            for (int i = 0; i < statistics.Count; i++)
            {
                displayList.Add(new VirusAttackDisplay
                {
                    VirusName = statistics[i].VirusName,
                    AttackCount = statistics[i].AttackCount
                });
            }

            dgvData.DataSource = null;
            dgvData.DataSource = displayList;
            UpdateTotalLabel();
        }

        /// <summary>
        /// Получить список атак для привязки
        /// </summary>
        /// 
        private System.Collections.Generic.List<VirusAttack> GetAttacksList()
        {
            var list = new System.Collections.Generic.List<VirusAttack>();
            for (int i = 0; i < statistics.Count; i++)
            {
                list.Add(statistics[i]);
            }
            return list;
        }

        /// <summary>
        /// Обновить метку с итогами
        /// </summary>
        private void UpdateTotalLabel()
        {
            lblTotal.Text = $"Всего атак: {statistics.TotalAttacks} | Записей: {statistics.Count}";
        }
        /// <summary>
        /// Кнопка "Добавить"
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVirusName.Text))
            {
                MessageBox.Show("Введите название вируса!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudAttackCount.Value <= 0)
            {
                MessageBox.Show("Количество атак должно быть больше 0!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на дублирование
            for (int i = 0; i < statistics.Count; i++)
            {
                if (statistics[i].VirusName.Equals(txtVirusName.Text,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Такой вирус уже существует!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            VirusAttack attack = new VirusAttack(
                txtVirusName.Text.Trim(),
                (int)nudAttackCount.Value);

            statistics.Add(attack);
            RefreshData();  // <-- Важно! Обновляем таблицу

            txtVirusName.Clear();
            nudAttackCount.Value = 0;
            txtVirusName.Focus();

            statusLabel.Text = $"Добавлено: {attack.VirusName}";
        }
        /// <summary>
        /// Кнопка "Очистить поля"
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVirusName.Clear();
            nudAttackCount.Value = 0;
            txtVirusName.Focus();
        }

        /// <summary>
        /// Кнопка "Удалить строку"
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                int index = dgvData.SelectedRows[0].Index;
                if (statistics.RemoveAt(index))
                {
                    RefreshData();
                    statusLabel.Text = "Запись удалена";
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Кнопка "Очистить всё"
        /// </summary>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Удалить все записи?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                statistics.Clear();
                RefreshData();
                statusLabel.Text = "Все данные удалены";
            }
        }

        /// <summary>
        /// Кнопка "Обновить диаграмму"
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (statistics.Count == 0)
            {
                MessageBox.Show("Нет данных для диаграммы!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            statistics.DrawChart(chartVirus);
            lblChartInfo.Text = $"Записей: {statistics.Count} | Всего: {statistics.TotalAttacks}";
            statusLabel.Text = "Диаграмма обновлена";
        }

        /// <summary>
        /// Переключение вкладок
        /// </summary>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2 && statistics.Count > 0)
            {
                statistics.DrawChart(chartVirus);
                lblChartInfo.Text = $"Записей: {statistics.Count} | Всего: {statistics.TotalAttacks}";
            }
        }

        /// <summary>
        /// Меню: Сохранить
        /// </summary>
        private void menuSave_Click(object sender, EventArgs e)
        {
            if (statistics.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*",
                Title = "Сохранить данные",
                FileName = "virus_attacks.txt"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    statistics.SaveToFile(saveDialog.FileName);
                    statusLabel.Text = $"Сохранено: {saveDialog.FileName}";
                    MessageBox.Show("Данные сохранены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Меню: Загрузить
        /// </summary>
        private void menuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*",
                Title = "Загрузить данные"
            };

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    statistics.LoadFromFile(openDialog.FileName);
                    RefreshData();
                    statusLabel.Text = $"Загружено: {openDialog.FileName}";
                    MessageBox.Show("Данные загружены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Меню: Выход
        /// </summary>
        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Меню: О программе
        /// </summary>
        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Анализ вирусных атак — Вариант 6\n" +
                "Тема 4: Построение графиков и диаграмм",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (statistics.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Сохранить данные перед выходом?", "Подтверждение",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Текстовые файлы|*.txt|Все файлы|*.*",
                        FileName = "virus_attacks.txt"
                    };
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        statistics.SaveToFile(saveDialog.FileName);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
