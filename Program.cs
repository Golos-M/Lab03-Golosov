Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200;
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05; // начисление 5% процентов
Console.WriteLine($"После пополнения на 500: {balance}");

balance /= 2;
Console.WriteLine($"После деления пополам: {balance}");

Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");

int lessonNumber = 1;
Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
Console.WriteLine($"После это lessonNumber = {lessonNumber}");

int weekNumber = 1;
Console.WriteLine($"++weekNumber выводит: {++lessonNumber}");
Console.WriteLine($"После это weekNumber = {weekNumber}");

Console.WriteLine();
Console.WriteLine("Практическая ловушка");

int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");

Console.WriteLine();
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;

bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");


Console.WriteLine();
Console.WriteLine("Логические операторы");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;

Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");


Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value) {
    Console.WriteLine($"Вычисляется: {label}");
    return value;
}

Console.WriteLine("Проверяем && (первый операнд false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true):");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {resultOr}");

Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4 = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4 = {resultWithParens}");

bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5>3 && 2<4 || false = {logicResult}");
Console.WriteLine($"(5>3 && 2<4) || false = {logicResultParens}");

Console.WriteLine();
Console.WriteLine("Приёмная комиссия");

Console.Write("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);

// TODO 1: hasGoodCertificate = true, если averageGrade >= 4.0
bool hasGoodCertificate = averageGrade >= 4.0;

// TODO 2: hasGoodExam = true, если examScore >= 60
bool hasGoodExam = examScore >= 60;

// TODO 3: isEligibleByRules = true, если (hasGoodCertificate И hasGoodExam) ИЛИ hasBenefit
bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// TODO 4: итоговый балл = средний балл * 10, а затем прибавьте баллы экзамена
double totalScore = averageGrade * 10;
totalScore += examScore;

Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");



Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine(isEven);



int x = 5;

int result1 = ++x + 3; 
x = 5;
int result2 = x++ + 3; 
x = 5;
int y = 10;
int result3 = ++x + y++; 

Console.WriteLine($"Результат 1 (++x + 3): {result1}, x = {x}");
Console.WriteLine($"Результат 2 (x++ + 3): {result2}, x = {x}");
Console.WriteLine($"Результат 3 (++x + y++): {result3}, x = {x}, y = {y}");



Console.Write("Введите сумму покупки: ");
double purchaseAmount = double.Parse(Console.ReadLine());
Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
bool hasLoyaltyCard = int.Parse(Console.ReadLine()) == 1;
Console.Write("Введите количество товаров в чеке: ");
int itemCount = int.Parse(Console.ReadLine());
bool condition1 = purchaseAmount >= 3000;
bool condition2 = itemCount >= 3;
bool condition3 = hasLoyaltyCard;
bool eligibleForDiscount = (condition1 && condition2) || condition3;

Console.WriteLine($"Сумма >= 3000: {condition1}");
Console.WriteLine($"Товаров >= 3: {condition2}");
Console.WriteLine($"Есть карта клиента: {condition3}");
Console.WriteLine($"Право на скидку: {eligibleForDiscount}");