/**
 * @(#)Properties.java
 *
 *
 * @author 
 * @version 1.00 2016/11/15
 */


public class Properties {


    public static Properties s1,s2,s3,s4,s5,s6;
    public float monthlyRent;
    public String propAddress;
    public int noBeds;
    public RenewableRating energyRate;

   
   
    /*public Properties()
    { 
        setRent(0.0f);
    	setPropAddress("Unknown");
    	setNoBeds(0);
    	setEnergyRate(0 ,"Unknown" ,"Unknown");
    }*/
    
     public Properties(float rent ,String propAddress )
    {
    	setRent(rent);
    	setPropAddress(propAddress);
    }	
    public Properties(float rent ,String propAddress ,int noBeds ,RenewableRating energyRate)
    {
    	setRent(rent);
    	setPropAddress(propAddress);
    	setNoBeds(noBeds);
    	setEnergyRate(energyRate);
    }
    
    
    public Properties(float rent ,String propAddress ,int noBeds ,int windowRating ,String insulation ,String heatingType)
    {
    	setRent(rent);
    	setPropAddress(propAddress);
    	setNoBeds(noBeds);
    	energyRate = new RenewableRating(windowRating ,insulation ,heatingType);
    }
     public Properties()
    {
      monthlyRent = 0;
      propAddress = "Unknown";
      noBeds = 0;
      energyRate = new RenewableRating();
    }
   
   //mutator methods
    public void setRent(float rent)
    {
    	this.monthlyRent = rent;
    }
    public void setPropAddress(String address)
    {
    	this.propAddress = address;
    }
     public void setNoBeds(int beds)
    {
    	this.noBeds=beds;
    }
     public RenewableRating getEnergyRate()
	 {
	 	return energyRate;
	 }

    
    public void setEnergyRate(RenewableRating energyRate)
    {
    	this.energyRate = energyRate;
    }
    public void setEnergyRate(int windowRating ,String insulation ,String heatingType)
    {
        this.energyRate = new RenewableRating(windowRating,insulation,heatingType);	//an instance of RenewableRating is created --composite class
    }
    
    
    //accessor methods
    public float getRent()
    {
    	return monthlyRent;
    }
    public String getAddress()
    {
    	return propAddress;
    }
    public int getBeds()
    {
    	return noBeds;
    }

    public String toString()
    {
    	return "\nMonthly Rent: $" + getRent()+ "\nProperty Address:" + getAddress() + "\nNo of Beds:" + getBeds() + "\n\nSEAI-BUILDING ENERGY RATING" + getEnergyRate();
    }	
    
          
                                   
    
    
    
}