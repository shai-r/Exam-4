using Rabanut.Model;
using static Rabanut.Service.RabanutService;
using static Rabanut.Service.DateService;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Rabanut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExists();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool IsInputNullOrEmpty() =>
            string.IsNullOrEmpty(DayInWeekComboBox.Text) ||
                string.IsNullOrEmpty(DayInMonthComboBox.Text) ||
                string.IsNullOrEmpty(MonthComboBox.Text) ||
                string.IsNullOrEmpty(YearComboBox.Text);
        private string MakeResult() => 
            GetDayInWeek(DayInWeekComboBox.Text) + " " +
            GetDayAndMonth(DayInMonthComboBox.Text, MonthComboBox.Text) + " " +
            GetYear(YearComboBox.Text);
        private void OnGetDateButten(object sender, EventArgs e)
        {
            if (IsInputNullOrEmpty())
            {
                MessageBox.Show("");
                return;
            }
            AddQuery(
                new(
                    DayInWeekComboBox.Text,
                    DayInMonthComboBox.Text,
                    MonthComboBox.Text,
                    YearComboBox.Text,
                    MakeResult()
                )
            );
            MessageBox.Show(MakeResult());
        }
    }
}
