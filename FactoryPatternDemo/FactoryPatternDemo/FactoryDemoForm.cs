using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactoryPatternDemo
{
  public partial class FactoryDemoForm : Form
  {
    public FactoryDemoForm()
    {
      InitializeComponent();
      comboBox1.DataSource= Enum.GetValues(typeof(ShapeType));
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //IShape shape = FactoryCreator.Create((ShapeType) comboBox1.SelectedItem);
      //textBox1.Text = shape.GetShape();
      IShapeCreator shapeCreator=new ShapeCreator();
      IShape shape = shapeCreator.CreateShape((ShapeType) comboBox1.SelectedItem);
      textBox1.Text = shape.GetShape();
    }
  }
}
