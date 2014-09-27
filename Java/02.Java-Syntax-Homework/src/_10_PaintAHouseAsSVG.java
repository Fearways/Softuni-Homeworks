import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Font;
import java.awt.Shape;
import java.awt.Stroke;
import java.awt.geom.Ellipse2D;
import java.awt.geom.Path2D;
import java.awt.geom.Rectangle2D;
import java.io.File;
import java.io.IOException;
import java.util.Scanner;
import org.jfree.graphics2d.svg.*;

public class _10_PaintAHouseAsSVG {
	public static SVGGraphics2D background = new SVGGraphics2D(290, 290);

	public static void main(String[] args) {
		String resultFile = "House.html";
		double x = 0;
		double y = 0;
		double[] xpoints = new double[3];
		double[] ypoints = new double[3];
		xpoints[0] = 12.5 * 10;
		xpoints[1] = 22.5 * 10;
		xpoints[2] = 17.5 * 10;
		ypoints[0] = 8.5 * 10;
		ypoints[1] = 8.5 * 10;
		ypoints[2] = 3.5 * 10;
		Shape firstBox = new Rectangle2D.Double(12.5 * 10, 8.5 * 10, 5 * 10, 5 * 10);
		Shape secondBox = new Rectangle2D.Double(20 * 10, 8.5 * 10, 2.5 * 10, 5 * 10);
		Path2D triangle = new Path2D.Double();
		triangle.moveTo(xpoints[0], ypoints[0]);
		for (int i = 1; i < xpoints.length; ++i) {
			triangle.lineTo(xpoints[i], ypoints[i]);
		}
		triangle.lineTo(xpoints[0], ypoints[0]);
		triangle.closePath();
		background.setColor(new Color(191, 191, 191));
		background.fill(firstBox);
		background.fill(secondBox);
		background.fill(triangle);
		background.setColor(new Color(0, 25, 92));
		background.draw(firstBox);
		background.draw(secondBox);
		background.draw(triangle);
		drawGrid();
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		for (int i = 0; i < n; i++) {
			x = input.nextDouble();
			y = input.nextDouble();
			double ab = ((12.5 - 22.5) * (y - 8.5) - (8.5 - 8.5) * (x - 22.5));
			double ac = ((17.5 - 12.5) * (y - 8.5) - (3.5 - 8.5) * (x - 12.5));
			double cb = ((22.5 - 17.5) * (y - 3.5) - (8.5 - 3.5) * (x - 17.5));
			boolean insideFirstCube = y >= 8.5 && y <= 13.5 && x >= 12.5 && x <= 17.5;
			boolean insideSecondCube = y >= 8.5 && y <= 13.5 && x >= 20 && x <= 22.5;
			if (ab >= 0 && ac >= 0 && cb >= 0 || insideFirstCube || insideSecondCube) {
				_10_PaintAHouseAsSVG.drawPoint(Color.black, x, y);
			} 
			else {
				_10_PaintAHouseAsSVG.drawPoint(new Color(191, 191, 191), x, y);
			}
		}
		input.close();
		try {
			org.jfree.graphics2d.svg.SVGUtils.writeToHTML(new File(resultFile), "House", background.getSVGElement());
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	public static void drawGrid() {
		int haight = 35;
		int width = 100;
		background.setFont(new Font("arial", Font.PLAIN, 8));
		Stroke s = new BasicStroke(0.3f,
				BasicStroke.CAP_SQUARE,
				BasicStroke.JOIN_MITER,
				10.0f,
				new float[] { 1.0f, 1.0f },
				0.0f);
		background.setStroke(s);
		for (int rows = 0; rows < 6; rows++) {
			background.setColor(Color.black);
			background.drawString(String.valueOf(haight / 10f), 70, haight + 3);
			background.setColor(new Color(151, 177, 200));
			background.drawLine(90, haight, 235, haight);
			haight += 25;
		}
		for (int columns = 0; columns < 6; columns++) {
			background.setColor(Color.black);
			background.drawString(String.valueOf(width / 10f), width - 10, 20);
			background.setColor(new Color(151, 177, 200));
			background.drawLine(width, 25, width, 175);
			width += 25;
		}
	}

	public static void drawPoint(Color c, double x, double y) {
		background.setColor(c);
		Shape circle = new Ellipse2D.Double(x * 10 - 1.5, y * 10 - 1.5, 3, 3);
		background.fill(circle);
		background.setColor(Color.black);
	}
}