// Andrea Burr
// 10-18-2022
// Mini3 redo - github
Console.Clear();
bool playagain = true;

while (playagain){
    
Console.WriteLine("Hello! What is your name?");
string myName = Console.ReadLine();

Console.WriteLine("Hi " + myName + " what time did you get up this morning?");
string Morning = Console.ReadLine();
Console.WriteLine("After you got up at " + Morning + " what did you do?" );
string Breakfast = Console.ReadLine();
Console.WriteLine("that sounds fun! ttyl");
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}