import random

app_name = "Number Guesser"
app_version = "1.0.0"
app_author = "Richard Amare"

print(app_name + ": Version " + app_version + " by " + app_author)

name = input("What's your name?\n")
print(f"Hello, {name}")

corrent_number = random.randint(1, 10)
guess = 0
num_of_guesses = 0

print("Guess a number between 1 and 10")

while (guess != corrent_number):
  current_guess = int(input())
  guess = current_guess
  num_of_guesses += 1

  if (guess != corrent_number):
    print("Wrong, number, please try again")

print(f"Congratulations, you won! It took you {num_of_guesses} guesses.")