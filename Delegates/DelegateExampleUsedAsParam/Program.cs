using System;
using System.Collections.Generic;
using static DelegateExampleUsedAsParam.Classes.ViewsOnConsole;

namespace DelegateExampleUsedAsParam
{
    class Program
    {
        static void Main(string[] args)
        {
            var header = "Please, choose a view mode:";
            var messages = new List<string> { "Write 0 to exit",
                "Write 1 to choose 'complete tableView'",
                "Write 2 to choose 'no header tableView'",
                "Write 3 to choose 'no footer tableView'",
                "Write 4 to choose 'cardView'" };
            var footer = "menu";
            ViewDelegate view;
            var choosed = 1;
            var success = false;
            do
            {
                view = CompleteTableView;
                switch (choosed)
                {
                    case 0:
                        break;

                    case 1:
                        view = CompleteTableView;
                        break;

                    case 2:
                        view = NoHeaderTableView;
                        break;

                    case 3:
                        view = NoFooterTableView;
                        break;

                    case 4:
                        view = CardView;
                        break;

                    default:
                        break;
                }
                ViewMessages(header, messages, footer, view);
                success = Int32.TryParse(Console.ReadLine(), out choosed);
                if(!success || !(choosed > 0 && choosed <= 4))
                {
                    Console.WriteLine("Please, enter an integer betweeen 0 and 4");
                }
            } while (!success || choosed != 0);
        }
    }
}
