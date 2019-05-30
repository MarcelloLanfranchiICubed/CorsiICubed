using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateExampleUsedAsParam.Classes
{
    public static class ViewsOnConsole
    {
        public static void ViewMessages(string header, List<string> messages, string footer, ViewDelegate callback)
        {
            callback(header, messages, footer).ForEach(str =>
            Console.WriteLine(str));
        }

        public delegate List<string> ViewDelegate(string header, List<string> messages, string footer);
        public static List<string> CompleteTableView(string header, List<string> messages, string footer)
        {
            var listOfMessages = new List<string>();
            var list = new List<string> { header, footer };
            var maxLength = MaxLength(list.Concat(messages).ToList()) + 3;
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages.Add(' ' + header);
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages = listOfMessages.Concat(ListMessages(messages, maxLength)).ToList();
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages.Add(' ' + footer);
            listOfMessages.Add(new String('_', maxLength));
            return listOfMessages;
        }
        public static List<string> NoHeaderTableView(string header, List<string> messages, string footer)
        {
            var listOfMessages = new List<string>();
            var list = new List<string> { footer };
            var maxLength = MaxLength(list.Concat(messages).ToList()) + 3;
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages = listOfMessages.Concat(ListMessages(messages, maxLength)).ToList();
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages.Add(' ' + footer);
            listOfMessages.Add(new String('_', maxLength));
            return listOfMessages;
        }
        public static List<string> NoFooterTableView(string header, List<string> messages, string footer)
        {
            var listOfMessages = new List<string>();
            var list = new List<string> { header };
            var maxLength = MaxLength(list.Concat(messages).ToList()) + 3;
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages.Add(' ' + header);
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages = listOfMessages.Concat(ListMessages(messages, maxLength)).ToList();
            listOfMessages.Add(new String('_', maxLength));
            return listOfMessages;
        }

        public static List<string> CardView(string header, List<string> messages, string footer)
        {
            var listOfMessages = new List<string>();
            listOfMessages.Add(' ' + header.ToUpper());
            listOfMessages.Add(' ' + footer.ToLower());
            var list = new List<string> { header, footer };
            var maxLength = MaxLength(list.Concat(messages).ToList()) + 3;
            listOfMessages.Add(new String('_', maxLength));
            listOfMessages = listOfMessages.Concat(ListMessages(messages, maxLength)).ToList();
            return listOfMessages;
        }

        private static int MaxLength(List<string> strings)
        {
            return strings.Select(s => s.Length).Max();
        }

        private static List<string> ListMessages(List<string> messages, int maxLength)
        {
            return messages.Select(message => " * " + message).ToList();
        }
    }
}
