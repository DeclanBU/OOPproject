/**
 * @(#)Properties.java
 *
 *
 * @author 
 * @version 1.00 2016/11/15
 */


public class Properties {

    private float monthlyRent; 
    private String propAddress;
    private int noBeds;
    private RenewableRating energyRate;    
    
   
   
    public Properties()
    { 
        setRent(0.0f);
    	setPropAddress("Unknown");
    	setNoBeds(0);
    	setEnergyRate(0 ,"Unknown" ,"Unknown");
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
    	setEnergyRate(windowRating ,insulation ,heatingType);
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
        this.energyRate = new RenewableRating(windowRating,insulation,heatingType);	
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
    	return "Monthly Rent:" + getRent()+ "\nProperty Address:" + getAddress() + "No of Beds:" + getBeds() + "Energy Rating:" + getEnergyRate();
    }	
    
          
                                   
    
    
    
}