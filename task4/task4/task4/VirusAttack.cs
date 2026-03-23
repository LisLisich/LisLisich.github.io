using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    /// <summary>
    /// Класс для хранения информации о вирусной атаке
    /// </summary>
    public class VirusAttack
    {
        private string virusName;
        private int attackCount;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public VirusAttack(string name, int count)
        {
            this.virusName = name;
            this.attackCount = count;
        }

        /// <summary>
        /// Название вируса
        /// </summary>
        public string VirusName
        {
            get { return virusName; }
            set { virusName = value; }
        }

        /// <summary>
        /// Количество атак
        /// </summary>
        public int AttackCount
        {
            get { return attackCount; }
            set { attackCount = value; }
        }

        public override string ToString()
        {
            return $"{virusName}: {attackCount}";
        }
    }
}
