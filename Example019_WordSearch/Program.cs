// Перебор слов (слово из 1 буквы)
// итеративный подход
/*
char[] s = { 'a', 'и', 'c', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++,-5}{s[i]}");
}


// Перебор слов (слово из 2 букв)

char[] s = { 'a', 'и', 'c', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}


// Перебор слов (слово из 5 букв)

char[] s = { 'a', 'и', 'c', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }
    }
}
*/

// рекурсия

int n = 1;
void FindWords(string alpabet, char[] word, int length = 0)// метод принимает строкой алфавит "аисв",
{                                                          // массив из букв, которые будут составлять новое слово
    if (length == word.Length)                             // длинна слова (на итерации рекурсии)
    {
        Console.WriteLine($"{n++} {new String(word)}");     // условие выхода из рекурсии
        return;
    }
    for (int i = 0; i < alpabet.Length; i++)               // иначе в цикле собирается новое слово
    {
        word[length] = alpabet[i];
        FindWords(alpabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);