import java.util.Scanner;

public class _02_Generate3LetterWords {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);
		String stringInput = input.next();
		char[] givenLetters = stringInput.toCharArray();
		input.close();
		findCombinations(givenLetters, "");
	}

	public static void findCombinations(char[] givenLetters, String s) {

		if (s.length() == 3) {
			System.out.println(s);

		} 
		else {
			for (int i = 0; i < givenLetters.length; i++) {
				String oldCurr = s;
				s += givenLetters[i];
				findCombinations(givenLetters, s);
				s = oldCurr;
			}
		}
	}
}