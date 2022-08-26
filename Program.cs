using System;
using System.Collections.Generic;



//Directs the entire program
void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    MagicMooseQuestions();
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

//Makes the random numbers happen.
int GetRandomNumber()
{
    Random r = new Random();
    int fortuneNumber = r.Next(0, 20);
    return fortuneNumber;
}

//The list of different fortunes to iterate thru
List<string> listOfFortunes = new List<string> {
"As I see it, yes",
"Ask again later",
"Better not tell you now",
"Cannot predict now",
"Concentrate and ask again",
" Don’t count on it",
"It is certain",
"It is decidedly so",
"Most Likely",
"My reply is no",
"My sources say no",
"Outlook not so good",
"Outlook good",
"Reply Hazy, try again",
"Signs point to Yes",
"Very Doubtful",
"Without a doubt",
"Yes",
"Yes - Definitely",
"You may rely on it"
};


//This will recieve the question and give a canned response
string FeelHeard()
{
    Console.WriteLine("My Question:");
    string question = Console.ReadLine();
    if (question == "exit")
    {
        string fortune = "exit";
        return fortune;
    }
    else
    {
        string myfortune = Reply();
        return myfortune;
    }
}

string Reply()
{
    string fortune = listOfFortunes[GetRandomNumber() + 1];
    Console.WriteLine(fortune);
    return fortune;
}


//This will allow for many questions to be asked until the user no loner wants to ask questions
void MagicMooseQuestions()
{
    string response = "";
    do
    {
        MooseSays("Ask me a question and recieve my Wisdom or leave my presence by typing 'exit'");
        response = FeelHeard();
        Console.WriteLine("Push enter to proceed");
        string ReadyToProceedFeedBack = Console.ReadLine();
    }
    while (response != "exit");
}
Main();