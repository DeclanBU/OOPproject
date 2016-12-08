import java.io.*; 
public class accountHolder implements Serializable {
	//Attributes
	
	
	public String name;
	public  int bankNum;
	public static double balance;
	private int phone;

	private double landLordBalance;
	
	
	
	
	//No agrument constructor
	public accountHolder()
	{
		name = "Unknown";
		balance = 1000;
		phone = 12345;	
	
	}
	//Multi argument constructor
	public accountHolder(String name,double balance,int phone )
	{
		//setting values for attributes using multi agruments constructor
		this.name = name;
	    this.balance = balance;
        this.phone = phone;
	}
	public accountHolder(String name, int bankNum ,double balance)
	{
		//setting values for attributes using multi agruments constructor
		this.name = name;
		//this.phone = phone;
		this.bankNum = bankNum;
		this.balance = balance;

	}
	public String getName()
		{
		return name;
		}
	//Accessor Method
	public int getPhone()
		{
		 return phone;
		 }
	//Accessor Method
	public double getBalance()
	{
		return balance;
	}
	//public double getlandLordBalance()

	public double getBankNum()
		{
		 return bankNum;
		 }
	public double getLandLordBalance()
		{
		 return landLordBalance;
		 }
	//Mutator Method
	public void setName (String name)
    {
		this.name = name;
	}
	//Mutator Method
	public void setPhone(int phone)
	{
	    this.phone = phone;
	}
	public void setBankNum(int bankNum)
	{
	    this.bankNum = bankNum;
	}
	//Mutator Method
	public void setBalance(double balance)
    {
	   this.balance = balance;
	}
	public static void deposit(double amount)
	{
		if (amount <=balance){
			balance -= amount;
		}
	}
	public static void personalAcc(double amount){
		balance += amount;
	}

	//toString Mthod which also makes a call to the toString method from the Account class
	public String toString() {

	return
			"\nName: " + getName() + "\nBank Number:" + getBankNum() + "\nAccount Balance:" + getBalance();
	}



}