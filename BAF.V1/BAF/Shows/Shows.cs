using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BAF.Shows
{
    class Shows
    {
        public static bool ShowBool1 = false;
        public static bool ShowBool2 = false;
        public static bool ShowBool3 = false;
        public static bool ShowBool4 = false;
        public static bool ShowBool5 = false;
        public static bool ShowBool6 = false;
        public static bool ShowBool7 = false;
        public static bool ShowBool8 = false;
        public static bool ShowBool9 = false;

        public static void Show1()
        {
            while (ShowBool1 == true)
            {
                OpenDMX.setDmxValue(172, 0);
                OpenDMX.setDmxValue(168, 255);
                OpenDMX.setDmxValue(173, 160);
                Thread.Sleep(3000);
                if (ShowBool1 == false)
                {
                    break;
                }
                OpenDMX.setDmxValue(168, 0);
                if (ShowBool1 == false)
                {
                    break;
                }
                Thread.Sleep(3000);
            }
        }

        public static void Show2() // Color Change
        {
            while (ShowBool2 == true)
            {
                OpenDMX.setDmxValue(187, 6); 

                if (ShowBool2 == false)
                {
                    break;
                }
                Thread.Sleep(1000);
                OpenDMX.setDmxValue(187, 15);

                if (ShowBool2 == false)
                {
                    break;
                }
                Thread.Sleep(1000);
                OpenDMX.setDmxValue(187, 20);

                if (ShowBool2 == false)
                {
                    break;
                }
                Thread.Sleep(1000);
            }
        }

        public static void Show3() //Red Color

        {
            while (ShowBool3 == true)
            {
                OpenDMX.setDmxValue(187, 6);

                if (ShowBool3 == false)
                {
                    break;
                }
            }
        }

        public static void Show4() // Green Color
        {
            while (ShowBool4 == true)
            {
                OpenDMX.setDmxValue(187, 15);
                if (ShowBool4 == false)
                {
                    break;
                }
            }
        }

        public static void Show5() //Blue Color
        {
            while (ShowBool5 == true)
            {
                OpenDMX.setDmxValue(187, 20);

                if (ShowBool5 == false)
                {
                    break;
                }
            }
        }

        public static void Show6() //White Color
        {
            while (ShowBool6 == true)
            {
                OpenDMX.setDmxValue(187, 25);

                if (ShowBool6 == false)
                {
                    break;
                }
            }
        }

        public static void Show7() // SLOW
        {
            while (ShowBool7 == true)
            {
                OpenDMX.setDmxValue(172, 255);
                OpenDMX.setDmxValue(168, 255);
                OpenDMX.setDmxValue(173, 255);
                Thread.Sleep(60000);
                if (ShowBool7 == false)
                {
                    break;
                }
                OpenDMX.setDmxValue(168, 0);
                if (ShowBool7 == false)
                {
                    break;
                }
                Thread.Sleep(60000);
            }
        }
        public static void Show8() // 3 Red
        {
            while (ShowBool8 == true)
            {
               OpenDMX.setDmxValue(175, 6);
               OpenDMX.setDmxValue(178, 6);
               // OpenDMX.setDmxValue(177, 6);
                if (ShowBool8 == false)
                {
                    break;
                }

            }
        }
        public static void Show9() //Auto Program
        {
            while (ShowBool9 == true)
            {
           OpenDMX.setDmxValue(188, 255);

                if (ShowBool9 == false)
                { 
                    break;
                }
            }
            OpenDMX.setDmxValue(188, 0);
        }

        public static class OpenDMX
        {
            public static byte[] buffer = new byte[513];
            public static uint handle;
            public static bool done = false;
            public static bool Connected = false;
            public static int bytesWritten = 0;
            public static FT_STATUS status;

            public const byte BITS_8 = 8;
            public const byte STOP_BITS_2 = 2;
            public const byte PARITY_NONE = 0;
            public const UInt16 FLOW_NONE = 0;
            public const byte PURGE_RX = 1;
            public const byte PURGE_TX = 2;

            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_Open(UInt32 uiPort, ref uint ftHandle);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_Close(uint ftHandle);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_Read(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesReturned);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_Write(uint ftHandle, IntPtr lpBuffer, UInt32 dwBytesToRead, ref UInt32 lpdwBytesWritten);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_SetDataCharacteristics(uint ftHandle, byte uWordLength, byte uStopBits, byte uParity);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_SetFlowControl(uint ftHandle, char usFlowControl, byte uXon, byte uXoff);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_GetModemStatus(uint ftHandle, ref UInt32 lpdwModemStatus);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_Purge(uint ftHandle, UInt32 dwMask);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_ClrRts(uint ftHandle);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_SetBreakOn(uint ftHandle);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_SetBreakOff(uint ftHandle);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_GetStatus(uint ftHandle, ref UInt32 lpdwAmountInRxQueue, ref UInt32 lpdwAmountInTxQueue, ref UInt32 lpdwEventStatus);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_ResetDevice(uint ftHandle);
            [DllImport("FTD2XX.dll")]
            public static extern FT_STATUS FT_SetDivisor(uint ftHandle, char usDivisor);

            public static void start()
            {
                handle = 0;
                status = FT_Open(0, ref handle);
                Thread thread = new Thread(new ThreadStart(writeData));
                thread.Start();
            }

            public static void setDmxValue(int channel, byte value)
            {
                if (buffer != null)
                {
                    buffer[channel] = value;
                }
            }

            public static void writeData()
            {
                try
                {
                    initOpenDMX();
                    if (OpenDMX.status == FT_STATUS.FT_OK)
                    {
                        status = FT_SetBreakOn(handle);
                        status = FT_SetBreakOff(handle);
                        bytesWritten = write(handle, buffer, buffer.Length);

                        Thread.Sleep(25);
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                }
            }

            public static int write(uint handle, byte[] data, int length)
            {
                try
                {
                    IntPtr ptr = Marshal.AllocHGlobal((int)length);
                    Marshal.Copy(data, 0, ptr, (int)length);
                    uint bytesWritten = 0;
                    status = FT_Write(handle, ptr, (uint)length, ref bytesWritten);
                    return (int)bytesWritten;
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp);
                    return 0;
                }
            }

            public static void initOpenDMX()
            {
                status = FT_ResetDevice(handle);
                status = FT_SetDivisor(handle, (char)12);
                status = FT_SetDataCharacteristics(handle, BITS_8, STOP_BITS_2, PARITY_NONE);
                status = FT_SetFlowControl(handle, (char)FLOW_NONE, 0, 0);
                status = FT_ClrRts(handle);
                status = FT_Purge(handle, PURGE_TX);
                status = FT_Purge(handle, PURGE_RX);
            }
        }
    }
}
