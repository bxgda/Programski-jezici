package podrazumevaniPaket;
import prevoz.*;

public class GlavnaKlasa {

	public static void main(String[] args) {

		Garaza<Auto> g = new Garaza<>();
		Auto sus1 = new SUSAuto(109, 200, false);
		Auto a1 = new ElektricniAuto(350, 300, 1000);
		Auto sus2 = new SUSAuto(250, 500, true);
		Auto a2 = new ElektricniAuto(600, 900, 200);
		g.dodajAuto(sus1);
		g.dodajAuto(a1);
		g.dodajAuto(sus2);
		g.dodajAuto(a2);
		g.megatest();
	}

}
