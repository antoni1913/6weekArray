string userName = "antoni Darth Vader";

Console.WriteLine(userName.Length);

Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}.");

string updaterUserName = userName.Replace('a', '4');

Console.WriteLine(updaterUserName);

string hello = "Hello, world!".
ToLower
();
int counter = 0;
for (int i = 0; i <
hello.Length
; i++)
{
    if (
hello
[i] == 'l')
    {

        counter
        ++;
    }
}
Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");
//