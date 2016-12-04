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

public class hp extends JFrame {
	JButton submitBut;
	JTextField numOfRoomsField,priceRangeField,accField;
	private ImageIcon image1;
	private JLabel label1;
	private JButton butt,butt2;
	private JPanel panel;
	public Properties property ,s1,s2,s3,s4,s5,s6;
	JTextArea area;
	ArrayList<Properties> realEstate = new ArrayList<Properties>();
	//public static ArrayList <Properties> houses = new ArrayList<Properties>();
	//private ImageIcon image2;
//	private JLabel label2;

    public hp() {


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

        Properties s1 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");
		gui.houses.add(s1);
		Properties s2 = new Properties( 700 ," 69 sheen Av,falls park ,Listowel  ",3,4," Wall Insulated" ," Oil Fired Heating");
		gui.houses.add(s2);
		Properties s3 = new Properties( 450 ," 14 reeks Av,oak park ,Tralee  ",3,4," Attic Insulated " ," Under Floor Heating");
		gui.houses.add(s3);
		Properties s4 = new Properties( 1000 ," 14 reeks Av,Muckross ,Killarney  ",2,4," Wall Insulated" ," Oil Fired Heating");
		gui.houses.add(s4);
		Properties s5 = new Properties( 220 ," 22 diver Av,Main Street ,Castleisland  ",1,7,"Dry lined walls" ,"Air to water Unit");
		gui.houses.add(s5);
		Properties s6 = new Properties( 1200 ," 14 reeks Av,Muckross ,Killarney  ",6,4," Wall Insulated" ," Oil Fired Heating");
		gui.houses.add(s6);

	}
    
    private class homeListener implements ActionListener
    	{
         public void actionPerformed(ActionEvent e)
        {
        	
        	if(e.getSource() == butt)
        	{
        		//int confirm = 1, rentC = 1;
        		gui g = new gui();

					g.open();
				    System.out.println(g.houses);



			}
        	else if (e.getSource()== butt2)
			{


				//displayProperties();

				JFrame f = new JFrame("dd");
				JTextArea area = new JTextArea();
                f.setVisible(true);
                f.setSize(400,200);
				Container contentPane = getContentPane();
				contentPane.setBackground (Color.white);
				contentPane.setLayout(null);
				FlowLayout flow = new FlowLayout();
				f.setLayout(flow);
                f.setLocationRelativeTo(null);
                f.setDefaultCloseOperation( EXIT_ON_CLOSE );


        	   	 JLabel nameLabel = new JLabel("Enter Num of prefered Bedrooms:1-4");
        	   	 f.add(nameLabel);
        	   	 numOfRoomsField = new JTextField(4);
        		 f.add(numOfRoomsField);
				 numOfRoomsField.addActionListener(new submitListener());

                 JLabel bankLabel = new JLabel("Enter Max Price Range:$300-----$1000");
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
	private class submitListener implements ActionListener{

		public void actionPerformed(ActionEvent e)
		{

			String text="Noting ";
		    String numBeds = numOfRoomsField.getText();
		    String priceRange = priceRangeField.getText();



			if (e.getSource() ==  submitBut )
			  {
				  searchProp(priceRange,numBeds);//Taking in the arguements here
			  }
		  }
		
		}
		private void searchProp(String priceRange ,String numBeds  )
		{
			JTextArea ar = new JTextArea();
			for (int i=0;i < gui.houses.size();i++)
			      {
				    if (gui.houses.get(i).getRent() <= Integer.parseInt(priceRange) && gui.houses.get(i).getBeds() >= Integer.parseInt(numBeds))
					ar.append(String.valueOf(gui.houses.get(i).toString()));
				   //ar.append("\nProperty no: " + i + 1 + " " + gui.houses.get(i).toString() + "\n");
			      } //JOptionPane.showMessageDialog(null,"Nothing available");
			         JOptionPane.showMessageDialog(null, ar);
			       //gui.houses.get(i).toString();



			//JOptionPane.showMessageDialog(null, "Nothing available");


			area.setVisible(true);
			numOfRoomsField.setVisible(true);

			//displayProperties();
			//System.out.print(s1.getAddress().toString());
			//JOptionPane.showMessageDialog(null,s1.toString()+s2.toString());

		}
				
				//tf.add(s1.toString());


     public static void main(String [] args)
     {


		 hp img = new hp();
        img.setVisible(true);
        
        img.setTitle("VFM Properties");
    	img.setSize(700,400);
    	img.setLocationRelativeTo(null);
    	img.setResizable(false);
        img.setDefaultCloseOperation( EXIT_ON_CLOSE );

    }
   
     
}