import java.util.Scanner;

public class _09_PointsInsideTheHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		input.close();
		double Ax = 12.5;
		double Ay = 8.5;
		double Bx = 22.5;
		double By = 8.5;
		double Cx = 17.5;
		double Cy = 3.5;
		double ab = ((Ax - Bx) * (y - By) - (Ay - By) * (x - Bx));
		double ac = ((Cx - Ax) * (y - Ay) - (Cy - Ay) * (x - Ax));
		double cb = ((Bx - Cx) * (y - Cy) - (By - Cy) * (x - Cx));
		boolean insideFirstCube = y >= 8.5 && y <= 13.5 && x >= 12.5 && x <= 17.5;
		boolean insideSecondCube = y >= 8.5 && y <= 13.5 && x >= 20 && x <= 22.5;
		if (ab >= 0 && ac >= 0 && cb >= 0 || insideFirstCube || insideSecondCube) {
			System.out.println("Inside");
		} 
		else {
			System.out.println("Outside");
		}
	}
}