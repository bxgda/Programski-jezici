package prevoz;
import java.io.*;

public class ElektricniAuto extends Auto implements Comparable<Auto> {

	double kapacitet;
	
	public ElektricniAuto() {
		super();
		kapacitet = 0;
	}
	
	public ElektricniAuto(int konjaza, int obrtniMoment, double kapacitet) {
		super(konjaza, obrtniMoment);
		this.kapacitet = kapacitet;
		try {
			FileWriter f = new FileWriter(redniBroj + ".txt");
			BufferedWriter b = new BufferedWriter(f);
			b.write("elektricni auto sa konjazom: " + konjaza + "\nobrtni moment: " + obrtniMoment
					+ "\nredni broj: " + redniBroj + "\nkapacitet baterije: " + kapacitet);
			b.close();
		}
		catch(IOException e) {
			System.out.println(e);
		}
	}
	
	@Override
	public double brutalnost() {
		return konjaza * obrtniMoment + kapacitet;
	}

	@Override
	public int compareTo(Auto o) {
		if(this.brutalnost() < o.brutalnost())
			return -1;
		else if (this.brutalnost() == o.brutalnost())
			return 0;
		else
			return 1;
	}

}
