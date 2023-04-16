namespace CourseWork_With_SQLite.Forms
{
    /// <summary>
    /// Класс, для реализации формы со справкой
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод после нажатия на кнопку
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
