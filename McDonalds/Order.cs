namespace McDonalds
{
    internal class Order
    {
        private int position = 3;
        private int amount;
        private string description = "";
        private int page = 0;
        private string text_bill = "";
        private int number;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+ "\\check.txt";

        private List<string> titles = new List<string>()
        {
            "Булочки",
            "Котлета",
            "Сыр",
            "Помидоры",
            "Соус",
            "Огурцы",
            "Конец заказа"
        };

        private List<string> titles_old = new List<string>() { };

        private void Remake()
        {
            foreach (string item in titles)
            {
                titles_old.Add(item);
            }
        }

        DopMenu dop = new DopMenu();
        public void MakeIt()
        {
            Remake();
            while (true)
            {
                Menu(titles, amount, position, description);
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (position > 3)
                        {
                            position--;
                        }
                        else position = 3;
                        break;
                    case ConsoleKey.DownArrow:
                        if (position <= titles.Count + 1)
                        {
                            position++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (page == 0)
                        {
                            switch (position)
                            {
                                case 3:
                                    titles.Clear();
                                    foreach (string bread in dop.bread)
                                    {
                                        titles.Add(bread);
                                    }
                                    page=1;
                                    break;
                                case 4:
                                    titles.Clear();
                                    position = 3;
                                    foreach (string meat in dop.meat)
                                    {
                                        titles.Add(meat);
                                    }
                                    page = 2;
                                    break;
                                case 5:
                                    titles.Clear();
                                    position = 3;
                                    foreach (string chees in dop.chees)
                                    {
                                        titles.Add(chees);
                                    }
                                    page = 3;
                                    break;
                                case 6:
                                    titles.Clear();
                                    position = 3;
                                    foreach (string tomate in dop.tomate)
                                    {
                                        titles.Add(tomate);
                                    }
                                    page = 4;
                                    break;
                                case 7:
                                    titles.Clear();
                                    position = 3;
                                    foreach (string souse in dop.souse)
                                    {
                                        titles.Add(souse);
                                    }
                                    page = 5;
                                    break;
                                case 8:
                                    titles.Clear();
                                    position = 3;
                                    foreach (string pikle in dop.pikles)
                                    {
                                        titles.Add(pikle);
                                    }
                                    page = 6;
                                    break;
                                case 9:
                                    Console.Clear();
                                    NumberOrder();
                                    Print();
                                    Console.WriteLine($"Заказ готов, следующий через 5 секунд" +
                                        $"\nВаш номер: A-{number}\n\nESC для выхода");
                                    amount = 0;
                                    description = "";
                                    Thread.Sleep(5000);
                                    break;
                            }
                        }
                        else if (page > 0)
                        {
                            switch (page)
                            {
                                case 1:
                                    switch (position)
                                    {
                                        case 3:
                                            amount += 20;
                                            description += "белый хлеб, ";
                                            break;
                                        case 4:
                                            amount += 19;
                                            description += "черный хлеб, ";
                                            break;
                                        case 5:
                                            amount += 30;
                                            description += "сырный хлеб, ";
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (position)
                                    {
                                        case 3:
                                            amount += 150;
                                            description += "говядина, ";
                                            break;
                                        case 4:
                                            amount += 160;
                                            description += "курица, ";
                                            break;
                                        case 5:
                                            amount += 200;
                                            description += "соевое мясо, ";
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (position)
                                    {
                                        case 3:
                                            amount += 30;
                                            description += "обычный сыр, ";
                                            break;
                                        case 4:
                                            amount += 50;
                                            description += "Дор блю, ";
                                            break;
                                        case 5:
                                            amount += 70;
                                            description += "колбасный сыр, ";
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (position)
                                    {
                                        case 3:
                                            amount += 15;
                                            description += "большая помидорка, ";
                                            break;
                                        case 4:
                                            amount += 10;
                                            description += "маленькая помидорка, ";
                                            break;
                                        case 5:
                                            amount += 0;
                                            description += "без помидорки, ";
                                            break;
                                    }
                                    break;
                                case 5:
                                    switch (position)
                                    {
                                        case 3:
                                            amount += 10;
                                            description += "кисло-сладкий, ";
                                            break;
                                        case 4:
                                            amount += 10;
                                            description += "кетчуп, ";
                                            break;
                                        case 5:
                                            amount += 10;
                                            description += "сырный, ";
                                            break;
                                    }
                                    break;
                                case 6:
                                    switch (position)
                                    {
                                        case 3:
                                            amount += 5;
                                            description += "1 огурец, ";
                                            break;
                                        case 4:
                                            amount += 10;
                                            description += "2 огурца, ";
                                            break;
                                        case 5:
                                            amount += 0;
                                            description += "без огурца, ";
                                            break;
                                    }
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                        page = 0;
                        position = 3;
                        titles.Clear();
                        foreach (string title in titles_old)
                        {
                            titles.Add(title);
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private void Menu(List<string> titles, int amount, int position, string description)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Заказ бургера в McDonald's");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Выберите параметры бургера");
            Console.WriteLine("--------------------------");
            foreach (string title in titles)
            {
                Console.WriteLine($"  {title}");
            }
            Console.WriteLine($"\nЦена: {amount} Рублей\nВаш бургер: {description}");
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
        }

        private void NumberOrder()
        {
            Random random_num = new Random();
            number = random_num.Next(0, 1000);
        }
        private void Print()
        {
            text_bill = $"\nВремя заказа: {DateTime.Now}\n" +
                $"Номер заказа: A-{number}\n\tЗаказ: {description}\n\tК оплате: {amount} Рублей";
            
            if (File.Exists(path))
            {
                File.AppendAllText(path , text_bill);
            }
            else 
            {
                var bill = File.Create(path);
                bill.Close();
                File.AppendAllText(path, text_bill);
            }
        }
    }
}
