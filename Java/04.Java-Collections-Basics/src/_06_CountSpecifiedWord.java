import java.util.Scanner;

public class _06_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		String word = input.next();
		input.close();
		String[] words = text.split("([().,!?:;'\"-]|\\s)+");
		int count = 0;
		for (String currentWord : words) {
			if (currentWord.equalsIgnoreCase(word)) {
				count++;
			}
		}
		System.out.println(count);
	}
}