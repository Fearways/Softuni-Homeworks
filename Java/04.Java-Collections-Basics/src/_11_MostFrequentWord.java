import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] text = input.nextLine().toLowerCase()
				.split("([().,!?:;'\"-]|\\s)+");
		input.close();
		Map<String, Integer> wordsCount = new TreeMap<String, Integer>();
		int maxCount = 0;
		for (String word : text) {
			Integer count = wordsCount.get(word);
			if (count == null) {
				count = 0;
			}
			if (count + 1 > maxCount) {
				maxCount = count + 1;
			}
			wordsCount.put(word, count + 1);
		}

		for (Map.Entry<String, Integer> max : wordsCount.entrySet()) {
			if (max.getValue() == maxCount) {
				System.out.printf("%s -> %d times\n", max.getKey(),
						max.getValue());
			}
		}
	}
}