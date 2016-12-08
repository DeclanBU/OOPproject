/**
 * @(#)RenewableRating.java
 *
 *
 * @author 
 * @version 1.00 2016/11/16
 */


public class RenewableRating {

    private int windowRating;
    private String insulation;
    private String heatingType;
    
    public RenewableRating(int windowRating , String insulation ,String heatingType )
    {
    	setWindowRating(windowRating);
    	setInsulation(insulation);
        setHeatingType(heatingType);
    }
    public RenewableRating()
    {
    	this (0 , "unknown" ,"unknown");
    }
    public void setWindowRating(int winRating)
    {
    	this. windowRating=winRating;
    }
    public void setInsulation(String insulation)
    {
    	this. insulation=insulation;
    }	
    public void setHeatingType(String heatingType)
    {
    	this. heatingType=heatingType;
    }	
    public int getWindowRating()
    {
    	return windowRating;
    }	
    public String getInsulation()
    {
    	return insulation;
    }
    public String getHeatingType()
    {
    	return heatingType;
    }
    public String toString()
    {
    	return "\nBER Rating:" + getWindowRating() + "\nInsulation Type:" + getInsulation() + "\nHeating Type:" + getHeatingType() + "\n\nClick below if you wish to take this Property!!  \n\n";
    }				
}