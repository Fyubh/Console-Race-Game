﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NeedForSpeed2._0
{
    static class Art
    {
        private static void MissionImpossible()
        {
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(587, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(554, 1200);
            Thread.Sleep(75);
            Console.Beep(932, 150);
            Console.Beep(784, 150);
            Console.Beep(523, 1200);
            Thread.Sleep(150);
            Console.Beep(466, 150);
            Console.Beep(523, 150);
        }
        public static void Car()
        {
            Console.WriteLine("\t\t\t\t\t\t                                        ░░▓▓▓▓██▓▓░░                                                                                  ");
            Console.WriteLine("\t\t\t\t\t\t                                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓                                                                              ");
            Console.WriteLine("\t\t\t\t\t\t                                ░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░                                                                          ");
            Console.WriteLine("\t\t\t\t\t\t                            ░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░                                                                    ");
            Console.WriteLine("\t\t\t\t\t\t                        ▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓                                                                ");
            Console.WriteLine("\t\t\t\t\t\t                      ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████                                                            ");
            Console.WriteLine("\t\t\t\t\t\t                ░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒                                                        ");
            Console.WriteLine("\t\t\t\t\t\t              ▓▓▓▓▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                                      ");
            Console.WriteLine("\t\t\t\t\t\t          ▒▒██▒▒▒▒▓▓██▒▒▒▒██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒                                                    ");
            Console.WriteLine("\t\t\t\t\t\t        ▓▓▓▓▓▓▓▓▓▓▒▒██▒▒▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░▓▓▓▓▒▒                                                  ");
            Console.WriteLine("\t\t\t\t\t\t    ▓▓▓▓▒▒▓▓▒▒▒▒░░░░██▓▓▒▒▒▒██▒▒▒▒▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒░░░░░░░░▒▒██                                                  ");
            Console.WriteLine("\t\t\t\t\t\t    ██▒▒▒▒▓▓▒▒░░░░░░██▓▓░░░░░░▓▓▓▓▒▒▒▒██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░░░░░▓▓▒▒▓▓                                                ");
            Console.WriteLine("\t\t\t\t\t\t    ▓▓▒▒▒▒▒▒▓▓▓▓▓▓░░██▓▓░░░░░░░░▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░▒▒▓▓▓▓░░▒▒░░                                          ");
            Console.WriteLine("\t\t\t\t\t\t    ▓▓▒▒▒▒▒▒▓▓▒▒▒▒▓▓██▓▓░░░░░░░░▒▒▓▓██▒▒██▒▒▒▒▓▓▒▒▒▒▒▒▒▒██▒▒▒▒░░░░░░░░░░░░░░░░▒▒░░░░▓▓▓▓██▓▓                                          ");
            Console.WriteLine("\t\t\t\t\t\t  ░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░▒▒▓▓██░░░░▓▓▓▓▒▒██▒▒▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓██▒▒                                          ");
            Console.WriteLine("\t\t\t\t\t\t░░▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░▒▒▓▓██░░░░░░▒▒▓▓▒▒▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▓▓▓▓▓▓▒▒                                          ");
            Console.WriteLine("\t\t\t\t\t\t▒▒▒▒▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██░░░░░░░░▓▓▒▒▓▓▒▒░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▓▓██▒▒▒▒▒▒▒▒▓▓██                                      ");
            Console.WriteLine("\t\t\t\t\t\t▒▒▒▒▒▒▓▓▒▒▒▒████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒░░░░░░░░██▒▒▓▓░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░                                  ");
            Console.WriteLine("\t\t\t\t\t\t▒▒▒▒▒▒▓▓▒▒▓▓██████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██▒▒░░░░▒▒▒▒▓▓▓▓▓▓░░░░░░▒▒░░▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░                            ");
            Console.WriteLine("\t\t\t\t\t\t  ██▓▓▓▓▒▒██████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██░░▒▒▒▒▓▓▒▒██▒▒░░▒▒▒▒▒▒▒▒▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██                          ");
            Console.WriteLine("\t\t\t\t\t\t    ░░▓▓▓▓████  ██▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▒▒▓▓░░▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░                      ");
            Console.WriteLine("\t\t\t\t\t\t░░░░░░░░▒▒████▒▒██████▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▓▓▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                    ");
            Console.WriteLine("\t\t\t\t\t\t  ░░░░░░░░▒▒████▒▒██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▒▒▒▒▒▒████████▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒                  ");
            Console.WriteLine("\t\t\t\t\t\t      ░░░░▒▒██████████▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▓▓████▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓░░▓▓▒▒▒▒                  ");
            Console.WriteLine("\t\t\t\t\t\t          ░░░░██████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▒▒▓▓░░                  ");
            Console.WriteLine("\t\t\t\t\t\t              ░░██████░░░░██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██▓▓▓▓██▓▓▓▓▒▒▒▒▓▓██                      ");
            Console.WriteLine("\t\t\t\t\t\t                  ░░░░░░░░░░▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██████▓▓▓▓██▓▓▓▓▒▒▓▓                    ");
            Console.WriteLine("\t\t\t\t\t\t                      ░░░░░░░░░░░░▓▓██▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒██▓▓██▒▒▓▓████▓▓▒▒▒▒▒▒▓▓██                    ");
            Console.WriteLine("\t\t\t\t\t\t                          ░░░░░░░░░░░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓██▒▒██████▒▒▒▒▒▒▒▒▒▒▓▓                      ");
            Console.WriteLine("\t\t\t\t\t\t                              ░░░░░░░░░░▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▓▓▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▓▓▒▒▓▓▓▓▓▓████▓▓▓▓▒▒▓▓▓▓▒▒▒▒▓▓░░░░░░                  ");
            Console.WriteLine("\t\t\t\t\t\t                                  ░░░░░░░░░░░░▓▓██▒▒▒▒▒▒▒▒▓▓██████▓▓▒▒▒▒▒▒▓▓▒▒▓▓  ▓▓▓▓▓▓██▓▓▒▒▒▒▒▒▒▒▓▓▒▒▒▒██▒▒░░░░░░░░                ");
            Console.WriteLine("\t\t\t\t\t\t                                      ░░░░░░░░░░░░██▓▓▓▓▓▓██████████▓▓▒▒▒▒▓▓▒▒▒▒██▒▒████▒▒▒▒▓▓▒▒▒▒▒▒▒▒▓▓██▓▓░░░░░░░░                  ");
            Console.WriteLine("\t\t\t\t\t\t                                          ░░░░░░░░░░▒▒▒▒██████░░▒▒████▒▒▒▒▓▓██▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▒▒░░░░░░░░░░                    ");
            Console.WriteLine("\t\t\t\t\t\t                                              ░░░░░░░░░░░░▓▓██▒▒░░░░████▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒██▓▓░░░░░░░░░░                          ");
            Console.WriteLine("\t\t\t\t\t\t                                                  ░░░░░░░░████▒▒▓▓██████▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░                              ");
            Console.WriteLine("\t\t\t\t\t\t                                                        ░░▒▒████▒▒▒▒████▓▓▓▓▓▓▓▓▒▒▒▒▓▓▓▓▒▒▒▒░░░░░░░░                                  ");
            Console.WriteLine("\t\t\t\t\t\t                                                          ░░████████████░░████░░████▓▓░░░░░░░░░░                                      ");
            Console.WriteLine("\t\t\t\t\t\t                                                              ▒▒▓▓██▓▓░░░░░░░░░░░░░░░░░░░░░░                                          ");
            Console.WriteLine("\t\t\t\t\t\t                                                                ░░▒▒░░░░░░░░░░░░░░░░░░░░░░                                            ");
            Console.WriteLine("\t\t\t\t\t\t                                                                      ░░░░░░░░░░░░░░                                                  ");
            Console.WriteLine("\t\t\t\t\t\t                                                                          ░░░░░░                                                      ");

            Console.WriteLine("\n\n\n\n\n\n\n\t\t\t\t\t\t\t\t\t▒███████▒ ██░ ██  ▄▄▄       ███▄    █   ▄████  ██▓ ██▀███      ██▓ ███▄    █  ▄████▄       ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t▒ ▒ ▒ ▄▀░▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓██▒▓██ ▒ ██▒   ▓██▒ ██ ▀█   █ ▒██▀ ▀█       ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t░ ▒ ▄▀▒░ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒██▒▓██ ░▄█ ▒   ▒██▒▓██  ▀█ ██▒▒▓█    ▄      ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t  ▄▀▒   ░░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓░██░▒██▀▀█▄     ░██░▓██▒  ▐▌██▒▒▓▓▄ ▄██▒     ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t▒███████▒░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░██░░██▓ ▒██▒   ░██░▒██░   ▓██░▒ ▓███▀ ░ ██▓ ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t░▒▒ ▓░▒░▒ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░▓  ░ ▒▓ ░▒▓░   ░▓  ░ ▒░   ▒ ▒ ░ ░▒ ▒  ░ ▒▓▒ ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t░░▒ ▒ ░ ▒ ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ▒ ░  ░▒ ░ ▒░    ▒ ░░ ░░   ░ ▒░  ░  ▒    ░▒  ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t░ ░ ░ ░ ░ ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░  ▒ ░  ░░   ░     ▒ ░   ░   ░ ░ ░         ░   ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t  ░ ░     ░  ░  ░      ░  ░         ░       ░  ░     ░         ░           ░ ░ ░        ░  ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t░                                                                            ░          ░  ");


            Thread.Sleep(3000);
            Console.Clear();
        }
        
        public static void PressKey()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("          _____                    _____                    _____                    _____                    _____                  ");
            Console.WriteLine("         /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\                 ");
            Console.WriteLine("        /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\                /::\\    \\                ");
            Console.WriteLine("       /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\              /::::\\    \\               ");
            Console.WriteLine("      /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\            /::::::\\    \\              ");
            Console.WriteLine("     /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\             ");
            Console.WriteLine("    /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/__\\:::\\    \\        /:::/__\\:::\\    \\            ");
            Console.WriteLine("   /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\       \\:::\\   \\:::\\    \\       \\:::\\   \\:::\\    \\           ");
            Console.WriteLine("  /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\    ___\\:::\\   \\:::\\    \\    ___\\:::\\   \\:::\\    \\          ");
            Console.WriteLine(" /:::/\\:::\\   \\:::\\____\\  /:::/\\:::\\   \\:::\\____\\  /:::/\\:::\\   \\:::\\    \\  /\\   \\:::\\   \\:::\\    \\  /\\   \\:::\\   \\:::\\    \\         ");
            Console.WriteLine("/:::/  \\:::\\   \\:::|    |/:::/  \\:::\\   \\:::|    |/:::/__\\:::\\   \\:::\\____\\/::\\   \\:::\\   \\:::\\____\\/::\\   \\:::\\   \\:::\\____\\        ");
            Console.WriteLine("\\::/    \\:::\\  /:::|____|\\::/   |::::\\  /:::|____|\\:::\\   \\:::\\   \\::/    /\\:::\\   \\:::\\   \\::/    /\\:::\\   \\:::\\   \\::/    /        ");
            Console.WriteLine(" \\/_____/\\:::\\/:::/    /  \\/____|:::::\\/:::/    /  \\:::\\   \\:::\\   \\/____/  \\:::\\   \\:::\\   \\/____/  \\:::\\   \\:::\\   \\/____/         ");
            Console.WriteLine("          \\::::::/    /         |:::::::::/    /    \\:::\\   \\:::\\    \\       \\:::\\   \\:::\\    \\       \\:::\\   \\:::\\    \\             ");
            Console.WriteLine("           \\::::/    /          |::|\\::::/    /      \\:::\\   \\:::\\____\\       \\:::\\   \\:::\\____\\       \\:::\\   \\:::\\____\\            ");
            Console.WriteLine("            \\::/____/           |::| \\::/____/        \\:::\\   \\::/    /        \\:::\\  /:::/    /        \\:::\\  /:::/    /            ");
            Console.WriteLine("             ~~                 |::|  ~|               \\:::\\   \\/____/          \\:::\\/:::/    /          \\:::\\/:::/    /             ");
            Console.WriteLine("                                |::|   |                \\:::\\    \\               \\::::::/    /            \\::::::/    /              ");
            Console.WriteLine("                                \\::|   |                 \\:::\\____\\               \\::::/    /              \\::::/    /               ");
            Console.WriteLine("                                 \\:|   |                  \\::/    /                \\::/    /                \\::/    /                ");
            Console.WriteLine("                                  \\|___|                   \\/____/                  \\/____/                  \\/____/                 ");
            Console.WriteLine("          _____                    _____                _____                        _____                   _______                 ");
            Console.WriteLine("         /\\    \\                  /\\    \\              |\\    \\                      /\\    \\                 /::\\    \\                ");
            Console.WriteLine("        /::\\____\\                /::\\    \\             |:\\____\\                    /::\\    \\               /::::\\    \\               ");
            Console.WriteLine("       /:::/    /               /::::\\    \\            |::|   |                    \\:::\\    \\             /::::::\\    \\              ");
            Console.WriteLine("      /:::/    /               /::::::\\    \\           |::|   |                     \\:::\\    \\           /::::::::\\    \\             ");
            Console.WriteLine("     /:::/    /               /:::/\\:::\\    \\          |::|   |                      \\:::\\    \\         /:::/~~\\:::\\    \\            ");
            Console.WriteLine("    /:::/____/               /:::/__\\:::\\    \\         |::|   |                       \\:::\\    \\       /:::/    \\:::\\    \\           ");
            Console.WriteLine("   /::::\\    \\              /::::\\   \\:::\\    \\        |::|   |                       /::::\\    \\     /:::/    / \\:::\\    \\          ");
            Console.WriteLine("  /::::::\\____\\________    /::::::\\   \\:::\\    \\       |::|___|______                /::::::\\    \\   /:::/____/   \\:::\\____\\         ");
            Console.WriteLine(" /:::/\\:::::::::::\\    \\  /:::/\\:::\\   \\:::\\    \\      /::::::::\\    \\              /:::/\\:::\\    \\ |:::|    |     |:::|    |        ");
            Console.WriteLine("/:::/  |:::::::::::\\____\\/:::/__\\:::\\   \\:::\\____\\    /::::::::::\\____\\            /:::/  \\:::\\____\\|:::|____|     |:::|    |        ");
            Console.WriteLine("\\::/   |::|~~~|~~~~~     \\:::\\   \\:::\\   \\::/    /   /:::/~~~~/~~                 /:::/    \\::/    / \\:::\\    \\   /:::/    /         ");
            Console.WriteLine(" \\/____|::|   |           \\:::\\   \\:::\\   \\/____/   /:::/    /                   /:::/    / \\/____/   \\:::\\    \\ /:::/    /          ");
            Console.WriteLine("       |::|   |            \\:::\\   \\:::\\    \\      /:::/    /                   /:::/    /             \\:::\\    /:::/    /           ");
            Console.WriteLine("       |::|   |             \\:::\\   \\:::\\____\\    /:::/    /                   /:::/    /               \\:::\\__/:::/    /            ");
            Console.WriteLine("       |::|   |              \\:::\\   \\::/    /    \\::/    /                    \\::/    /                 \\::::::::/    /             ");
            Console.WriteLine("       |::|   |               \\:::\\   \\/____/      \\/____/                      \\/____/                   \\::::::/    /              ");
            Console.WriteLine("       |::|   |                \\:::\\    \\                                                                  \\::::/    /               ");
            Console.WriteLine("       \\::|   |                 \\:::\\____\\                                                                  \\::/____/                ");
            Console.WriteLine("        \\:|   |                  \\::/    /                                                                   ~~                      ");
            Console.WriteLine("         \\|___|                   \\/____/                                                                                            ");
            Console.WriteLine("          _____                _____                    _____                    _____                _____                          ");
            Console.WriteLine("         /\\    \\              /\\    \\                  /\\    \\                  /\\    \\              /\\    \\                         ");
            Console.WriteLine("        /::\\    \\            /::\\    \\                /::\\    \\                /::\\    \\            /::\\    \\                        ");
            Console.WriteLine("       /::::\\    \\           \\:::\\    \\              /::::\\    \\              /::::\\    \\           \\:::\\    \\                       ");
            Console.WriteLine("      /::::::\\    \\           \\:::\\    \\            /::::::\\    \\            /::::::\\    \\           \\:::\\    \\                      ");
            Console.WriteLine("     /:::/\\:::\\    \\           \\:::\\    \\          /:::/\\:::\\    \\          /:::/\\:::\\    \\           \\:::\\    \\                     ");
            Console.WriteLine("    /:::/__\\:::\\    \\           \\:::\\    \\        /:::/__\\:::\\    \\        /:::/__\\:::\\    \\           \\:::\\    \\                    ");
            Console.WriteLine("    \\:::\\   \\:::\\    \\          /::::\\    \\      /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\          /::::\\    \\                   ");
            Console.WriteLine("  ___\\:::\\   \\:::\\    \\        /::::::\\    \\    /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\        /::::::\\    \\                  ");
            Console.WriteLine(" /\\   \\:::\\   \\:::\\    \\      /:::/\\:::\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/\\:::\\   \\:::\\____\\      /:::/\\:::\\    \\                 ");
            Console.WriteLine("/::\\   \\:::\\   \\:::\\____\\    /:::/  \\:::\\____\\/:::/  \\:::\\   \\:::\\____\\/:::/  \\:::\\   \\:::|    |    /:::/  \\:::\\____\\                ");
            Console.WriteLine("\\:::\\   \\:::\\   \\::/    /   /:::/    \\::/    /\\::/    \\:::\\  /:::/    /\\::/   |::::\\  /:::|____|   /:::/    \\::/    /                ");
            Console.WriteLine(" \\:::\\   \\:::\\   \\/____/   /:::/    / \\/____/  \\/____/ \\:::\\/:::/    /  \\/____|:::::\\/:::/    /   /:::/    / \\/____/                 ");
            Console.WriteLine("  \\:::\\   \\:::\\    \\      /:::/    /                    \\::::::/    /         |:::::::::/    /   /:::/    /                          ");
            Console.WriteLine("   \\:::\\   \\:::\\____\\    /:::/    /                      \\::::/    /          |::|\\::::/    /   /:::/    /                           ");
            Console.WriteLine("    \\:::\\  /:::/    /    \\::/    /                       /:::/    /           |::| \\::/____/    \\::/    /                            ");
            Console.WriteLine("     \\:::\\/:::/    /      \\/____/                       /:::/    /            |::|  ~|           \\/____/                             ");
            Console.WriteLine("      \\::::::/    /                                    /:::/    /             |::|   |                                               ");
            Console.WriteLine("       \\::::/    /                                    /:::/    /              \\::|   |                                               ");
            Console.WriteLine("        \\::/    /                                     \\::/    /                \\:|   |                                               ");
            Console.WriteLine("         \\/____/                                       \\/____/                  \\|___|                                               ");

            Console.ReadKey();
            Console.Clear();
            Console.Beep(700, 100);
        }

        public static void GameOver()
        {
            Console.SetWindowSize(100, 45);
            Console.Clear();
            Console.WriteLine("          _____                    _____                    _____                    _____          ");
            Console.WriteLine("         /\\    \\                  /\\    \\                  /\\    \\                  /\\    \\         ");
            Console.WriteLine("        /::\\    \\                /::\\    \\                /::\\____\\                /::\\    \\        ");
            Console.WriteLine("       /::::\\    \\              /::::\\    \\              /::::|   |               /::::\\    \\       ");
            Console.WriteLine("      /::::::\\    \\            /::::::\\    \\            /:::::|   |              /::::::\\    \\      ");
            Console.WriteLine("     /:::/\\:::\\    \\          /:::/\\:::\\    \\          /::::::|   |             /:::/\\:::\\    \\     ");
            Console.WriteLine("    /:::/  \\:::\\    \\        /:::/__\\:::\\    \\        /:::/|::|   |            /:::/__\\:::\\    \\    ");
            Console.WriteLine("   /:::/    \\:::\\    \\      /::::\\   \\:::\\    \\      /:::/ |::|   |           /::::\\   \\:::\\    \\   ");
            Console.WriteLine("  /:::/    / \\:::\\    \\    /::::::\\   \\:::\\    \\    /:::/  |::|___|______    /::::::\\   \\:::\\    \\  ");
            Console.WriteLine(" /:::/    /   \\:::\\ ___\\  /:::/\\:::\\   \\:::\\    \\  /:::/   |::::::::\\    \\  /:::/\\:::\\   \\:::\\    \\ ");
            Console.WriteLine("/:::/____/  ___\\:::|    |/:::/  \\:::\\   \\:::\\____\\/:::/    |:::::::::\\____\\/:::/__\\:::\\   \\:::\\____\\");
            Console.WriteLine("\\:::\\    \\ /\\  /:::|____|\\::/    \\:::\\  /:::/    /\\::/    / ~~~~~/:::/    /\\:::\\   \\:::\\   \\::/    ");
            Console.WriteLine(" \\:::\\    /::\\ \\::/    /  \\/____/ \\:::\\/:::/    /  \\/____/      /:::/    /  \\:::\\   \\:::\\   \\/____/ ");
            Console.WriteLine("  \\:::\\   \\:::\\ \\/____/            \\::::::/    /               /:::/    /    \\:::\\   \\:::\\    \\     ");
            Console.WriteLine("   \\:::\\   \\:::\\____\\               \\::::/    /               /:::/    /      \\:::\\   \\:::\\____\\    ");
            Console.WriteLine("    \\:::\\  /:::/    /               /:::/    /               /:::/    /        \\:::\\   \\::/    /    ");
            Console.WriteLine("     \\:::\\/:::/    /               /:::/    /               /:::/    /          \\:::\\   \\/____/     ");
            Console.WriteLine("      \\::::::/    /               /:::/    /               /:::/    /            \\:::\\    \\         ");
            Console.WriteLine("       \\::::/    /               /:::/    /               /:::/    /              \\:::\\____\\        ");
            Console.WriteLine("        \\::/____/                \\::/    /                \\::/    /                \\::/    /        ");
            Console.WriteLine("                                  \\/____/                  \\/____/                  \\/____/         ");
            Console.WriteLine();
            Console.WriteLine("         _______                   _____                    _____                    _____          ");
            Console.WriteLine("        /::\\    \\                 /\\    \\                  /\\    \\                  /\\    \\         ");
            Console.WriteLine("       /::::\\    \\               /::\\____\\                /::\\    \\                /::\\    \\        ");
            Console.WriteLine("      /::::::\\    \\             /:::/    /               /::::\\    \\              /::::\\    \\       ");
            Console.WriteLine("     /::::::::\\    \\           /:::/    /               /::::::\\    \\            /::::::\\    \\      ");
            Console.WriteLine("    /:::/~~\\:::\\    \\         /:::/    /               /:::/\\:::\\    \\          /:::/\\:::\\    \\     ");
            Console.WriteLine("   /:::/    \\:::\\    \\       /:::/____/               /:::/__\\:::\\    \\        /:::/__\\:::\\    \\    ");
            Console.WriteLine("  /:::/    / \\:::\\    \\      |::|    |               /::::\\   \\:::\\    \\      /::::\\   \\:::\\    \\   ");
            Console.WriteLine(" /:::/____/   \\:::\\____\\     |::|    |     _____    /::::::\\   \\:::\\    \\    /::::::\\   \\:::\\    \\  ");
            Console.WriteLine("|:::|    |     |:::|    |    |::|    |    /\\    \\  /:::/\\:::\\   \\:::\\    \\  /:::/\\:::\\   \\:::\\____\\ ");
            Console.WriteLine("|:::|____|     |:::|    |    |::|    |   /::\\____\\/:::/__\\:::\\   \\:::\\____\\/:::/  \\:::\\   \\:::|    |");
            Console.WriteLine(" \\:::\\    \\   /:::/    /     |::|    |  /:::/    /\\:::\\   \\:::\\   \\::/    /\\::/   |::::\\  /:::|____|");
            Console.WriteLine("  \\:::\\    \\ /:::/    /      |::|    | /:::/    /  \\:::\\   \\:::\\   \\/____/  \\/____|:::::\\/:::/    / ");
            Console.WriteLine("   \\:::\\    /:::/    /       |::|____|/:::/    /    \\:::\\   \\:::\\    \\            |:::::::::/    /  ");
            Console.WriteLine("    \\:::\\__/:::/    /        |:::::::::::/    /      \\:::\\   \\:::\\____\\           |::|\\::::/    /   ");
            Console.WriteLine("     \\::::::::/    /         \\::::::::::/____/        \\:::\\   \\::/    /           |::| \\::/____/    ");
            Console.WriteLine("      \\::::::/    /           ~~~~~~~~~~               \\:::\\   \\/____/            |::|  ~|          ");
            Console.WriteLine("       \\::::/    /                                      \\:::\\    \\                |::|   |          ");
            Console.WriteLine("        \\::/____/                                        \\:::\\____\\               \\::|   |          ");
            Console.WriteLine("         ~~                                               \\::/    /                \\:|   |          ");
            Console.WriteLine("                                                           \\/____/                  \\|___|          ");


            MissionImpossible();
        }
    }
}
