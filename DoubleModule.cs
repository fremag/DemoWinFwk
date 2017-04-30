using WinFwk.UICommands;
using WinFwk.UIModules;

namespace DemoWinFwk
{
    public partial class DoubleModule : UIModule, UIDataProvider<MyDouble>
    {
        public DoubleModule()
        {
            InitializeComponent();
            this.Name = "DoubleModule";
            this.Text = "My Double Module";
            this.Summary = "Nothing";
        }

        public MyDouble Data => new MyDouble { Data = double.Parse(textBox1.Text) };
    }
}