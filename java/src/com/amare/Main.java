package com.amare;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
	    String appName = "Number Guesser";
        String appVersion = "1.0.0";
        String appAuthor = "Richard Amare";

        System.out.println(String.format("%s: Version %s by %s" , appName, appVersion, appAuthor));

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        System.out.println("What's your name?");
        String name = reader.readLine();

        System.out.println("Hello, " + name);

        int correctNumber = (int) (Math.random() * 10);
        int guess = 0;
        int numberOfGuesses = 0;

        System.out.println("Guess a number between 1 and 10");

        while (guess != correctNumber) {
            String input = reader.readLine();
            guess = Integer.parseInt(input);
            numberOfGuesses++;

            if (guess != correctNumber) {
                System.out.println("Wrong number, please try again");
            }
        }

        System.out.println("Congratulations, you won! It took you " + numberOfGuesses + " guesses");

    }
}
