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
//import javax.swing.FlowLayout;

@SuppressWarnings({"unchecked", "deprecation"})

public class gui extends JFrame implements ActionListener{
    	
     JMenu fileMenu,tenantMenu;
     ArrayList <Tenant> tenants;
    	private JButton but1, but2, but3, but4, but5, but6;
    	//private JTextArea area1, area2, area3, area4, area5, area6;
    	
    	public gui(){
    		super("Properties-To Let");
    		setLayout(new FlowLayout());
    	    setBounds(333,70,1000,500);
    		//setTitle("Properties - To let");
    		
    		setSize(700,600);
        	setDefaultCloseOperation( EXIT_ON_CLOSE );
        	createFileMenu();
        	createTenantMenu();
        	JMenuBar menuBar = new JMenuBar();
            setJMenuBar(menuBar);
            menuBar.add(fileMenu);
            menuBar.add(tenantMenu);
	  		//this.setLayout(null);
    		
    		
    		Icon b = new ImageIcon(getClass().getResource("house3.png"));//300 168
    		Icon x = new ImageIcon(getClass().getResource("m.png"));
    		Icon c = new ImageIcon(getClass().getResource("house2.png"));
    		Icon a = new ImageIcon(getClass().getResource("house4.png"));
    		Icon d = new ImageIcon(getClass().getResource("house6.png"));
    		Icon e = new ImageIcon(getClass().getResource("house5.png"));
    		Icon f = new ImageIcon(getClass().getResource("1.png"));
    	//	Icon x = new ImageIcon(getClass().getResource("m.png"));
    		
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
    public void save() throws IOException {
      	ObjectOutputStream os;
      	os = new ObjectOutputStream(new FileOutputStream ("tenants.dat"));
      	os.writeObject(tenants);
      	os.close();
      }
      
      /** loads an array of bicycles from the file "bikes.dat"
       */  // CHANGED
      public void open() {
      	try{
      	  ObjectInputStream is;
      	  is = new ObjectInputStream(new FileInputStream ("bikes.dat"));
          tenants  = (ArrayList<Tenant>) is.readObject(); // CHANGED
      	  is.close();
      	}
      	catch(Exception e){
      		JOptionPane.showMessageDialog(null,"open didn't work");
      		e.printStackTrace();
      	}
      	// counting valid bikes not needed
      } // end open()
      
    	public void addTenant()
    		{
      			String name = JOptionPane.showInputDialog("Please enter your name: ");
      			int bankNum  = Integer.parseInt(JOptionPane.showInputDialog("Please enter your 8 digit bank number: "));
      			double balance = Double.parseDouble(JOptionPane.showInputDialog("Balance: "));	
				Tenant tenant = new Tenant(name,bankNum,balance);
      			tenants.add(tenant);
      	
      	JOptionPane.showMessageDialog(null,name + " has successfully paid deposit ");
      }
     
     
       public void display(){
      	
      	JTextArea area = new JTextArea();
      	
      	int numUsers = tenants.size();
      	if (numUsers>0) {
      	     
      	     area.setText("Account Holders: \n\n");
      	       
      	       for (int i = 0; i<numUsers; i++) 
      	    	area.append("User no: " + i + " " + tenants.get(i).toString()+"\n");
      	  		JOptionPane.showMessageDialog(null,area);
      	}
      	else
      	   JOptionPane.showMessageDialog(null,"No Users in the system");
        } 
        public void actionPerformed(ActionEvent e){
        	
        	if(e.getSource() == but1)
        	{
        		int confirm = 1, rentC = 1;
        		Properties s1 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");
        	
        		confirm = JOptionPane.showConfirmDialog(null,s1.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0)
        		{
        			addTenant();
        		}	 
        			 
        			 //if (e.getActionCommand() .equals ("quit")){
      	                       // JOptionPane.showMessageDialog(null,"Shutting down the system");
      	                          //  System.exit(0);
      	                // }
        		         if (e.getActionCommand() .equals ("Save")){
        		          
        		            try{
      	 				    	save();
      	 	                     JOptionPane.showMessageDialog(null,"Data saved successfully");
      	                       } // try
        	    	         catch (IOException f){
      	 	                    JOptionPane.showMessageDialog(null,"Not able to save the file:\n"+
      	 	                     "Check the console printout for clues to why ");
      	                     	f.printStackTrace();
        	    	         }
        		           }
        			    else if (e.getActionCommand() .equals ("Open")){
      	 						open();
        						display();
      						}
        			 
        		
        			 
        			 //if(rentC == 0)
        			 {
        			 	JOptionPane.showMessageDialog(null,"congratulations" + s1.getAddress() + "is now yours");
        			 }
        			 
        		
        		
        		
        		//area1.setVisible(true);
        	}
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            if(e.getSource() == but2)
        	{
        		int confirm = 1, rentC = 1;
        		Properties s2 = new Properties();
        		confirm = JOptionPane.showConfirmDialog(null,s2.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0)
        		{
        			 rentC = JOptionPane.showConfirmDialog(null,"HI Im declan are you sure ypu wish to rent this house","Rental Confirmation",JOptionPane.YES_NO_OPTION);
        			 
        			 if(rentC == 0)
        			 {
        			 	JOptionPane.showMessageDialog(null,"congratulations" + s2.getAddress() + "is now yours");
        			 }
        		}
        		
        		//area1.setVisible(true);
        	}
        	if(e.getSource() == but3)
        	{
        		int confirm = 1, rentC = 1;
        		Properties s3 = new Properties();
        		confirm = JOptionPane.showConfirmDialog(null,s3.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0)
        		{
        			 rentC = JOptionPane.showConfirmDialog(null,"HI Im declan are you sure ypu wish to rent this house","Rental Confirmation",JOptionPane.YES_NO_OPTION);
        			 
        			 if(rentC == 0)
        			 {
        			 	JOptionPane.showMessageDialog(null,"congratulations" + s3.getAddress() + "is now yours");
        			 }
        		}
        		
        		//area1.setVisible(true);
        	}
        	if(e.getSource() == but4)
        	{
        		int confirm = 1, rentC = 1;
        		Properties s4 = new Properties();
        		confirm = JOptionPane.showConfirmDialog(null,s4.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0)
        		{
        			 rentC = JOptionPane.showConfirmDialog(null,"HI Im declan are you sure ypu wish to rent this house","Rental Confirmation",JOptionPane.YES_NO_OPTION);
        			 
        			 if(rentC == 0)
        			 {
        			 	JOptionPane.showMessageDialog(null,"congratulations" + s4.getAddress() + "is now yours");
        			 }
        		}
        		
        		//area1.setVisible(true);
        	} 
        		if(e.getSource() == but5)
        	{
        		int confirm = 1, rentC = 1;
        		Properties s5 = new Properties();
        		confirm = JOptionPane.showConfirmDialog(null,s5.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0)
        		{
        			 rentC = JOptionPane.showConfirmDialog(null,"HI Im declan are you sure ypu wish to rent this house","Rental Confirmation",JOptionPane.YES_NO_OPTION);
        			 
        			 if(rentC == 0)
        			 {
        			 	JOptionPane.showMessageDialog(null,"congratulations" + s5.getAddress() + "is now yours");
        			 }
        		}
        		
        		//area1.setVisible(true);
        	} 
        		if(e.getSource() == but6)
        	{
        		int confirm = 1, rentC = 1;
        		Properties s6 = new Properties();
        		confirm = JOptionPane.showConfirmDialog(null,s6.toString(),"House Details",JOptionPane.YES_NO_OPTION);
        		if( confirm == 0)
        		{
        			 rentC = JOptionPane.showConfirmDialog(null,"If you wish to !!","Rental Confirmation",JOptionPane.YES_NO_OPTION);
        			 
        			 if(rentC == 0)
        			 {
        			 	JOptionPane.showMessageDialog(null,"congratulations" + s6.getAddress() + "is now yours");
        			 }
        		}
        		
        		//area1.setVisible(true);
        	 }
        }
        	
        	 private void createFileMenu(){
      			fileMenu = new JMenu("File");
      	
      			JMenuItem item;
      			item = new JMenuItem("Save");
      			item.addActionListener(this);
      			fileMenu.add(item);
      			item = new JMenuItem("Open");
      			item.addActionListener(this);
      			fileMenu.add(item);
      			item = new JMenuItem("New File");
      			item.addActionListener(this);
      			fileMenu.add(item);
      
      			fileMenu.addSeparator();
      			item = new JMenuItem("Log Out");
      			item.addActionListener(this);
      			fileMenu.add(item);
             } 
             private void createTenantMenu(){
      			tenantMenu = new JMenu("Tenant Listing");
      
      			JMenuItem item;
      			item = new JMenuItem("Add");
      			item.addActionListener(this);
      			tenantMenu.add(item);
      	
      			item = new JMenuItem("Display");
      			item.addActionListener(this);
      			tenantMenu.add(item);
      }	    
    		
    	}
    
    
    
