package paquete;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.GridLayout;
import java.awt.Color;
import java.awt.Font;
import javax.swing.UIManager;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.SwingConstants;
import java.awt.SystemColor;
import javax.swing.JTextField;
import javax.swing.JPanel;
import javax.swing.ImageIcon;
import javax.swing.JList;
import javax.swing.AbstractListModel;
import javax.swing.JRadioButton;

public class programa {
	private JFrame frame;
	private JTextField t1;
	private JTextField t2;
	private JTextField t3;
	private JTextField t4;
	private JTextField t5;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					programa window = new programa();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public programa() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.getContentPane().setBackground(new Color(240, 255, 255));
		frame.getContentPane().setForeground(Color.LIGHT_GRAY);
		frame.setBounds(100, 100, 558, 437);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel titulo = new JLabel("Instituto tecnol\u00F3gico de Mexicali\r\n");
		titulo.setHorizontalAlignment(SwingConstants.CENTER);
		titulo.setBackground(new Color(0, 0, 153));
		titulo.setFont(new Font("MS Reference Sans Serif", Font.BOLD, 23));
		titulo.setForeground(new Color(102, 51, 51));
		titulo.setBounds(57, 11, 429, 74);
		frame.getContentPane().add(titulo);
		
		JLabel nombre = new JLabel("Nombre:");
		nombre.setFont(new Font("Tahoma", Font.BOLD, 15));
		nombre.setForeground(Color.BLACK);
		nombre.setBounds(10, 77, 89, 14);
		frame.getContentPane().add(nombre);
		
		JLabel carera = new JLabel("Carrera:");
		carera.setFont(new Font("Tahoma", Font.BOLD, 15));
		carera.setForeground(Color.BLACK);
		carera.setBounds(10, 117, 63, 14);
		frame.getContentPane().add(carera);
		
		JLabel curp = new JLabel("CURP:\r\n");
		curp.setFont(new Font("Tahoma", Font.BOLD, 15));
		curp.setForeground(Color.BLACK);
		curp.setBounds(10, 158, 63, 14);
		frame.getContentPane().add(curp);
		
		JLabel edad = new JLabel("Edad:");
		edad.setForeground(Color.BLACK);
		edad.setFont(new Font("Tahoma", Font.BOLD, 15));
		edad.setBounds(10, 202, 63, 14);
		frame.getContentPane().add(edad);
		
		JLabel correo = new JLabel("Correo:");
		correo.setForeground(Color.BLACK);
		correo.setFont(new Font("Tahoma", Font.BOLD, 15));
		correo.setBounds(10, 246, 63, 14);
		frame.getContentPane().add(correo);
		
		JButton btn = new JButton("ACEPTAR");
		btn.setBackground(Color.LIGHT_GRAY);
		btn.setForeground(SystemColor.activeCaptionText);
		btn.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String nombre, carrera, curp, edad, correo;
				nombre = t1.getText();
				carrera = t2.getText();
				curp = t3.getText();
				edad = t4.getText();
				correo = t5.getText();
				JOptionPane.showMessageDialog(null, "Nombre: "+nombre+"\nCarrera: "+carrera+ "\nCurp: "+curp+
						"\nEdad: "+edad+"\nCorreo: "+correo , "Titulo", JOptionPane.WARNING_MESSAGE);
			}
		});
		btn.setBounds(213, 296, 89, 35);
		frame.getContentPane().add(btn);
		
		t1 = new JTextField();
		t1.setBounds(114, 76, 230, 20);
		frame.getContentPane().add(t1);
		t1.setColumns(10);
		
		t2 = new JTextField();
		t2.setBounds(114, 116, 230, 20);
		frame.getContentPane().add(t2);
		t2.setColumns(10);
		
		t3 = new JTextField();
		t3.setBounds(114, 157, 230, 20);
		frame.getContentPane().add(t3);
		t3.setColumns(10);
		
		t4 = new JTextField();
		t4.setColumns(10);
		t4.setBounds(114, 201, 230, 20);
		frame.getContentPane().add(t4);
		
		t5 = new JTextField();
		t5.setColumns(10);
		t5.setBounds(114, 245, 230, 20);
		frame.getContentPane().add(t5);
		
		JButton btnCancelar = new JButton("CANCELAR\r\n");
		btnCancelar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				t1.setText("");
				t2.setText("");
				t3.setText("");
				t4.setText("");
				t5.setText("");
			}
		});
		btnCancelar.setForeground(Color.BLACK);
		btnCancelar.setBackground(Color.LIGHT_GRAY);
		btnCancelar.setBounds(305, 296, 89, 35);
		frame.getContentPane().add(btnCancelar);
		
		JButton btnSalir = new JButton("SALIR\r\n");
		btnSalir.setForeground(Color.BLACK);
		btnSalir.setBackground(Color.LIGHT_GRAY);
		btnSalir.setBounds(255, 344, 89, 35);
		frame.getContentPane().add(btnSalir);
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				frame.setVisible(false);
				frame.dispose();
			}
		});
	}
}