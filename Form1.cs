using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*«Восточный календарь». В восточном календаре принят 60летний цикл, состоящий из 12-
летних подциклов, обозначаемых названиями цвета: зеленый, красный, желтый, белый и
голубой. При этом каждый цвет следует по два года подряд. В каждом подцикле годы носят
названия животных: крысы, коровы, тигра, зайца, дракона, змеи, лошади, овцы, обезьяны,
петуха, собаки и свиньи. 4 год нашей эры — начало цикла: «год зеленой крысы». Написать
приложение-визуализатор по номеру года выводится соответствующая картинка на соответсвующем фоне*/

namespace EasternCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*     
         Bitmap Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\rat.png");
         pictureBox1.Image = (Image)Image;
         pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage ;
            */
        private void IsDigit_KeyPress(object sender, KeyPressEventArgs e) //запрет ввода букв
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (yearTextBox.Text != "")
            {
                int year = int.Parse(yearTextBox.Text);
                year = year - (year - 4) / 60 * 60;
                int yearColor, yearAnimal;
                
                if(year>=4)
                {
                    //Color
                    yearColor = year - (year / 10) * 10;
                    
                    var green = "#00FF7F";
                    var myGreen = ColorTranslator.FromHtml(green);
                    var red = "#EE2C2C";
                    var myRed = ColorTranslator.FromHtml(red);
                    var yellow = "#FFF68F";
                    var myYellow = ColorTranslator.FromHtml(yellow);
                    var white = "#FFFAF0";
                    var myWhite = ColorTranslator.FromHtml(white);
                    var blue = "#1E90FF";
                    var myBlue = ColorTranslator.FromHtml(blue);

                    if (yearColor == 4 || yearColor == 5) pictureBox1.BackColor = myGreen;
                    else if (yearColor == 6 || yearColor == 7) pictureBox1.BackColor = myRed;
                    else if (yearColor == 8 || yearColor == 9) pictureBox1.BackColor = myYellow;
                    else if (yearColor == 0 || yearColor == 1) pictureBox1.BackColor = myWhite;
                    else pictureBox1.BackColor = myBlue;

                    //Animal
                    yearAnimal = year - (year - 4 )/ 12* 12 - 4;

                    Bitmap Image=null;
                    if (yearAnimal == 0) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\rat.png");
                    if (yearAnimal == 1) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\cow.png");
                    if (yearAnimal == 2) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\tiger.png");
                    if (yearAnimal == 3) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\rabbit.png");
                    if (yearAnimal == 4) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\dragon.png");
                    if (yearAnimal == 5) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\snake.png");
                    if (yearAnimal == 6) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\horse.png");
                    if (yearAnimal == 7) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\sheep.png");
                    if (yearAnimal == 8) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\monkey.png");
                    if (yearAnimal == 9) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\cock.png");
                    if (yearAnimal == 10) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\dog.png");
                    if (yearAnimal == 11) Image = new Bitmap("D:\\EasternCalendar\\EasternCalendar\\resourses\\pig.png");

                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.Image = (Image)Image;
                }
            }
            else
            {
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.Image = null;
            }
        }
    }
}
