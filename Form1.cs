using System.Windows.Forms;
using WinFwk.UIModules;
using WinFwk.UIServices;

namespace DemoWinFwk
{
    public partial class Form1 : UIModuleForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitModuleFactory();
            UIServiceHelper.InitServices(msgBus);
            AddToolBar("Data", 1, null);
            AddToolBar("Text", 2, null);
            AddToolBar("File", 3, null);

            InitToolBars();
            InitWorkplace();
            InitLog();

            DockModule(new StringModule());
            DockModule(new DoubleModule());
            DockModule(new StatusModule());
            DockModule(new LogTestsModule());

            this.WindowState = FormWindowState.Maximized;
        }
    }
}