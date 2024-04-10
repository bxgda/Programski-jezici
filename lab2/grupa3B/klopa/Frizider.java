package klopa;
import java.util.*; 	
import java.io.*;

public class Frizider {
	ArrayList<Namirnica> listaNamirnica = new ArrayList<Namirnica>();
	
	public Frizider() {
		
	}
	
	public void dodajNamirnicu(Namirnica n) {
		listaNamirnica.add(n);
	}
	
	public void velikoSpremanje() {
		if(listaNamirnica.size() >= 2) {
			double avg = 0;
			listaNamirnica.sort(null);
			
			avg += listaNamirnica.get(0).hranljivost();
			listaNamirnica.get(0).print();
			listaNamirnica.remove(0);
	
			avg += listaNamirnica.get(0).hranljivost();
			listaNamirnica.get(0).print();
			listaNamirnica.remove(0);
			
			avg /= 2;
			
			try {
				FileOutputStream fos = new FileOutputStream("yuck.bin");
				BufferedOutputStream bos = new BufferedOutputStream(fos);
				DataOutputStream dos = new DataOutputStream(bos);
				
				dos.writeDouble(avg);
				
				dos.close();
			}catch(IOException e) {
				System.out.println("Doslo je do greske prilikom upisivanja vrednosti u: yuck.bin");
			}
		}
	}
}
