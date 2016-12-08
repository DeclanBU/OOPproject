/**
 * @(#)hp.java
 *
 *
 * @author 
 * @version 1.00 2016/11/18
 */
import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.*;                              //myFrame4
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.util.ArrayList;
import javax.swing.JOptionPane;

import static java.nio.channels.Pipe.open;

public class Hp extends JFrame {
	JButton submitBut;
	JTextField numOfRoomsField,priceRangeField,accField;
	private ImageIcon image1;
	private JLabel label1;
	private JButton butt,butt2;
	private JPanel panel;
	public Properties property ,s1,s2,s3,s4,s5,s6;
	JTextArea area;
	ArrayList<Properties> realEstate = new ArrayList<Properties>();

    public Hp() {


    	setSize(300,300);
    	Container contentPane = getContentPane();
    	contentPane.setBackground (Color.white);
    	contentPane.setLayout(null);
    	setLayout(new FlowLayout(1));
    	
    
    
        ImageIcon image1 = new ImageIcon(getClass().getResource("jack.png"));
    	JLabel label1 = new JLabel(image1);
    	add(label1);
    	label1.setBounds(100,0,1000,500);
    	contentPane.add(label1);
    	
    	butt = new JButton("Click to view Properties");
	    butt.setSize(100,100);
	    butt.setBounds(100,0,1000,500);
        butt.addActionListener(new homeListener());
        contentPane.add(butt);
        
        butt2 = new JButton("Search");
	    butt.setSize(100,100);
	    butt.setBounds(100,0,1000,500);
	    butt2.addActionListener(new homeListener());
        contentPane.add(butt2);
        
        //the Properties that are available to the user are 
 //try this     gui.s1;
        Properties s1 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");
		Gui.houses.add(s1);
		Properties s2 = new Properties( 700 ," 69 sheen Av,falls park ,Listowel  ",3,4," Wall Insulated" ," Oil Fired Heating");
		Gui.houses.add(s2);
		Properties s3 = new Properties( 450 ," 14 reeks Av,oak park ,Tralee  ",3,4," Attic Insulated " ," Under Floor Heating");
		Gui.houses.add(s3);
		Properties s4 = new Properties( 1000 ," 14 reeks Av,Muckross ,Killarney  ",2,4," Wall Insulated" ," Oil Fired Heating");
		Gui.houses.add(s4);
		Properties s5 = new Properties( 220 ," 22 diver Av,Main Street ,Castleisland  ",1,7,"Dry lined walls" ,"Air to water Unit");
		Gui.houses.add(s5);
		Properties s6 = new Properties( 1200 ," 14 reeks Av,Muckross ,Killarney  ",6,4," Wall Insulated" ," Oil Fired Heating");
		Gui.houses.add(s6);
		


	}
    
    private class homeListener implements ActionListener
    	{
         public void actionPerformed(ActionEvent e)
        {
        	
        	if(e.getSource() == butt)
        	{
        		int confirm = 1, rentC = 1;
        		Gui g = new Gui();

					g.open();
					g.open1();
					g.open3();
				    System.out.println(g.houses);
				g.accHolder = g.accounts.get(0);



			}
        	else if (e.getSource()== butt2)
			{


				//displayProperties();

				JFrame f = new JFrame("Property Search");
				JTextArea area = new JTextArea();
                f.setVisible(true);
                f.setSize(300,200);
				Container contentPane = getContentPane();
				contentPane.setBackground (Color.white);
				contentPane.setLayout(null);
				FlowLayout flow = new FlowLayout();
				f.setLayout(flow);
                f.setLocationRelativeTo(null);
                f.setDefaultCloseOperation( EXIT_ON_CLOSE );

				 JLabel lab = new JLabel("Please enter both fields!!");
				 f.add(lab);
        	   	 JLabel nameLabel = new JLabel("Minimum Num of Bedrooms needed:");
        	   	 f.add(nameLabel);
        	   	 numOfRoomsField = new JTextField(4);
        		 f.add(numOfRoomsField);
				 numOfRoomsField.addActionListener(new submitListener());

                 JLabel bankLabel = new JLabel("Enter Max Allowance(from $220)");
                 f.add(bankLabel);
				 priceRangeField = new JTextField(4);
                 f.add(priceRangeField);

				 area = new JTextArea();
				 f.add(area);
				 area.setVisible(true);


				 submitBut = new JButton("Submit Search");
				 submitBut.addActionListener(new submitListener());
       			 f.add(submitBut);
       			
                 JTextField tf = new JTextField();
                 f.add(tf);

		    	}
              }
            }
             public static void main(String [] args)
             {


		 		Hp img = new Hp();
        		img.setVisible(true);
        		img.setTitle("VFM Properties");
    			img.setSize(400,400);
    			img.setLocationRelativeTo(null);
    			img.setResizable(false);
        		img.setDefaultCloseOperation( EXIT_ON_CLOSE );

    		}
        	private class submitListener implements ActionListener{
              public void actionPerformed(ActionEvent e)
		      {

		    	String numBeds = numOfRoomsField.getText();
		    	String priceRange = priceRangeField.getText();



				if (e.getSource() ==  submitBut )
			  	{
				  searchProp(priceRange,numBeds);//Taking in the arguements here
			  	}
		  	 }
		
	          //the search option is performed by the searchProp method 
			}
			private void searchProp(String priceRange ,String numBeds  )
			{
             
			JTextArea ar = new JTextArea("          Always new Properties");
			for (int i=0;i < Gui.houses.size();i++)
			      {
			      	/*all the houses that are under or equal to the price entered will be returned and providing the price is within range houses that have 
			      	more rooms than are entered will also be returned*/     
				    
				    if (Gui.houses.get(i).getRent() <= Integer.parseInt(priceRange) && Gui.houses.get(i).getBeds() >= Integer.parseInt(numBeds))
				
				      ar.append("\nProperty no: " + (i + 1) + " " + Gui.houses.get(i).toString() + "\n");

			      } 
			         JOptionPane.showMessageDialog(null, ar);
			       
            area.setVisible(true);
			numOfRoomsField.setVisible(true);

			
		}
     
}