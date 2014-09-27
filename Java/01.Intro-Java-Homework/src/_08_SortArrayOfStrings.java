import java.util.Arrays;
import java.util.Scanner;

public class _08_SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		String[] allWords = new String[n];
		for (int i = 0; i < n; i++) {
			allWords[i] = input.next();
		}
		input.close();
		Arrays.sort(allWords);
		for (int i = 0; i < n; i++) {
			System.out.println(allWords[i]);
		}
	}
}