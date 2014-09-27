import java.util.Scanner;

public class _06_SumTwoNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		int b = input.nextInt();
		input.close();
		System.out.println(a+b);
	}
}