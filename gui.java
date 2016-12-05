/**
 * @(#)gui.java
 *
 *
 * @author 
 * @version 1.00 2016/11/17
 */
import java.io.*; 
import java.awt.*;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.Icon;      
import javax.swing.ImageIcon;
import javax.swing.*;                           //myFrame4
import javax.swing.JTextArea;
import java.util.*;

import static java.lang.System.*;
//import javax.swing.FlowLayout;

@SuppressWarnings({"unchecked", "deprecation"})

public class gui extends JFrame implements ActionListener{
     
     //JTextField nameField,bankNumField,accField;	
     JMenu fileMenu,Admin;
     JFrame f;
     JButton bal;
     Tenant tenant;
     accountHolder accHolder;
     double landLordBalance=0;
	public Properties  s1,s2,s3,s4,s5,s6;
     public static ArrayList <Properties> houses = new ArrayList<Properties>();
     ArrayList <accountHolder> accounts = new ArrayList<accountHolder>();         
     ArrayList <Tenant> tenants = new ArrayList<Tenant>();
    
     private JButton but1, but2, but3, but4, but5, but6;
    		
    
    	
    	public gui(){
    		super("Properties-To Let");
    		Container cPane = new Container();
    		setLayout(new FlowLayout());
    	    setBounds(333,70,1000,500);
    		setLocationRelativeTo(null);
    		setSize(700,600);
        	setDefaultCloseOperation( EXIT_ON_CLOSE );
        	createFileMenu();
        	createTenantMenu();
        	JMenuBar menuBar = new JMenuBar();
            setJMenuBar(menuBar);
            menuBar.add(fileMenu);
            menuBar.add(Admin);
	  		//this.setLayout(null);
    		
    		//imported images supported by JButtons
    		Icon b = new ImageIcon(getClass().getResource("house3.png"));//300 168
    		Icon x = new ImageIcon(getClass().getResource("click.png"));
    		Icon c = new ImageIcon(getClass().getResource("house2.png"));
    		Icon a = new ImageIcon(getClass().getResource("house4.png"));
    		Icon d = new ImageIcon(getClass().getResource("house6.png"));
    		Icon e = new ImageIcon(getClass().getResource("house5.png"));
    		Icon f = new ImageIcon(getClass().getResource("1.png"));
    	//	Icon x = new ImageIcon(getClass().getResource("m.png"));
    		
    		
    		//rollover feature on all buttons
    		but1 = new JButton(b);
    	    add(but1);
    	    but1.setRolloverIcon(x);
    		but1.addActionListener(this);
    		
    		but2 = new JButton(c);
    	    add(but2);
    	    but2.setRolloverIcon(x);
    		but2.addActionListener(this);
    		
    		but3 = new JButton(a);
    	    add(but3);
    	    but3.setRolloverIcon(x);
    		but3.addActionListener(this);
    			
    		but4 = new JButton(d);
    	    add(but4);
    	    but4.setRolloverIcon(x);
    		but4.addActionListener(this);
    		
    		but5 = new JButton(e);
    	    add(but5);
    	    but5.setRolloverIcon(x);
    		but5.addActionListener(this);
    	
    		but6 = new JButton(f);
    	    add(but6);
    	    but6.setRolloverIcon(x);
    		but6.addActionListener(this);



    		
    	    setVisible(true);
    		
    	   }
    	   public void newSystem(){
    		  tenants = new ArrayList<Tenant>();
    	   }
    	   //saving tenants details to save
           public void save() throws IOException //A method
           {
      	   
      	      ObjectOutputStream os;
      	      os = new ObjectOutputStream(new FileOutputStream ("tenants.dat"));
      	      os.writeObject(tenants);
      	      os.close();
           }
	public void save1() throws IOException //A method
	{

		ObjectOutputStream os;
		os = new ObjectOutputStream(new FileOutputStream ("accounts.dat"));
		os.writeObject(accounts);
		os.close();
	}
      
           /** loads an array of tenants from the file "tenants.dat"
           */  // CHANGED
           public void open()
           	 {
      	       try{
      	      ObjectInputStream is;
      	      is = new ObjectInputStream(new FileInputStream ("tenants.dat"));
              tenants  = (ArrayList<Tenant>) is.readObject(); // CHANGED
      	      is.close();
      	       }
      	       catch(Exception e){
      		   JOptionPane.showMessageDialog(null,"open didn't work");
      		   e.printStackTrace();
      	       }
      	
             } // end open()

	public void open1()
	{
		try{
			ObjectInputStream is;
			is = new ObjectInputStream(new FileInputStream ("tenants.dat"));
			accounts  = (ArrayList<accountHolder>) is.readObject(); // CHANGED
			is.close();
		}
		catch(Exception e){
			JOptionPane.showMessageDialog(null,"open didn't work");
			e.printStackTrace();
		}

	} // end open()


	/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    	  // method to load all tenant details  
    	    public void addTenant()
    		{
    			
      		String name = JOptionPane.showInputDialog("Please enter your name: ");
      		int bankNum = Integer.parseInt(JOptionPane.showInputDialog("Please enter your Bank Number: "));
      		//double balance = Double.parseDouble(JOptionPane.showInputDialog("Balance: "));
				tenant = new Tenant(name,bankNum);
      		    tenants.add(tenant);
      	

            }
	        //this  method allows a potential tenant to create an account which will be necessary before renting a property
            public void addAccountHolder()
    		{
    			
      		String name = JOptionPane.showInputDialog("Please enter your name: ");
      		int bankNum  = Integer.parseInt(JOptionPane.showInputDialog("Please enter your Bank Number: "));
      		double balance = Double.parseDouble(JOptionPane.showInputDialog("Enter starting Balance: "));	
			accHolder = new accountHolder(name,bankNum,balance);
      		accounts.add(accHolder);
				try {
					save1();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
      	    

	  public static void displayProperties()
		{
             JTextArea area = new JTextArea();
      	
      	    int numProps = houses.size();  
      	    if (numProps>0) {
      	     
      	     area.setText("Properties: \n\n");
      	       
      	       for (int i = 0; i<numProps; i++)

      	    	area.append("\nProperty no: " +(i+1)+" " + houses.get(i).toString()+"\n");
      	    	
      	  		JOptionPane.showMessageDialog(null,area);
      	    }	
      	    else 	
            //System.out.print(s1.getAddress());
            JOptionPane.showMessageDialog(null,"No properties at the moment");
            }
            public void moneyTransfer()
            {

            }
		public void Administrator()
            {
         	
                String user = JOptionPane.showInputDialog(null,"Please 'T' for list of tenants or 'p' for list of properties","Tenants!",JOptionPane.INFORMATION_MESSAGE);
        		if(user.charAt(0)==('t') || user.charAt(0)==('T'))
        	    {
        			display();
        		}
        		else if (user.charAt(0)==('p') || user.charAt(0)==('P'))
        		{
        			displayProperties();
        		}
            }
     
     
		public void display(){
      	
      	    JTextArea area = new JTextArea();
           // double amount = accHolder.getBalance();
      	    int numTenants = tenants.size();  
      	    if (numTenants>0) {
      	     
      	     area.setText("Lease Holders: \n\n");
      	       
      	       for (int i = 0; i<numTenants; i++) 
      	    	area.append("\nTenant no: " + (i+1)+" " + tenants.get(i).toString()+"\n");
				area.append("\n\nLandLord Balance: " + landLordBalance);

      	  		JOptionPane.showMessageDialog(null,area);
      	}
      	else
      	   JOptionPane.showMessageDialog(null,"There are currently no tenants on our system ");
        }
        public void display2()
		{
      	
      	  JTextArea area1 = new JTextArea();
			int numAccounts = accounts.size();

			if (numAccounts>0) {
      	     
      	     area1.setText("Account Details: \n\n");
      	       
      	      // for (int j = 0; j<numAccounts; j++)
      	    	area1.append("\nAccount Holder  " + accHolder.toString()+"\n");
     
      	  		JOptionPane.showMessageDialog(null,area1);
      	}
      	else
      	   JOptionPane.showMessageDialog(null,"!!!You do not have an Account ");
        }
         //in this method the information on 6 different properties can be viewed by simply clicking on the image of the property wished to be viewed
        public void actionPerformed(ActionEvent e){

        	if(e.getSource() == but1)
        	{


        		int confirm = 1, rentC = 1,numTenants = tenants.size(),numAccounts = accounts.size();
        		 s1 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");

				confirm = JOptionPane.showConfirmDialog(null,s1.toString(),"House Details",JOptionPane.YES_NO_OPTION);
				if( confirm == 0) {

					addTenant();

					if (accHolder.getBankNum() == tenant.getBankNum() && (accHolder.getName().equals(tenant.getName())))
					{
						if (accHolder.getBalance() >= s1.getRent())
						{
							accountHolder.deposit(s1.getRent());
							landLordBalance += s1.getRent();

							JOptionPane.showMessageDialog(null, "Thank you " + accHolder.getName() + "\n\nLease terms agreed for the Property " + s1.getAddress() + " \nThe first months rent of " + s1.getRent() + " will be taken from your bank account.");

							try {
								save();
								JOptionPane.showMessageDialog(null, "Data saved successfully");
							} // try
							catch (IOException f) {
								JOptionPane.showMessageDialog(null, "Not able to save the file:\n" +
										"Check the console printout for clues to why ");
								f.printStackTrace();
							}
							but1.setVisible(false);
						}
						else
							JOptionPane.showMessageDialog(null, "Not enough Funds in your Account");
					}
					else
						JOptionPane.showMessageDialog(null, "Bank Number or Username is incorrect!!!!!");
				}
				else if(confirm==1)
				{
					JOptionPane.showMessageDialog(null,"Visit us again we have new properties daily!!!!!");
				}


				//area1.setVisible(true);
        	 }
           else	if(e.getSource() == but2)
        	{
        		int confirm = 1, rentC = 1;
        		 s2 = new Properties( 380 ," 69 sheen Av,falls park ,Listowel  ",4,4," Wall Insulated" ," Oil Fired Heating");

				confirm = JOptionPane.showConfirmDialog(null,s2.toString(),"House Details",JOptionPane.YES_NO_OPTION);
				if( confirm == 0) {

					addTenant();

					if (accHolder.getBankNum() == tenant.getBankNum() && (accHolder.getName().equals(tenant.getName())))
					{
						if (accHolder.getBalance() >= s2.getRent())
						{
							accountHolder.deposit(s2.getRent());
							landLordBalance += s2.getRent();

							JOptionPane.showMessageDialog(null, "Thank you " + accHolder.getName() + "\n\nLease terms agreed for the Property " + s2.getAddress() + " \nThe first months rent of " + s2.getRent() + " will be taken from your bank account.");

							try {
								save();
								JOptionPane.showMessageDialog(null, "Data saved successfully");
							} // try
							catch (IOException f) {
								JOptionPane.showMessageDialog(null, "Not able to save the file:\n" +
										"Check the console printout for clues to why ");
								f.printStackTrace();
							}
							but2.setVisible(false);
						}
						else
							JOptionPane.showMessageDialog(null, "Not enough Funds in your Account");
					}
					else
						JOptionPane.showMessageDialog(null, "Bank Number or Username is incorrect!!!!!");
				}
				else if(confirm==1)
				{
					JOptionPane.showMessageDialog(null,"Visit us again we have new properties daily!!!!!");
				}


				//area1.setVisible(true);
        	 }
        	else if(e.getSource() == but3)
        	{
        		int confirm = 1, rentC = 1;
				s3 = new Properties( 450 ," 14 reeks Av,oak park ,Tralee  ",4,4," Attic Insulated " ," Under Floor Heating");

				confirm = JOptionPane.showConfirmDialog(null,s3.toString(),"House Details",JOptionPane.YES_NO_OPTION);
				if( confirm == 0) {

					addTenant();

					if (accHolder.getBankNum() == tenant.getBankNum() && (accHolder.getName().equals(tenant.getName())))
					{
						if (accHolder.getBalance() >= s3.getRent())
						{
							accountHolder.deposit(s3.getRent());
							landLordBalance += s3.getRent();

							JOptionPane.showMessageDialog(null, "Thank you " + accHolder.getName() + "\n\nLease terms agreed for the Property " + s3.getAddress() + " \nThe first months rent of " + s3.getRent() + " will be taken from your bank account.");

							try {
								save();
								JOptionPane.showMessageDialog(null, "Data saved successfully");
							} // try
							catch (IOException f) {
								JOptionPane.showMessageDialog(null, "Not able to save the file:\n" +
										"Check the console printout for clues to why ");
								f.printStackTrace();
							}
							but3.setVisible(false);
						}
						else
							JOptionPane.showMessageDialog(null, "Not enough Funds in your Account");
					}
					else
						JOptionPane.showMessageDialog(null, "Bank Number or Username is incorrect!!!!!");
				}
				else if(confirm==1)
				{
					JOptionPane.showMessageDialog(null,"Visit us again we have new properties daily!!!!!");
				}


				//area1.setVisible(true);
        	  }
           else	if(e.getSource() == but4)
        	  {
        		int confirm = 1, rentC = 1;
        		 s4 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");

				  confirm = JOptionPane.showConfirmDialog(null,s4.toString(),"House Details",JOptionPane.YES_NO_OPTION);
				  if( confirm == 0) {

					  addTenant();

					  if (accHolder.getBankNum() == tenant.getBankNum() && (accHolder.getName().equals(tenant.getName())))
					  {
						  if (accHolder.getBalance() >= s4.getRent())
						  {
							  accountHolder.deposit(s4.getRent());
							  landLordBalance += s4.getRent();

							  JOptionPane.showMessageDialog(null, "Thank you " + accHolder.getName() + "\n\nLease terms agreed for the Property " + s4.getAddress() + " \nThe first months rent of " + s4.getRent() + " will be taken from your bank account.");

							  try {
								  save();
								  JOptionPane.showMessageDialog(null, "Data saved successfully");
							  } // try
							  catch (IOException f) {
								  JOptionPane.showMessageDialog(null, "Not able to save the file:\n" +
										  "Check the console printout for clues to why ");
								  f.printStackTrace();
							  }
							  but4.setVisible(false);
						  }
						  else
							  JOptionPane.showMessageDialog(null, "Not enough Funds in your Account");
					  }
					  else
						  JOptionPane.showMessageDialog(null, "Bank Number or Username is incorrect!!!!!");
				  }
				  else if(confirm==1)
				  {
					  JOptionPane.showMessageDialog(null,"Visit us again we have new properties daily!!!!!");
				  }

				  //area1.setVisible(true);
        	 }
        	else if(e.getSource() == but5)
        	 {
        		int confirm = 1, rentC = 1;
        		 s5 = new Properties( 220 ," 22 diver Av,Main Street ,Castleisland  ",3,7,"Dry lined walls" ,"Air to water Unit");

				 confirm = JOptionPane.showConfirmDialog(null,s5.toString(),"House Details",JOptionPane.YES_NO_OPTION);
				 if( confirm == 0) {

					 addTenant();

					 if (accHolder.getBankNum() == tenant.getBankNum() && (accHolder.getName().equals(tenant.getName())))
					 {
						 if (accHolder.getBalance() >= s5.getRent())
						 {
							 accountHolder.deposit(s5.getRent());
							 landLordBalance += s5.getRent();

							 JOptionPane.showMessageDialog(null, "Thank you " + accHolder.getName() + "\n\nLease terms agreed for the Property " + s5.getAddress() + " \nThe first months rent of " + s5.getRent() + " will be taken from your bank account.");

							 try {
								 save();
								 JOptionPane.showMessageDialog(null, "Data saved successfully");
							 } // try
							 catch (IOException f) {
								 JOptionPane.showMessageDialog(null, "Not able to save the file:\n" +
										 "Check the console printout for clues to why ");
								 f.printStackTrace();
							 }
							 but5.setVisible(false);
						 }
						 else
							 JOptionPane.showMessageDialog(null, "Not enough Funds in your Account");
					 }
					 else
						 JOptionPane.showMessageDialog(null, "Bank Number or Username is incorrect!!!!!");
				 }
				 else if(confirm==1)
				 {
					 JOptionPane.showMessageDialog(null,"Visit us again we have new properties daily!!!!!");
				 }

				 //area1.setVisible(true);
        	 }
          else if(e.getSource() == but6)
        	{
        		int confirm = 1, rentC = 1;
				s6 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");
        	
        		confirm = JOptionPane.showConfirmDialog(null,s6.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0) {

        			addTenant();
					
					if (accHolder.getBankNum() == tenant.getBankNum() && (accHolder.getName().equals(tenant.getName())))
					   {
						if (accHolder.getBalance() >= s6.getRent())
						  {
							  accountHolder.deposit(s6.getRent());
							  landLordBalance += s6.getRent();

							  JOptionPane.showMessageDialog(null, "Thank you " + accHolder.getName() + "\n\nLease terms agreed for the Property " + s6.getAddress() + " \nThe first months rent of " + s6.getRent() + " will be taken from your bank account.");

							  try {
								save();
								JOptionPane.showMessageDialog(null, "Data saved successfully");
							  } // try
							  catch (IOException f) {
								JOptionPane.showMessageDialog(null, "Not able to save the file:\n" +
										"Check the console printout for clues to why ");
								f.printStackTrace();
							  }
								but6.setVisible(false);
						  }
						  else
							JOptionPane.showMessageDialog(null, "Not enough Funds in your Account");
					    }
					    else
						JOptionPane.showMessageDialog(null, "Bank Number or Username is incorrect!!!!!");
				}
        		else if(confirm==1)
        		{
        			JOptionPane.showMessageDialog(null,"Visit us again we have new properties daily!!!!!");
        		}
        		
        		//area1.setVisible(true);
			}

			if (e.getActionCommand().equals("Admin(Landlord)"))
        	   {
        	   	 int password;
				   password= Integer.parseInt(JOptionPane.showInputDialog("Please enter 8 digit password"));

				   if(password == 12345678)
        	   	   {
					   Administrator();
				   }

			   }//create account
        	    if (e.getActionCommand().equals("Create Account"))
        	   { 
				   addAccountHolder();

				               try{
      	 				    	save();
      	 	                     JOptionPane.showMessageDialog(null,"Data saved successfully");
      	                       } // try
        	    	         catch (IOException f){
      	 	                    JOptionPane.showMessageDialog(null,"Not able to save the file:\n"+
      	 	                     "Check the console printout for clues to why ");
      	                     	f.printStackTrace();
      	                     	}		
                                 
       			      
       			      //f.setVisible(true);
			   }
        	    /*if (e.getActionCommand().equals("Login"))
        	   {
        	   	 int password;
        	   	
        	   	   password= Integer.parseInt(JOptionPane.showInputDialog("Please enter 8 digit password"));
        	   	   
        	   	   while(password != 12345678)
        	   	    {
        	   	   	  password= Integer.parseInt(JOptionPane.showInputDialog("Incorrect!!! Please enter 8 digit password"));
        	   	    }
        	   	  
        	   	   display2();
        	   	  
        	   }*/
        	    if (e.getActionCommand().equals("Login"))
			{
				int password=12345678;
				String name = JOptionPane.showInputDialog("Please enter your name: ");
				password= Integer.parseInt(JOptionPane.showInputDialog(" Please enter password"));
				//int bankNum = Integer.parseInt(JOptionPane.showInputDialog("Please enter your Bank Number: "));
				//double balance = Double.parseDouble(JOptionPane.showInputDialog("Balance: "));

				/*while(password != 12345678)
				{
					password= Integer.parseInt(JOptionPane.showInputDialog("Incorrect!!! Please enter 8 digit password"));
				}*/
				if (accHolder.getName().equals(name) && (password==12345))

					display2();

				try {
					save1();
				} catch (IOException e1) {
					e1.printStackTrace();
				}
			}
        	   
        	   
        }
        	
        	 private void createFileMenu(){
      			fileMenu = new JMenu("Personal Account");
      	
      			JMenuItem item;
      			item = new JMenuItem("Create Account");
      			item.addActionListener(this);
      			fileMenu.add(item);
      			
      			item = new JMenuItem("Login");
      			item.addActionListener(this);
      			fileMenu.add(item);
      		
      			
      			item = new JMenuItem("Save1");
      			item.addActionListener(this);
      			fileMenu.add(item);
      		
      
      			fileMenu.addSeparator();
      			item = new JMenuItem("Log Out");
      			item.addActionListener(this);
      			fileMenu.add(item);
             } 
             private void createTenantMenu(){
      			Admin = new JMenu("Admin(Landlord)");
      
      			JMenuItem item;
      			item = new JMenuItem("Admin(Landlord)");
      			item.addActionListener(this);
      			Admin.add(item);
      	
      		
      }	    
    		
    }
    
    
    
