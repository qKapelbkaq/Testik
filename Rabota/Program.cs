//вар 8
dynamic Smena = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите название смены:");
Smena.Nazvanie = Console.ReadLine() ?? "Название смены не указано";

//вар 7
dynamic Para = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите время начала пары:");
Para.Nachalo = Console.ReadLine() ?? "Время начала пары не указано";
Console.WriteLine("Введите время окончания пары:");
Para.Okonch = Console.ReadLine() ?? "Время окончания пары не указано";
Console.WriteLine("Введите время начала перерыва:");
Para.PererivNach = Console.ReadLine() ?? "Время начала перерыва не указано";
Console.WriteLine("Введите время окончания перерыва:");
Para.PererivOkonch = Console.ReadLine() ?? "Время окончания перерыва не указано";
Para.Smena = Smena;

//Заглушка
dynamic Podrazd = new System.Dynamic.ExpandoObject();
Podrazd.Pod = "";

//вар 10
dynamic Doljnost = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите название должности:");
Doljnost.Nazvanie = Console.ReadLine() ?? "Должность не указана";
Console.WriteLine("Введите оклад:");
Doljnost.Oklad = Console.ReadLine() ?? "Оклад не указан";
Doljnost.Podrazd = Podrazd;

//вар 9
dynamic Sotrudnik = new System.Dynamic.ExpandoObject();
Console.WriteLine("Введите фамилию:");
Sotrudnik.Familia = Console.ReadLine() ?? "Фамалия не указана";
Console.WriteLine("Введите имя:");
Sotrudnik.Imia = Console.ReadLine() ?? "Имя не указано";
Console.WriteLine("Введите отчество:");
Sotrudnik.Otchestvo = Console.ReadLine() ?? "Отчество не указано";
Sotrudnik.Doljnost = Doljnost;






