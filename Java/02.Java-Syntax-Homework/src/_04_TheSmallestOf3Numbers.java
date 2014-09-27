import java.util.Scanner;

public class _04_TheSmallestOf3Numbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double a = input.nextDouble();
		double b = input.nextDouble();
		double c = input.nextDouble();
		input.close();
		System.out.print(Math.min(a, Math.min(b, c)));
	}
}