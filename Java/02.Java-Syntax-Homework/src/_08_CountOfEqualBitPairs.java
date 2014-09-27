import java.util.Scanner;

public class _08_CountOfEqualBitPairs {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		input.close();
		int pairs = 0;
		int firstBit = number & 1;
		number >>= 1;
		while (number > 0) {
			int bit = number & 1;
			if (firstBit == bit) {
				pairs++;
			}
			firstBit = bit;
			number >>= 1;
		}
		System.out.println(pairs);
	}
}