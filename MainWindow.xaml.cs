using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace pr3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Classes.PersonInfo Player = new Classes.PersonInfo("Student",100, 10, 1, 0, 0 ,5);
        public List<Classes.PersonInfo> Enemys = new List<Classes.PersonInfo>();
        public MainWindow()
        {
            InitializeComponent();
            UserInfoPlayer();
            Enemys.Add(new Classes.PersonInfo("Название врага №1", 100, 20, 1, 15, 5, 20));
            Enemys.Add(new Classes.PersonInfo("Название врага №2", 20, 5, 1, 5, 2, 5));
            Enemys.Add(new Classes.PersonInfo("Название врага №3", 50, 3, 1, 10, 10, 15));
            dispatcherTimer.Tick += AttackPlayer;
            dispatcherTimer.Interval = new System.TimeSpan(0, 0, 10);
            dispatcherTimer.Start();
        }
        public void UserInfoPlayer()
        {
            if (Player.Glasses > 100 * Player.Level)
            {
                Player.Level++;
                Player.Glasses = 0;
                Player.Health += 100;
                Player.Damage++;
                Player.Armor++;
            }

            playerHealth.Content = "Жизненные показатели: " + Player.Health;
            playerArmor.Content = "Броня: " + Player.Armor;
            playerLevel.Content = "Уровень: " + Player.Level;
            playerGlasses.Content = "Опыт: " + Player.Glasses;
            playerMoney.Content = "Монеты: " + Player.Money;
        }
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private void AttackPlayer(object sender, System.EventArgs e)
        {
        }
    }
}
