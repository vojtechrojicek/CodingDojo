# Battle plan version 1.0.0

## 1.1. ReturnNegative

In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?

### Examples

``` C#
Kata.MakeNegative(1);  // return -1
Kata.MakeNegative(-5); // return -5
Kata.MakeNegative(0);  // return 0
```

### Notes

The number can be negative already, in which case no change is required.
Zero (0) is not checked for any specific sign. Negative zeros make no mathematical sense.

## 1.2. What is between?

Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.

### For example

``` C#
a = 1
b = 4
--> [1, 2, 3, 4]
```

## 1.3. DefineCardSuit

You get any card as an argument. Your task is to return the suit of this card (in lowercase).

Our deck (is preloaded):

``` C#
string[] Deck =
{
    "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
    "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
    "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
    "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
};
```

``` C#
DefineSuit("3♣") -> return "clubs"
DefineSuit("3♦") -> return "diamonds"
DefineSuit("3♥") -> return "hearts"
DefineSuit("3♠") -> return "spades"
```

## 2.1. DontGiveMeFive

Don't give me five! In this kata you get the start number and the end number of a region and should return the count of all numbers except numbers with a 5 in it.
The start and the end number are both inclusive!

Examples:

``` C#
1,9 -> 1,2,3,4,6,7,8,9 -> Result 8
4,17 -> 4,6,7,8,9,10,11,12,13,14,16,17 -> Result 12
```

The result may contain fives. ;-)
The start number will always be smaller than the end number. Both numbers can be also negative!

## 2.2. JadenCasingStrings

Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). Jaden is also known for some of his philosophy that he delivers via Twitter.
When writing on Twitter, he is known for almost always capitalizing every word.
For simplicity, you'll have to capitalize each word, check out how contractions are expected to be in the example below.

Your task is to convert strings to how they would be written by Jaden Smith.
The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

Example:

``` C#
Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
```

## 2.3. CreditCardMask

Usually when you buy something, you're asked whether your credit card number,
phone number or answer to your most secret question is still correct. However, since someone
could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.

Examples:

``` C#
"4556364607935616" --> "############5616"
        "64607935616" -->      "#######5616"
                "1" -->                "1"
                "" -->                 ""

// "What was the name of your first pet?"

"Skippy" --> "##ippy"

"Nananananananananananananananana Batman!"
-->
"####################################man!"
```

## 2.4. BinaryAddition

Implement a function that adds two numbers together and returns their sum in binary.
The conversion can be done before, or after the addition.

The binary number returned should be a string.

``` C#
Examples:(Input1, Input2 --> Output (explanation)))

1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)
```

## 2.5. PrinterErrors

In a factory a printer prints labels for boxes.
For one kind of boxes the printer has to use colors which,
for the sake of simplicity, are named with letters from a to m.

The colors used by the printer are recorded in a control string.
For example a "good" control string would be aaabbbbhaijjjm meaning
that the printer used three times color a, four times color b,
one time color h then one time color a...

Sometimes there are problems: lack of colors, technical
malfunction and a "bad" control string is produced e.g. aaaxbbbbyyhwawiwjjjwwm
with letters not from a to m.

You have to write a function printer_error which given a string
will return the error rate of the printer as a string representing
a rational whose numerator is the number of errors and the denominator
the length of the control string. Don't reduce this fraction to a simpler expression.

The string has a length greater or equal to one and contains only letters from ato z.

``` C#
Examples:
s="aaabbbbhaijjjm"
printer_error(s) => "0/14"

s="aaaxbbbbyyhwawiwjjjwwm"
printer_error(s) => "8/22"
```

## 2.6. TwoToOne

Take 2 strings s1 and s2 including only letters from ato z.
Return a new sorted string, the longest possible,
containing distinct letters - each taken only once - coming from s1 or s2.

``` C#
Examples:
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"
```

## 3.1. PersistentBugger

Write a function, persistence, that takes in a positive
parameter num and returns its multiplicative persistence,
which is the number of times you must multiply the digits in num until you reach a single digit.

``` C#
For example (Input --> Output):

39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
4 --> 0 (because 4 is already a one-digit number)
```

## 3.2. LonelyFrog

You are a lonely frog.

You live on a coordinate axis.

The meaning of your life is to jump and jump..

Two actions are allowed:

forward: Move forward 1 unit.

double: If you at x point, then you can move to x*2 point.

Now, here comes your new task. Your starting point is x, the target point is y.

You need to jump to the target point with minimal steps.
Please tell me, what's the minimal steps?

1 <= x <= 10, x < y <= 100000

Example

``` C#
For x = 1, y = 8, the output should be 3.

step  from   to      action
1:     1 --> 2     forward(or double)
2:     2 --> 4       double
3:     4 --> 8       double
```

``` C#
For x = 1, y = 17, the output should be 5.

step  from    to      action
1:     1  --> 2     forward(or double)
2:     2  --> 4       double
3:     4  --> 8       double
4:     8  --> 16      double
5:     16 --> 17     forward
```

``` C#
For x = 1, y = 15, the output should be 6.

step  from    to      action
1:     1  --> 2      forward(or double)
2:     2  --> 3      forward
3:     3  --> 6      double
5:     6  --> 7      forward
6:     7  --> 14     double
7:     14 --> 15     forward
```

```C#
For x = 3, y = 12, the output should be 2.

step  from    to       action
1:     3  --> 6       double
2:     6  --> 12      double

```

```C#
For x = 3, y = 16, the output should be 3.

step  from    to       action
1:     3  --> 4      forward
2:     4  --> 8       double
3:     8  --> 16      double
```
