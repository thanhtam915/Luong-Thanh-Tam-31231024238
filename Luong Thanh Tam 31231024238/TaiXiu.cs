using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class TaiXiu
    {
        public static void MainTX()
        {
            Console.Write("Chao mung ban toi tro choi tai xiu cua chung toi" + Environment.NewLine + "Tai khoan ban con la 1000$ " + Environment.NewLine + "Mot van thang ban duoc 100$ con thua thi mat 100$");
            gameplay();
        }
        public static int tungxucxac()
        {
            Random rnd = new Random();
            int lan1 = rnd.Next(6) + 1;
            int lan2 = rnd.Next(6) + 1;
            int lan3 = rnd.Next(6) + 1;
            int tong = lan1 + lan2 + lan3;
            return tong;
        }
        public static void gameplay()
        {
            int lan_choi = 0; ;
            int tien = 1000;
            while (true)
            {
                if (tien <= 0)
                {
                    Console.WriteLine("Het tien roi thang nghien co bac");
                    break;
                }
                Console.Write(Environment.NewLine + "Chon Tai Hay Xiu<T/X>:");
                string lua_chon = Console.ReadLine();
                int luot_quay = tungxucxac();
                if (lua_chon.ToUpper() == "T")
                {
                    if (luot_quay >= 10)
                    {
                        Console.WriteLine("You win" + Environment.NewLine + "Ban nhan duoc 100$");
                        tien = tien + 100;
                        lan_choi++;
                        Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                        string tiep_tuc = Console.ReadLine();
                        if (tiep_tuc.ToUpper() == "K")
                        {
                            Console.WriteLine("Bye");
                            return;
                        }
                        else if (tiep_tuc.ToUpper() == "C") continue;
                        else if (tiep_tuc.ToUpper() == "TK")
                        {
                            Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                            Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                            while (true)
                            {
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK")
                                {
                                    Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                    Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                    continue;
                                }
                                else
                                {
                                    Console.Write("Vui long nhap lai:");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("Vui long nhap lai:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK")
                                {
                                    while (true)
                                    {
                                        tiep_tuc = Console.ReadLine();
                                        if (tiep_tuc.ToUpper() == "K")
                                        {
                                            Console.WriteLine("Bye");
                                            return;
                                        }
                                        else if (tiep_tuc.ToUpper() == "C") break;
                                        else if (tiep_tuc.ToUpper() == "TK")
                                        {
                                            Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                            Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Write("Vui long nhap lai:");
                                            continue;
                                        }
                                    }
                                }
                                else continue;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("You lose" + Environment.NewLine + "Ban mat 100$");
                        tien = tien - 100;
                        lan_choi++;
                        Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                        string tiep_tuc = Console.ReadLine();
                        if (tiep_tuc.ToUpper() == "K") break;
                        else if (tiep_tuc.ToUpper() == "C") continue;
                        else if (tiep_tuc.ToUpper() == "TK")
                        {
                            while (true)
                            {
                                Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK")
                                {
                                    Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                    Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                    continue;
                                }
                                else
                                {
                                    Console.Write("Vui long nhap lai:");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("Vui long nhap lai:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK")
                                {
                                    Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                    Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                    tiep_tuc = Console.ReadLine();
                                    if (tiep_tuc.ToUpper() == "K")
                                    {
                                        Console.WriteLine("Bye");
                                        return;
                                    }
                                    else if (tiep_tuc.ToUpper() == "C") break;
                                    else if (tiep_tuc.ToUpper() == "TK") continue;
                                    else
                                    {
                                        Console.WriteLine("Vui long nhap lai");
                                        continue;
                                    }
                                }
                                else continue;
                            }
                        }
                    }
                }
                else if (lua_chon.ToUpper() == "X")
                {
                    if (luot_quay < 10)
                    {
                        Console.WriteLine("You win" +
                            "Ban nhan duoc 100$");
                        tien = tien + 100;
                        lan_choi++;
                        Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                        string tiep_tuc = Console.ReadLine();
                        if (tiep_tuc.ToUpper() == "K")
                        {
                            Console.WriteLine("Bye");
                            return;
                        }
                        else if (tiep_tuc.ToUpper() == "C") continue;
                        else if (tiep_tuc.ToUpper() == "TK")
                        {
                            while (true)
                            {
                                Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK") continue;
                                else
                                {
                                    Console.Write("Vui long nhap lai");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("Vui long nhap lai:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK")
                                {
                                    Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                    Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                    tiep_tuc = Console.ReadLine();
                                    if (tiep_tuc.ToUpper() == "K")
                                    {
                                        Console.WriteLine("Bye");
                                        return;
                                    }
                                    else if (tiep_tuc.ToUpper() == "C") break;
                                    else if (tiep_tuc.ToUpper() == "TK") continue;
                                    else
                                    {
                                        Console.WriteLine("Vui long nhap lai");
                                        continue;
                                    }
                                }
                                else continue;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("You lose" + Environment.NewLine + "Ban mat 100$");
                        tien = tien - 100;
                        lan_choi++;
                        Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                        string tiep_tuc = Console.ReadLine();
                        if (tiep_tuc.ToUpper() == "K")
                        {
                            Console.WriteLine("Bye");
                            break;
                        }
                        else if (tiep_tuc.ToUpper() == "C") continue;
                        else if (tiep_tuc.ToUpper() == "TK")
                        {
                            while (true)
                            {
                                Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK") continue;
                                else
                                {
                                    Console.WriteLine("Vui long nhap lai");
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("Vui long nhap lai:");
                                tiep_tuc = Console.ReadLine();
                                if (tiep_tuc.ToUpper() == "K")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                else if (tiep_tuc.ToUpper() == "C") break;
                                else if (tiep_tuc.ToUpper() == "TK")
                                {
                                    Console.WriteLine($"Tong luot choi:{lan_choi}, Luot tien con lai:{tien}");
                                    Console.Write("Choi nua khong<C/K>Hoac Thong Ke:");
                                    tiep_tuc = Console.ReadLine();
                                    if (tiep_tuc.ToUpper() == "K")
                                    {
                                        Console.WriteLine("Bye");
                                        return;
                                    }
                                    else if (tiep_tuc.ToUpper() == "C") break;
                                    else if (tiep_tuc.ToUpper() == "TK") continue;
                                    else
                                    {
                                        Console.WriteLine("Vui long nhap lai");
                                        continue;
                                    }
                                }
                                else continue;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap lai:");
                    continue;
                }

            }
        }
    }
}
