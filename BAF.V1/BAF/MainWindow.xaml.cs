using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
using static BAF.Shows.Shows;
using System.Drawing;

namespace BAF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                OpenDMX.start();
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            OpenDMX.setDmxValue(174, 255);

            Thread t = new Thread(DataThread);
            t.Start();

            OpenDMX.setDmxValue(1, 255);
        }

        bool BO = false;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool2 == false)
            {
                ShowBool2 = true;
                Thread S2 = new Thread(Show2);
                S2.Start();
                ShowBool3 = false;
                ShowBool4 = false;
                ShowBool5 = false;
                ShowBool6 = false;
                ShowBool8 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool2 = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool3 == false)
            {
                ShowBool3 = true;
                Thread S3 = new Thread(Show3);
                S3.Start();
                ShowBool2 = false;
                ShowBool4 = false;
                ShowBool5 = false;
                ShowBool6 = false;
                ShowBool8 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool3 = false;
            }

        }

        public static void DataThread()
        {
            while (true)
            {
                OpenDMX.writeData();
                Thread.Sleep(50);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool1 == false)
            {
                ShowBool1 = true;
                Thread S1 = new Thread(Show1);
                S1.Start();
                ShowBool7 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool1 = false;
            }
        }

        private void BO_Button_Click(object sender, RoutedEventArgs e)
        {
            if (BO == false)
            {
                OpenDMX.setDmxValue(1, 0);
                OpenDMX.setDmxValue(173, 0);
                OpenDMX.setDmxValue(174, 0);
                Show1_Button.IsEnabled = false;
                Show2_Button.IsEnabled = false;
                Show3_Button.IsEnabled = false;
                Show4_Button.IsEnabled = false;
                Show5_Button.IsEnabled = false;
                Show6_Button.IsEnabled = false;
                LED.IsEnabled = false;
                ShowBool1 = false;
                BO = true;
            }
            else
            {
                OpenDMX.setDmxValue(174, 255);
                OpenDMX.setDmxValue(1, 255);
                Show1_Button.IsEnabled = true;
                Show2_Button.IsEnabled = true;
                Show3_Button.IsEnabled = true;
                Show4_Button.IsEnabled = true;
                Show5_Button.IsEnabled = true;
                Show6_Button.IsEnabled = true;
                LED.IsEnabled = true;
                BO = false;
            }            
        }

        private void Show4_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool4 == false)
            {
                ShowBool4 = true;
                Thread S4 = new Thread(Show4);
                S4.Start();
                ShowBool2 = false;
                ShowBool3 = false;
                ShowBool5 = false;
                ShowBool6 = false;
                ShowBool8 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool4 = false;
            }
        }

        private void Show5_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool5 == false)
            {
                ShowBool5 = true;
                Thread S5 = new Thread(Show5);
                S5.Start();
                ShowBool2 = false;
                ShowBool3 = false;
                ShowBool4 = false;
                ShowBool6 = false;
                ShowBool8 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool5 = false;
            }
        }

        private void Show6_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool6 == false)
            {
                ShowBool6 = true;
                Thread S6 = new Thread(Show6);
                S6.Start();
                ShowBool2 = false;
                ShowBool3 = false;
                ShowBool4= false;
                ShowBool5 = false;
                ShowBool8 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool6 = false;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Show7_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool7 == false)
            {
                ShowBool7 = true;
                Thread S7 = new Thread(Show7);
                S7.Start();
                ShowBool1 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool7 = false;
            }
        }

        private void Show8_Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool8 == false)
            {
                ShowBool8 = true;
                Thread S8 = new Thread(Show8);
                S8.Start();
                ShowBool2 = false;
                ShowBool3 = false;
                ShowBool4 = false;
                ShowBool5 = false;
                ShowBool6 = false;
                ShowBool9 = false;
            }
            else
            {
                ShowBool8 = false;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                    StatusBox.Text = "No Enttec USB Device Found";
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                {
                    StatusBox.Text = "Found DMX on USB";
                }
                else
                    StatusBox.Text = "Error Opening Device";
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                StatusBox.Text = "Error Connecting to Enttec USB Device";
            }

            if (ShowBool9 == false)
            {
                ShowBool9 = true;
                Thread S9 = new Thread(Show9);
                S9.Start();
                ShowBool1 = false;
                ShowBool2 = false;
                ShowBool3 = false;
                ShowBool4 = false;
                ShowBool5 = false;
                ShowBool6 = false;
                ShowBool7 = false;
                ShowBool8 = false;
            }
            else
            {
                ShowBool9 = false;
            }
        }

        private void LED_Click(object sender, RoutedEventArgs e)
        {
            if (bool_LED == false)
            { 
            OpenDMX.setDmxValue(5, 170);
                bool_LED = true;
            }
            else
            {
                OpenDMX.setDmxValue(5, 0);
                bool_LED = false;
            }
        }

        bool bool_LED = false;
    }

    public enum FT_STATUS
    {
        FT_OK = 0,
        FT_INVALID_HANDLE,
        FT_DEVICE_NOT_FOUND,
        FT_DEVICE_NOT_OPENED,
        FT_IO_ERROR,
        FT_INSUFFICIENT_RESOURCES,
        FT_INVALID_PARAMETER,
        FT_INVALID_BAUD_RATE,
        FT_DEVICE_NOT_OPENED_FOR_ERASE,
        FT_DEVICE_NOT_OPENED_FOR_WRITE,
        FT_FAILED_TO_WRITE_DEVICE,
        FT_EEPROM_READ_FAILED,
        FT_EEPROM_WRITE_FAILED,
        FT_EEPROM_ERASE_FAILED,
        FT_EEPROM_NOT_PRESENT,
        FT_EEPROM_NOT_PROGRAMMED,
        FT_INVALID_ARGS,
        FT_OTHER_ERROR
    };
}