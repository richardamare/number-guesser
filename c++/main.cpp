//
//  main.cpp
//  number-guesser
//
//  Created by Richard Amare on 4/25/22.
//

#include <iostream>
#include <string>
using namespace std;


int main(int argc, const char * argv[]) {
    string appName = "Number Guesser";
    string appVersion = "1.0.0";
    string appAuthor = "Richard Amare";
    
    cout << appName << ": Version " << appVersion << " by " << appAuthor << endl;
    
    string name;
    
    cout << "What's your name?" << endl;
    cin >> name;
    
    cout << "Hello, " << name << endl;
    
    int correctNumber = rand() % 10 + 1;
    int guess = 0;
    int numberOfGuesses = 0;
    
    cout << "Guess a number between 1 and 10" << endl;
    
    while (guess != correctNumber) {
        int current;
        cin >> current;
        guess = current;
        numberOfGuesses += 1;
        if (guess != correctNumber) {
            cout << "Wrong number, please try again" << endl;
        }
    }
    
    cout << "Congratulations, you won! It took you " << numberOfGuesses << " guesses" << endl;
    
    return 0;
}
