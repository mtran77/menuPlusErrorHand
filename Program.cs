//Base template for programs with menu and error handling 

Console.Clear();
//outputs menu and gets user input
int userInput = GetMenuInput();

while (userInput != 4){
    // Decides what to do with user input
    MainMenuSelection(userInput);
    //outputs menu and gets user input after decision has already been made
    userInput = GetMenuInput();
}
//-----------main

static int GetMenuInput(){
    System.Console.WriteLine("1. Password Cracker\n2. Spin the Wheel\n3. Interrogation\n4. Exit");
    return int.Parse(Console.ReadLine());
}

static void MainMenuSelection(int userInput) {
    if (userInput == 1){
        System.Console.WriteLine("1");
    } else if (userInput == 2) {
        System.Console.WriteLine("2");
    } else if (userInput == 3) {
        System.Console.WriteLine("3");
    }else {
        DisplayError();
        Continue(); //Clears the screen after an error has been made 
    }

}


//* quality of life functions
static void DisplayError(){
    System.Console.WriteLine("Choose a valid option");
}
static void Continue(){
    Header();
    System.Console.WriteLine("Press any key to continue");
    Header();
    Console.ReadKey();
    Console.Clear();
}

static void Header (){
    Console.WriteLine("==================");
}