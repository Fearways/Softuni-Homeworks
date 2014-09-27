import java.util.Scanner;

public class _01_SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int start = input.nextInt();
		int end = input.nextInt();
		input.close();
		for (int i = start; i <= end; i++) {
			if (i <= 11) {
				System.out.print(i + " ");
			} 
			else if (i > 11 && i < 100) {
				if (i % 10 == i / 10) {
					System.out.print(i + " ");
				}
			} 
			else if (i >= 100) {
				if (i % 10 == i / 100) {
					System.out.print(i + " ");
				}
			}
		}
		System.out.println();
	}
}