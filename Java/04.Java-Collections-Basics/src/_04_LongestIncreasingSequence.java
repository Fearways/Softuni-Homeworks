import java.util.ArrayList;
import java.util.Scanner;

public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String line = input.nextLine();
		input.close();
		String[] numbersStrings = line.split(" ");
		int[] numbers = new int[numbersStrings.length];
		for (int i = 0; i < numbers.length; i++) {
			numbers[i] = Integer.parseInt(numbersStrings[i]);
		}
		ArrayList<ArrayList<Integer>> sequences = new ArrayList<>();
		ArrayList<Integer> sequence = new ArrayList<>();
		sequence.add(numbers[0]);
		for (int i = 1; i < numbers.length; i++) {

			if (numbers[i] > numbers[i - 1]) {
				sequence.add(numbers[i]);
			} else {
				sequences.add(sequence);
				sequence = new ArrayList<>();
				sequence.add(numbers[i]);
			}
		}
		sequences.add(sequence);
		for (ArrayList<Integer> seq : sequences) {
			for (Integer integer : seq) {
				System.out.print(integer + " ");
			}
			System.out.println();
		}
		ArrayList<Integer> longest = new ArrayList<>();
		for (int i = 1; i < sequences.size(); i++) {
			if (sequences.get(i).size() > sequences.get(i - 1).size()) {
				longest = sequences.get(i);
			}
		}
		System.out.print("Longest: ");
		for (Integer integer : longest) {
			System.out.print(integer + " ");
		}
	}
}