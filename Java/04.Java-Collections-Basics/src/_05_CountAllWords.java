import java.util.Scanner;

public class _05_CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String text = input.nextLine();
		input.close();
		String[] words = text.split("([().,!?:;'\"-]|\\s)+");
		System.out.println();
		System.out.println(words.length);
	}
}