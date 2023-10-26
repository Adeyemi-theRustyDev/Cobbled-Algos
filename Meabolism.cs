using System;
using System.Collections.Generic;

namespace TheRustyDev;

/*public class Program2
{
	public static void Main(string[] args)
	{
		Console.WriteLine("@yemiTheRustyDev\n\n");
		Ecc complex2ECC =  new Ecc(new int[]{1, 3, 5, 1});
		Enzyme complex2 = new Enzyme("Succinate Dehydrogenase", complex2ECC, "oxidoreductase");
		Console.WriteLine(complex2.BasicInfo());
	}
} */

public class Enzyme
{
	public string Name { get; set; }
	public Ecc CommissionCode { get; init; }
	public List<string> Substrates { get; set; }
	public string BiochemicalClass { get; set; }
	
	public Enzyme(string name, Ecc commissionCode, string biochemicalClass)
	{
		Name = name;
		CommissionCode = commissionCode;
		BiochemicalClass = biochemicalClass;
	}
	
	public string  BasicInfo()
	{
		string banner = "\t\t\t\tBASIC ENZYME INFO (BEI)\t\t\t\t\n";
		return $"{banner}Enzyme Name: {Name}\nECC: {CommissionCode}\nClass: {BiochemicalClass}";
	}
	
}

public class Ecc
{
	static int MAX_CODE_LENGTH = 4; // Maximum length of an enzyme code 
	private int[] code = new int[MAX_CODE_LENGTH];
	public int[] Code  { get => code; }
	
	public Ecc(int[] code)
	{
		 if (code.Length <= MAX_CODE_LENGTH) this.code = code; // Doesn't set for arrays whose length is greater than the max (it therefore defaults)
	}
	public override string ToString() => $"{code[0]}.{code[1]}.{code[2]}.{code[3]}";
}
