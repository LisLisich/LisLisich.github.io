using System.Windows.Forms;

namespace task7
{
    /// <summary>
    /// PictureBox с включённой двойной буферизацией для устранения мерцания
    /// </summary>
    public class Canvas : PictureBox
    {
        public Canvas()
        {
            // Включаем двойную буферизацию
            this.DoubleBuffered = true;

            // Настраиваем стиль для перерисовки
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.UserPaint, true);
        }
    }
}