using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleBinding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public RegisterAndValue Register_D12102 = new RegisterAndValue("D12102", 1);
        public CheckBoxBaseic cb_BasicBind = new CheckBoxBaseic();

        public RegisterAndValue0 Register_L40 = new RegisterAndValue0("L4");
        public RegisterAndValue Register_L4 = new RegisterAndValue("L4");
        public RegisterAndValue1 Register_L41 = new RegisterAndValue1("L4");
        public RegisterAndValueB Register_X100 = new RegisterAndValueB();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbInputNumber.SetBinding(TextBox.TextProperty, new Binding("sValue") { Source = Register_D12102, Mode = BindingMode.TwoWay });
            
            cb_Basic.DataContext = cb_BasicBind;

            MCB_Origin_L40.DataContext = Register_L40.IsintCheck;//Register_L40和Register_L4本质一样，只是想说明xaml中绑定对象为变量的问题
            MCB_Origin_L4.DataContext = Register_L4.aci;//只有aci里面有IsintCheck属性
            MCB_Origin_L41.DataContext = Register_L41;

            rbt_Input_X100.DataContext = Register_X100.IsCheck;
        }

       

        private void Bt_Jog_M3_Click(object sender, RoutedEventArgs e)
        {
            Register_D12102.sValue = "Hello";
            cb_BasicBind.i_Check = 1;

            Register_L40.IsintCheck.IsintCheck = 9;//其实本质上这个checkbox的IsCheck已经只是用来和字典关联的了<Trigger Property="CheckBox.IsChecked" Value="true">
            Register_L41.IsintCheck = 10;
            Register_L4.aci.IsintCheck = 11;

            Register_X100.IsCheck.IsCheck = true;
        }

        private void Bt_Jog_M4_Click(object sender, RoutedEventArgs e)
        {
            Register_D12102.sValue = "bye~bye~";
            cb_BasicBind.i_Check = 0;


            Register_L40.IsintCheck.IsintCheck = 0;
            Register_L41.IsintCheck = 0;
            Register_L4.aci.IsintCheck = 0;

            Register_X100.IsCheck.IsCheck= false;
        }
    }
}
