using System;

namespace Hacker_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gamestart;
            do
            {
                /* TIPS
                 * do something while ESC pressed : while(Console.ReadKey().Key != ConsoleKey.Escape);
                 * change color of text : Console.ForegroundColor = ConsoleColor.ANY;
                 * pause 1 sec : System.Threading.Thread.Sleep(1000);
                 * random value from 0 to 100 : rnd.Next(0,100); 
                 * 
                 * 
                 */
                Console.Clear();
                Console.Title = "Hacker Simulator by dimankiev";
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"+----------------+------+");
                Console.WriteLine(@"|HaCkEr SiMuLaToR| v.0.2|");
                Console.WriteLine(@"+----------------+------+");
                Console.WriteLine(@"Enter 1 to start");
                gamestart = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(gamestart) && gamestart == "1")
                {
                    int startgametimer = 5;
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"GAME STARTS IN {0}...", startgametimer);
                        System.Threading.Thread.Sleep(1000);
                        Console.ResetColor();
                        startgametimer = --startgametimer;
                    }
                    while (startgametimer != 0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Enter 1 to start");
                    System.Threading.Thread.Sleep(1000);
                    Console.ResetColor();

                }
            }
            while (gamestart != "1");
            Random rnd = new Random();
            string playerip = "127.0.0.1";
            int pbl = 3000;
            int vbl = 0;
            int vfw = 1;
            int vav = 1;
            int pfw = 1;
            int psdk = 1;
            int pav = 1;
            int pscan = 1;
            int vfwlim = pscan + 10;
            int vavlim = psdk + 10;
            int vblmax = pbl + (pbl / 10);
            int vblmin = pbl - (pbl / 10);
            int ipa;
            int ipb;
            int ipc;
            int ipd;
            int chance;
            int scanspeed = 250;
            int hackspeed = 250;
            int transferspeed = 100;
            int chancemin = 0;
            string scanselect;
            string command;
            string result = "none";
            int hackprocess;
            int fwprice = pfw * 1000;
            int sdkprice = psdk * 1000;
            int avprice = pav * 1000;
            int scanprice = pscan * 1000;
            int upresult = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Welcome to HS Console !");
            Console.WriteLine(@"Commands list - help");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"HS Console 2018@localhost >");
            do
            {
                fwprice = pfw * 1000;
                sdkprice = psdk * 1000;
                avprice = pav * 1000;
                scanprice = pscan * 1000;
                command = Console.ReadLine();
                result = "none";
                upresult = 0;
                if (command == "help")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"--===COMMANDS LIST===--");
                    Console.WriteLine(@"help - cmd list");
                    Console.WriteLine(@"scan - scan random host");
                    Console.WriteLine(@"balance - show your balance");
                    Console.WriteLine(@"price - show upgrade price list");
                    Console.WriteLine(@"upfw - upgrade your Firewall (incerase hack speed)");
                    Console.WriteLine(@"upsdk - upgrade your SDK (incerase chance of succesful hack by 2)");
                    Console.WriteLine(@"upav - upgrade your AntiVirus software (incerase transfer speed)");
                    Console.WriteLine(@"upscan - upgrade your Scan software (incerase scan speed)");
                    Console.WriteLine(@"apps - show apps list with levels");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"");
                    Console.WriteLine(@"exitfromhsconsole - exit HS Console");
                    Console.WriteLine(@"--===COMMANDS LIST===--");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "scan")
                {
                    vfwlim = pscan + 10;
                    vavlim = psdk + 10;
                    vblmax = pbl + 1000 + (pbl / 10);
                    vblmin = pbl - (pbl / 10);
                    ipa = rnd.Next(0, 256);
                    ipb = rnd.Next(0, 256);
                    ipc = rnd.Next(0, 256);
                    ipd = rnd.Next(0, 256);
                    vbl = rnd.Next(vblmin,vblmax);
                    vfw = rnd.Next(0, vfwlim);
                    vav = rnd.Next(0, vavlim);
                    hackprocess = 0;
                    do
                    {
                        Console.WriteLine(@"Scanning... {0}%", hackprocess);
                        hackprocess = hackprocess + 5;
                        System.Threading.Thread.Sleep(scanspeed);
                        Console.Clear();
                    }
                    while (hackprocess != 100);
                    Console.WriteLine(@"Scan finished !");
                    Console.WriteLine(@"HOST : {0}.{1}.{2}.{3}", ipa, ipb, ipc, ipd);
                    Console.WriteLine(@"FIREWALL LEVEL : {0}", vfw);
                    Console.WriteLine(@"ANTIVIRUS : {0}", vav);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"HACK IT ? (yes/no)");
                    Console.ForegroundColor = ConsoleColor.Green;
                    scanselect = Console.ReadLine();
                    if (scanselect == "yes") {
                        do
                        {
                            if (psdk > vav)
                            {
                                //Console.WriteLine(@"Your SDK stronger than victim's AV");
                                chance = rnd.Next(chancemin, 140);
                                Console.WriteLine(@"Chance of successful hack : {0} %", chance);
                                System.Threading.Thread.Sleep(1000);
                            }
                            else if (psdk == vav)
                            {
                                //Console.WriteLine(@"Your SDK equals victim's AV");
                                chance = rnd.Next(chancemin, 140);
                                Console.WriteLine(@"Chance of successful hack : {0} %", chance);
                                System.Threading.Thread.Sleep(1000);
                            }
                            else
                            {
                                //Console.WriteLine(@"Your SDK less than victim's AV");
                                chance = rnd.Next(chancemin, 140);
                                Console.WriteLine(@"Chance of successful hack : {0} %", chance);
                                System.Threading.Thread.Sleep(1000);
                            }
                        }
                        while (chance < 0);
                        do
                        {
                            if (chance > 50)
                            {
                                hackprocess = 0;
                                do
                                {
                                    Console.WriteLine(@"Connecting to host... {0}%", hackprocess);
                                    hackprocess = hackprocess + 5;
                                    System.Threading.Thread.Sleep(hackspeed);
                                    Console.Clear();
                                }
                                while (hackprocess != 100);
                                hackprocess = 0;
                                do
                                {
                                    Console.WriteLine(@"Hacking... {0}%", hackprocess);
                                    hackprocess = hackprocess + 5;
                                    System.Threading.Thread.Sleep(hackspeed);
                                    Console.Clear();
                                }
                                while (hackprocess != 100);
                                Console.WriteLine(@"Victim balance : {0} $. Press ENTER to transfer victim's money to you", vbl);
                                Console.ReadLine();
                                hackprocess = 0;
                                do
                                {
                                    Console.WriteLine(@"Transfering... {0}%", hackprocess);
                                    hackprocess = hackprocess + 2;
                                    System.Threading.Thread.Sleep(transferspeed);
                                    Console.Clear();
                                }
                                while (hackprocess != 100);
                                hackprocess = 0;
                                pbl = pbl + vbl;
                                result = "exit";
                                Console.WriteLine(@"Successful !");
                                Console.WriteLine(@"Disconnecting...");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(@"Unsuccessful !");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(@"Disconnecting...");
                                result = "exit";
                            }
                        }
                        while (result != "exit");
                        result = "none";
                    }
                    else if (scanselect == "no")
                    {
                        command = "exit";
                    }
                    else
                    {
                        Console.WriteLine(@"Unrecognized text ! Disconnecting...");
                        command = "exit";
                    }
                    Console.WriteLine(@"HS Console 2018@localhost >");
                    result = "none";
                }
                else if (command == "balance")
                {
                    hackprocess = 0;
                    do
                    {
                        Console.WriteLine(@"Checking balance... {0}%", hackprocess);
                        hackprocess = hackprocess + 4;
                        System.Threading.Thread.Sleep(25);
                        Console.Clear();
                    }
                    while (hackprocess != 100);
                    Console.WriteLine(@"Your balance is : {0}", pbl);
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "upfw")
                {
                    if (pbl > fwprice)
                    {
                        if (hackspeed != 10)
                        {
                            Console.WriteLine(@"Firewall Upgrade successful");
                            pfw = pfw + 1;
                            hackspeed = hackspeed - 10;
                            pbl = pbl - fwprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (hackspeed == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Firewall already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (pbl == fwprice)
                    {
                        if (hackspeed != 10)
                        {
                            Console.WriteLine(@"Firewall Upgrade successful");
                            pfw = pfw + 1;
                            hackspeed = hackspeed - 10;
                            pbl = pbl - fwprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (hackspeed == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Firewall already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (upresult != 1)
                    {
                        if (pbl < scanprice)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Upgrade Failed !");
                            Console.WriteLine(@"Insufficient balance !");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        upresult = 0;
                    }
                }
                else if (command == "upsdk")
                {
                    if (pbl > sdkprice)
                    {
                        if (chancemin != 135)
                        {
                            Console.WriteLine(@"SDK Upgrade successful");
                            psdk = psdk + 1;
                            chancemin = chancemin + 5;
                            pbl = pbl - sdkprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (chancemin == 135)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"SDK already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (pbl == sdkprice)
                    {
                        if (chancemin != 135)
                        {
                            Console.WriteLine(@"SDK Upgrade successful");
                            psdk = psdk + 1;
                            chancemin = chancemin + 5;
                            pbl = pbl - sdkprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (chancemin == 135)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"SDK already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (upresult != 1)
                    {
                        if (pbl < sdkprice)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Upgrade Failed !");
                            Console.WriteLine(@"Insufficient balance !");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    upresult = 0;
                }
                else if (command == "upav")
                {
                    if (pbl > avprice)
                    {
                        if (transferspeed != 10)
                        {
                            Console.WriteLine(@"Antivirus Upgrade successful");
                            pav = pav + 1;
                            transferspeed = transferspeed - 10;
                            pbl = pbl - avprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (transferspeed == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Antivirus already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (pbl == avprice)
                    {
                        if (transferspeed != 10)
                        {
                            Console.WriteLine(@"Antivirus Upgrade successful");
                            pav = pav + 1;
                            transferspeed = transferspeed - 10;
                            pbl = pbl - avprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (transferspeed == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Antivirus already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (upresult != 1)
                    {
                        if (pbl < avprice)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Upgrade Failed !");
                            Console.WriteLine(@"Insufficient balance !");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    upresult = 0;
                }
                else if (command == "upscan")
                {
                    if (pbl > scanprice)
                    {
                        if (scanspeed != 10)
                        {
                            Console.WriteLine(@"Scan Upgrade successful");
                            pscan = pscan + 1;
                            scanspeed = scanspeed - 10;
                            pbl = pbl - scanprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (scanspeed == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Scan already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (pbl == scanprice)
                    {
                        if (scanspeed != 10)
                        {
                            Console.WriteLine(@"Scan Upgrade successful");
                            pscan = pscan + 1;
                            scanspeed = scanspeed - 10;
                            pbl = pbl - scanprice;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                        else if (scanspeed == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Scan already at max level");
                            Console.ForegroundColor = ConsoleColor.Green;
                            upresult = 1;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    if (upresult != 1)
                    {
                        if (pbl < scanprice)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(@"Upgrade Failed !");
                            Console.WriteLine(@"Insufficient balance !");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(@"HS Console 2018@localhost >");
                        }
                    }
                    upresult = 0;
                }
                else if (command == "price")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"--===PRICE LIST===--");
                    Console.WriteLine(@"Firewall : {0} $", fwprice);
                    Console.WriteLine(@"Antivirus : {0} $", avprice);
                    Console.WriteLine(@"SDK : {0} $", sdkprice);
                    Console.WriteLine(@"Scan : {0} $", scanprice);
                    Console.WriteLine(@"--===PRICE LIST===--");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"HS Console 2018@localhost >");

                }
                else if (command == "apps")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"--===APPS===--");
                    Console.WriteLine(@"Firewall : {0} lvl", pfw);
                    Console.WriteLine(@"Antivirus : {0} lvl", pav);
                    Console.WriteLine(@"SDK : {0} lvl", psdk);
                    Console.WriteLine(@"Scan : {0} lvl", pscan);
                    Console.WriteLine(@"--===APPS===--");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "")
                {
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "dimankiev_dev_info")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"--===DEBUG INFO===--");
                    Console.WriteLine(@"playerip : {0}", playerip);
                    Console.WriteLine(@"pbl : {0}", pbl);
                    Console.WriteLine(@"pfw : {0}", pfw);
                    Console.WriteLine(@"psdk : {0}", psdk);
                    Console.WriteLine(@"pav : {0}", pav);
                    Console.WriteLine(@"pscan : {0}", pscan);
                    Console.WriteLine(@"vfwlim : {0}", vfwlim);
                    Console.WriteLine(@"vavlim : {0}", vavlim);
                    Console.WriteLine(@"vblmax : {0}", vblmax);
                    Console.WriteLine(@"vblmin : {0}", vblmin);
                    Console.WriteLine(@"scanspeed : {0}", scanspeed);
                    Console.WriteLine(@"hackspeed : {0}", hackspeed);
                    Console.WriteLine(@"transferspeed : {0}", transferspeed);
                    Console.WriteLine(@"chancemin : {0}", chancemin);
                    Console.WriteLine(@"result : {0}", result);
                    Console.WriteLine(@"upresult : {0}", upresult);
                    Console.WriteLine(@"--===DEBUG INFO===--");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "dimankiev_dev_cheat")
                {
                    pbl = pbl + 1000000;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"CHEAT ACTIVATED : + 1000000 $");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "exit")
                {
                    Console.WriteLine(@"Connection closed !");
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
                else if (command == "exitfromhsconsole")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Bye-Bye");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Unknown command, please try again");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"HS Console 2018@localhost >");
                }
            }
            while (command != "exitfromhsconsole");
            Console.ResetColor();
        }
    }
}
