import java.util.Scanner;

public class _07_CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine().toLowerCase();
		String subString = input.next().toLowerCase();
		input.close();
		int count = count(text, subString);
		System.out.println(count);
	}

	public static int count(String string, String substring) {
		int count = 0;
		int idx = 0;
		while ((idx = string.indexOf(substring, idx)) != -1) {
			idx++;
			count++;
		}
		return count;
	}
}