using System;
using System.Diagnostics;

namespace VRChatMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool vrcrunstat = false;
            //avy's bit
            var uri = "steam://rungameid/438100%22";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
            //avy's bit
            //koyo's bit
            while (!vrcrunstat)
            {
                Process[] runingProcess = Process.GetProcesses();
                vrcrunstat = vrcrunstatus(runingProcess);
                if (vrcrunstat == true)
                {
                    killeac(runingProcess);
                }
            }

        }
        static bool vrcrunstatus(Process[] runningProcess)
        {
            for (int i = 0; i < runningProcess.Length; i++)
            {

                if (runningProcess[i].ProcessName == "VRChat")
                {
                    return true;
                }
            }
            return false;
        }

        static void killeac(Process[] runningProcess)
        {
            for (int i = 0; i < runningProcess.Length; i++)
            {

                if (runningProcess[i].ProcessName == "EasyAntiCheat_EOS")
                {
                    runningProcess[i].Kill();
                }
            }
        }

    }
}
//koyo's bit