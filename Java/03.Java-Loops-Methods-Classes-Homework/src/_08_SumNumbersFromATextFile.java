import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class _08_SumNumbersFromATextFile {

	public static void main(String[] args) {
		BufferedReader reader;
		int sum = 0;
		try {
			reader = new BufferedReader(new FileReader("input.txt"));
			try {
				String line = reader.readLine();
				while (line != null) {
					if(!line.equals("")){
					sum += Integer.parseInt(line);
					}
					line = reader.readLine();
				}
			} 
			catch (IOException e) {
				e.printStackTrace();
			}
			try {
				reader.close();
			} 
			catch (IOException e) {
				e.printStackTrace();
			}
			System.out.println(sum);
		} 
		catch (FileNotFoundException e) {
			System.out.println("Error");
		}
	}
}