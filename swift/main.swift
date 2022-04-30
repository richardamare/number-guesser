let appName = "Number Guesser"
let appVersion = "1.0.0"
let appAuthor = "Richard Amare"

print("\(appName): Version \(appVersion) by \(appAuthor)")

print("What's your name?")

let name = readLine() ?? ""

print("Hello, \(name)")

var correctNumber = Int.random(in: 1...10)
var guess = 0
var numOfGuesses = 0

print("Guess a number between 1 and 10")

while guess != correctNumber {
  let current = readLine() ?? ""
  guess = Int(current) ?? 0
  numOfGuesses += 1
  
  if (guess != correctNumber) {
    print("Wrong number, please try again")
  }
}

print("Congratulations, you won! It took you \(numOfGuesses) guesses.")