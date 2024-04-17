using System;
using System.Windows;
using System.Windows.Controls;

namespace Novella
{
    public partial class Minigame2 : Window
    {
        private Random random = new Random();

        public Minigame2()
        {
            InitializeComponent();
        }

        private void RockButton_Click(object sender, RoutedEventArgs e)
        {
            PlayGame("Камень");
        }

        private void PaperButton_Click(object sender, RoutedEventArgs e)
        {
            PlayGame("Бумага");
        }

        private void ScissorsButton_Click(object sender, RoutedEventArgs e)
        {
            PlayGame("Ножницы");
        }

        private void PlayGame(string playerChoice)
        {
            int playerWins = 0;
            int computerWins = 0;

            string computerChoice = GetComputerChoice();
            string result = DetermineWinner(playerChoice, computerChoice);
            DisplayResult(playerChoice, computerChoice, result);

            if (result == "Вы победили!")
            {
                playerWins++;
                if (playerWins == 3)
                {
                    MessageBox.Show("Поздравляем! Вы достигли 3 побед!");
                    Novella3 novella3 = new Novella3();
                    novella3.Show();
                    this.Close();
                }
            }
            else if (result == "Компьютер победил!")
            {
                computerWins++;
                if (computerWins == 3)
                {
                    MessageBox.Show("Компьютер достиг 3 побед. Вы проиграли!");
                    this.Close();
                }
            }
            else if (result == "Ничья!")
            {
                playerWins = 0;
                computerWins = 0;
            }

            playerWinsTextBlock.Text = $"Выигрыши игрока: {playerWins}";
            computerWinsTextBlock.Text = $"Выигрыши компьютера: {computerWins}";
        }

        private string GetComputerChoice()
        {
            int choice = random.Next(3);
            switch (choice)
            {
                case 0: return "Камень";
                case 1: return "Ножницы";
                case 2: return "Бумага";
                default: return "Неизвестно";
            }
        }

        private string DetermineWinner(string playerChoice, string computerChoice)
        {
            if (playerChoice == computerChoice)
                return "Ничья!";

            if ((playerChoice == "Камень" && computerChoice == "Ножницы") ||
                (playerChoice == "Ножницы" && computerChoice == "Бумага") ||
                (playerChoice == "Бумага" && computerChoice == "Камень"))
                return "Вы победили!";

            return "Компьютер победил!";
        }

        private void DisplayResult(string playerChoice, string computerChoice, string result)
        {
            resultTextBlock.Text = $"Вы выбрали: {playerChoice}\nКомпьютер выбрал: {computerChoice}\n\n{result}";
        }
    }
}