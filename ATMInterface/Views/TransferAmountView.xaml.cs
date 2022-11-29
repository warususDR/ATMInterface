﻿using ATMInterface.ViewModels;
using System;
using System.Collections.Generic;
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

namespace ATMInterface.Views
{
    /// <summary>
    /// Логика взаимодействия для TransferAmountView.xaml
    /// </summary>
    public partial class TransferAmountView : UserControl
    {
        private TransferAmountViewModel _viewmodel;
        public TransferAmountView(Action goToTransfer, Action goToMain)
        {
            InitializeComponent();
            DataContext = _viewmodel = new TransferAmountViewModel(goToTransfer, goToMain);
        }
    }
}
