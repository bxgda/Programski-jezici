package prevoz;
import java.io.*;
import java.util.ArrayList;

public class Garaza<t extends Auto> {
	
	private ArrayList<t> automobili;
	
	public Garaza() {
		automobili = new ArrayList<>();
	}
	
	public void dodajAuto(t a) {
		automobili.add(a);
	}
	
	public void megatest() {
		automobili.sort(null);
		try {
			FileOutputStream f = new FileOutputStream("bruteforce.bin");
			BufferedOutputStream b = new BufferedOutputStream(f);
			DataOutputStream d = new DataOutputStream(b);
			d.writeDouble(automobili.get(automobili.size()-1).brutalnost());
			d.close();
		}
		catch(IOException e) {
			System.out.println(e);
		}
	}
}
