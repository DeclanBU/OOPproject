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
import javax.swing.JOptionPane;
import static java.nio.channels.Pipe.open;

public class hp extends JFrame {
	JButton bal;
	JTextField numOfRoomsField,priceRangeField,accField;
	private ImageIcon image1;
	private JLabel label1;
	private JButton butt,butt2;
	private JPanel panel;
	Properties s1,s2,s3,s4,s5,s6;
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
        
	    }
    
    private class homeListener implements ActionListener
    	{
         public void actionPerformed(ActionEvent e)
        {
        	
        	if(e.getSource() == butt)
        	{
        		//int confirm = 1, rentC = 1;
        		gui g = new gui();


  
        	}
        	else if (e.getSource()== butt2)
			{
				//displayProperties();
				Properties s1 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");
				Properties s2 = new Properties( 380 ," 69 sheen Av,falls park ,Listowel  ",4,4," Wall Insulated" ," Oil Fired Heating");
				Properties s3 = new Properties( 450 ," 14 reeks Av,oak park ,Tralee  ",4,4," Attic Insulated " ," Under Floor Heating");
				Properties s4 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");
				Properties s5 = new Properties( 220 ," 22 diver Av,Main Street ,Castleisland  ",3,7,"Dry lined walls" ,"Air to water Unit");
				Properties s6 = new Properties( 350 ," 14 reeks Av,Muckross ,Killarney  ",4,4," Wall Insulated" ," Oil Fired Heating");


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

                 JLabel bankLabel = new JLabel("Enter Max Price Range:$300-----$550");
                 f.add(bankLabel);
				 priceRangeField = new JTextField(4);
                 f.add(priceRangeField);

       			 JButton bal = new JButton("Submit Search");
       			 bal.addActionListener(new submitListener());
       			 f.add(bal);
       			
                 JTextField tf = new JTextField();
                 f.add(tf);
	            
	            
			}
        }
     }
	private class submitListener implements ActionListener{

		public void actionPerformed(ActionEvent e)
		{
		   String numBeds = numOfRoomsField.getText();
		   String priceRange = priceRangeField.getText();
		   
		   
		  if (e.getActionCommand().equals("Submit Search"))
		  {
		  	if (Properties.s1.getBeds().equals("4"))
		  	{
		  		
		  	}
		  	
		  	
		  }	
		
		}
				
				//tf.add(s1.toString());

	}
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