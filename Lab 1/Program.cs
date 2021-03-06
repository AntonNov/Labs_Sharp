﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {      
        static void Main(string[] args)
        {
            const int MAXCOUNT = 21;

            const int MAXCOUNTFOR2ND = 17;

            int counterOfStrings; 

            Console.Title = "Игра 21";

            Console.SetWindowSize(50, 30);

            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.White;

            Console.Clear();

            Scoreboard scoreboard = new Scoreboard();

            while (true)
            {
                scoreboard.Draw();

                Console.WriteLine("->Добро пожаловать!");

                //Звук начала игры
                Console.Beep(500, 500);

                scoreboard.countOfFirstPlayer = RightCard();

                scoreboard.countOfComputer = RightCard();

                CardIdentifier(scoreboard.countOfFirstPlayer);

                counterOfStrings = Console.CursorTop-Scoreboard.height;

                scoreboard.Draw();

                Console.CursorTop += counterOfStrings;

                Console.WriteLine("->Берём дальше? (↑/Escape)");

                ConsoleKeyInfo answer = RightInput();

                int newСardForFirstPlayer, newСardForComputer; 

                bool isUsing = false;

                while ((answer.Key != ConsoleKey.Escape || scoreboard.countOfComputer < MAXCOUNTFOR2ND) &&
                            (answer.Key == ConsoleKey.UpArrow || scoreboard.countOfComputer < MAXCOUNTFOR2ND))
                {
                    if (isUsing)
                    {
                        scoreboard.Draw();

                        isUsing = false;
                    }

                    if (answer.Key == ConsoleKey.UpArrow)
                    {
                        newСardForFirstPlayer = RightCard(scoreboard.countOfFirstPlayer);

                        CardIdentifier(newСardForFirstPlayer);

                        scoreboard.countOfFirstPlayer += newСardForFirstPlayer;

                        counterOfStrings = Console.CursorTop - Scoreboard.height;

                        scoreboard.Draw();

                        Console.CursorTop += counterOfStrings;

                        if (scoreboard.countOfFirstPlayer > MAXCOUNT)
                        {
                            counterOfStrings = Console.CursorTop - Scoreboard.height;

                            scoreboard.Draw(Convert.ToString(scoreboard.countOfComputer));

                            Console.CursorTop += counterOfStrings;

                            Console.WriteLine("->Вы перебрали! Компьютер победил");

                            ConsoleKey temp = FinalInput();               
                       
                            if (temp == ConsoleKey.End)
                            {

                                Console.WriteLine("->Спасибо за игру!");

                                return;
                            }
                            else if (temp == ConsoleKey.Enter)
                            {
                                Console.Clear();

                                scoreboard.countOfFirstPlayer = 0;

                                scoreboard.countOfComputer = 0;

                                isUsing = true;

                                continue;
                            }

                        }
                        else
                        {
                            Console.WriteLine("->Берём дальше?");

                            answer = RightInput();

                        }
                    }

                    newСardForComputer = RightCard(); ;

                    scoreboard.countOfComputer += newСardForComputer;

                    if (scoreboard.countOfComputer >= MAXCOUNTFOR2ND)
                    {
                        continue;
                    }

                    if (scoreboard.countOfComputer > MAXCOUNT)
                    {
                        Console.WriteLine("->Компьютер перебрал! Вы победили!");

                        counterOfStrings = Console.CursorTop - Scoreboard.height;

                        scoreboard.Draw(Convert.ToString(scoreboard.countOfComputer));

                        Console.CursorTop += counterOfStrings;

                        ConsoleKey temp = FinalInput();

                        if (temp == ConsoleKey.End)
                        {

                            Console.WriteLine("->Спасибо за игру!");

                            return;
                        }
                        else if (temp == ConsoleKey.Enter)
                        {
                            Console.Clear();

                            scoreboard.countOfFirstPlayer = 0;

                            scoreboard.countOfComputer = 0;

                            isUsing = true;

                            continue;
                        }
                    }
                }


                Console.WriteLine("->Счёт компьютера " + scoreboard.countOfComputer);

                counterOfStrings = Console.CursorTop - Scoreboard.height;

                scoreboard.Draw(Convert.ToString(scoreboard.countOfComputer));

                Console.CursorTop += counterOfStrings;

                if (scoreboard.countOfFirstPlayer > scoreboard.countOfComputer)
                {
                    Console.WriteLine("->Ваша победа!!");
                }
                else if (scoreboard.countOfFirstPlayer < scoreboard.countOfComputer)
                {
                    Console.WriteLine("->Проигрыш!!");
                }
                else
                {
                    Console.WriteLine("->Ничья!!");
                }


                if (FinalInput() == ConsoleKey.End)
                {

                    Console.WriteLine("->Спасибо за игру!");

                    return;
                }

                Console.Clear();
            }


        }

        /// <summary>
        /// Выводит на консоль, какая карта выпала
        /// </summary>
        /// <param name="numberOfTheCard"></param>
        static void CardIdentifier(int numberOfTheCard)
        {
            switch (numberOfTheCard)
            {
                case 1: Console.WriteLine("->Вам выпал туз"); break;

                case 2: Console.WriteLine("->Вам выпал валет"); break;

                case 3: Console.WriteLine("->Вам выпала дама"); break;

                case 4: Console.WriteLine("->Вам выпал король"); break;

                case 6: Console.WriteLine("->Вам выпала 6"); break;

                case 7: Console.WriteLine("->Вам выпала 7"); break;

                case 8: Console.WriteLine("->Вам выпала 8"); break;

                case 9: Console.WriteLine("->Вам выпала 9"); break;

                case 10: Console.WriteLine("->Вам выпала 10"); break;

                case 11: Console.WriteLine("->Вам выпал Туз"); break;

                default: Console.WriteLine("->Ошибка"); break;
            }

        }

        /// <summary>
        /// Генерирует правильную карту (туза в зависимости от общего значения очков, исключает выпадение 5)
        /// </summary>
        /// <param name="newCard"></param>
        /// <param name="generalValue"></param>
        static int RightCard(int generalValue = 0)
        {
            Random random = new Random();

            int card = random.Next(2, 12);

            while (card == 5)
            {
                card = random.Next(2, 12);
            }

            if (card == 11 && generalValue > 10)
            {
                card = 1;
            }

            return card;
        }

        /// <summary>
        /// Ввод клавиш Escape и upArrow для ответа
        /// </summary>
        /// <returns></returns>
        static ConsoleKeyInfo RightInput()
        {
            ConsoleKeyInfo answer = Console.ReadKey();

            if (answer.Key == ConsoleKey.Escape)
            {
                Console.Write("\b ");
            }

            while (!(answer.Key == ConsoleKey.Escape || answer.Key == ConsoleKey.UpArrow))
            {
                Console.WriteLine("->Ошибка ввода, повторите ввод");

                Console.WriteLine("->Повторите. Берём дальше?");

                answer = Console.ReadKey();

                if (answer.Key == ConsoleKey.Escape)
                {
                    Console.Write("\b ");
                }

            }

            return answer;
        }


        /// <summary>
        /// Ввод клавиш End и Enter для окончания старой/начала новой игры
        /// </summary>
        /// <returns></returns>
        static ConsoleKey FinalInput()
        {

            Console.WriteLine("Нажмите End для выхода или Enter для продолжения");

            ConsoleKeyInfo answer = Console.ReadKey();

            if (answer.Key == ConsoleKey.Escape)
            {
                Console.Write("\b ");
            }

            while (!(answer.Key == ConsoleKey.End || answer.Key == ConsoleKey.Enter))
            {
                Console.WriteLine("->Ошибка ввода, повторите ввод");

                Console.WriteLine("->Повторите. Заканчиваем игру?");

                answer = Console.ReadKey();

                if (answer.Key == ConsoleKey.Escape)
                {
                    Console.Write("\b ");
                }

            }

            if (answer.Key == ConsoleKey.Escape)
            {
                Console.Write("\b ");
            }

            return answer.Key;

        }

    }


}
