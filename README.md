# GBTest
Просим пользователя ввести целое число, записываем его в переменную n - это размер массива

Далее пользователь вводит значения массива в количестве, указанном ранее

Цикл for собирает массив myArray, конвертируя значения в строку

метод SecondArray принимает на вход 2 аргумента: наш myArray и array2, который будет состоять из значений массива myArray, не превышающих или равных трем знакам.

Цикл for проходит по каждому элементу myArray через условие, проверяющее размер каждого элемента. Подходящие элементы записываются в переменную count

метод ShowArray показывает нам наш массив в консоли

Вызываем метод и смотрим на результат
Console.WriteLine(myArray);
SecondArray(myArray, array2);
ShowArray(array2);