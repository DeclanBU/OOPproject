import java.io.*; 
public class accountHolder implements Serializable {
	//Attributes
	/**This is an instantiable accountHolder class that is needed before you can rent a property
	 * @author Declan Buckley
	 * version 1.0 2016   11/17
	 */
	
	public String name;
	public  int bankNum;
	public static double balance;

	private double landLordBalance;




	/**No agrument constructor
	 * it assigns the default values for the AccountHolder Class*/
	public accountHolder()
	{
		name = "Unknown";
		balance = 1000;

	
	}

	public accountHolder(String name,double balance )
	{
		/** Multiple argument constructor method
		 @param sets name to the  AccountHolder name
		 @param sets bankNum to the AccountHolders bank number*/

		this.name = name;
	    this.balance = balance;

	}
	/** Multiple argument constructor method
	 @param  name sets to the  AccountHolder name
	 @param  bankNum sets to the AccountHolders bank number
	 @param  balance sets to AccountHolder balance*/
	public accountHolder(String name, int bankNum ,double balance)
	{
		//setting values for attributes using multi agruments constructor
		this.name = name;
		this.bankNum = bankNum;
		this.balance = balance;

	}
	/** Accessor method
	 @return  name returns the name of the AccountHolder object*/
	public String getName()
		{
		return name;
		}
	/** Accessor method
	 @return balance returns the balance of the AccountHolder object*/

	public double getBalance()
	{
		return balance;
	}
	/** Accessor method
	 @return bankNum returns the bank number of the AccountHolder object*/

	public int getBankNum()
		{
		 return bankNum;
		 }
	public double getLandLordBalance()
		{
		 return landLordBalance;
		 }
	/** Mutator method
	 @param name sets the name of the AccountHolder object*/
	public void setName (String name)
    {
		this.name = name;
	}

	/** Accessor method
	 @param bankNum sets the bank number of the AccountHolder object*/

	public void setBankNum(int bankNum)
	{
	    this.bankNum = bankNum;
	}
	//Mutator Method
	/** Accessor method
	@param balance sets the bank number of the AccountHolder object*/
	public void setBalance(double balance)
    {
	   this.balance = balance;
	}
	public static void deposit(double amount) {
		if (amount <= balance) {
			balance -= amount;
		}
	}

	/**toString Method which makes a call to the toString method from the AccountHolder class*/
	public String toString() {

	return
			"\nName: " + getName() + "\nBank Number:" + getBankNum() + "\nAccount Balance:" + getBalance();
	}



}