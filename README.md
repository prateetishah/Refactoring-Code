# Refactoring-Code
Refactor this method as best you can.
public string Foobar(int a, int b) {
int countA = 0;
for (int i = 0; i <= a; i++) {
countA = countA + i; }
string result = "Sum of A: ";
result += string.Format("{0}", countA);
int countB = 0;
for (int j = 0; j <= b; j++) {
countB += j; }
result += "; Sum of B: ";
result += string.Format("{0}", countB);
return result; }
