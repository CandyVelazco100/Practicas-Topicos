package paquete;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import java.awt.Color;
import java.awt.Font;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.SwingConstants;
import java.awt.SystemColor;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.AbstractListModel;
import javax.swing.ButtonGroup;
import javax.swing.JRadioButton;
import javax.swing.JCheckBox;

public class programa   {
	private JRadioButton rb1;
	private JRadioButton rb2;
	ButtonGroup bg = new ButtonGroup();
	private JFrame frame;
	private JTextField t1;
	private JTextField t3;
	private JTextField t4;
	private JTextField t5;
	private JList listacarrera;
	private JCheckBox chb1, chb2, chb3; 
	/**
	 * Launch the application.
	 * @return 
	 */
	
	public String mostrarcarrera(java.awt.event.ActionEvent evt) {
		String mnsj;
		if(listacarrera.getSelectedIndex() == -1) {
			mnsj = "No";
		}else {
			mnsj= listacarrera.getSelectedValue().toString();
		}
		return mnsj;	
	}
	
	public String mostrargen(java.awt.event.ActionEvent evt) {
		String mnsj = "No seleccionado";
		if(rb1.isSelected()) {
			mnsj = "Masculino";
		}else if(rb2.isSelected()) {
			mnsj = "Femenino";
		}
		return mnsj;
	}
	
	public String mostrarTurn(java.awt.event.ActionEvent evt) {
		String mnsj = "";
		if(chb1.isSelected()) {
			mnsj += "Matutino"; 
		}else if(chb2.isSelected()) {
			mnsj += "Intermedio"; 

		}else if (chb3.isSelected()) {
			mnsj += "Nocturno"; 
		}
		return mnsj;
	}
	
	
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
		frame.setResizable(false);
		frame.getContentPane().setBackground(new Color(240, 255, 255));
		frame.getContentPane().setForeground(Color.LIGHT_GRAY);
		frame.setBounds(100, 100, 566, 536);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel titulo = new JLabel("Instituto tecnol\u00F3gico de Mexicali\r\n");
		titulo.setHorizontalAlignment(SwingConstants.CENTER);
		titulo.setBackground(new Color(0, 0, 153));
		titulo.setFont(new Font("MS Reference Sans Serif", Font.BOLD, 23));
		titulo.setForeground(new Color(102, 51, 51));
		titulo.setBounds(59, 0, 429, 74);
		frame.getContentPane().add(titulo);
		
		JLabel lblnom = new JLabel("Nombre:");
		lblnom.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblnom.setForeground(Color.BLACK);
		lblnom.setBounds(10, 77, 89, 14);
		frame.getContentPane().add(lblnom);
		
		JLabel lblcarrera = new JLabel("Carrera:");
		lblcarrera.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblcarrera.setForeground(Color.BLACK);
		lblcarrera.setBounds(10, 117, 63, 14);
		frame.getContentPane().add(lblcarrera);
		
		JLabel lblcurp = new JLabel("CURP:\r\n");
		lblcurp.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblcurp.setForeground(Color.BLACK);
		lblcurp.setBounds(10, 264, 63, 14);
		frame.getContentPane().add(lblcurp);
		
		JLabel lbledad = new JLabel("Edad:");
		lbledad.setForeground(Color.BLACK);
		lbledad.setFont(new Font("Tahoma", Font.BOLD, 15));
		lbledad.setBounds(10, 308, 63, 14);
		frame.getContentPane().add(lbledad);
		
		JLabel lblcorreo = new JLabel("Correo:");
		lblcorreo.setForeground(Color.BLACK);
		lblcorreo.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblcorreo.setBounds(10, 352, 63, 14);
		frame.getContentPane().add(lblcorreo);
		
		JButton aceptar = new JButton("ACEPTAR");
		aceptar.setBackground(Color.LIGHT_GRAY);
		aceptar.setForeground(SystemColor.activeCaptionText);
		aceptar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String nombre, carrera, curp, edad, correo, gen, turno;
				nombre = t1.getText();
				carrera = mostrarcarrera(e);
				curp = t3.getText();
				edad = t4.getText();
				correo = t5.getText();
				gen = mostrargen(e);
				turno = mostrarTurn(e);
				JOptionPane.showMessageDialog(null, "Nombre: "+nombre+"\nCarrera: "+carrera+ "\nCurp: "+curp+
						"\nEdad: "+edad+"\nCorreo: "+correo+"\nGenero: "+gen+"\nTurno: "+turno , "Titulo", JOptionPane.WARNING_MESSAGE);

			}
		});
		aceptar.setBounds(196, 403, 89, 35);
		frame.getContentPane().add(aceptar);
		
		t1 = new JTextField();
		t1.setBounds(114, 76, 230, 20);
		frame.getContentPane().add(t1);
		t1.setColumns(10);
		
		t3 = new JTextField();
		t3.setBounds(114, 264, 230, 20);
		frame.getContentPane().add(t3);
		t3.setColumns(10);
		
		t4 = new JTextField();
		t4.setColumns(10);
		t4.setBounds(114, 308, 230, 20);
		frame.getContentPane().add(t4);
		
		t5 = new JTextField();
		t5.setColumns(10);
		t5.setBounds(114, 352, 230, 20);
		frame.getContentPane().add(t5);
		
		JButton btnCancelar = new JButton("CANCELAR\r\n");
		btnCancelar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				t1.setText("");
				t3.setText("");				
				t4.setText("");
				t5.setText("");
				listacarrera.clearSelection();
				bg.clearSelection();
				chb1.setSelected(false);
				chb2.setSelected(false);
				chb3.setSelected(false);

			}
		});
		btnCancelar.setForeground(Color.BLACK);
		btnCancelar.setBackground(Color.LIGHT_GRAY);
		btnCancelar.setBounds(288, 403, 89, 35);
		frame.getContentPane().add(btnCancelar);
		
		JButton btnSalir = new JButton("SALIR\r\n");
		btnSalir.setForeground(Color.BLACK);
		btnSalir.setBackground(Color.LIGHT_GRAY);
		btnSalir.setBounds(238, 451, 89, 35);
		frame.getContentPane().add(btnSalir);
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				frame.setVisible(false);
				frame.dispose();
			}
		});

		listacarrera = new JList();
		listacarrera.setFont(new Font("Tahoma", Font.ITALIC, 12));
		listacarrera.setModel(new AbstractListModel() {
			String[] values = new String[] {"SISTEMAS", "QUIMICA", "INDUSTRIAL", "ELECTRONICA", "GESTION", "MECATRONICA", "MECANICA", "CONTADOR"};
			public int getSize() {
				return values.length;
			}
			public Object getElementAt(int index) {
				return values[index];
			}	
		});
		listacarrera.setBounds(114, 117, 230, 136);
		frame.getContentPane().add(listacarrera);
		
		JLabel lblgen = new JLabel("G\u00E9nero: ");
		lblgen.setForeground(Color.BLACK);
		lblgen.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblgen.setBounds(448, 79, 89, 14);
		frame.getContentPane().add(lblgen);
		
		rb1 = new JRadioButton("Hombre\r\n");
		rb1.setFont(new Font("Tahoma", Font.ITALIC, 12));
		rb1.setBackground(new Color(240, 255, 255));
		rb1.setBounds(437, 100, 109, 23);
		frame.getContentPane().add(rb1);
		
		rb2 = new JRadioButton("Mujer");
		rb2.setFont(new Font("Tahoma", Font.ITALIC, 12));
		rb2.setBackground(new Color(240, 255, 255));
		rb2.setBounds(437, 126, 109, 23);
		frame.getContentPane().add(rb2);
		
		bg.add(rb1);
		bg.add(rb2);

		JLabel lblturno = new JLabel("Turno:");
		lblturno.setForeground(Color.BLACK);
		lblturno.setFont(new Font("Tahoma", Font.BOLD, 15));
		lblturno.setBounds(448, 179, 89, 14);
		frame.getContentPane().add(lblturno);
		
		chb1 = new JCheckBox("Matutino");
		chb1.setFont(new Font("Tahoma", Font.ITALIC, 12));
		chb1.setBackground(new Color(240, 255, 255));
		chb1.setBounds(437, 200, 97, 23);
		frame.getContentPane().add(chb1);
		
		chb2 = new JCheckBox("Intermedio");
		chb2.setFont(new Font("Tahoma", Font.ITALIC, 12));
		chb2.setBackground(new Color(240, 255, 255));
		chb2.setBounds(437, 227, 97, 23);
		frame.getContentPane().add(chb2);
		
		chb3 = new JCheckBox("Nocturno");
		chb3.setFont(new Font("Tahoma", Font.ITALIC, 12));
		chb3.setBackground(new Color(240, 255, 255));
		chb3.setBounds(437, 255, 97, 23);
		frame.getContentPane().add(chb3);
	}
}