# CamelCase Problem
## Problem

There is a sequence of words in CamelCase as a string of letters,
**_s_**, having the following properties:

- It is a concatenation of one or more words consisting of English
  letters.

- All letters in the first word are lowercase.

- For each of the subsequent words, the first letter is uppercase and
  rest of the letters are lowercase.

Given **_s_**, determine the number of words in
**_s_**.

## Example

##### **_s_** = "oneTwoThree"

There are _3_ words in the string:
’one’, ’Two’, ’Three’.

## Function Description

Complete the camelcase function in the editor below.

camelcase has the following parameter(s):

- string s: the string to analyze

## Returns

- int: the number of words in **_s_**

## Input Format

A single line containing string **_s_**.

## Constains

1 <= length of s <= 10^5

## Sample Input

        saveChangesInTheEditor

## Sample Output

        5

## Explanation

String **_s_** contains five words:

1. save

2. Changes

3. In

4. The

5. Editor
---
# Caesar Cipher Problem
Julius Caesar protected his confidential information by encrypting it using a cipher. Caesar's cipher shifts
each letter by a number of letters. If the shift takes you past the end of the alphabet, just rotate back to
the front of the alphabet. In the case of a rotation by 3, w, x, y and z would map to z, a, b and c

    Original alphabet: abcdefghijklmnopqrstuvwxyz
    Alphabet rotated +3: defghijklmnopqrstuvwxyzabc

For example, the given cleartext ***s = There's-a-starman-waiting-in-the-sky*** and the alphabet is
rotated by ***k=3*** The encrypted string is ***Wkhuh'v-d-vwdupdq-zdlwlqj-lq-wkh-vnb***
**Note:** The cipher only encrypts letters; symbols, such as -, remain unencrypted.

## Function Description
Complete the caesarCipher function in the editor below. It should return the encrypted string.
caesarCipher has the following parameter(s):
- s: a string in cleartext
- k: an integer, the alphabet rotation factor

## Input Format 
The first line contains the integer, , the length of the unencrypted string.
The second line contains the unencrypted string, .
The third line contains , the number of letters to rotate the alphabet by.

## Constraints
- ***1 <= n <= 100***
- ***0 <= k <= 100***
***s*** is a valid ASCII string without any spaces

## Output Format
For each test case, print the encoded string.

## Sample Input
    11
    middle-Outz
    2

## Sample Output
    okffng-Qwvb

## Explanation
    Original alphabet: abcdefghijklmnopqrstuvwxyz
    Alphabet rotated +2: cdefghijklmnopqrstuvwxyzab
    m -> o
    i -> k
    d -> f
    d -> f
    l -> n
    e -> g
    - -
    O -> Q
    u -> w
    t -> v
    z -> b