package podrazumevaniPaket;
import inflacija.Preskupo;
import turizam.*;
import java.io.*;

public class GlavnaKlasa {

	public static void main(String[] args) {
		
		InputStreamReader tast = new InputStreamReader(System.in);
		BufferedReader b = new BufferedReader(tast);
		
		Agencija<Put> a = new Agencija<>();
		
		try
		{
			for(int i = 0; i<4; i++)
			{
				System.out.println("Unesite 1 za letovanje ili 2 za zimovanje:");
				int p = Integer.parseInt(b.readLine());
				
				System.out.println("Unesite naziv destinacije:(ocekuje se String)");
				String naziv = b.readLine();
				
				System.out.println("Unesite broj dana:(ocekuje se int)");
				int brdana = Integer.parseInt(b.readLine());
				
				System.out.println("Unesite cenu po danu u evrima:(ocekuje se double)");
				double cena = Double.parseDouble(b.readLine());
				
				if( p == 1)
				{	
					Letovanje l = new Letovanje(naziv, brdana, cena);
					System.out.println("napravljen obj letovanje");
					a.dodajPut(l);
					System.out.println("obj letovanje dodat u listu");
				}
				else
				{
					if( p == 2)
					{
						System.out.println("Unesite cenu ski pasa po danu u evrima:(ocekuje se double)");
						double cenaSki = Double.parseDouble(b.readLine());
						Zimovanje z = new Zimovanje(naziv, brdana, cena, cenaSki);
						System.out.println("napravljen obj zimovanje");
						a.dodajPut(z);
						System.out.println("obj zimovanje dodat u listu");
					}
				}
			}
			a.urediPuteve();
			b.close();
		}
		catch(Preskupo p)
		{
			System.out.println(p);
		}
		catch(IOException ioe)
		{
			System.out.println(ioe);
		}
		catch(Exception e)
		{
			System.out.println(e);
		}
		

	}
}