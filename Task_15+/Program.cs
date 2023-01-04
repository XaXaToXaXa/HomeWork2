// Вариат календаря
Console.WriteLine("Введите целое число от 1 до 365");
int inPutDate = int.Parse(Console.ReadLine());
void Calculate(int date)
{
    switch (date)
    {
        case int day when day >= 1 && day <= 31:
            Console.WriteLine($"{date} января 2023, ");
            break;
        case int day when day >= 32 && day <= 59:
            Console.WriteLine($"{date - 31} февраля 2023, ");
            break;
        case int day when day >= 60 && day <= 90:
            Console.WriteLine($"{date - 59} марта 2023, ");
            break;
        case int day when day >= 91 && day <= 120:
            Console.WriteLine($"{date - 90} апреля 2023, ");
            break;
        case int day when day >= 121 && day <= 151:
            Console.WriteLine($"{date - 120} мая 2023, ");
            break;
        case int day when day >= 152 && day <= 181:
            Console.WriteLine($"{date - 151} июня 2023, ");
            break;
        case int day when day >= 182 && day <= 212:
            Console.WriteLine($"{date - 181} июля 2023, ");
            break;
        case int day when day >= 213 && day <= 243:
            Console.WriteLine($"{date - 212} августа 2023, ");
            break;
        case int day when day >= 244 && day <= 273:
            Console.WriteLine($"{date - 243} сентября 2023, ");
            break;
        case int day when day >= 274 && day <= 303:
            Console.WriteLine($"{date - 273} октября 2023, ");
            break;
        case int day when day >= 304 && day <= 334:
            Console.WriteLine($"{date - 303} ноября 2023, ");
            break;
        case int day when day >= 335 && day <= 365:
            Console.WriteLine($"{date - 334} декабря 2023, ");
            break;
        default:
            Console.WriteLine("Введено не верное число");
            break;
    }
}
void Week(int date)
{
    if (date > 7) 
    {
        switch (date % 7)
        {
            case 1:
                Console.WriteLine("И это будет воскресенье!");
                break;
            case 2:
                Console.WriteLine("И это будет понедельник!");
                break;
            case 3:
                Console.WriteLine("И это будет вторник!");
                break;
            case 4:
                Console.WriteLine("И это будет среда!");
                break;
            case 5:
                Console.WriteLine("И это будет четверг!");
                break;
            case 6:
                Console.WriteLine("И это будет пятница!");
                break;
            case 0:
                Console.WriteLine("И это будет суббота!");
                break;
        }
    }
    else
    {
        switch (date)
        {
            case 1:
                Console.WriteLine("И это будет воскресенье!");
                break;
            case 2:
                Console.WriteLine("И это будет понедельник!");
                break;
            case 3:
                Console.WriteLine("И это будет вторник!");
                break;
            case 4:
                Console.WriteLine("И это будет среда!");
                break;
            case 5:
                Console.WriteLine("И это будет четвер!");
                break;
            case 6:
                Console.WriteLine("И это будет пятница!");
                break;
            case 7:
                Console.WriteLine("И это будет суббота!");
                break;
        }
    }
}
Calculate(inPutDate);
Week (inPutDate);