# BlockResults


Вам представлен программа  по преобразованию первоначального массива строк, в массив из строк длинной не больше 3 символов.


**Программа состоит из трех частей**

1. Создается первоначальный массив.
2. На основании первоначального массива формируется конечный массив.
3. Оба массива выводятся на печать.


**1. Первоначальный массив** создается с помощю подпрограммы *" Element By Element Array Creation "* где задается размера массива и последовательно вводится каждый его элемент, используется любая последовательность любых символов.
~~~
string[] ElementByElementArrayCreation(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
~~~

**2. Конечный массив** формируется подпрограммой *" Sorting Three Char Elements Array "*, который является основой всей программы
~~~
string[] SortingThreeCharElementsArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++ )
~~~

**3. Печать** осуществляется с омощю подпрограммы *Print Array*
~~~
void PrintArray(string[] array, string message)
{
~~~

**Вы также можете** найти блок схему программы пройдя по ссылке - https://drive.google.com/file/d/1aeJb4imtrExmLamCML3npJRPfo8qqorr/view?usp=sharing

