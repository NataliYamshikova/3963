System.Random numSintezator = new System.Random();

//Вариант1
//int rngNumber = numSintezator.Next(10,100); //метод который на даст йелое число от 10 до 99
//Console.WriteLine(rngNumber); // увидим это число в терминате
//int firstNum= rngNumber/10;
//int secondNum = rngNumber%10;

//if (firstNum>secondNum)
//{
  //  Console.WriteLine("Первое число больше " +firstNum+ "вторго " +secondNum);
//}
//else
//{
  //  Console.WriteLine(secondNum);
//}

//Вариант 2
//char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
//Console.WriteLine(digits);
//int firstNumber = ((int)digits[0])-48;
//int secondNumber = ((int) digits[1]-48);
//Тернарный оператор 
// переменная = (условие)? значение1 : значение 2 : заменяет консттрукцию if else
//int resultNumber =(firstNumber>secondNumber)? resultNumber = firstNumber:resultNumber=secondNumber;
//Console.WriteLine (resultNumber);

//Вариант 3
//заполнили сразу все значение массива
