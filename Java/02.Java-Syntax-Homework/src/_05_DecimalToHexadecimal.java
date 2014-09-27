import java.util.Scanner;

public class _05_DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int nInDecimal = input.nextInt();
		input.close();
		String nInHexadecimal = Integer.toHexString(nInDecimal).toUpperCase();
		System.out.println(nInHexadecimal);
	}
}