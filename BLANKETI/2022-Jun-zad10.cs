        
// Znaci u zad treba ovaj indekser da se napise
public Item this[int i, int j, int k]
{
	get { return elements[i, j, k]; }
	set { elements[i, j, k] = value; }
}

// i ovaj operator+, ostalo je se podrazumeva da vec postoji
public static MultiDimensionalField operator+(MultiDimensionalField a, MultiDimensionalField b)
{
	// Provera da li su dimenzije polja jednake
	if (a.m != b.m || a.n != b.n || a.k != b.k)
		return new MultiDimensionalField(0, 0, 0); // ako nisu vrati prazno polje

	MultiDimensionalField result = new MultiDimensionalField(a.m, a.n, a.k);
	for (int i = 0; i < a.m; i++)
		for (int j = 0; j < a.n; j++)
			for (int k = 0; k < a.k; k++)
				result[i, j, k] = a[i, j, k] + b[i, j, k];

	return result;
}