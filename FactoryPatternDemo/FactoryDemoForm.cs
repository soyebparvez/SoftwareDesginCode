using System;
using System.Windows.Forms;

namespace FactoryPatternDemo
{
  public partial class FactoryDemoForm : Form
  {
    public FactoryDemoForm()
    {
      InitializeComponent();
      this.comboBox1.DataSource = Enum.GetValues(typeof(ShapeType));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      IShapeCreator shapeCreator = new ShapeCreator();
      IShape shape = shapeCreator.CreateShape((ShapeType)this.comboBox1.SelectedItem);
      this.textBox1.Text = shape.GetShape();
    }
  }
}
