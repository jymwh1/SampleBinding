using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleBinding
{
    /// <summary>
    /// 以后统一用这个方法绑定，大大节省代码量cnblogs.com/zh7791/p/9933954.html
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //tbInputNumber.SetBinding(TextBox.TextProperty, new Binding("sValue") { Source = Register_D12102, Mode = BindingMode.TwoWay });
        //cb_Basic.DataContext = cb_BasicBind;
        //上面语句分别为对应对象的为PropertyChanged添加了 += 不然它为空
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    

    public class CheckBoxBaseic : ViewModelBase
    {
        public CheckBoxBaseic()
        {
            _i_Check = 0;
        }

        private int _i_Check;

        public int i_Check
        {
            get { return _i_Check; }
            set
            {
                _i_Check = value;
                OnPropertyChanged();
            }
        }      

    }

    /// <summary>
    /// 用来绑定界面textbox的值
    /// </summary>
    public class RegisterAndValue : ViewModelBase
    {
        // 构造函数
        public RegisterAndValue(string sregister)
        {
            t_isintCheck = new IsintCheckChange();
            sRegister = sregister;
            sValue = string.Empty;
            ecount = 1;
        }

        public RegisterAndValue(string sregister, int icount)
        {
            t_isintCheck = new IsintCheckChange();
            sRegister = sregister;
            sValue = string.Empty;
            ecount = icount;
        }

        public int ecount;  // 寄存器个数

        private string t_register = "";

        public string sRegister
        {
            get { return this.t_register; }
            set { this.t_register = value; }
        }

        public string t_value = "";
        public string sValue
        {
            get { return t_value; }
            set
            {
                t_value = value;
                OnPropertyChanged();
            }
        }

        private IsintCheckChange t_isintCheck;
        public IsintCheckChange aci
        {
            get
            {
                return t_isintCheck;
            }
            set
            {
                t_isintCheck = value;
            }
        }
    }

    public class IsintCheckChange : ViewModelBase
    {
        public IsintCheckChange()
        {
            IsintCheck = 0;
        }
        private int _isintcheck;
        public int IsintCheck
        {
            get
            {
                return _isintcheck;
            }
            set
            {
                _isintcheck = value;
                OnPropertyChanged();
            }
        }
    }

    public class RegisterAndValue0 : ViewModelBase
    {
        // 构造函数
        public RegisterAndValue0(string sregister)
        {
            t_isintCheck = new IsintCheckChange();
            sRegister = sregister;
            sValue = string.Empty;
            ecount = 1;
        }

        public RegisterAndValue0(string sregister, int icount)
        {
            t_isintCheck = new IsintCheckChange();
            sRegister = sregister;
            sValue = string.Empty;
            ecount = icount;
        }

        public int ecount;  // 寄存器个数

        private string t_register = "";

        public string sRegister
        {
            get { return this.t_register; }
            set { this.t_register = value; }
        }

        public string t_value = "";
        public string sValue
        {
            get { return t_value; }
            set
            {
                t_value = value;
                OnPropertyChanged();
            }
        }

        private IsintCheckChange t_isintCheck;
        public IsintCheckChange IsintCheck
        {
            get
            {
                return t_isintCheck;
            }
            set
            {
                t_isintCheck = value;
            }
        }        
    }

    public class RegisterAndValue1 : ViewModelBase
    {
        public RegisterAndValue1(string sregister)
        {
            _isintcheck = 0;
            sRegister = sregister;
            sValue = string.Empty;
            ecount = 1;
        }

        public int ecount;  // 寄存器个数

        private string t_register = "";

        public string sRegister
        {
            get { return this.t_register; }
            set { this.t_register = value; }
        }

        public string t_value = "";
        public string sValue
        {
            get { return t_value; }
            set
            {
                t_value = value;
                OnPropertyChanged();
            }
        }

        private int _isintcheck;
        public int IsintCheck
        {
            get
            {
                return _isintcheck;
            }
            set
            {
                _isintcheck = value;
                OnPropertyChanged();
            }
        }
    }


    public class RegisterAndValueB
    {
        public RegisterAndValueB()
        {
            _IsCheck = new IsInCheck();
        }

        private string _register;
        public string register
        {
            get { return _register; }
            set { _register = value; }
        }


        private IsInCheck _IsCheck;
        public IsInCheck IsCheck
        {
            get { return _IsCheck; }
            set { _IsCheck = value; }
        }

    }

    public class IsInCheck:ViewModelBase
    {
        private bool _IsCheck;
        public bool IsCheck
        {
            get { return _IsCheck; }
            set
            {
                _IsCheck = value;
                OnPropertyChanged();
            }
        }

    }
}
