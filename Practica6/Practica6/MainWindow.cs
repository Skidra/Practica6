using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnFacturarClicked (object sender, EventArgs e)
	{
		double prod1= double.Parse(this.producto1.Text);
		double prod2= double.Parse(this.producto2.Text);
		double prod3= double.Parse(this.producto3.Text);

		double subOp=(prod1+prod2+prod3);
		this.subtotal.Text=subOp.ToString();

		double ivaOp=subOp*.16;
		this.iva.Text=ivaOp.ToString();

		double totOp=(subOp+ivaOp);
		this.total.Text=totOp.ToString();



	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		this.producto1.Text= " ";
		this.producto2.Text= " ";
		this.producto3.Text= " ";
		this.subtotal.Text= " ";
		this.iva.Text= " ";
		this.total.Text= " ";


	}
}
