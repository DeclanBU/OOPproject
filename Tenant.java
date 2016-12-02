import java.io.*; 
public class Tenant implements Serializable {
	//Attributes


	private String name;
	private double balance;
	private int phone;
	public int bankNum;
	//private double landLordBalance;


	//No agrument constructor
	public Tenant() {
		name = "Unknown";
		balance = 100;
		phone = 12345;

	}

	//Multi argument constructor
	public Tenant(String name, int bankNum) {
		//setting values for attributes using multi agruments constructor
		this.name = name;
		this.bankNum = bankNum;
		//	this.balance = balance;

	}

	public Tenant(String name, int phone, double balance, int bankNum) {
		//setting values for attributes using multi agruments constructor
		this.name = name;
		this.phone = phone;
		this.balance = balance;
		this.bankNum = bankNum;
	}

	public String getName() {
		return name;
	}

	//Accessor Method
	public int getPhone() {
		return phone;
	}

	//Accessor Method
	public double getBalance() {
		return balance;
	}

	public double getBankNum() {
		return bankNum;
	}

	public void setPhone(int phone) {
		this.phone = phone;
	}

	public void setBankNum(int bankNum) {
		this.bankNum = bankNum;
	}

	//Mutator Method
	public void setBalance(double balance) {
		this.balance = balance;
	}

	public void rent(double amount) {
		if (amount <= balance) {
			balance -= amount;
		}
	}

	public void landLordAcc(double amount) {
		if (amount >= balance)
			balance -= amount;
		}

		//toString Mthod which also makes a call to the toString method from the Account class

	public String toString() {

		return
				"\nName: " + getName() + "\nBank Number: " + getBankNum() + "\nBalance" +  getBalance();
	}
}
