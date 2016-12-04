Problem 4 – Calculation Problem
-------------------------------

At long last scientist found out that the cats have an evil plan to enslave all of humanity. The sinister organization **Al cat-qaeda** have been targeting high profile programmers and taking them down (a.k.a brutally murdering them), because they are the only ones that can ruin their plans.

“But why programmers?” you would ask, because they are the only ones that can write a program to crack their communication codes. They are using a **23**-based numeral system in order to fool everyone that they are stupid and harmless beings. The digits go as following:

| a   | b   | c   | d   | …   | j   | k   | …   | w   |
|-----|-----|-----|-----|-----|-----|-----|-----|-----|
| 0   | 1   | 2   | 3   | …   | 9   | 10  | …   | 22  |

Your task is to help the global programmer community. You will receive a set on letter-numbers (strings) on one line separated with a single space ‘ ‘. Sum all of the letter-numbers and print out the resulting sum both in the **23**-based system and decimal system as shown in the examples.

### Input

The input data should be read from the console.

The input data consists of a single string that needs to be split.

The input data will always be valid and in the format described. There is no need to check it explicitly.

### Output

The output data should be printed on the console.

Print out the sum of the given numbers in the format **“\[sum in 23-base numeral system\] = \[sum in decimal system\]**”.

### Constraints

-   The number of letters-numbers will be between 1 and 10, inclusive.

-   All of the given letter-numbers will consist of small characters.

-   None of the letter-numbers will start with an ‘a’.

-   The sum will always be between 0 and 2 147 483 647.

-   Allowed working time for your program: 0.1 seconds.

-   Allowed memory: 16 MB.

### Examples

<table>
<tbody>
<tr class="odd">
<td><strong>Example input</strong></td>
<td><strong>Example output</strong></td>
<td><strong>Explanation</strong></td>
</tr>
<tr class="even">
<td>mia</td>
<td>mia = 6532</td>
<td>mia = [12][8][0] = 12 * 23 * 23 + 8 * 23 + 0 * 1 =<br />
= 6348 + 184 + 0 = 6532</td>
</tr>
<tr class="odd">
<td>grrrr miao miao</td>
<td>htksw = 2195786</td>
<td><p>grrrr = … = 1895286<br />
miao = … = 150250<br />
miao = … = 150250</p>
<p>resulting sum =&gt; htksw = 2195786</p></td>
</tr>
</tbody>
</table>


